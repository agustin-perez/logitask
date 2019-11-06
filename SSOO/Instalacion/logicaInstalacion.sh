#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE así evitamos problemas con tildes y ñ.
export LANG=C.UTF-8
defaultPass="toor" #Contraseña por defecto (parametrizable)
#Función encargada de cambiar la contraseña dado un usuario por parámetros mediante passwd
pass()
{	
	salida=1
	while [ "$salida" -ne "0" ] #El bucle controla la salida de passwd, si hay error al ingresar la contraseña, permite volver a ingresarla
	do
		echo -e "Se va a cambiar la contraseña de $1\n"
		passwd "$1" >/dev/null #Se pasa por parámetros el usuario a passwd, y se redirige la salida estándar a /dev/null
		salida="$?" #Se redirige el error asociado a la salida de passwd 
		echo
	done
}

#Función encargada de crear todos los usuarios necesarios para que nuestro software funcione
users()
{
	groupadd fertspa #Creamos el grupo de nuestro software
	groupadd informix
	useradd -g informix informix 
	echo -e "$defaultPass\n$defaultPass" | passwd informix >/dev/null 2>&1
	useradd -g fertspa Admin #Creamos el usuario Admin en el grupo antes creado
	echo -e "$defaultPass\n$defaultPass" | passwd Admin >/dev/null 2>&1 #Seteamos contraseña por defecto y redirigimos stdout a /dev/null, y luego stderr a stdout que también son redirigidos a /dev/null
	useradd -g fertspa Operario
	echo -e "$defaultPass\n$defaultPass" | passwd Operario>/dev/null 2>&1
	useradd -g fertspa Transportista
	echo -e "$defaultPass\n$defaultPass" | passwd Transportista >/dev/null 2>&1
	opcU=
	while [ "$opcU" != "s" -a "$opcU" != "n" ] #Bucle encargado de manejar la opción (s/n) de abajo
	do
		echo "¿Quiere introducir las contraseñas manualmente? (s/n)"
		read opcU
		if [ "$opcU" = "s" ] #Seteamos las contraseñas manualmente mediante la función pass
		then
			pass "informix"
			pass "Admin" #Se llama a la función pass y se pasa por parámetros el usuario (como es requerido por la función)
			pass "Operario"
			pass "Transportista"
		else
			echo "Se utilizará la contraseña por defecto ($defaultPass) para todos los usuarios"
		fi
	done	
	echo "Se crearon todos los usuarios correctamente (enter para continuar)" 
	read
}
#Función encargada de cambiar el nombre de Host del sistema
hostnameScript()
{	
	opcH=
	while [ "$opcH" != "s" ] #Verifica el s/n
	do 
		echo "Escriba el nuevo nombre de sistema (reemplazará a localhost)"
		read nombreS
		echo "Verifique que esté correcto el nombre: $nombreS (s/n)"
		read opcH
	done
	sed -i 's/localhost/'$nombreS'/g' /etc/hostname #Reemplazamos el nombre por defecto localhost al ingresado arriba
	sed -i 's/localdomain/'$nombreS'domain/g' /etc/hostname
	sed -i 's/localhost/'$nombreS'/g' /etc/hosts
	sed -i 's/localdomain/'$nombreS'domain/g' /etc/hosts
}
#Script encargado de configurar toda la red de manera estática con una IP dada 
redConfig()
{
	interfaz=$(netstat -i|grep enp|cut -d" " -f1) #Averiguamos el nombre de la interfaz de red mediante netstat -i
	ruta="/etc/sysconfig/network-scripts/ifcfg-$interfaz"
	sed -i 's/ONBOOT=no/ONBOOT=YES/g' $ruta
	sed -i 's/BOOTPROTO=dhcp/BOOTPROTO=static/g' $ruta
	opcR=
	while [ "$opcR" != "s" ]
	do
		echo "Escriba la dirección IP del sistema"
		read IP
		echo "Verifique si la IP: $IP es correcta (s/n)"
		read opcR
	done

	opcR2=
	while [ "$opcR2" != "s" ]
	do
		echo "Escriba el Gateway del sistema"
		read gateway
		echo "Verifique si el gateway: $gateway es correcto (s/n)"
		read opcR2
	done

	if [ $(cat $ruta|grep IPADDR|wc -l) -eq 1 ] #Verificamos si no existe una ip por defecto o creada anteriormente
	then 
		sed -i '/IPADDR/d' $ruta
		sed -i '/NETMASK/d' $ruta
		sed -i '/GATEWAY/d' $ruta
		echo "IPADDR=$IP">>$ruta
		echo "NETMASK=255.255.255.0">>$ruta
		echo "GATEWAY=$gateway">>$ruta
	else
		echo "IPADDR=$IP">>$ruta
		echo "NETMASK=255.255.255.0">>$ruta
		echo "GATEWAY=$gateway">>$ruta
	fi
	service network restart #Reiniciamos el servicio para que se apliquen los cambios
}
#Creamos todos los directorios 
directoriosScript()
{
	mkdir /var/dbspaces
	chmod 0660 /var/dbspaces
	touch /var/dbspaces/EspacioPrincipal.dbspace
	chown informix.informix /var/dbspaces/EspacioPrincipal.dbspace
	chown informix.informix /home/informix
	chmod 0660 /var/dbspaces/EspacioPrincipal.dbspace
	#onspaces -c -d logitask -p /var/dbspaces/EspacioPrincipal.dbspace -o 0 -s 1000000
	mkdir /backups/logitask
	mkdir /etc/ScriptsLogitask
	cp ./Instalacion/backupScript.sh /etc/ScriptsLogitask/backupScript.sh
	chmod 0770 /etc/ScriptsLogitask/backupScript.sh
}
#Seteamos todas las variables de entorno necesarias para nuestro software
varsEntorno()
{
	echo "BACKUPS=/backups/logitask">>/home/informix/.bash_profile
	echo "export BACKUPS">>/home/informix/.bash_profile
	echo "DBSPACE=/var/dbspaces">>/home/informix/.bash_profile
	echo "export DBSPACE">>/home/informix/.bash_profile
	echo "PWD=/etc/ScriptsLogitask/">>/home/informix/.bash_profile
	echo "export PWD">>/home/informix/.bash_profile
}
#Configuramos el cron para agregar el script de backups diario
crontabCfg()
{
	echo -e "@daily root /etc/ScriptsLogitask/backupScript.sh\n">>/etc/crontab
	service crond restart #Reiniciamos el servicio crond para que quede funcionando todo 
}



