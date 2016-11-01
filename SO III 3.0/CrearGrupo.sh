#!/bin/bash
#CrearGrupo
clear
echo -e "\e[1;34m __________________________\e[0m" 
echo -e "\e[1;34m|\e[0m"	"\e[0;33m   CREACION DE GRUPOS  \e[0m"	" \e[1;34m|\e[0m"
echo -e "\e[1;34m ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\e[0m"
echo -e  
sleep 2
echo -e -n "\e[1;33m Ingrese los siguientes datos...\e[0m"
sleep 3
clear 
echo -e "\e[1;34m __________________________\e[0m" 
echo -e "\e[1;34m|\e[0m"	"\e[0;33m   CREACION DE GRUPOS  \e[0m"	" \e[1;34m|\e[0m"
echo -e "\e[1;34m ¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯\e[0m"
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese Grupo a Crear: "
read Grupo
	Grupo1=$(grep "$Grupo" /etc/group)
if [ "$Grupo1" == "" ]
then
echo -e -n "\n\e[0;32m>\e[0m" "Ingrese GID: "
read gr
groupadd  -g $gr  $Grupo
if [ $? == 0 ]
then
clear
echo -e -n "\e[1;36mEspere\e[0m"
sleep 1
clear
echo -e -n "\e[1;36mEspere.\e[0m"
sleep 1
clear
echo -e -n "\e[1;36mEspere..\e[0m"	
sleep 1 
clear
echo -e -n "\e[1;36mEspere...\e[0m"
sleep 2
clear
echo -e -n "\e[0;32m> Grupo creado exitosamente. \e[0m"
sleep 2
. MenuGrupo.sh
else
	echo -e -n "\n\e[0;31m [x] Se produjo un error...\e[0m"
	sleep 2
	. MenuUsuario.sh
fi
else
echo -e -n "\n\e[0;31m [x] El nombre de Grupo ya existe...\e[0m"
	sleep 2
	clear
	. CrearGrupo.sh
fi
;;
esac
done
