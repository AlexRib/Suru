#!/bin/bash
#ModificarUsuarioShell
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre de Usuario :"
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" != "" ]
then
echo -e -n "\n\e[0;34m>\e[0m" "Ingrese nueva Shell: "
read she
usermod -s /bin/$she $Usuario
if [ $? == 0 ]
then
clear	
echo -e -n "\e[0;32m> Modificacion realizada con exito... \e[0m"
sleep 3
. ModificarUsuario2.sh
else
	echo -e -n "\e[0;31m \n[x] No posee los permisos necesarios...\e[0m"
	sleep 3
	. ModificarUsuario2.sh
fi
else
echo " [x] El nombre de usuario no existe..."
	sleep 2
	clear
	. ModificarUsuario2.sh
fi
;;
esac
done
