#!/bin/bash
#MenuUsuario
while [ m!=6 ]
do
	clear
	echo -e " \e[0;34m____________________________\e[0m" 
	echo -e "\e[0;34m|\e[0m"	"\t USUARIOS\t "	"   \e[0;34m|\e[0m"
	echo -e "\e[0;34m|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [1] Crear un Usuario\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [2] Modificar un Usuario"      " \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [3] Eliminar un Usuario"      "  \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [4] Bloquear/Desbloquear"      " \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [5] Consultas\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [6] Atras\t\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|____________________________|\e[0m"
	echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Opcion :"
read m
case $m in

1). CrearUsuario.sh
;;
2). ModificarUsuario.sh
;;
3). EliminarUsuario.sh
;;
4). BloquearDesbloquear.sh
;;
5). ConsultaUsuario.sh
;;
6)break 
;;
*)echo -e "\n\e[0;31m [x] Opcion incorrecta...\e[0m"
sleep 2
clear
;;
esac
done
