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
echo "Ingrese Grupo "
read grupo
useradd -d /home/$Usuario -mk /etc/skel -c "$n $a" -s /bin/bash -g "$grupo" $Usuario 
	echo "Usuario Creado"	
else


echo " [x] El nombre de usuario ya existe..."
	clear
	sleep 2
	. CrearUsuario.sh



fi

echo "Presione Enter para volver..."
read x
. MenuUsuario.sh
;;
esac
done
