#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE para evitar problemas al mostrar caracteres especiales
export LANG=C.UTF-8
source ./Instalacion/logicaInstalacion.sh

instalarMain()
{
	echo "Se va a proceder a configurar el Sistema para poder utilizar el Software de SliferLogistics (enter para continuar)"
	read
	sleep 1

	echo -e "Creación de usuarios\n"
	users
	sleep 1

	echo -e "Configuración de red\n"
	hostnameScript
	redConfig
	sleep 2
	
	echo -e "Configuración de directorios y dbspaces\n"
	directoriosScript
	sleep 2
	
	echo -e "Configuración de variables de entorno\n"
	varsEntorno
	sleep 2

	echo -e "Configuración de Crontab\n"
	crontabCfg
	sleep 2

	echo -e "Instalación de Informix Dynamic Server\n"
	source ./InformixInstall/installIX.sh
	sleep 2
}
