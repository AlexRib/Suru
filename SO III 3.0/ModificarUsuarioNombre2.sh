
#ModificarUsuarioNombre

clear
echo "Ingrese nombre de Usuario: "
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" != "" ]
then
echo "Ingrese nuevo nombre: "
read nom
usermod $Usuario -l $nom	
else
echo " [x] El nombre de usuario no existe..."
	sleep 2
	clear
	. ModificarUsuario.sh
fi
echo "Presione Enter para volver..."
read x
. MenuUsuario.sh
;;
esac
done
