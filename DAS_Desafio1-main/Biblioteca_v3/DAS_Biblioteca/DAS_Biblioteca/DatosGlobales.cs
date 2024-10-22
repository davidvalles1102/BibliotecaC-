namespace DAS_Biblioteca
{
    using System.Collections.Generic;

    // Asegúrate de que la clase sea pública
    public static class DatosGlobales
    {
        // Listas globales accesibles desde cualquier formulario
        public static List<Usuarios> Usuarios { get; set; } = new List<Usuarios>();
        public static List<Libros> Libros { get; set; } = new List<Libros>();
        public static List<Prestamos> Prestamos { get; set; } = new List<Prestamos>();
    }
}
