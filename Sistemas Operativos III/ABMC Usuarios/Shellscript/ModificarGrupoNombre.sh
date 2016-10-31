#!/bin/bash
#ModificarGrupoNombre
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre del grupo :"
read Grupo
	Grupo1=$(grep "$Grupo" /etc/group)
if [ "$Grupo1" != "" ]
then
	echo -e -n "\n\e[0;34m>\e[0m" "Ingrese nuevo nombre para el Grupo: "
	read gr
	groupmod  -n $gr  $Grupo
	if [ $? == 0 ]
	then
		sleep 1
		clear	
		echo -e -n "\e[0;32m> Modificacion realizada con exito... \e[0m"
		sleep 2
	else
		sleep 1
		echo -e -n "\e[0;31m \n[x] Ocurrio un error.\e[0m"
		sleep 2
	fi
else
	echo -e -n "\e[0;31m \n[x] El nombre de Grupo no existe...\e[0m"
	sleep 2
	clear
fi
