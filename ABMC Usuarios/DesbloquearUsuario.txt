#!/bin/bash
#DesbloquearUsuario
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Usuario a Desbloquear :"
read Usuario
Usuario1=$(cut -d ":" -f1 /etc/passwd | grep -wi "$Usuario" )
if [ "$Usuario1" != "" ]
then
	usermod  -U $Usuario
	if [ $? == 0 ]
	then
		sleep 2
		clear	
		echo -e -n "\e[0;32m> Usuario Desbloqueado con exito... \e[0m"
		sleep 2
	else
		sleep 2
		clear
		echo -e -n "\e[0;31m [x] Ocurrio un error.\e[0m"
		sleep 2
	fi
else
	echo -e -n "\n\e[0;31m [x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
fi
