#!/bin/bash
#ModificarUsuarioLogin
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese login del Usuario :"
read Usuario
Usuario1=$(cut -d ":" -f1 /etc/passwd | grep -wi "$Usuario" )
if [ "$Usuario1" != "" ]
then
	echo -e -n "\n\e[0;34m>\e[0m" "Ingrese nuevo login :"
	read log
	usermod $Usuario -l $log
	if [ $? == 0 ]
	then
		sleep 1
		clear
		echo -e -n "\e[0;32m> Modificacion realizada con exito... \e[0m"			
		sleep 2
	else
		sleep 1
		echo -e -n "\n\e[0;31m [x] Se produjo un error...\e[0m"			
		sleep 2
	fi
else
	echo -e -n "\n\e[0;31m [x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
fi
