#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE para evitar problemas al mostrar caracteres especiales
export LANG=C.UTF-8
source ./ABML/logicaABML.sh

scriptABMLInicio()
{
	opABML=1
	while [ "$opABML" -ne "0" ]
	do
		clear
		arrayMenu=("Alta de usuarios" "Alta de grupos" "Baja de usuarios" "Baja de grupos" "Modificar usuarios" "Modificar grupos" "Listar usuarios" "Listar grupos" "Volver")
		menu 'arrayMenu[@]'
		read opABML
		case $opABML in
			1)
				clear
				altaUser
			;;

			2)
				clear
				altaGroup
			;;

			3)
				clear
				bajaUser
			;;

			4)
				clear
				bajaGroup
			;;

			5)
				clear
				modUser
			;;

			6)
				clear
				modGroup
			;;
	
			7)
				clear
				listadoUser
			;;

			8)
				clear
				listadoGroup
			;;

			9)
				opABML=0	
			;;

			*)
				clear
				echo "Ingrese una opción de las antes mencionadas"
				read
				opABML=1
			;;
		esac
	done
}
