#!/bin/bash
#Versión 3.0 25/10/2019
#
#Fertspa Studios
#
#Activamos el soporte UT8 para caracteres UNICODE para evitar problemas al mostrar caracteres especiales
export LANG=C.UTF-8

menu()
{
	#Esta función es utilizada para mostrar un menú de forma simple y sin repetir código
	arr=("${!1}") #Se pasa el Array por indirección
	echo "Seleccione una opcion: " 
	for var in $(echo ${!arr[@]}) #Se pasa el array por indirección con el ! para mostrarlo en formato (n1, n2, n3, n4)
	do	
		pos=$((var+ 1)) #Contador para las opciones
		echo "$pos. ${arr[$var]}" #Muestra el contador de opción con el contenido del array en la posición del for
	done
}

verifFecha()
{
	if [ "$(echo $1 | egrep '^[0-9]{4}-[0-1][1-9]-[0-3][1-9]$' | wc -l)" -eq "1" ]
	then 
		date '+%Y-%m-%d' -d "$1" | #redirigimos la salida a una tubería que no devuelve nada, así no imprime la fecha del comando date
		if [ $? -eq "0" ]
                then
                        echo "0"
                else
                        echo "1"
                fi
	else
		echo "1"
	fi
}



