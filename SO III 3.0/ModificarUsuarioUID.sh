#!/bin/bash
#ModificarUsuarioUID
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre de Usuario :"
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" != "" ]
then
echo -e -n "\n\e[0;34m>\e[0m" "Ingrese nuevo UID: "
read ui
usermod -u $ui  $Usuario
if [ $? == 0 ]
then
clear	
echo -e -n "\e[0;32m> Modificacion realizada con exito... \e[0m"
echo -e "\n "
id $Usuario
sleep 6
. ModificarUsuario2.sh
else
	echo -e -n "\e[0;31m \n[x] Error, el UID debe ser unico o no tiene los permisos necesarios...\e[0m"
	sleep 3
	. ModificarUsuario2.sh
fi
else
echo -e -n "\e[0;31m \n[x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
	. ModificarUsuarioUID.sh
fi
;;
esac
done
