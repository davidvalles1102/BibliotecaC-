﻿using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = dtpDate.Value;

            int i = 0;
            foreach (var prestamo in DatosGlobales.Prestamos)
            {
                if (prestamo.GetFechaPrestamo().Date == dt.Date)
                {
                    Usuarios us = prestamo.GetUsuario();
                    Libros lb = prestamo.GetLibro();
                    DateTime fp = prestamo.GetFechaPrestamo();
                    DateTime fd = prestamo.GetFechaDevolucion();

                    dgvConsulta.Rows.Add(i, us.NombreCompleto(), lb.GetTitulo(), fp.ToString());
                }
                
                i++;
            }
        }
    }
}
