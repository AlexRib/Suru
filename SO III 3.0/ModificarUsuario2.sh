#!/bin/bash
#ModificarUsuario2
while [ m!=5 ]
do
clear
	echo -e -n "\e[0;36m> Opciones Avanzadas\e[0m" 
	echo -e " \n\e[0;34m ____________________________\e[0m" 
	echo -e "\e[0;34m|\e[0m"	"     Modificar Usuario"	"    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [1] UID\t\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [2] Home\t\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [3] Shell\t"      "            \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [4] Clave\t\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [5] Atras\t\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|____________________________|\e[0m"
	echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Opcion :"
read m
case $m in


1). ModificarUsuarioUID.sh

;;

2). ModificarUsuarioHome.sh

;;

3). ModificarUsuarioShell.sh

;;

4). ModificarUsuarioClave.sh


;;


5). ModificarUsuario.sh

;;

*)echo -e "\n\e[0;31m [x] Opcion incorrecta...\e[0m"
sleep 2
clear
. ModificarUsuario2.sh

;;

esac
done
