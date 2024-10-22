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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            llenarPrestamo();
        }

        private void llenarPrestamo()
        {
            List<double> months = new List<double>();
            int currentMonth = 0;
            int count = 0;
            List<double> countList = new List<double>();
            foreach (var prestamo in DatosGlobales.Prestamos)
            {
                if (prestamo.GetPrestamoActivo())
                {
                    Usuarios us = prestamo.GetUsuario();
                    Libros lb = prestamo.GetLibro();
                    DateTime fp = prestamo.GetFechaPrestamo();
                    if (months.Contains(fp.Month))
                    {
                        count += 1;
                    }
                    else
                    {
                        if (currentMonth != 0)
                        {
                            countList.Add(count);
                        }
                        currentMonth = fp.Month;
                        months.Add(fp.Month);
                        count = 1;
                    }
                }
            }
            // Ultimo cuenta de prestamos por mes
            if(months.Count > 0)
            {
                countList.Add(count);
            }

            formsPlot1.Plot.Add.Scatter(months, countList);
        }

    }
}
