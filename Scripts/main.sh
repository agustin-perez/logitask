#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Release notes: cambios en la presentación del script, se agregan nuevas funciones correspondientes a la segunda entrega.
#Activamos el soporte UT8 para caracteres UNICODE para evitar problemas al mostrar caracteres especiales
export LANG=C.UTF-8
cd /var/logitask/script
source ./funciones.sh
if [ "$(id -u)" -eq "0" ] #Verificamos si el UID es 0, ya que es el de ROOT.
then
	opMain=1
	while [ "$opMain" -ne "0" ]
	do
		clear
		arrayMenu=("Instalador de software de SliferLogistics, Informix y entorno de trabajo" "ABML de usuarios y grupos" "Script de Centro de Computos" "Desinstalar todo el software" "Salir")
		menu 'arrayMenu[@]'
		read opMain
		case $opMain in
			1)
				clear
				source ./Instalacion/scriptInstalacion.sh
				instalarMain
			;;

			2)
				clear
				source ./ABML/scriptABML.sh
				scriptABMLInicio
			;;
			
			3)
				clear
				source ./CentroComputos/Computos.sh
				InicioComputos
			;;

			4)
				clear
				source ./Instalacion/desinstalar.sh
				uninstall
				informixUninstall
			;;

			5)
				clear
				opMain=0	
			;;

			*)
				clear
				echo "Ingrese una opción de las antes mencionadas"
				read
				opMain=1
			;;
		esac
	done
else
	echo -e "El script debe ser ejecutado por el usuario root\nSaliendo..." 
fi
