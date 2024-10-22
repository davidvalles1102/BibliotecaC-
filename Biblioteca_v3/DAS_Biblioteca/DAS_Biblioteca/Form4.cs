using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS_Biblioteca
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            llenarPrestamo();
        }

        private void llenarPrestamo()
        {

            string username;

            // Creamos el listado de libros disponibles
            lstLibros.Items.Clear();
            int i = 0;
            foreach (var libro in DatosGlobales.Libros)
            {
                if (libro.GetLibre())
                {
                    lstLibros.Items.Add(new Item { TextoVisible = libro.GetTitulo(), ValorInvisible = i });
                    //lstLibros.Items.Add(libro.GetTitulo());
                }
                i++;
            }

            // Creamos el listado de usuarios
            i = 0;
            lstUsuarios.Items.Clear();
            foreach (var usuario in DatosGlobales.Usuarios)
            {
                username = usuario.GetNombre() + " " + usuario.GetApellido();
                lstUsuarios.Items.Add(new Item { TextoVisible = username, ValorInvisible = i });
                //lstUsuarios.Items.Add(username);

                i++;
            }

            // Cuadro de prestamos
            dataGridView1.Rows.Clear();

            foreach (var prestamo in DatosGlobales.Prestamos)
            {
                if (prestamo.GetPrestamoActivo())
                {
                    int id = prestamo.GetId();
                    Usuarios us = prestamo.GetUsuario();
                    Libros lb = prestamo.GetLibro();
                    DateTime fp = prestamo.GetFechaPrestamo();

                    dataGridView1.Rows.Add(id, us.NombreCompleto(), lb.GetTitulo(), fp.ToString());
                }
            }
        }

        /**
         * Realizamos la asignacion del prestamo
         */
        private void button1_Click(object sender, EventArgs e)
        {
            Item itemSeleccionado = (Item)lstLibros.SelectedItem;
            int selectedLibro = itemSeleccionado.ValorInvisible;
            //int selectedLibro = lstLibros.SelectedIndex;

            itemSeleccionado = (Item)lstUsuarios.SelectedItem;
            int selectedUsuario = itemSeleccionado.ValorInvisible;
            //int selectedUsuario = lstUsuarios.SelectedIndex;

            DateTime dt = dtpFechaPrestamo.Value;
            int id = DatosGlobales.Prestamos.Count;

            if ((selectedLibro != -1) && (selectedUsuario != -1))
            {
                //MessageBox.Show(selectedUsuario + " "+ selectedLibro);
                DatosGlobales.Prestamos.Add(new Prestamos(id, DatosGlobales.Usuarios[selectedUsuario], DatosGlobales.Libros[selectedLibro], dt));
                DatosGlobales.Libros[selectedLibro].SetPrestar(DatosGlobales.Usuarios[selectedUsuario]);
            }

            llenarPrestamo();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se haya hecho clic en el encabezado
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // Obtener el valor de las celdas de la fila seleccionada
                int position = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                llenarDevolucion(position);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Verifica si hay filas seleccionadas
            {
                DataGridViewRow filaSeleccionada = dataGridView1.SelectedRows[0]; // Obtener la primera fila seleccionada

                // Obtener el valor de las celdas de la fila seleccionada
                int position = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                llenarDevolucion(position);
            }
        }

        private void llenarDevolucion(int position)
        {
            Libros libro = DatosGlobales.Prestamos[position].GetLibro();
            Usuarios us = DatosGlobales.Prestamos[position].GetUsuario();
            lblId.Text      = position.ToString();
            lblLibro.Text   = libro.GetTitulo();
            lblUsuario.Text = us.NombreCompleto();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = dtpFechaPrestamo.Value;
            string textId = lblId.Text;

            int idPrestamo = int.Parse(lblId.Text);

            //Indicamos que ya se realizo la devolucion
            DatosGlobales.Prestamos[idPrestamo].SetDevolucion(dt);

            // Habilitamos el libro para futuros prestamos
            Libros tmpLibro = DatosGlobales.Prestamos[idPrestamo].GetLibro();

            int positionLib = 0;
            foreach (Libros libro in DatosGlobales.Libros )
            {
                if (tmpLibro.GetId() == libro.GetId())
                {
                    DatosGlobales.Libros[positionLib].SetLiberar();
                }

                positionLib++;
            }

            // Limpiamos y rellenamos los campos
            lblId.Text      = "";
            lblLibro.Text   = "";
            lblUsuario.Text = "";

            llenarPrestamo();
        }
    }
}
