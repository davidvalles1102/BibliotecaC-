using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection.Metadata.Ecma335;

namespace DAS_Biblioteca
{
    public class Prestamos
    {
        private int ID { get; set; }
        private Usuarios    User { get; set; }
        private Libros      Libro { get; set; }
        private DateTime FechaPrestamo { get; set; }
        private DateTime FechaDevolucion { get; set; }

        private bool PrestamoActivo { get; set; }

        // Constructor general
        public Prestamos(int id, Usuarios us, Libros li, DateTime fp)
        {
            ID = id;
            User = us;
            Libro = li;
            FechaPrestamo = fp;

            PrestamoActivo = true;
        }

        public int GetId() {  return ID; }
        public Usuarios GetUsuario()
        {
            return User;
        }

        public Libros GetLibro()
        {
            return Libro;
        }

        public DateTime GetFechaPrestamo()
        { return FechaPrestamo; }

        public DateTime GetFechaDevolucion()
        { return FechaDevolucion; }

        public bool GetPrestamoActivo()
        {
            return PrestamoActivo;
        }

        public void SetDevolucion(DateTime fd)
        {
            FechaDevolucion = fd;
            PrestamoActivo = false;
        }
        


    }
}
