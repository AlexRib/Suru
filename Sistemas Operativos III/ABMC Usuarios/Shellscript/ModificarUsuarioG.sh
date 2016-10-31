#!/bin/bash
#ModificarUsuarioG
while [ m!=3 ]
do
clear
	echo -e "\e[1;32m¿Que desea modificar?\n\e[0m"
	echo -e " [1] Grupo Principal"      
	echo -e " [2] Grupo Secundario"
	echo -e " [3] Volver" 
	echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Opcion :"
read m
case $m in

1). ModificarUsuarioGP.sh
;;
2). ModificarUsuarioGS.sh
;;
3)break
;;
*)echo -e "\n\e[0;31m [x] Opcion incorrecta...\e[0m"
sleep 2
clear
;;
esac
done
