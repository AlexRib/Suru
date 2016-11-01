#mal

while [ $m!=3 ]
do
	clear
	
	echo -e "\n \e[0;34m____________________________\e[0m" 
	echo -e "\e[0;34m|\e[0m"	"\tMenu Principal\t"	"    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯|\e[0m"
	echo -e "\e[0;34m|\e[0m"	"\t[1] Usuario\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	"\t[2] Grupo\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|\e[0m"	"\t[3] Salir\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m|____________________________|\e[0m"
	echo -e "\e[0;34m|\e[0m"	"\e[0;36m Ingrese Opcion:\e[0m\t"      "    \e[0;34m|\e[0m"
	echo -e "\e[0;34m ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\e[0m" 
read m
case $m in

1). MenuUsuario.sh
;;
2). MenuGrupo.sh
;;
3). MenuSalir.sh
;;
*)echo -e "\n\e[0;31m [x] Opcion incorrecta...\e[0m"
sleep 2
clear
. MenuPrincipal.sh

;;

esac
done


