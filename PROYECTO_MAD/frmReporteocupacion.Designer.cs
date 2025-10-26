namespace PROYECTO_MAD
{
    partial class frmReporteocupacion
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CiudadReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreHotelReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioMesReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoHabitacionReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadHabitacionesReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeOcupacionReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPersonasReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CiudadReporteOcupacion,
            this.NombreHotelReporteOcupacion,
            this.AnioMesReporteOcupacion,
            this.TipoHabitacionReporteOcupacion,
            this.CantidadHabitacionesReporteOcupacion,
            this.PorcentajeOcupacionReporteOcupacion,
            this.CantidadPersonasReporteOcupacion});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1350, 634);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1349, 51);
            this.label13.TabIndex = 27;
            this.label13.Text = "Lista de Reportes de ocupacion:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.White;
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 18;
            this.iconButton4.Location = new System.Drawing.Point(1221, 16);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(57, 23);
            this.iconButton4.TabIndex = 28;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.White;
            this.iconButton5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 18;
            this.iconButton5.Location = new System.Drawing.Point(1284, 16);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(53, 23);
            this.iconButton5.TabIndex = 29;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1018, 18);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(197, 20);
            this.textBox8.TabIndex = 31;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(485, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(135, 21);
            this.comboBox3.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Año:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(356, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(445, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Pais:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(626, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ciudad:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(681, 18);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(135, 21);
            this.comboBox2.TabIndex = 37;
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(867, 18);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(145, 21);
            this.comboBox4.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(822, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Hotel:";
            // 
            // CiudadReporteOcupacion
            // 
            this.CiudadReporteOcupacion.HeaderText = "Ciudad";
            this.CiudadReporteOcupacion.Name = "CiudadReporteOcupacion";
            this.CiudadReporteOcupacion.ReadOnly = true;
            // 
            // NombreHotelReporteOcupacion
            // 
            this.NombreHotelReporteOcupacion.HeaderText = "Nombre del hotel";
            this.NombreHotelReporteOcupacion.Name = "NombreHotelReporteOcupacion";
            this.NombreHotelReporteOcupacion.ReadOnly = true;
            // 
            // AnioMesReporteOcupacion
            // 
            this.AnioMesReporteOcupacion.HeaderText = "Año - Mes";
            this.AnioMesReporteOcupacion.Name = "AnioMesReporteOcupacion";
            this.AnioMesReporteOcupacion.ReadOnly = true;
            // 
            // TipoHabitacionReporteOcupacion
            // 
            this.TipoHabitacionReporteOcupacion.HeaderText = "Tipo de habitacion";
            this.TipoHabitacionReporteOcupacion.Name = "TipoHabitacionReporteOcupacion";
            this.TipoHabitacionReporteOcupacion.ReadOnly = true;
            // 
            // CantidadHabitacionesReporteOcupacion
            // 
            this.CantidadHabitacionesReporteOcupacion.HeaderText = "# De Habitaciones";
            this.CantidadHabitacionesReporteOcupacion.Name = "CantidadHabitacionesReporteOcupacion";
            this.CantidadHabitacionesReporteOcupacion.ReadOnly = true;
            // 
            // PorcentajeOcupacionReporteOcupacion
            // 
            this.PorcentajeOcupacionReporteOcupacion.HeaderText = "Porcentaje de ocupacion";
            this.PorcentajeOcupacionReporteOcupacion.Name = "PorcentajeOcupacionReporteOcupacion";
            this.PorcentajeOcupacionReporteOcupacion.ReadOnly = true;
            // 
            // CantidadPersonasReporteOcupacion
            // 
            this.CantidadPersonasReporteOcupacion.HeaderText = "Cantidad de personas hospedadadas";
            this.CantidadPersonasReporteOcupacion.Name = "CantidadPersonasReporteOcupacion";
            this.CantidadPersonasReporteOcupacion.ReadOnly = true;
            // 
            // frmReporteocupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmReporteocupacion";
            this.Text = "frmReporteocupacion";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHotelReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioMesReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoHabitacionReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadHabitacionesReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeOcupacionReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPersonasReporteOcupacion;
    }
}