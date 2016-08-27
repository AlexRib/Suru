#!/bin/bash
#ModificarUsuarioComentario
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre de Usuario :"
read Usuario
Usuario1=$(cut -d ":" -f1 /etc/passwd | grep -wi "$Usuario" )
if [ "$Usuario1" != "" ]
then
	echo -e -n "\n\e[0;34m>\e[0m" "Ingrese nuevo comentario :"
	read com
	usermod $Usuario -c "$com"
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
	echo -e -n "\e[0;31m \n[x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
fi
