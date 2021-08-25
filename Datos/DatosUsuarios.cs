using System;
using Entidades;

namespace Datos
{
    public class DatosUsuarios
    {
        //Estos objetos simularan ser nuestra base de datos
        //En la cual contamos con 3 usuarios "registrados"
        EntidadUsuario Admin = new EntidadUsuario("William", "12345", 25, "Administrador");
        EntidadUsuario estudiante1 = new EntidadUsuario("Jade", "jd123", 21, "Estudiante");
        EntidadUsuario estudiante2 = new EntidadUsuario("Fred", "fr123", 27, "Estudiante");

        //Con este metodo le regresaremos la informacion al usuario
        public EntidadUsuario IniciarSesion(EntidadUsuario usuario) {

            //Si el nombre y la contraseña coinciden con las del Admin
            //Entonces retornaremos los datos de dicho usuario
            if (usuario.Nombre == Admin.Nombre && usuario.Contraseña == Admin.Contraseña)
            {
                usuario = Admin;

                return usuario;
            }
            //Si el nombre y la contraseña coinciden con las del estudiante1
            //Entonces retornaremos los datos de dicho usuario
            else if (usuario.Nombre == estudiante1.Nombre && usuario.Contraseña == estudiante1.Contraseña)
            {
                usuario = estudiante1;

                return usuario;
            }
            //Si el nombre y la contraseña coinciden con las del estudiante2
            //Entonces retornaremos los datos de dicho usuario
            else if (usuario.Nombre == estudiante2.Nombre && usuario.Contraseña == estudiante2.Contraseña)
            {
                usuario = estudiante2;

                return usuario;
            }
            //Si el nombre y la contraseña no corresponden a ninguno de los
            //usuarios que tenemos registrados, entonces retornamos un NULL
            //para dar a entender que ese usuario no esxiste en el sistema
            else
            {
                return null;
            }
        }
    }
}
