#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE para evitar problemas al mostrar caracteres especiales
export LANG=C.UTF-8

##------
#Información de la función
#Función encargada de desinstalar toda la configuración de SliferLogistics.
#Return: No devuelve nada.
##------
uninstall()
{
	echo -e "Se va a desinstalar todo el software de SliferLogistics\nPresione enter para continuar..."
	read a
	userdel Admin -f -r
	userdel OperarioPatio -f -r
	userdel OperarioPuerto -f -r
	userdel Transportista -f -r
	groupdel slifer
	rm -rf /backups
	rm -rf /etc/ScriptsSliferLogistics
	sed -i '/backupScript/d' /etc/crontab
}

##------
#Información de la función
#Función encargada de desinstalar Informix y su información relacionada.
#Return: No devuelve nada.
##------
informixUninstall()
{
	echo -e "Se va a desinstalar informix y todos los datos INCLUYENDO LOS DBSPACES, sea consciente de las consecuencias tras esta acción\nPresione enter para continuar..."
	read a
	salida="F"
	while [ "$salida" != "n" ] #El bucle controla la salida de passwd, si hay error al ingresar la contraseña, permite volver a ingresarla
	do
		echo -e "¿Está  realmente seguro que desea continuar? Las consecuencias son IRREVERSIBLES (9*17/n)\nRealice el cálculo para continuar..."
		read salida
		if [ "$salida" = "153" ]
		then	
			onmode -vky
			onclean -k
			source /opt/IBM/informix/uninstall/uninstall_ids
			rm -rf /opt/IBM			
			rm -rf /etc/profile.d/informix.sh
			rm -rf /etc/informix
			rm -rf /var/dbspaces
			userdel informix
			groupdel informix
			sed -i '/informix/d' /etc/services
			salida="n"
			echo -e "Se ha desinstalado Informix y todos sus datos exitosamente\nPresione enter para continuar..."
			read a
		fi
	done
}
	
