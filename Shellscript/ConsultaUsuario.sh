#!/bin/bash
#ConsultaUsuario
clear
echo -e -n "\e[0;32m>\e[0m" "Ingrese nombre de Usuario :"
read Usuario
Usuario1=$(cut -d ":" -f1 /etc/passwd | grep -wi "$Usuario" )
#Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" != "" ]
then
	sleep 1
	echo -e -n "\n\e[0;34m>\e[0m" "\e[1;34m@info del Usuario: \n\e[0m"
	finger $Usuario
	echo -e -n "\n\e[0;34m>\e[0m" "\e[1;34m@Presione Enter para continuar...\n\e[0m"
	read x
else
	sleep 1
	echo -e -n "\n\e[0;31m [x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
fi
