#!/bin/bash

function setcolors {
	BLACK='033[0;30m'
	RED='\033[0;31m'
	GREEN='\033[0;32m'
	BROWN='\033[0;33m'
	BLUE='\033[0;34m'
	PURPLE='\033[0;35m'
	CYAN='\033[0;36m'
	YELLOW='\033[1;33m'
	WHITE='\033[1;37m'
	printf '\e[8;30;100t'
	clear
}

function ejecutar {
	clear
	setcolors
	clear
	menu
}

############################################################ MENU ###################################################################
function menu {
	while [ $op!=5 ]
	do
		clear
		echo -e "${YELLOW}Menu Principal"
		echo
		echo -e "${PURPLE}1) ${WHITE}Adminstrador general"
		echo -e "${PURPLE}2) ${WHITE}Administrador individual"
		echo -e "${PURPLE}3) ${WHITE}Auxiliar"
		echo -e "${PURPLE}4) ${WHITE}Salir"
		echo -e "${YELLOW}"
		read -p "Ingrese una opción: " op
		case $op in
			1) admingeneral
				;;
			2) adminingeneral
				;;
			3) auxiliar
				;;
			4) exit
				;;
			*) echo -e "${RED}¡Opción inválida!"
				sleep 1.5	;;
		esac
	done
}

#######################################################################################################################################
############################################################# USUARIOS ################################################################

#Usuario General
function admingeneral {
while [ $op!=6 ]
	do
		clear
		echo -e "${YELLOW}Administracion general."
		echo
		echo -e "${PURPLE}1) ${WHITE}Usuarios"
		echo -e "${PURPLE}2) ${WHITE}Animales"
		echo -e "${PURPLE}3) ${WHITE}Atras"
		echo -e "${YELLOW}"
		read -p "Ingrese una opcion: " op
		case $op in
			1) .MenuPrincipal.sh
				;;
			2) animal
				;;
			3) menu
				;;
			*) echo -e "${RED}Opcion invalida!"
				sleep 1.5	;;
		esac
	done
	}

#Usuario Individual
function adminindividual {
while [ $op!=6 ]
	do
		clear
		echo -e "${YELLOW}Administracion individual."
		echo
		echo -e "${PURPLE}1) ${WHITE}Animal"
		echo -e "${PURPLE}2) ${WHITE}Bajas"
		echo -e "${PURPLE}3) ${WHITE}Modificaciones"
		echo -e "${PURPLE}4) ${WHITE}Consultas (Busquedas)"
		echo -e "${PURPLE}5) ${WHITE}Listados"
		echo -e "${PURPLE}6) ${WHITE}Volver"
		echo -e "${YELLOW}"
		read -p "Ingrese una opcion: " op
		case $op in
			1) ai_animal
				;;
			2) ai
				;;
			3) modemp
				;;
			4) consemp
				;;
			5) listemp
				;;
			6) menu
				;;
			*) echo -e "${RED}Opcion invalida!"
				sleep 1.5	;;
		esac
	done
}

#Usuario Auxiliar
function auxiliar {
while [ $op!=6 ]
	do
		clear
		echo -e "${YELLOW}Animales"
		echo
		echo -e "${PURPLE}1) ${WHITE}Altas"
		echo -e "${PURPLE}2) ${WHITE}Bajas"
		echo -e "${PURPLE}3) ${WHITE}Modificaciones"
		echo -e "${PURPLE}4) ${WHITE}Consultas (Busquedas)"
		echo -e "${PURPLE}5) ${WHITE}Listados"
		echo -e "${PURPLE}6) ${WHITE}Volver"
		echo -e "${YELLOW}"
		read -p "Ingrese una opcion: " op
		case $op in
			1) al
				;;
			2) bajemp
				;;
			3) modemp
				;;
			4) consemp
				;;
			5) listemp
				;;
			6) menu
				;;
			*) echo -e "${RED}Opcion invalida!"
				sleep 1.5	;;
		esac
	done
}

####################################################################################################################################
############################################################## Animal ##############################################################
function animal {
while [ $op!=6 ]
	do
		clear
		echo -e "${YELLOW}Animales:"
		echo
		echo -e "${PURPLE}1) ${WHITE}Toros"
		echo -e "${PURPLE}2) ${WHITE}Vacas"
		echo -e "${PURPLE}3) ${WHITE}Crias"
		echo -e "${PURPLE}6) ${WHITE}Volver"
		echo -e "${YELLOW}"
		read -p "Ingrese una opcion: " op
		case $op in
			1) menu_toro
				;;
			2) menu_vaca
				;;
			3) menu_cria
				;;
			4) menu
				;;
			*) echo -e "${RED}Opcion invalida!"
				sleep 1.5	;;
		esac
	done
}

############# Toro
function menu_toro {
while [ $op!=6 ]
	do
		clear
		echo -e "${YELLOW}------- TOROS ------"
		echo
		echo -e "${PURPLE}1) ${WHITE}Altas"
		echo -e "${PURPLE}2) ${WHITE}Bajas"
		echo -e "${PURPLE}3) ${WHITE}Modificaciones"
		echo -e "${PURPLE}4) ${WHITE}Consultas (Busquedas)"
		echo -e "${PURPLE}5) ${WHITE}Listados"
		echo -e "${PURPLE}6) ${WHITE}Volver"
		echo -e "${YELLOW}"
		read -p "Ingrese una opcion: " op
		case $op in
			1) alta_toro
				;;
			2) baja_toro
				;;
			3) mod_toro
				;;
			4) cons_toro
				;;
			5) list_toro
				;;
			6) animal
				;;
			*) echo -e "${RED}Opcion invalida!"
				sleep 1.5	;;
		esac
	done
}

############# Vaca
function menu_vaca {
while [ $op!=6 ]
	do
		clear
		echo -e "${YELLOW}------- VACAS ------"
		echo
		echo -e "${PURPLE}1) ${WHITE}Altas"
		echo -e "${PURPLE}2) ${WHITE}Bajas"
		echo -e "${PURPLE}3) ${WHITE}Modificaciones"
		echo -e "${PURPLE}4) ${WHITE}Consultas (Busquedas)"
		echo -e "${PURPLE}5) ${WHITE}Listados"
		echo -e "${PURPLE}6) ${WHITE}Volver"
		echo -e "${YELLOW}"
		read -p "Ingrese una opcion: " op
		case $op in
			1) alta_vaca
				;;
			2) baja_vaca
				;;
			3) mod_vaca
				;;
			4) cons_vaca
				;;
			5) list_vaca
				;;
			6) animal
				;;
			*) echo -e "${RED}Opcion invalida!"
				sleep 1.5	;;
		esac
	done
}

############# Cria
function menu_cria {
while [ $op!=6 ]
	do
		clear
		echo -e "${YELLOW}------- CRIAS ------"
		echo
		echo -e "${PURPLE}1) ${WHITE}Altas"
		echo -e "${PURPLE}2) ${WHITE}Bajas"
		echo -e "${PURPLE}3) ${WHITE}Modificaciones"
		echo -e "${PURPLE}4) ${WHITE}Consultas (Busquedas)"
		echo -e "${PURPLE}5) ${WHITE}Listados"
		echo -e "${PURPLE}6) ${WHITE}Volver"
		echo -e "${YELLOW}"
		read -p "Ingrese una opcion: " op
		case $op in
			1) alta_cria
				;;
			2) baja_cria
				;;
			3) mod_cria
				;;
			4) cons_cria
				;;
			5) listado_cria
				;;
			6) animal
				;;
			*) echo -e "${RED}Opcion invalida!"
				sleep 1.5	;;
		esac
	done
}

############# Alta
function alta_toro {
		sexo="Macho"
		clear
		echo
		read -p "Identificacion: " id
		read -p "Nombre: " nom
		read -p "Tipo: " tipo
		read -p "Raza: " raza
		read -p "Fecha nacimiento: " fecha_nac
		echo $id:$sexo:$nom:$tipo:$raza:$fecha_nac >> toro.txt
		sleep 1.5
		echo -e "${GREEN}Datos ingresados correctamente."
		sleep 1.5
		menu_toro
}

############# Baja
function baja_toro {
		clear
		read -p "Identificación: " id
		if [ $? -ne 0 ]
		then
			echo -e "${RED}Eliminando..."
			sleep 1
			sed -i "/$id/d" toro.txt
			echo -e "${GREEN}Registro de toro eliminado!"
			sleep 1.5
		else
			echo "El registo no existe"
			sleep 1.5
		fi
		menu_toro
}

############# Modificacion
function mod_toro {
		clear
		read -p "Identificación: " id
		echo "Datos del toro: "
		
		if grep $id toro.txt
		then
			echo "Que desea modificar:"
			echo "1- Nombre"
			echo "2- Tipo"
			echo "Ingrese opcion"
			read op
		case $op in
			1)
				read -p "Nombre actual: " nom1
				read -p "Nuevo nombre: " nom2
				sed "s/$nom1/$nomb2/" toro.txt
				echo "Modificacion exitosa"
				;;

			2)				
				read -p "Tipo actual: " tipo1
				read -p "Nuevo tipo: " tipo2
				sed "s/$tipo1/$tipo2/" toro.txt
				echo "Modificacion exitosa"
			 	;;
			 	esac
		else 
			echo "El toro no existe."
		
		fi
		menu_toro
}

############# Consulta
function cons_toro {
		clear
		read -p "Identificacion: " id
		if grep $id toro.txt
		then
			read -p "Presione ENTER para continuar" j
		else
			echo "EL registro no existe"
		fi
		menu_toro
}

############# Listado
function list_toro {
		echo "Identificacion : Sexo : Nombre : Tipo : Raza : Fecha nacimiento"
		cat toro.txt
		read -p "Presione ENTER para continuar" j
		menu_toro
}

############# Alta
function alta_vaca {
		sexo="Hembra"
		clear
		echo
		read -p "Identificacion: " id
		read -p "Nombre: " nom
		read -p "Tipo: " tipo
		read -p "Raza: " raza
		read -p "Fecha nacimiento: " fecha_nac
		echo $id:$sexo:$nom:$tipo:$raza:$fecha_nac >> vaca.txt
		sleep 1.5
		echo -e "${GREEN}Datos ingresados correctamente."
		sleep 1.5
		menu_vaca
}

############# Baja
function baja_vaca {
		clear
		read -p "Identificación: " id
		echo -e "${RED}Eliminando..."
		sleep 1
		sed -i "/$id/d" vaca.txt
		echo -e "${GREEN}Registro de vaca eliminado!"
		sleep 2
}

############# Modificacion
function mod_vaca {
		clear
		read -p "Identificación: " id
		
			echo "Datos del vaca: "
			grep $id vaca.txt
		if [ $? -ne 0 ]
		then
			echo "Que desea modificar:"
			echo "1- Nombre"
			echo "2- Tipo"
			echo "Ingrese opcion"
			read op
		case $op in
			1)
				read -p "Nombre actual: " nom1
				read -p "Nuevo nombre: " nom2
				sed "s/$nom1/$nomb2/" vaca.txt
				echo "Modificacion exitosa"
				;;

			2)				
				read -p "Tipo actual: " tipo1
				read -p "Nuevo tipo: " tipo2
				sed "s/$tipo1/$tipo2/" vaca.txt
				echo "Modificacion exitosa"
				;;
				esac

		else 
			echo "La vaca no existe."
		fi
}

############# Consulta
function cons_vaca {
		clear
		read -p "Identificación: " id
		grep $id vaca.txt
		if [ $? -ne 0 ]
		then
			echo "s"
		else
			echo "Error al buscar"
		fi
}

############# Listado
function list_vaca {
		echo "Identificacion : Sexo : Nombre : Tipo : Raza : Fecha nacimiento"
		cat vaca.txt
}

############# Alta
function alta_cria {
		clear
		echo
		read -p "Identificacion: " id
		read -p "Nombre: " nom
		read -p "Tipo: " tipo
		read -p "Raza: " raza
		read -p "Sexo:" sexo
		read -p "Fecha nacimiento: " fecha_nac
		echo $id:$sexo:$nom:$tipo:$raza:$fecha_nac >> cria.txt
		sleep 1.5
		echo -e "${GREEN}Datos ingresados correctamente."
		sleep 1.5
		menu_cria
}

############# Baja
function baja_cria {
		clear
		read -p "Identificación: " id
		echo -e "${RED}Eliminando..."
		sleep 1
		sed -i "/$id/d" cria.txt
		echo -e "${GREEN}Registro de toro eliminado!"
		sleep 2
}

############# Modificacion
function mod_cria {
		clear
		read -p "Identificación: " id
		
			echo "Datos de la cria: "
			grep $id cria.txt
		if [ $? -ne 0 ]
		then
			echo "Que desea modificar:"
			echo "1- Nombre"
			echo "2- Tipo"
			echo "Ingrese opcion"
			read op
		case $op in
			1)
				read -p "Nombre actual: " nom1
				read -p "Nuevo nombre: " nom2
				sed "s/$nom1/$nomb2/" cria.txt
				echo "Modificacion exitosa"
				;;

			2)				
				read -p "Tipo actual: " tipo1
				read -p "Nuevo tipo: " tipo2
				sed "s/$tipo1/$tipo2/" cria.txt
				echo "Modificacion exitosa"
				;;
				esac
		else 
			echo "La cria no existe."
		fi
}

############# Consulta
function cons_cria {
		clear
		read -p "Identificación: " id
		grep $id cria.txt
		if [ $? -ne 0 ]
		then
			echo "s"
		else
			echo "Error al buscar"
		fi
}

############# Listado
function list_cria {
		echo "Identificacion : Sexo : Nombre : Tipo : Raza : Fecha nacimiento"
		cat cria.txt
}

ejecutar