#!/bin/bash
#EliminarUsuario
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Usuario a eliminar: "
read Usuario
Usuario1=$(cut -d ":" -f1 /etc/passwd | grep -wi "$Usuario" )
if [ "$Usuario1" != "" ]
then
	userdel -r $Usuario 
	if [ $? == 0 ]
	then	
		sleep 1
		clear
		echo -e -n "\e[0;32m> Usuario eliminado con exito... \e[0m"
		sleep 2
	else
		echo -e -n "\n\e[0;31m \n[x] Ocurrio un error.\e[0m"
		sleep 2
	fi
else
	echo -e -n "\n\e[0;31m [x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
fi
