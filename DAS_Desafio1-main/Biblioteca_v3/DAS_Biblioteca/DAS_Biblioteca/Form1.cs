namespace DAS_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 libros = new Form2();
            libros.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 usuarios = new Form3();
            usuarios.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 libros = new Form4();
            libros.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 historial = new Form5();
            historial.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 graficos = new Form6();
            graficos.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
