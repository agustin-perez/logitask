#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE para evitar problemas al mostrar caracteres especiales
export LANG=C.UTF-8
source ./CentroComputos/funcionesServicios.sh
serviciosMain()
{
	opcSM=1
	while [ "$opcSM" -ne "0" ]
	do
		clear
		arrmenu=("Ver servicios activos (q para salir)" "Consultar estado de servicio" "Levantar servicio" "Activar servicio" "Atrás")
		menu 'arrmenu[@]'
		read opcSM
		case $opcSM in 
			1)
				clear
				systemctl list-unit-files | grep "enabled" | less
			;;
		
			2)	
				echo "Escriba el nombre del servicio"
				read serv
				if [ "$serv" != "" ]
				then
					systemctl status $serv
				fi
				echo -e "\nPresione enter para continuar..."					
				read a
			;;

			3)
				echo "Escriba el nombre del servicio"
				read srv
				systemctl start $srv
				systemctl status $srv
				echo -e "\nPresione enter para continuar..."					
				read a
			;;

			4)
				echo "Escriba el nombre del servicio"
				read srvc
				systemctl enable $srvc
				systemctl start $srvc
				systemctl status $srvc
				echo -e "\nPresione enter para continuar..."					
				read a
			;;	
		
			5)
				opcSM=0
			;;

			*)
				echo "Ingrese una opción de las antes mencionadas"
				read
				opcSM=1
			;;
		esac
	done
}
