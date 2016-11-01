#!/bin/bash
#ModificarGrupoGID
clear
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese nombre del grupo :"
read Grupo
	Grupo1=$(grep "$Grupo" /etc/group)
if [ "$Grupo1" != "" ]
then
echo -e -n "\n\e[0;34m>\e[0m" "Ingrese nuevo GID para el Grupo: "
read gid
groupmod  -g $gid  $Grupo
if [ $? == 0 ]
then
clear	
echo -e -n "\e[0;32m> Modificacion realizada con exito... \e[0m"
sleep 3
. ModificarGrupo.sh
else
	echo -e -n "\e[0;31m \n[x] Ocurrio un error. Consulte con el Administrador.\e[0m"
	sleep 2
	. ModificarGrupo.sh
fi
else
echo -e -n "\e[0;31m \n[x] El nombre de Grupo no existe...\e[0m"
	sleep 2
	clear
	. ModificarGrupoNombre.sh
fi
;;
esac
done
