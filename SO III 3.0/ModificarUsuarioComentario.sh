#!/bin/bash
#ModificarUsuarioComentario
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre de Usuario :"
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" != "" ]
then
echo -e -n "\n\e[0;34m>\e[0m" "Ingrese nuevo comentario :"
read com
usermod $Usuario -c "$com"
if [ $? == 0 ]
then
clear	
echo -e -n "\n\e[1;36mEspere...\e[0m"
sleep 2
clear
echo -e -n "\e[0;32m> Modificacion realizada con exito... \e[0m"
sleep 3
. ModificarUsuario.sh
else
	echo -e -n "\e[0;31m \n[x] Ocurrio un error.\e[0m"
	sleep 3
	. ModificarUsuario.sh
fi
else
echo -e -n "\e[0;31m \n[x] El nombre de usuario no existe...\e[0m"
	sleep 2
	clear
	. ModificarUsuarioComentario.sh
fi
echo "Presione Enter para volver..."
read x
. MenuUsuario.sh
;;
esac
done

