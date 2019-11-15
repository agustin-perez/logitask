#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE así evitamos problemas con tildes y ñ
export LANG=C.UTF-8

dia=$(date +%u)

su informix -c "onmode -vky" #Detenemos informix y guardamos todo en disco
$(echo "CIERRE PARCIAL DE INFORMIX PARA:\nBackup de: $(date)(día de la semana: $dia)" | mail -s "Backup $(date)" informix) 
tar -czf /backups/backupBD$dia.tgz -g registroBD$dia.snar /var/dbspaces
su informix -c "oninit -vy" #Levantamos informix nuevamente 

#Backup de logs
tar -czf /backups/backupLogs$dia.tgz -g registroLogs$dia.snar /var/log

#No lo vamos a usar todavía
#rsync -av --delete -b --backup-dir=back prueba* backup* --suffix=”backup $(date +%u)”

