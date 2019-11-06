#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE para evitar problemas al mostrar caracteres especiales
export LANG=C.UTF-8

##------
#Información de la función
#Función encargada de manejar los procesos para el operador del centro de cómputos.
#Return: No devuelve nada.
##------
inicioProcesos()
{
	opcCCD=1
	while [ "$opcCCD" -ne "0" ]
	do
		clear
		arrmenu=("Ver procesos activos" "Terminar proceso por nombre" "Terminar proceso por PID" "Atrás")
		menu 'arrmenu[@]'
		read opcCCD
		case $opcCCD in 
			1)
				clear
				top
			;;
		
			2)	
				echo -e "Escriba nombre del proceso"
				read srcsv
				killall $srcsv
			;;

			3)	
				echo -e "Escriba el PID del proceso"
				read srcsv
				kill -9 $srcsv
			;;

			4)
				opcCCD=0
			;;

			*)
				clear
				echo "Ingrese una opción de las antes mencionadas"
				read
				opcCCD=1
			;;
		esac
	done
}

##------
#Información de la función
#Función encargada de manejar los logs para el operador del centro de cómputos.
#Return: No devuelve nada.
##------
inicioLogs()
{
	opcLG=1
	while [ "$opcLG" -ne "0" ]
	do
		clear
		arrmenu=("Ver log de último inicio del sistema" "Ver syslog" "Ver mensajes del sistema" "Ver logs de inicio de sesión y seguridad" "Ver último login de un usuario" "Ver logins fallidos" "Ver logins exitosos" "Atrás")
		echo -e "--> Presione q para salir de cualquier opción"
		menu 'arrmenu[@]'
		
		read opcLG
		case $opcLG in 
			1)
				clear
				dmesg | tail | less
			;;
			
			2)
				clear
				journalctl -r
			;;
			3)
				clear
				tail /var/log/messages | less
			;;
			4)
				clear
				tail /var/log/secure | less
			;;
			
			5)
				clear
				read -p "Ingrese el nombre del usuario a buscar('todo' para todos los usuarios):" input
                if [ $input = "todo" ]; then
                    lastlog | less
                else
                    lastlog -u $input | less
                fi
			;;
			6)
				clear
				read -p "Ingrese el nombre del usuario a buscar('todo' para todos los usuarios):" input
				if [ $input = "todo" ]; then
						lastb | less
				else
						if grep -Fxq "$input" /var/log/btmp
						then
								lastb | grep $input | less
						else
								echo ""
								echo -e "Usuario no encontrado."
								read -p "Ingrese cualquier letra para continuar" clear
						fi
				fi
			;;
			7)
				clear
				read -p "Ingrese el nombre del usuario a buscar('todo' para todos los usuarios):" input
				if [ $input = "todo" ]; then
						last | less
				else
						if grep -Fxq "$input" /var/log/wtmp
						then
								last | grep $input | less
						else
								echo ""
								echo -e "Usuario no encontrado."
								read -p "Ingrese cualquier letra para continuar" clear
						fi
				fi
			;;
			8)
				opcLG=0
			;;

			*)
				clear
				echo "Ingrese una opción de las antes mencionadas"
				read
				opcLG=1
			;;
		esac
	done
}

##------
#Información de la función
#Función encargada de manejar los backups para el operador del centro de cómputos.
#Return: No devuelve nada.
##------
inicioBackups()
{
	opcBCK=1
	while [ "$opcBCK" -ne "0" ]
	do
		clear
		arrmenu=("Realizar backup de BD (Dbspaces)" "Realizar backup de logs" "Atrás")
		menu 'arrmenu[@]'
		read opcBCK
		case $opcBCK in 
			1)
				onmode -vky
				clear
				tar -czf /backups/backupBD$dia.tgz -g registroBD$dia.snar /var/dbspaces
				oninit -vy
				clear
				onstat -
			;;
		
			2)
				tar -czf /backups/backupLogs$dia.tgz -g registroLogs$dia.snar /var/log
			;;

			3)
				opcBCK=0
			;;

			*)
				clear
				echo "Ingrese una opción de las antes mencionadas"
				read
				opcBCK=1
			;;
		esac
	done
}

##------
#Información de la función
#Función encargada de manejar la restauración de backups para el operador del centro de cómputos.
#Return: No devuelve nada.
##------
inicioRestore()
{
	opcRE=1
	while [ "$opcRE" -ne "0" ]
	do
		clear
		arrmenu=("Restaurar backup de BD (Dbspaces)" "Restaurar backup de logs" "Atrás")
		menu 'arrmenu[@]'
		read opcRE
		case $opcRE in 
			1)
				onmode -vky
				clear
				tar -xvf /backups/backupBD$dia.tgz -C /var/dbspaces
				oninit -vy
				clear
				onstat -
			;;
		
			2)
				tar -xvf /backups/backupLogs$dia.tgz -C /var/log
			;;

			3)
				opcRE=0
			;;

			*)
				clear
				echo "Ingrese una opción de las antes mencionadas"
				read
				opcRE=1
			;;
		esac
	done
}
inicioFirewall()
{
opcFW=1
	while [ "$opcFW" -ne "0" ]
	do
		clear
		arrmenu=("Instalar Firewall " "Restaurar firewall a default" "Atrás")
		menu 'arrmenu[@]'
		read opcFW
		case $opcFW in 
			1)
				clear
				echo ""
				echo "Esta opcion va a eliminar su actual configuracion de firewall por iptables y asignar nuevas reglas"
				echo "Se abriran los puertos 80,443,9088,22,631,25,110,143,465,993,955"
				read -p "ENTER para continuar , ctrl + C para cancelar" eleccion

				#Establezco firewall restrictivo
				echo ""
				echo "Estableciendo reglas de entrada y salida"
				echo ""

				#Establecemos reglas de entrada
				iptables -A INPUT -p tcp --destination-port 80 -j ACCEPT   # web server
				iptables -A INPUT -p tcp --destination-port 443 -j ACCEPT  # HTTP
				iptables -A INPUT -p tcp --destination-port 9088 -j ACCEPT # Informix
				iptables -A INPUT -p tcp --destination-port 22 -j ACCEPT   # SSH
				iptables -A INPUT -p tcp --destination-port 631 -j ACCEPT  # Impresion
				iptables -A INPUT -p tcp --destination-port 25 -j ACCEPT   # SMTP
				iptables -A INPUT -p tcp --destination-port 110 -j ACCEPT  # pop3
				iptables -A INPUT -p tcp --destination-port 143 -j ACCEPT  # imap
				iptables -A INPUT -p tcp --destination-port 465 -j ACCEPT  # SMTPS
				iptables -A INPUT -p tcp --destination-port 993 -j ACCEPT  # imaps
				iptables -A INPUT -p tcp --destination-port 995 -j ACCEPT  # pop3 sobre SSL

				#Establecemos reglas de salida
				iptables -A OUTPUT -p tcp --destination-port 80 -j ACCEPT   # web server
				iptables -A OUTPUT -p tcp --destination-port 443 -j ACCEPT  # HTTP
				iptables -A OUTPUT -p tcp --destination-port 9088 -j ACCEPT # Informix
				iptables -A OUTPUT -p tcp --destination-port 22 -j ACCEPT   # SSH
				iptables -A OUTPUT -p tcp --destination-port 631 -j ACCEPT  # Impresion
				iptables -A OUTPUT -p tcp --destination-port 25 -j ACCEPT   # SMTP
				iptables -A OUTPUT -p tcp --destination-port 110 -j ACCEPT  # pop3
				iptables -A OUTPUT -p tcp --destination-port 143 -j ACCEPT  # imap
				iptables -A OUTPUT -p tcp --destination-port 465 -j ACCEPT  # SMTPS
				iptables -A OUTPUT -p tcp --destination-port 993 -j ACCEPT  # imaps
				iptables -A OUTPUT -p tcp --destination-port 995 -j ACCEPT  # pop3 sobre SSL
				iptables-save
				iptables-save >> /etc/rc.local

				iptables -P INPUT DROP
				iptables -P FORWARD DROP
				iptables -P OUTPUT DROP


				clear
				echo "------------------"
				echo " Reglas aplicadas "
				echo "------------------"
			;;
		
			2)
				clear
				echo ""
				echo "Esta opcion va a eliminar cualquier configuración de iptables existente"
				echo "PUEDE QUE SEA MUY VULNERABLE A ATAQUES"
				read -p "ENTER para continuar , ctrl + C para cancelar" eleccion
				iptables -F
				iptables -X
				iptables -Z
				iptables -t nat -F
				iptables -P INPUT ACCEPT
				iptables -P FORWARD ACCEPT
				iptables -P OUTPUT ACCEPT
				echo "----------------"
				echo "Script terminado
				echo "----------------"
			;;

			3)
				opcFW=0
			;;

			*)
				clear
				echo "Ingrese una opción de las antes mencionadas"
				read
				opcFW=1
			;;
		esac
	done
}

