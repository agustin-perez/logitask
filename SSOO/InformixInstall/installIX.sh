#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE así evitamos problemas contildes y ñ.
export LANG=C.UTF-8

source ./InformixInstall/logicaIX.sh 

echo -e "Se va a proceder a instalar el SGBD IBM Informix Dynamic Server\nRuta a utilizar: /opt/IBM/informix (anótela para la instalación)\nPresione enter para continuar..."
read a

opcIX="n"
while [ "$opcIX" != "s" ]
do
	echo -e "Escriba el nombre que va a tener la base de datos (Database server name) (máx 16 char, solo letras)."
	read DBSERVERNAME
	if [ $(echo "$DBSERVERNAME" | egrep '^[a-zA-Z]{1,16}$' | wc -l) -eq "1" ] >>/dev/null 2>&1
	then
		#LLAMADO DE FUNCIONES -------------------
		opcIX="s"
		setIP
		usersYGrupos
		serviciosArchivos
		variables
		instalador
		onconfigCFG
		sqlhostsCFG
		dbspacesPrincipales
		#FIN DE LLAMADO DE FUNCIONES ------------
		oninit -ivy
		onstat -
		systemctl enable informix
		systemctl start informix
		onspaces -c -d logitaskdb -p /var/dbspaces/EspacioPrincipal.dbspace -o 0 -s 1000000
		onmode -vky
		#reboot
	else
		opcIX="n"
		echo -e "\nEl nombre contiene caracteres inválidos, ingrese un nombre de servidor válido con máximo de 16 caracteres.\nPresione enter para continuar..."
		read a		
	fi
done 

