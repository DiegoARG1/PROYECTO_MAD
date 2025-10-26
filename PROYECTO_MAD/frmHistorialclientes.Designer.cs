namespace PROYECTO_MAD
{
    partial class frmHistorialclientes
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
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NombreClienteHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadHotelHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreHotelHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoHabitacionHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroHabitacionHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPersonasHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoReservacionHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReservacionHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCheckInHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCheckOutHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstatusReservacionHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnticipoHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoHospedajeHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFacturaHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreClienteHistorial,
            this.CiudadHotelHistorial,
            this.NombreHotelHistorial,
            this.TipoHabitacionHistorial,
            this.NumeroHabitacionHistorial,
            this.NroPersonasHistorial,
            this.CodigoReservacionHistorial,
            this.FechaReservacionHistorial,
            this.FechaCheckInHistorial,
            this.FechaCheckOutHistorial,
            this.EstatusReservacionHistorial,
            this.AnticipoHistorial,
            this.MontoHospedajeHistorial,
            this.TotalFacturaHistorial});
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
            this.label13.Text = "Lista de Historial de clientes:";
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
            this.iconButton4.Location = new System.Drawing.Point(1155, 16);
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
            this.iconButton5.Location = new System.Drawing.Point(1218, 16);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(53, 23);
            this.iconButton5.TabIndex = 29;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(722, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Buscar por:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(984, 19);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(165, 20);
            this.textBox8.TabIndex = 31;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(798, 18);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(180, 21);
            this.comboBox3.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Selecciona el año:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(633, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(83, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // NombreClienteHistorial
            // 
            this.NombreClienteHistorial.HeaderText = "NombreCliente";
            this.NombreClienteHistorial.Name = "NombreClienteHistorial";
            this.NombreClienteHistorial.ReadOnly = true;
            // 
            // CiudadHotelHistorial
            // 
            this.CiudadHotelHistorial.HeaderText = "Ciudad";
            this.CiudadHotelHistorial.Name = "CiudadHotelHistorial";
            this.CiudadHotelHistorial.ReadOnly = true;
            // 
            // NombreHotelHistorial
            // 
            this.NombreHotelHistorial.HeaderText = "Hotel";
            this.NombreHotelHistorial.Name = "NombreHotelHistorial";
            this.NombreHotelHistorial.ReadOnly = true;
            // 
            // TipoHabitacionHistorial
            // 
            this.TipoHabitacionHistorial.HeaderText = "TipoHabitacion";
            this.TipoHabitacionHistorial.Name = "TipoHabitacionHistorial";
            this.TipoHabitacionHistorial.ReadOnly = true;
            // 
            // NumeroHabitacionHistorial
            // 
            this.NumeroHabitacionHistorial.HeaderText = "# Habitacion";
            this.NumeroHabitacionHistorial.Name = "NumeroHabitacionHistorial";
            this.NumeroHabitacionHistorial.ReadOnly = true;
            // 
            // NroPersonasHistorial
            // 
            this.NroPersonasHistorial.HeaderText = "# Personas Hospedadas";
            this.NroPersonasHistorial.Name = "NroPersonasHistorial";
            this.NroPersonasHistorial.ReadOnly = true;
            // 
            // CodigoReservacionHistorial
            // 
            this.CodigoReservacionHistorial.HeaderText = "Codigo de reservacion";
            this.CodigoReservacionHistorial.Name = "CodigoReservacionHistorial";
            this.CodigoReservacionHistorial.ReadOnly = true;
            // 
            // FechaReservacionHistorial
            // 
            this.FechaReservacionHistorial.HeaderText = "Fecha de reservacion";
            this.FechaReservacionHistorial.Name = "FechaReservacionHistorial";
            this.FechaReservacionHistorial.ReadOnly = true;
            // 
            // FechaCheckInHistorial
            // 
            this.FechaCheckInHistorial.HeaderText = "CheckIn";
            this.FechaCheckInHistorial.Name = "FechaCheckInHistorial";
            this.FechaCheckInHistorial.ReadOnly = true;
            // 
            // FechaCheckOutHistorial
            // 
            this.FechaCheckOutHistorial.HeaderText = "CheckOut";
            this.FechaCheckOutHistorial.Name = "FechaCheckOutHistorial";
            this.FechaCheckOutHistorial.ReadOnly = true;
            // 
            // EstatusReservacionHistorial
            // 
            this.EstatusReservacionHistorial.HeaderText = "Estatus";
            this.EstatusReservacionHistorial.Name = "EstatusReservacionHistorial";
            this.EstatusReservacionHistorial.ReadOnly = true;
            // 
            // AnticipoHistorial
            // 
            this.AnticipoHistorial.HeaderText = "Anticipo";
            this.AnticipoHistorial.Name = "AnticipoHistorial";
            this.AnticipoHistorial.ReadOnly = true;
            // 
            // MontoHospedajeHistorial
            // 
            this.MontoHospedajeHistorial.HeaderText = "Monto de hospedaje";
            this.MontoHospedajeHistorial.Name = "MontoHospedajeHistorial";
            this.MontoHospedajeHistorial.ReadOnly = true;
            // 
            // TotalFacturaHistorial
            // 
            this.TotalFacturaHistorial.HeaderText = "Total factura";
            this.TotalFacturaHistorial.Name = "TotalFacturaHistorial";
            this.TotalFacturaHistorial.ReadOnly = true;
            // 
            // frmHistorialclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmHistorialclientes";
            this.Text = "frmHistorialclientes";
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreClienteHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadHotelHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHotelHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoHabitacionHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroHabitacionHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPersonasHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoReservacionHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaReservacionHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCheckInHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCheckOutHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstatusReservacionHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnticipoHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoHospedajeHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFacturaHistorial;
    }
}