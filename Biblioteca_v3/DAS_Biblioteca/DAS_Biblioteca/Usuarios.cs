using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DAS_Biblioteca
{
    public class Usuarios
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        // Constructor por defecto
        public Usuarios(string nombre, string apellido, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
        }

        public string NombreCompleto()
        {
            return Nombre+" "+Apellido;
        }

        public string GetNombre()
            { return Nombre; }
        public string GetApellido()
            { return Apellido; }
        public string GetEmail()
            {return Email; }
    }
}
