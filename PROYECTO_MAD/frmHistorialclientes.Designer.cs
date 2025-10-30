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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.NombreClienteHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadHotelHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreHotelHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPersonasHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoReservacionHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaReservacionHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCheckInHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCheckOutHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstatusReservacionHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnticipoHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoHospedajeHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFacturaHistorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txtValorBusqueda = new System.Windows.Forms.TextBox();
            this.cboBuscarPor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreClienteHistorial,
            this.CiudadHotelHistorial,
            this.NombreHotelHistorial,
            this.NroPersonasHistorial,
            this.CodigoReservacionHistorial,
            this.FechaReservacionHistorial,
            this.FechaCheckInHistorial,
            this.FechaCheckOutHistorial,
            this.EstatusReservacionHistorial,
            this.AnticipoHistorial,
            this.MontoHospedajeHistorial,
            this.TotalFacturaHistorial});
            this.dgvHistorial.Location = new System.Drawing.Point(-1, 54);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.Size = new System.Drawing.Size(1350, 634);
            this.dgvHistorial.TabIndex = 26;
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
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.Black;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.Location = new System.Drawing.Point(1155, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.Black;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 18;
            this.btnLimpiar.Location = new System.Drawing.Point(1218, 16);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(53, 23);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            // txtValorBusqueda
            // 
            this.txtValorBusqueda.Location = new System.Drawing.Point(984, 19);
            this.txtValorBusqueda.Name = "txtValorBusqueda";
            this.txtValorBusqueda.Size = new System.Drawing.Size(165, 20);
            this.txtValorBusqueda.TabIndex = 31;
            // 
            // cboBuscarPor
            // 
            this.cboBuscarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBuscarPor.FormattingEnabled = true;
            this.cboBuscarPor.Location = new System.Drawing.Point(798, 18);
            this.cboBuscarPor.Name = "cboBuscarPor";
            this.cboBuscarPor.Size = new System.Drawing.Size(180, 21);
            this.cboBuscarPor.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(430, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Selecciona el año:";
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(545, 18);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(171, 21);
            this.cboAnio.TabIndex = 34;
            this.cboAnio.SelectedIndexChanged += new System.EventHandler(this.cboAnio_SelectedIndexChanged);
            // 
            // frmHistorialclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBuscarPor);
            this.Controls.Add(this.txtValorBusqueda);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "frmHistorialclientes";
            this.Text = "frmHistorialclientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtValorBusqueda;
        private System.Windows.Forms.ComboBox cboBuscarPor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreClienteHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadHotelHistorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHotelHistorial;
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