#!/bin/bash
#ModificarUsuarioGP
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre de Usuario :"
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" != "" ]
then
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre o GID de un grupo: "
read gr
usermod -g $gr $Usuario
if [ $? == 0 ]
then
clear	
echo -e -n "\e[1;36mEspere...\e[0m"
sleep 2
clear
echo -e -n "\e[0;32m> Modificacion realizada con exito... \e\n[0m"
id $Usuario
echo -e -n "\n\e[1;34m> Presione Enter para volver... \e[0m"
read x
. ModificarUsuario.sh
else
	echo -e -n "\e[0;31m \n[x] Ocurrio un error.\e[0m"
	sleep 3
	. ModificarUsuarioGrupo.sh
fi
else
echo " [x] El nombre de usuario ya existe..."
	sleep 2
	clear
	. ModificarUsuarioGP.sh
fi
;;
esac
done
