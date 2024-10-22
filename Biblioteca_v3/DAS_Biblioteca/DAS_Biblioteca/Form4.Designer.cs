namespace DAS_Biblioteca
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            lstUsuarios = new ListBox();
            label1 = new Label();
            lstLibros = new ListBox();
            dtpFechaPrestamo = new DateTimePicker();
            dataGridView1 = new DataGridView();
            no = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            libro = new DataGridViewTextBoxColumn();
            fechaPrestamo = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            lblId = new Label();
            label7 = new Label();
            lblLibro = new Label();
            lblUsuario = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            label8 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lstUsuarios);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lstLibros);
            groupBox1.Controls.Add(dtpFechaPrestamo);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Realizar Prestamo";
            // 
            // button1
            // 
            button1.Location = new Point(83, 191);
            button1.Name = "button1";
            button1.Size = new Size(98, 33);
            button1.TabIndex = 9;
            button1.Text = "Prestar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 136);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 8;
            label3.Text = "Fecha de prestamo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 25);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 7;
            label2.Text = "Usuarios";
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 15;
            lstUsuarios.Location = new Point(174, 43);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(106, 79);
            lstUsuarios.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Libros";
            // 
            // lstLibros
            // 
            lstLibros.FormattingEnabled = true;
            lstLibros.ItemHeight = 15;
            lstLibros.Location = new Point(20, 43);
            lstLibros.Name = "lstLibros";
            lstLibros.Size = new Size(106, 79);
            lstLibros.TabIndex = 4;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(20, 154);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(260, 23);
            dtpFechaPrestamo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { no, usuario, libro, fechaPrestamo });
            dataGridView1.Location = new Point(345, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(515, 187);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // no
            // 
            no.HeaderText = "No";
            no.Name = "no";
            no.ReadOnly = true;
            // 
            // usuario
            // 
            usuario.HeaderText = "Usuario";
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            // 
            // libro
            // 
            libro.HeaderText = "Libro";
            libro.Name = "libro";
            libro.ReadOnly = true;
            // 
            // fechaPrestamo
            // 
            fechaPrestamo.HeaderText = "Fecha Prestamo";
            fechaPrestamo.Name = "fechaPrestamo";
            fechaPrestamo.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblId);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(lblLibro);
            groupBox2.Controls.Add(lblUsuario);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(10, 259);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(848, 114);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Devolucion";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(95, 19);
            lblId.Name = "lblId";
            lblId.Size = new Size(10, 15);
            lblId.TabIndex = 8;
            lblId.Text = ".";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 19);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 7;
            label7.Text = "ID:";
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Location = new Point(95, 78);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(10, 15);
            lblLibro.TabIndex = 6;
            lblLibro.Text = ".";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(95, 50);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(10, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 78);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 4;
            label6.Text = "Libro:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 47);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 3;
            label5.Text = "Usuario:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 62);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(119, 15);
            label4.TabIndex = 2;
            label4.Text = "Fecha de devolucion:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(568, 56);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(244, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(335, 85);
            button2.Name = "button2";
            button2.Size = new Size(184, 23);
            button2.TabIndex = 0;
            button2.Text = "Procesar devolucion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(453, 26);
            label8.Name = "label8";
            label8.Size = new Size(262, 15);
            label8.TabIndex = 3;
            label8.Text = "Para realizar una devolucion de clic en una celda";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 385);
            Controls.Add(label8);
            Controls.Add(groupBox2);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "Form4";
            Text = "Prestamos";
            Load += Form4_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpFechaPrestamo;
        private Button button1;
        private Label label3;
        private Label label2;
        private ListBox lstUsuarios;
        private Label label1;
        private ListBox lstLibros;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn no;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn libro;
        private DataGridViewTextBoxColumn fechaPrestamo;
        private GroupBox groupBox2;
        private Button button2;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label lblLibro;
        private Label lblUsuario;
        private Label lblId;
        private Label label7;
        private Label label8;
    }
}