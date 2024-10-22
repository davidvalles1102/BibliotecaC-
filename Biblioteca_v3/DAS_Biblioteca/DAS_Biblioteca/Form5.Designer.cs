namespace DAS_Biblioteca
{
    partial class Form5
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
            Button btnConsultar;
            dtpDate = new DateTimePicker();
            dgvConsulta = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            libro = new DataGridViewTextBoxColumn();
            fechaprestamo = new DataGridViewTextBoxColumn();
            fechadevolucion = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            btnConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(6, 24);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(244, 23);
            dtpDate.TabIndex = 0;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.SkyBlue;
            btnConsultar.ForeColor = Color.Black;
            btnConsultar.Location = new Point(256, 26);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 1;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += button1_Click;
            // 
            // dgvConsulta
            // 
            dgvConsulta.AllowUserToAddRows = false;
            dgvConsulta.AllowUserToDeleteRows = false;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsulta.Columns.AddRange(new DataGridViewColumn[] { id, usuario, libro, fechaprestamo, fechadevolucion });
            dgvConsulta.Location = new Point(24, 86);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.ReadOnly = true;
            dgvConsulta.RowTemplate.Height = 25;
            dgvConsulta.Size = new Size(764, 352);
            dgvConsulta.TabIndex = 2;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
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
            // fechaprestamo
            // 
            fechaprestamo.HeaderText = "Fecha Prestamo";
            fechaprestamo.Name = "fechaprestamo";
            fechaprestamo.ReadOnly = true;
            // 
            // fechadevolucion
            // 
            fechadevolucion.HeaderText = "Fecha Devolucion";
            fechadevolucion.Name = "fechadevolucion";
            fechadevolucion.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(btnConsultar);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(764, 60);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Realizar consulta";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvConsulta);
            Name = "Form5";
            Text = "Historico";
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpDate;
        private Button btnConsultar;
        private DataGridView dgvConsulta;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn libro;
        private DataGridViewTextBoxColumn fechaprestamo;
        private DataGridViewTextBoxColumn fechadevolucion;
    }
}