#!/bin/bash
#ModificarUsuarioLogin
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese login del Usuario :"
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" != "" ]
then
echo -e -n "\n\e[0;34m>\e[0m" "Ingrese nuevo login :"
read log
usermod $Usuario -l $log
echo -e -n "\n\e[1;36mEspere...\e[0m"
sleep 2
if [ $? == 0 ]
then
clear	
echo -e -n "\e[0;32m> Modificacion realizada con exito... \e[0m"
sleep 3
. ModificarUsuario.sh
fi
else
	echo -e -n "\e[0;31m \n[x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
	. ModificarUsuarioLogin.sh
fi
;;
esac
done
