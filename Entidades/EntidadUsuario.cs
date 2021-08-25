using System;

namespace Entidades
{
    public class EntidadUsuario
    {
        private string nombre;
        private string contraseña;
        private int edad;
        private string rol;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Rol { get => rol; set => rol = value; }

        public EntidadUsuario() { }

        public EntidadUsuario(string nombre, string contraseña, int edad, string rol)
        {
            this.Nombre = nombre;
            this.Contraseña = contraseña;
            this.Edad = edad;
            this.Rol = rol;
        }
    }
}
