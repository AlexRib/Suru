#Salir
clear
echo "Está seguro de que desea salir? (S/N)" 
read salir
if [ "$salir" == "S" ]
then
	echo "Cerrando sesión..."
	clear
	sleep 2
	exit
fi

if [ "$salir" == "N" ]
then
	echo "Redireccionando a Menu Principal..."
	clear
	sleep 2
	. ManuPrincipal.sh
fi

;;

esac
done
