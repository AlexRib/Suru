#!/bin/bash
#ModificarUsuarioClave
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre de Usuario :"
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)

if [ "$Usuario1" != "" ]
then
passwd $Usuario
if [ $? == 0 ]
then
clear	
echo -e -n "\e[0;32m> Clave modificada con exito... \e[0m"
sleep 3
. ModificarUsuario.sh
else
	echo -e -n "\e[0;31m \n[x] No tiene los permisos necesarios...\e[0m"
	sleep 3
	. ModificarUsuario.sh
fi
else
echo -e -n "\e[0;31m \n[x] El nombre de Usuario no existe...\e[0m"
	sleep 2
	clear
	. ModificarUsuarioClave.sh
fi
;;
esac
done