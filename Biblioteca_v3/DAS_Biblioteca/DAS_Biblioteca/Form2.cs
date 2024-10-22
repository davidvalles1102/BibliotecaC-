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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Cargamos el listado de los libro
            llenarLibros();

            // Bloqueamos los input box del nuevo libro
            txtBoxTitulo.Enabled = false;
            txtBoxAutor.Enabled = false;
            txtBoxIsbn.Enabled = false;
            btnSaveNewBook.Enabled = false;
            btnCancelar.Enabled = false;

            // Ocultamos el group box de edicion
            button3.Enabled = false;
            btnCancelarDetalle.Enabled = false;

            groupBox3.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // desbloqueamos los input box del nuevo libro
            txtBoxTitulo.Enabled = true;
            txtBoxAutor.Enabled = true;
            txtBoxIsbn.Enabled = true;
            btnCancelar.Enabled = true;
            btnSaveNewBook.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Bloqueamos los input box del nuevo libro
            txtBoxTitulo.Enabled = false;
            txtBoxAutor.Enabled = false;
            txtBoxIsbn.Enabled = false;
            btnSaveNewBook.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnSaveNewBook_Click(object sender, EventArgs e)
        {
            int id = DatosGlobales.Libros.Count;
            string tit = txtBoxTitulo.Text;
            string au = txtBoxAutor.Text;
            string isb = txtBoxIsbn.Text;
            DatosGlobales.Libros.Add(new Libros(id, tit, au, isb));

            llenarLibros();

            // Bloqueamos los input box del nuevo libro
            txtBoxTitulo.Text = "";
            txtBoxTitulo.Enabled = false;
            txtBoxAutor.Text = "";
            txtBoxAutor.Enabled = false;
            txtBoxIsbn.Text = "";
            txtBoxIsbn.Enabled = false;
            btnSaveNewBook.Enabled = false;
            btnCancelar.Enabled = false;

        }

        private void llenarLibros()
        {
            dataGridView1.Rows.Clear();

            foreach (var libro in DatosGlobales.Libros)
            {
                dataGridView1.Rows.Add(libro.GetId(), libro.GetTitulo(), libro.GetAutor(), libro.GetISBN());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Bloqueamos los input box del nuevo libro
            txtBoxTitulo.Enabled = false;
            txtBoxAutor.Enabled = false;
            txtBoxIsbn.Enabled = false;
            btnSaveNewBook.Enabled = false;
            btnCancelar.Enabled = false;

            // Habilitamos la informacion a consultar

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false; //Ocultamos el groupbox de detalle

            int idLibro = int.Parse(lblId.Text);

            textBox3.Text = DatosGlobales.Libros[idLibro].GetTitulo();
            textBox2.Text = DatosGlobales.Libros[idLibro].GetAutor();
            textBox1.Text = DatosGlobales.Libros[idLibro].GetISBN();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no se haya hecho clic en el encabezado
            {
                DataGridViewRow filaSeleccionada = dataGridView1.Rows[e.RowIndex];

                // Obtener el valor de las celdas de la fila seleccionada
                int position = int.Parse(filaSeleccionada.Cells[0].Value.ToString());

                lblId.Text = Convert.ToString(DatosGlobales.Libros[position].GetId());
                lblTitulo.Text = DatosGlobales.Libros[position].GetTitulo();
                lblAutor.Text = DatosGlobales.Libros[position].GetAutor();
                lblIsbn.Text = DatosGlobales.Libros[position].GetISBN();
                string estado = "Prestado";
                if (DatosGlobales.Libros[position].GetLibre())
                {
                    estado = "Libre";
                }
                lblEstado.Text = estado;

                button3.Enabled = true ;
                btnCancelarDetalle.Enabled = true;
            }
        }

        private void btnCancelarDetalle_Click(object sender, EventArgs e)
        {
            // Limpiamos el area del detalle del libro
            lblId.Text = "";
            lblTitulo.Text = "";
            lblAutor.Text = "";
            lblIsbn.Text = "";
            lblEstado.Text = "";

            // Bloqueamos los input box del nuevo libro
            txtBoxTitulo.Text = "";
            txtBoxTitulo.Enabled = false;
            txtBoxAutor.Text = "";
            txtBoxAutor.Enabled = false;
            txtBoxIsbn.Text = "";
            txtBoxIsbn.Enabled = false;
            btnSaveNewBook.Enabled = false;
            btnCancelar.Enabled = false;

            button3.Enabled = false;
            btnCancelarDetalle.Enabled = false;

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = true; //Ocultamos el groupbox de detalle
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idLibro = int.Parse(lblId.Text);

            DatosGlobales.Libros[idLibro].SetTitulo(textBox3.Text);
            DatosGlobales.Libros[idLibro].SetAutor(textBox2.Text);
            DatosGlobales.Libros[idLibro].SetISBN(textBox1.Text);

            llenarLibros();

            groupBox3.Visible = false;
            groupBox2.Visible = true;

            // Limpiamos el area del detalle del libro
            lblId.Text = "";
            lblTitulo.Text = "";
            lblAutor.Text = "";
            lblIsbn.Text = "";
            lblEstado.Text = "";

            // Bloqueamos los input box del nuevo libro
            txtBoxTitulo.Text = "";
            txtBoxTitulo.Enabled = false;
            txtBoxAutor.Text = "";
            txtBoxAutor.Enabled = false;
            txtBoxIsbn.Text = "";
            txtBoxIsbn.Enabled = false;
            btnSaveNewBook.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
