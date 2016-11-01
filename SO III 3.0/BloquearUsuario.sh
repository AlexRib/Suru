#!/bin/bash
#BloquearUsuario
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Usuario a Bloquear :"
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" != "" ]
then
usermod  -L $Usuario
if [ $? == 0 ]
then
clear
echo -e -n "\e[1;36mEspere...\e[0m"
sleep 3	
clear
echo -e -n "\e[0;32m> Usuario Bloqueado con exito... \e[0m"
sleep 3
. BloquearDesbloquear.sh
else
	clear
	echo -e -n "\e[1;36mEspere...\e[0m"
	sleep 3	
	clear
	echo -e -n "\e[0;31m [x] Ocurrio un error.\e[0m"
	sleep 3
	. BloquearDesbloquear.sh
fi
else
echo " [x] El nombre de usuario no existe..."
	sleep 2
	clear
	. BloquearUsuario.sh
fi
;;
esac
done
