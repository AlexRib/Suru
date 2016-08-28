#!/bin/bash
#BloquearUsuario
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Usuario a Bloquear :"
read Usuario
Usuario1=$(cut -d ":" -f1 /etc/passwd | grep -wi "$Usuario" )
if [ "$Usuario1" != "" ]
then
	usermod  -L $Usuario
	if [ $? == 0 ]
	then
		sleep 1
		clear
		echo -e -n "\e[0;32m> Usuario Bloqueado con exito... \e[0m"
		sleep 2
	else
		sleep 1
		clear
		echo -e -n "\e[0;31m [x] Ocurrio un error.\e[0m"
		sleep 2
	fi
else
	echo -e -n "\n\e[0;31m [x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
fi
