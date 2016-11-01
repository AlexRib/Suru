#rearUsuario

clear
echo "Ingrese Usuario a Crear "
read Usuario
	Usuario1=$(grep "$Usuario" /etc/passwd)
if [ "$Usuario1" == "" ]
then
echo "Ingrese Nombre"
read n
echo "Ingrese Apellido: "
read a
useradd -d /home/$Usuario -mk /etc/skel -c "$n $a" -s /bin/bash -g "100" $Usuario
echo "Usuario Creado"	
else
echo " [x] El nombre de usuario ya existe..."
	sleep 2
	clear
	. CrearUsuario.sh
fi

echo "Presione Enter para volver..."
read x
. MenuUsuario.sh
;;
esac
done
