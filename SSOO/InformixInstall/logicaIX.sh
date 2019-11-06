#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#Activamos el soporte UT8 para caracteres UNICODE así evitamos problemas con tildes y ñ.
export LANG=C.UTF-8

source ./Instalacion/logicaInstalacion.sh

##------
#Información de la función
#Función encargada de ejecutar el instalador oficial de Informix 14.10.
#Return: No devuelve nada.
##------
instalador()
{
	source /etc/profile.d/informix.sh
	cp -R ./InformixInstall/IBM /opt/
	/opt/IBM/informix/./ids_install
}

##------
#Información de la función
#Función encargada de agregar usuarios y grupos necesarios para el funcionamiento de Informix.
#Return: No devuelve nada.
##------
usersYGrupos()
{
#	groupadd informix >>/dev/null 2>&1
#	useradd informix -g informix >>/dev/null 2>&1
	echo -e "A continuación se pedirá una contraseña para el usuario Informix (DBSA)\nEnter para continuar..."
	read a 
	pass informix 
}

##------
#Información de la función
#Función encargada de obtener la IP y hostname del sistema.
#Return: No devuelve nada.
##------
setIP()
{
	IP="$(cat /etc/sysconfig/network-scripts/ifcfg-enp0s3 | grep IPADDR | cut -d"=" -f2)"
	hostname="$(hostname -s)"
}

##------
#Información de la función
#Función encargada de agregar servicios para Informix.
#Return: No devuelve nada.
##------
serviciosArchivos()
{
	echo "informix	9088/tcp	#Informix Service" >> /etc/services
	echo "$IP	$hostname" >> /etc/hosts
	cp informix.service /etc/systemd/system
	mkdir /etc/informix
	cp abrir.sh /etc/informix
	cp cerrar.sh /etc/informix 
	systemctl enable informix
}

##------
#Información de la función
#Función encargada de configurar las variables de entorno para Informix.
#Return: No devuelve nada.
##------
variables()
{
	echo "export INFORMIXDIR=/opt/IBM/informix" >> /etc/profile.d/informix.sh
	echo "export ONCONFIG=onconfig.$DBSERVERNAME" >> /etc/profile.d/informix.sh
	echo "export INFORMIXSERVER=$DBSERVERNAME" >> /etc/profile.d/informix.sh
	echo "export INFORMIXSQLHOSTS=\$INFORMIXDIR/etc/sqlhosts" >> /etc/profile.d/informix.sh
	echo "export PATH=\$INFORMIXDIR/bin:\$PATH" >> /etc/profile.d/informix.sh
	echo "export DBDATE=DMY4/ #Setea el formato de fechas" >> /etc/profile.d/informix.sh
	echo "export TERM=vt100" >> /etc/profile.d/informix.sh
	echo "export TERMCAP=\$INFORMIXDIR/etc/termcap" >> /etc/profile.d/informix.sh
}

##------
#Información de la función
#Función encargada de agregar los DBSPACES esenciales para Informix.
#Return: No devuelve nada.
##------
dbspacesPrincipales()
{
	#Basandonos en el particionado: 
	mkdir /var/dbspaces
	chmod 770 /var/dbspaces
	chown informix:informix /var/dbspaces
	touch /var/dbspaces/rootdbs
	chmod 660 /var/dbspaces/rootdbs
	chown informix:informix /var/dbspaces/rootdbs
	touch /var/dbspaces/tempdbs
	chmod 660 /var/dbspaces/tempdbs
	chown informix:informix /var/dbspaces/tempdbs
	touch /var/dbspaces/root_mirror
	chmod 660 /var/dbspaces/root_mirror
	chown informix:informix /var/dbspaces/root_mirror
}

##------
#Información de la función
#Función encargada de configurar el archivo principal de ON (Gestor de arranque y administración de Informix).
#Return: No devuelve nada.
##------
onconfigCFG()
{
	cp /opt/IBM/informix/etc/onconfig.std /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
	chown informix.informix /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
	chown informix:informix onconfig.$DBSERVERNAME
	sed -i '/ROOTNAME/c\ROOTNAME rootdbs' /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
	sed -i '/ROOTPATH/c\ROOTPATH /var/dbspaces/rootdbs' /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
	sed -i '/ROOTSIZE/c\ROOTSIZE 1000000' /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
	sed -i '/MIRRORPATH/c\MIRRORPATH /var/dbspaces/root_mirror' /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
	sed -i '/DBSPACETEMP/c\DBSPACETEMP /var/dbspaces/tempdbs' /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
	sed -i '/SERVERNUM/c\SERVERNUM 0' /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
	sed -i "/DBSERVERNAME/c\DBSERVERNAME $DBSERVERNAME" /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
	sed -i '/TAPEDEV/c\TAPEDEV /dev/null' /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
	sed -i '/LTAPEDEV/c\LTAPEDEV /dev/null' /opt/IBM/informix/etc/onconfig.$DBSERVERNAME
}

##------
#Información de la función
#Función encargada de configurar el archivo sqlhosts de Informix.
#Return: No devuelve nada.
##------	
sqlhostsCFG()
{
	echo "$DBSERVERNAME	onsoctcp	$IP	9088" > /opt/IBM/informix/etc/sqlhosts
	chown informix.informix /opt/IBM/informix/etc/sqlhosts
}
