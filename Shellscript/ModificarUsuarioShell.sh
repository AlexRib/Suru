#!/bin/bash
#ModificarUsuarioShell
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre de Usuario :"
read Usuario
Usuario1=$(cut -d ":" -f1 /etc/passwd | grep -wi "$Usuario" )
if [ "$Usuario1" != "" ]
then
	echo -e -n "\n\e[0;34m>\e[0m" "Ingrese nueva Shell: "
	read she
	usermod -s /bin/$she $Usuario
	if [ $? == 0 ]
	then
		sleep 1
		clear	
		echo -e -n "\e[0;32m> Modificacion realizada con exito... \e[0m"
		sleep 2
	else
		speel 1
		echo -e -n "\e[0;31m \n[x] Se produjo un error...\e[0m"
		sleep 2
	fi
else
	echo -e -n "\n\e[0;31m [x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
fi
