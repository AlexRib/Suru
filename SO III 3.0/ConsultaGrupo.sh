#!/bin/bash
#ConsultaGrupo
clear
echo -e -n "\e[0;32m>\e[0m" "Ingrese nombre del grupo :"
read Grupo
	Grupo1=$(grep "$Grupo" /etc/group)
if [ "$Grupo1" != "" ]
then
echo -e -n "\n\e[0;34m>\e[0m" "\e[1;34m@info de los Grupos: \n\e[0m"
grep $Grupo /etc/group
echo -e -n "\n\e[0;34m>\e[0m" "\e[1;34m@Presione Enter para continuar...\n\e[0m"
read x
. ModificarGrupo.sh
else
echo -e -n "\e[0;31m \n[x] El nombre de Grupo no existe...\e[0m"
	sleep 2
	clear
	. ModificarGrupoNombre.sh
fi
;;
esac
done