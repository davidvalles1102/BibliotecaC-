using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace DAS_Biblioteca
{
    public class Libros
    {
        private int ID { get; set; }
        private string Titulo { get; set; }
        private string Isbn { get; set; }
        private string Autor { get; set; }
        private bool Libre { get; set; }

        private Usuarios Prestado { get; set; }

        public Libros(int id, string tit, string au, string isb) 
        {
            ID = id;
            Titulo = tit;
            Autor = au;
            Isbn = isb;
            Libre = true;
        }
        public int GetId() {  return ID; }
        public string GetTitulo()
        {
            return Titulo;
        }

        public void SetTitulo(string value_txt)
        {
            Titulo = value_txt;
        }

        public string GetISBN()
        {
            return Isbn;
        }

        public void SetISBN(string value_txt)
        {
            Isbn = value_txt;
        }

        public string GetAutor()
        {
            return Autor;
        }

        public void SetAutor(string value_txt)
        {
            Autor = value_txt;
        }

        public void SetPrestar(Usuarios us)
        {
            Prestado = us;
            Libre = false;
        }

        public void SetLiberar()
        {
            Libre = true;
        }

        public bool GetLibre()
        {
            return Libre;
        }
    }
}
