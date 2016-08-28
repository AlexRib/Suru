#!/bin/bash
#MenuGrupo
while [ m!=5 ]
do
	clear
	echo -e " \e[0;34m____________________________\e[0m" 
	echo -e "\e[0;34m|\e[0m"	"\t    GRUPOS\t"	"    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [1] Crear un Grupo\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [2] Modificar un Grupo"      "   \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [3] Eliminar un Grupo"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [4] Consultas\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	" [5] Atras\t\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|____________________________|\e[0m"
	echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Opcion :"
	read m
	case $m in

1). CrearGrupo.sh
;;
2). ModificarGrupo.sh
;;
3). EliminarGrupo.sh
;;
4). ConsultaGrupo.sh
;;
5)break
;;
*)echo -e "\n\e[0;31m [x] Opcion incorrecta...\e[0m"
sleep 2
clear
;;
esac
done
