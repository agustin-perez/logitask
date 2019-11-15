#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE para evitar problemas al mostrar caracteres especiales
export LANG=C.UTF-8
source ./CentroComputos/logicaComputos.sh

InicioComputos()
{
	opcCC=1
	while [ "$opcCC" -ne "0" ]
	do
		clear
		arrmenu=("Administrar servicios" "Administrar procesos" "Ver logs" "Realizar backup" "Restaurar backups" "Configurar red" "Firewall" "Atrás")
		menu 'arrmenu[@]'
		read opcCC
		case $opcCC in 
			1)
				clear
				source ./CentroComputos/scriptServicios.sh
				serviciosMain
			;;
		
			2)	
				clear
				inicioProcesos
			;;

			3)
				clear
				inicioLogs
			;;

			4)
				clear
				inicioBackups
			;;
		
			5)
				clear
				inicioRestore
			;;
			
			6)
				clear
				source ./Instalacion/logicaInstalacion.sh
				redConfig
			;;
		
			7)
				clear
				inicioFirewall
			;;
			
			8)
				clear
				opcCC=0
			;;
			*)
				clear
				echo "Ingrese una opción de las antes mencionadas"
				read
				opcCC=1
			;;
		esac
	done
}

