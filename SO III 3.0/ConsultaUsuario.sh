#!/bin/bash
#ConsultaUsuario
clear
echo -e -n "\e[0;32m>\e[0m" "Ingrese nombre de Usuario :"
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" != "" ]
then
echo -e -n "\n\e[0;34m>\e[0m" "\e[1;34m@info del Usuario: \n\e[0m"
finger $Usuario
echo -e -n "\n\e[0;34m>\e[0m" "\e[1;34m@Presione Enter para continuar...\n\e[0m"
read x
. MenuUsuario.sh
else
echo " [x] El nombre de usuario no existe..."
	sleep 2
	clear
	. ConsultaUsuario.sh
fi
;;
esac
done
