#!/bin/bash
#MenuSalir
while [ m!=2 ]
do
clear
	echo -e "\e[1;32mEsta seguro de que desea salir?\n\e[0m"
	echo -e " [1] Si"      
	echo -e " [2] No"
	echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Opcion :"
read m
case $m in
1)
	clear
	echo -e -n "\e[1;36mCerrando sesion\e[0m"
	sleep 1
	clear
	echo -e -n "\e[1;36mCerrando sesion.\e[0m"
	sleep 1
	clear
	echo -e -n "\e[1;36mCerrando sesion..\e[0m"	
	sleep 1 
	clear
	echo -e -n "\e[1;36mCerrando sesion...\e[0m"
	sleep 2
	exit
;;
2)
	clear
	echo -e -n "\e[0;34m>\e[0m" "\e[1;34mRedireccionando a Menu Principal...\e[0m"
	sleep 2
	break
;;
*)echo -e "\n\e[0;31m [x] Opcion incorrecta...\e[0m"
sleep 2
clear
;;
esac
done
