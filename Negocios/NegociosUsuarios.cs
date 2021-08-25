using System;
using Entidades;
using Datos;

namespace Negocios
{
    public class NegociosUsuarios
    {
        //Con este objeto realizaremos las peticiones a la capa de Datos
        DatosUsuarios datos = new DatosUsuarios();

        //Este metodo nos permitirá validar y verificar los datos
        //para que el usuario pueda Iniciar Sesion
        public EntidadUsuario negocioIniciarSesion(EntidadUsuario usuario) {

            //Primero nos aseguramos de que el usuario ingrese su nombre y contraseña
            //porque estos campos no deben estar vacios
            if (usuario.Nombre == "" || usuario.Contraseña == "")
            {
                Console.WriteLine("Debe ingresar un nombre y/o una contraseña!");
                return null;
            }
            else
            {
                //Si todo esta en orden, usamos la capa de datos para encontrar
                //al usuario. El resultado lo almacenamos en el objeto "usuario"
                usuario = datos.IniciarSesion(usuario);

                //Si el objeto usuario resulta estar vacio, significa que
                //no se encontró al usuario, por ende, no está registrado
                if (usuario == null)
                {
                    Console.WriteLine("Este usuario no se encuentra registrado dentro del sistema!");
                    return null;
                }
                else
                {
                    //Si se encuentra un usuario que coincida con los datos ingresados
                    //entonces retornamos el usuario con todos los datos
                    Console.WriteLine("Inicio de Sesión exitoso!");
                    return usuario;
                }
            }
        }
    }
}
