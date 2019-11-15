#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE para evitar problemas al mostrar caracteres especiales
export LANG=C.UTF-8
source ./Instalacion/logicaInstalacion.sh

altaGroup()
{
	opcAG=
	while [ "$opcAG" != "s" ]
	do
		echo "Ingrese el nombre del grupo a crear"
		read group
		echo "Verifique si el grupo: $group es correcto (s/n)" #Se da una confirmación visual, ya que hay libertad de caracteres para un nombre de grupo
		read opcAG
		if [ "$(grep "$group" /etc/group | cut -d: -f1 | wc -l)" -eq "1" ] #Verificamos que no exista el grupo en group
		then
			echo -e "El grupo $group ya existe\n"
			opcAG="r"
		fi
	done
	groupadd $group #Creamos el grupo
	echo "$group"
}

#Función para crear usuarios
altaUser()
{
	#Sección de nombre
	opcA=
	while [ "$opcA" != "s" ]
	do
		echo "Ingrese el nombre del usuario a crear"
		read user
		echo "Verifique que el usuario: $user es correcto (s/n)" #Se da una confirmación visual, ya que hay libertad de caracteres para un nombre de usuario
		read opcA
		if [ "$(grep "$user" /etc/passwd | cut -d: -f1 | wc -l)" -eq "1" ] #Verificamos que no exista el usuario en passwd
		then
			echo -e "El usuario $user ya existe\n"
			opcA="r"
		fi
	done
	#Sección de home
	paramHome= #Parametro de home, por default es vacío y no va a modificar el comando final
	opcB=
	while [ "$opcB" != "s" ]
	do
		echo "¿Quiere crear el directorio /home/$user? (s/n)"
		read opcB
		if [ "$opcB" = "n" ]
		then
			paramHome="-M" #Asignamos el parámetro que va en el useradd (-M indica sin home)
			break
		fi
	done
	#Sección de grupo
	paramGroup= #Parametro de grupo
	opcC=
	while [ "$opcC" != "s" ]
	do
		echo "¿Quiere agregarle un grupo principal al usuario? (s/n)"
		read opcC
		if [ "$opcC" = "n" ]
		then
			paramGroup="-N" #Asignamos el parámetro que va en el useradd (-N indica sin grupo)
			break
		fi
		#Sección de ver grupos
		opcSC=
		while [ "$opcSC" != "s" ]
		do
			echo "¿Quiere ver todos los grupos existentes? (s/n)"
			read opcSC
			if [ "$opcSC" = "n" ]
			then
				break #Rompemos el bucle para no mostrar el comando de abajo
			fi
			listadoGroup #Listamos los grupos
		done
		#Sección de grupo nuevo
		opcSSC=
		while [ "$opcSSC" != "n" ]
		do
			echo "¿Quiere crear un grupo nuevo? (s/n)"
			read opcSSC
			if [ "$opcSSC" = "n" ]
			then
				echo "Ingrese el grupo"
				read group 
				if [ "$(grep "$group" /etc/group | cut -d: -f1 | wc -l)" -eq "1" ]
				then 
					paramGroup="-g $group" #Asignamos el parámetro que va en el useradd
				else
					echo -e "El grupo no existe\n"
					read
					opcSSC="r" #Damos un valor que no coincida con el while para repetir el bucle
				fi
			elif [ "$opcSSC" = "s" ]
			then
				altaGrupo
				paramGroup="-g $group" #Asignamos el parámetro que va en el useradd con el grupo nuevo
				break
			fi
		done
	done
	#Opcion de usuario temporal
	paramTemp=
	opcD=
	while [ "$opcD" != "n" ]
	do
		echo "¿El usuario va a ser temporal? (s/n)"
		read opcD
		if [ "$opcD" = "s" ]
		then
			echo -e "Escriba la fecha de vencimiento de la siguiente forma AAAA-MM-DD"
			read fechaV
			verificarFecha=$(verifFecha $fechaV) #Llamamos a la función que verifica las fechas
			if [ "$verificarFecha" -eq "0" ] #Usamos la salida de la función antes mencionada (0 - fecha correcta, 1 - fecha errónea)
			then 
				paramTemp="-e $fechaV" #Asignamos el parámetro que va en el useradd
				break
			fi
			echo "El formato de la fecha ingresado no es correcto"
			read
			opcD="r" #Damos un valor que no coincida con el while para repetir el bucle
		fi
	done
	useradd $user $paramHome $paramGroup $paramTemp #Comando final de alta
	sleep 2
	pass "$user" #Llamamos a la función pass de logica instalacion para no repetir funciones
}

#Función encargada de eliminar un usuario en función de su nombre
bajaUser()
{
	opcBU=
	while [ "$opcBU" != "s" ]
	do
		echo "Ingrese el nombre del usuario a eliminar"
		read userDel
		echo "Verifique que el usuario: $userDel es correcto (s/n)" #Se da una confirmación de nombre
		read opcBU
	done
	paramHomeUser=
	opcSBU=
	while [ "$opcSBU" != "n" ]
	do
		echo "¿Quiere eliminar el directorio /home/$userDel y su directorio de mails? (s/n)"
		read opcSBU
		if [ "$opcSBU" = "s" ]
		then
			paramHomeUser="-r" #Seteamos el parámetro para borrar home y directorio de mails
			opcSBU="n"
		fi
	done
	userdel $userDel -f -Z $paramHomeUser > /dev/null #Usamos los parámetros -f por si está abierta la sesión del usuario y -Z para eliminar registros de la seguridad de SELinux. Luego redireccionamos a /dev/null la salida para que no muestre advertencias de forma innecesaria.
}

bajaGroup()
{
	opcBG=
	while [ "$opcBG" != "s" ]
	do
		echo "Ingrese el nombre de grupo a eliminar"
		read groupDel
		echo "Verifique que el grupo: $groupDel es correcto (s/n)" #Se da una confirmación de nombre
		read opcBG
	done
	groupdel $groupDel
}
modUser()
{
	echo "Ingrese el usuario a modificar"
	read userToMod
	if ! [ -z "$userToMod" ]
	then
		if [ "$(grep $userToMod /etc/passwd | cut -d: -f1 | wc -l)" -eq "1" ]
		then 
			opcMenuMU=1
			while [ "$opcMenuMU" -ne "0" ]
			do	
				echo "¿Que va a modificar?"	
				arrMenuModUser=("Fecha de expiración" "Grupo principal" "Agregar grupos secundarios" "Contraseña" "Volver")
				menu 'arrMenuModUser[@]'
				read opcMenuMU
				case $opcMenuMU in 
					1)
						echo -e "Escriba la fecha de vencimiento de la siguiente forma AAAA-MM-DD"
						read fechaMod
						verificarFechaMod=$(verifFecha $fechaMod) #Llamamos a la función que verifica las fechas
						if [ "$verificarFechaMod" -eq "0" ] #Usamos la salida de la función antes mencionada (0 - fecha correcta, 1 - fecha errónea)
						then 
							usermod $userToMod -e $fechaMod
							echo -e "\nInformacion del cambio:"
							chage -l $userToMod
							echo "Presione enter para continuar"
							read
						else
							echo "El formato de la fecha ingresado no es correcto"
							read
							opcMenuMU="1" #Damos un valor que no coincida con el while para repetir el bucle
						fi
					;;
					
					2)
						echo "Ingrese nuevo grupo"
						read newGroup
						usermod $userToMod -g $newGroup #Cambiamos grupo mediante el parámetro -g
					;;
					
					3)
						echo "Ingrese grupo para agregar"
						read newAddedGroup
						usermod $userToMod -G $newAddedGroup #Agregamos grupo mediante el parámetro -G
					;;

					4)
						pass "$userToMod"
					;;

					5)
						opcMenuMU=0
					;;

					*)
						echo "Ingrese una opción de las antes mencionadas"
						read
						opMenuMU=1
					;;
				esac
			done
		else
			echo "El usuario $userToMod no existe (presione enter para continuar)"
			read
		fi
	else
		echo "Debe ingresar un usuario (presione enter para continuar)"
		read
	fi
}

#Función de modificación de nombre de grupos
modGroup()
{
	opcMG=
	while [ "$opcMG" != "s" ]
	do
		echo "Ingrese el nombre del grupo a modificar nombre"
		read groupM
		echo "Verifique que el nombre: $groupM es correcto (s/n)" #Se da una confirmación de nombre
		read opcMG
		if [ "$opcMG" = "s" ]
		then
			echo "Escriba el nuevo nombre del grupo"
			read nuevoGroup
			opcSMG=
			while [ "$opcSMG" != "s" ]
			do
				echo "Verifique que el nuevo nombre: $nuevoGroup es correcto (s/n)"
				read opcSMG
				if [ "$opcSMG" = "s" ]
				then	
					groupmod $groupM -n $nuevoGroup
				else
					opcSMG="r"
				fi
			done
		else
			opcMG="r"
		fi
	done
	
}

#Listado de usuarios del sistema
listadoUser()
{
	echo "Presione enter para continuar, para salir del listado presione la tecla q"
	read
	cut -d: -f1 /etc/passwd | sort | less #Muestra todos los usuarios desde /etc/passwd, los ordena alfabéticamente y los muestra por páginas
}

#Listado de grupos del sistema
listadoGroup()
{
	echo "Presione enter para continuar, para salir del listado presione la tecla q"
	read
	cut -d: -f1 /etc/group | sort | less #Misma funcionalidad que en listadoUser pero en archivo group
}
