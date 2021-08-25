using System;
using Entidades;
using Negocios;

namespace Vistas
{
    class Login
    {
        static void Main(string[] args)
        {
            //En este objeto almacenaremos el nombre y contraseña del usuario
            EntidadUsuario usuario = new EntidadUsuario();
            //luego, mediante el negocio realizaremos el inicio de sesión
            NegociosUsuarios negocio = new NegociosUsuarios();


            Console.WriteLine("BIENVENIDOS AL SISTEMA" +
                "\n\nPara Iniciar Sesión, ingresa tu nombre:");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ahora ingresa la contraseña: ");
            usuario.Contraseña = Console.ReadLine();

            //Ahora que tenemos los datos, realizamos la peticion
            //a la capa de negocios para poder iniciar sesion
            //El resultado lo almacenaremos en la misma variable
            usuario = negocio.negocioIniciarSesion(usuario);

            //Si el usuario resulta estar vacio, entonces no se encontró
            //a ese usuario dentro del sistema
            if (usuario == null)
            {
                Console.WriteLine(":(");
                Environment.Exit(1);
            }
            else
            {
                //Si se encuentra un usuario que coincida con el nombre y contraseña
                //ingresados, entonces mostramos sus datos
                Console.WriteLine("Bienvenido " + usuario.Nombre + "!" +
                    "\nA continuación le mostramos sus datos:" +
                    "\nNombre: " + usuario.Nombre + 
                    "\nEdad: " + usuario.Edad + 
                    "\nRol: " + usuario.Rol);
            }
        }
    }
}
