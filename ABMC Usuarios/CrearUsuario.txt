#!/bin/bash
#CrearUsuario
clear
echo -e "\e[1;34m ___________________________\e[0m" 
echo -e "\e[1;34m|\e[0m"	"\e[0;33m  CREACION DE USUARIOS\e[0m"	"   \e[1;34m|\e[0m"
echo -e "\e[1;34m ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\e[0m"
echo -e  
sleep 2
echo -e -n "\e[1;33m Ingrese los siguientes datos...\e[0m"
sleep 3
clear 
echo -e "\e[1;34m ___________________________\e[0m" 
echo -e "\e[1;34m|\e[0m"	"\e[0;33m  CREACION DE USUARIOS\e[0m"	"   \e[1;34m|\e[0m"
echo -e "\e[1;34m ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\e[0m"
echo -e -n "\n\e[0;32m>\e[0m" "Usuario: "
read Usuario
Usuario1=$(cut -d ":" -f1 /etc/passwd | grep -wi "$Usuario" )
if [ "$Usuario1" == "" ]
then
	echo -e -n "\n\e[0;32m>\e[0m" "Nombre: "
	read n
	echo -e -n "\n\e[0;32m>\e[0m" "Apellido: "
	read a
	useradd -d /home/$Usuario -mk /etc/skel -c "$n $a" -s /bin/bash -g "100" $Usuario
	if [ $? == 0 ]
	then
		passwd $Usuario
		sleep 2
		clear
		echo -e -n "\e[1;36mEspere\e[0m"
		sleep 1
		clear
		echo -e -n "\e[1;36mEspere.\e[0m"
		sleep 1
		clear
		echo -e -n "\e[1;36mEspere..\e[0m"	
		sleep 1 
		clear
		echo -e -n "\e[1;36mEspere...\e[0m"
		sleep 2
		clear
		echo -e -n "\e[0;32m> Usuario creado exitosamente. \e[0m"
		sleep 2
		clear
		echo -e -n "\e[0;34m>\e[0m" "\e[1;34m@info del Usuario: \n\e[0m"
		finger $Usuario
		echo -e -n "\e[1;34m> Presione Enter para volver... \e[0m"
		read x
	else
		echo -e -n "\n\e[0;31m [x] Se produjo un error...\e[0m"
		sleep 2
	fi
else
	echo -e -n "\n\e[0;31m [x] El nombre de usuario ya existe...\e[0m"
	sleep 2
	clear
	fi
