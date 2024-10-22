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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxNombre.Text = string.Empty;
            txtBoxApellido.Text = string.Empty;
            txtBoxEmail.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string no = txtBoxNombre.Text;
            string ap = txtBoxApellido.Text;
            string em = txtBoxEmail.Text;
            DatosGlobales.Usuarios.Add(new Usuarios(no, ap, em));

            txtBoxNombre.Text = string.Empty;
            txtBoxApellido.Text = string.Empty;
            txtBoxEmail.Text = string.Empty;

            llenarUsuarios();
        }

        private void llenarUsuarios()
        {
            dataGridView1.Rows.Clear();

            int i = 0;
            foreach (var usuario in DatosGlobales.Usuarios)
            {
                dataGridView1.Rows.Add(i, usuario.GetNombre(), usuario.GetApellido(), usuario.GetEmail());
                i++;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            llenarUsuarios();
        }
    }
}
