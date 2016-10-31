#!/bin/bash
#ModificarUsuarioGP
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre de Usuario :"
read Usuario
Usuario1=$(cut -d ":" -f1 /etc/passwd | grep -wi "$Usuario" )
if [ "$Usuario1" != "" ]
then
	echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre o GID de un grupo: "
	read gr
	usermod -g $gr $Usuario
	if [ $? == 0 ]
	then
		sleep 1
		clear
		echo -e -n "\e[0;32m> Modificacion realizada con exito... \e\n\n[0m"
		sleep 1
		id $Usuario
		echo -e -n "\n\e[1;34m> Presione Enter para volver... \e[0m"
		read x
	else
		sleep 1
		echo -e -n "\e[0;31m \n[x] Se produjo un error.\e[0m"
		sleep 2
	fi
else
	echo -e -n "\n\e[0;31m [x] El nombre de usuario no existe..."
	sleep 2
	clear
fi
