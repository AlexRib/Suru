#!/bin/bash
#EliminarUsuario
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Usuario a eliminar: "
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" != "" ]
then
userdel -r $Usuario 
if [ $? == 0 ]
then
clear
echo -e -n "\e[1;36mEspere...\e[0m"	
sleep 2
clear
echo -e -n "\e[0;32m> Modificacion realizada con exito... \e[0m"
sleep 3
. ModificarUsuario.sh
else
	clear
	echo -e -n "\e[0;31m \n[x] No posee permisos de administrador.\e[0m"
	sleep 3
	. MenuUsuario.sh
fi
else
echo -e -n "\e[0;31m \n[x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
	. EliminarUsuario.sh
fi
;;
esac
done
