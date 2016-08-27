#!/bin/bash
#EliminarGrupo
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese  Grupo a eliminar :"
read Grupo
	Grupo1=$(grep "$Grupo" /etc/group)
if [ "$Grupo1" != "" ]
then
	groupdel $Grupo
	if [ $? == 0 ]
	then
		sleep 1
		clear
		echo -e -n "\e[0;32m> Grupo eliminado... \e[0m"
		sleep 2
	else
		echo -e -n "\e[0;31m \n[x] Ocurrio un error.\e[0m"
		sleep 2
	fi
else
	echo -e -n "\e[0;31m \n[x] El nombre de Grupo no existe...\e[0m"
	sleep 2
	clear
fi

