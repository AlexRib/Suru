#!/bin/bash
#ConsultaGrupo
clear
echo -e -n "\e[0;32m>\e[0m" "Ingrese nombre del Grupo :"
read Grupo
Grupo1=$(grep "$Grupo" /etc/group)
if [ "$Grupo1" != "" ]
then
	sleep 1
	echo -e -n "\n\e[0;34m>\e[0m" "\e[1;34m@info del Grupo: \n\e[0m"
	grep $Grupo /etc/group
	echo -e -n "\n\e[0;34m>\e[0m" "\e[1;34m@Presione Enter para continuar...\n\e[0m"
	read x
else
	echo -e -n "\n\e[0;31m [x] El nombre del Grupo no existe...\e[0m"
	sleep 2
	clear
fi
