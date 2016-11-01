
#BloquearDesbloquear

while [ $m!=3 ]
do
	clear
	echo " [1] Bloquear Usuario"
	echo " [2] Desbloquear Usuario"
	echo " [3] Volver"
read m
case $m in

1). BloquearUsuario.sh
;;
2).DebloquearUsuario.sh
;;
3). ModificarUsuario.sh
;;
*)echo -e "\n\e[0;31m [x] Opcion incorrecta...\e[0m"
sleep 2
clear
. BloquearDesbloquear.sh

;;

esac
done




