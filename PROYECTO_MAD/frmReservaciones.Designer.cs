namespace PROYECTO_MAD
{
    partial class frmReservaciones
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.btnBuscardisponibilidad = new FontAwesome.Sharp.IconButton();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RfcCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiarfiltro = new FontAwesome.Sharp.IconButton();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbSeleccionacliente = new System.Windows.Forms.GroupBox();
            this.btnClientenuevo = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDefinirestancia = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpSalida = new System.Windows.Forms.DateTimePicker();
            this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.cbMetodopago = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nudAnticipo = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMontototal = new System.Windows.Forms.Label();
            this.btnConfirmarreservacion = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.NombreHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoHabitacionReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidadReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioNocheReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisponibilidadReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPersonasReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gbSeleccionacliente.SuspendLayout();
            this.gbDefinirestancia.SuspendLayout();
            this.gbResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnticipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pais:";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(39, 25);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(127, 28);
            this.cbPais.TabIndex = 20;
            // 
            // btnBuscardisponibilidad
            // 
            this.btnBuscardisponibilidad.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscardisponibilidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscardisponibilidad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscardisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscardisponibilidad.ForeColor = System.Drawing.Color.White;
            this.btnBuscardisponibilidad.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscardisponibilidad.IconColor = System.Drawing.Color.White;
            this.btnBuscardisponibilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscardisponibilidad.IconSize = 16;
            this.btnBuscardisponibilidad.Location = new System.Drawing.Point(165, 153);
            this.btnBuscardisponibilidad.Name = "btnBuscardisponibilidad";
            this.btnBuscardisponibilidad.Size = new System.Drawing.Size(222, 32);
            this.btnBuscardisponibilidad.TabIndex = 23;
            this.btnBuscardisponibilidad.Text = "BuscarDisponibilidad";
            this.btnBuscardisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscardisponibilidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscardisponibilidad.UseVisualStyleBackColor = false;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.ApellidosCliente,
            this.RfcCliente,
            this.CorreoCliente,
            this.TelefonoCliente});
            this.dgvCliente.Location = new System.Drawing.Point(7, 62);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(548, 190);
            this.dgvCliente.TabIndex = 26;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // ApellidosCliente
            // 
            this.ApellidosCliente.HeaderText = "Apellidos";
            this.ApellidosCliente.Name = "ApellidosCliente";
            this.ApellidosCliente.ReadOnly = true;
            // 
            // RfcCliente
            // 
            this.RfcCliente.HeaderText = "RFC";
            this.RfcCliente.Name = "RfcCliente";
            this.RfcCliente.ReadOnly = true;
            // 
            // CorreoCliente
            // 
            this.CorreoCliente.HeaderText = "Correo electronico";
            this.CorreoCliente.Name = "CorreoCliente";
            this.CorreoCliente.ReadOnly = true;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.HeaderText = "Telefono";
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.ReadOnly = true;
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
            this.btnBuscar.Location = new System.Drawing.Point(439, 33);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 23);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiarfiltro
            // 
            this.btnLimpiarfiltro.BackColor = System.Drawing.Color.White;
            this.btnLimpiarfiltro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiarfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarfiltro.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiarfiltro.IconColor = System.Drawing.Color.Black;
            this.btnLimpiarfiltro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiarfiltro.IconSize = 18;
            this.btnLimpiarfiltro.Location = new System.Drawing.Point(502, 32);
            this.btnLimpiarfiltro.Name = "btnLimpiarfiltro";
            this.btnLimpiarfiltro.Size = new System.Drawing.Size(53, 23);
            this.btnLimpiarfiltro.TabIndex = 29;
            this.btnLimpiarfiltro.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(268, 30);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(165, 26);
            this.txtBusqueda.TabIndex = 31;
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(82, 28);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(180, 28);
            this.cbFiltro.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1349, 52);
            this.label13.TabIndex = 27;
            this.label13.Text = "Detalle Reservacion";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbSeleccionacliente
            // 
            this.gbSeleccionacliente.BackColor = System.Drawing.Color.White;
            this.gbSeleccionacliente.Controls.Add(this.btnClientenuevo);
            this.gbSeleccionacliente.Controls.Add(this.label1);
            this.gbSeleccionacliente.Controls.Add(this.cbFiltro);
            this.gbSeleccionacliente.Controls.Add(this.txtBusqueda);
            this.gbSeleccionacliente.Controls.Add(this.btnBuscar);
            this.gbSeleccionacliente.Controls.Add(this.btnLimpiarfiltro);
            this.gbSeleccionacliente.Controls.Add(this.dgvCliente);
            this.gbSeleccionacliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSeleccionacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSeleccionacliente.Location = new System.Drawing.Point(5, 55);
            this.gbSeleccionacliente.Name = "gbSeleccionacliente";
            this.gbSeleccionacliente.Size = new System.Drawing.Size(560, 296);
            this.gbSeleccionacliente.TabIndex = 50;
            this.gbSeleccionacliente.TabStop = false;
            this.gbSeleccionacliente.Text = "Selecciona el cliente";
            // 
            // btnClientenuevo
            // 
            this.btnClientenuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClientenuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientenuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClientenuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientenuevo.ForeColor = System.Drawing.Color.White;
            this.btnClientenuevo.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnClientenuevo.IconColor = System.Drawing.Color.White;
            this.btnClientenuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClientenuevo.IconSize = 16;
            this.btnClientenuevo.Location = new System.Drawing.Point(165, 258);
            this.btnClientenuevo.Name = "btnClientenuevo";
            this.btnClientenuevo.Size = new System.Drawing.Size(222, 32);
            this.btnClientenuevo.TabIndex = 53;
            this.btnClientenuevo.Text = "Cliente Nuevo";
            this.btnClientenuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientenuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientenuevo.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Buscar por:";
            // 
            // gbDefinirestancia
            // 
            this.gbDefinirestancia.BackColor = System.Drawing.Color.White;
            this.gbDefinirestancia.Controls.Add(this.label7);
            this.gbDefinirestancia.Controls.Add(this.dtpSalida);
            this.gbDefinirestancia.Controls.Add(this.dtpEntrada);
            this.gbDefinirestancia.Controls.Add(this.label6);
            this.gbDefinirestancia.Controls.Add(this.cbCiudad);
            this.gbDefinirestancia.Controls.Add(this.label5);
            this.gbDefinirestancia.Controls.Add(this.cbEstado);
            this.gbDefinirestancia.Controls.Add(this.label4);
            this.gbDefinirestancia.Controls.Add(this.cbPais);
            this.gbDefinirestancia.Controls.Add(this.label3);
            this.gbDefinirestancia.Controls.Add(this.btnBuscardisponibilidad);
            this.gbDefinirestancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDefinirestancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDefinirestancia.Location = new System.Drawing.Point(5, 357);
            this.gbDefinirestancia.Name = "gbDefinirestancia";
            this.gbDefinirestancia.Size = new System.Drawing.Size(560, 191);
            this.gbDefinirestancia.TabIndex = 53;
            this.gbDefinirestancia.TabStop = false;
            this.gbDefinirestancia.Text = "Definir Estancia";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(292, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Salida:";
            // 
            // dtpSalida
            // 
            this.dtpSalida.Location = new System.Drawing.Point(295, 83);
            this.dtpSalida.Name = "dtpSalida";
            this.dtpSalida.Size = new System.Drawing.Size(260, 26);
            this.dtpSalida.TabIndex = 30;
            // 
            // dtpEntrada
            // 
            this.dtpEntrada.Location = new System.Drawing.Point(9, 83);
            this.dtpEntrada.Name = "dtpEntrada";
            this.dtpEntrada.Size = new System.Drawing.Size(257, 26);
            this.dtpEntrada.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Entrada:";
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(407, 25);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(148, 28);
            this.cbCiudad.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(352, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ciudad:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(216, 25);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(130, 28);
            this.cbEstado.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Estado:";
            // 
            // gbResumen
            // 
            this.gbResumen.BackColor = System.Drawing.Color.White;
            this.gbResumen.Controls.Add(this.cbMetodopago);
            this.gbResumen.Controls.Add(this.label10);
            this.gbResumen.Controls.Add(this.nudAnticipo);
            this.gbResumen.Controls.Add(this.label9);
            this.gbResumen.Controls.Add(this.label8);
            this.gbResumen.Controls.Add(this.lbMontototal);
            this.gbResumen.Controls.Add(this.btnConfirmarreservacion);
            this.gbResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumen.Location = new System.Drawing.Point(5, 554);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(560, 130);
            this.gbResumen.TabIndex = 54;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = "Resumen y Confirmacion";
            // 
            // cbMetodopago
            // 
            this.cbMetodopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodopago.FormattingEnabled = true;
            this.cbMetodopago.Location = new System.Drawing.Point(333, 37);
            this.cbMetodopago.Name = "cbMetodopago";
            this.cbMetodopago.Size = new System.Drawing.Size(222, 28);
            this.cbMetodopago.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(199, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 31);
            this.label10.TabIndex = 40;
            this.label10.Text = "Medio de Pago:";
            // 
            // nudAnticipo
            // 
            this.nudAnticipo.DecimalPlaces = 2;
            this.nudAnticipo.Location = new System.Drawing.Point(82, 39);
            this.nudAnticipo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nudAnticipo.Name = "nudAnticipo";
            this.nudAnticipo.Size = new System.Drawing.Size(111, 26);
            this.nudAnticipo.TabIndex = 39;
            this.nudAnticipo.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(7, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 31);
            this.label9.TabIndex = 38;
            this.label9.Text = "Anticipo:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 31);
            this.label8.TabIndex = 37;
            this.label8.Text = "Monto Total:";
            // 
            // lbMontototal
            // 
            this.lbMontototal.BackColor = System.Drawing.Color.White;
            this.lbMontototal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMontototal.Location = new System.Drawing.Point(112, 98);
            this.lbMontototal.Name = "lbMontototal";
            this.lbMontototal.Size = new System.Drawing.Size(215, 20);
            this.lbMontototal.TabIndex = 2;
            this.lbMontototal.Text = "$0.00";
            // 
            // btnConfirmarreservacion
            // 
            this.btnConfirmarreservacion.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmarreservacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarreservacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarreservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarreservacion.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarreservacion.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnConfirmarreservacion.IconColor = System.Drawing.Color.White;
            this.btnConfirmarreservacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmarreservacion.IconSize = 20;
            this.btnConfirmarreservacion.Location = new System.Drawing.Point(333, 89);
            this.btnConfirmarreservacion.Name = "btnConfirmarreservacion";
            this.btnConfirmarreservacion.Size = new System.Drawing.Size(222, 32);
            this.btnConfirmarreservacion.TabIndex = 23;
            this.btnConfirmarreservacion.Text = "Confirmar Reservacion";
            this.btnConfirmarreservacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarreservacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarreservacion.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(571, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(772, 28);
            this.label11.TabIndex = 55;
            this.label11.Text = "Seleccionar Habitaciones";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreHotel,
            this.TipoHabitacionReservacion,
            this.CapacidadReservacion,
            this.PrecioNocheReservacion,
            this.DisponibilidadReservacion,
            this.CantidadReservacion,
            this.NumeroPersonasReservacion,
            this.SubTotalReservacion});
            this.dgvHabitaciones.Location = new System.Drawing.Point(571, 88);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(772, 596);
            this.dgvHabitaciones.TabIndex = 56;
            // 
            // NombreHotel
            // 
            this.NombreHotel.HeaderText = "Hotel";
            this.NombreHotel.Name = "NombreHotel";
            this.NombreHotel.ReadOnly = true;
            // 
            // TipoHabitacionReservacion
            // 
            this.TipoHabitacionReservacion.HeaderText = "Tipo de habitacion";
            this.TipoHabitacionReservacion.Name = "TipoHabitacionReservacion";
            this.TipoHabitacionReservacion.ReadOnly = true;
            // 
            // CapacidadReservacion
            // 
            this.CapacidadReservacion.HeaderText = "Capacidad";
            this.CapacidadReservacion.Name = "CapacidadReservacion";
            this.CapacidadReservacion.ReadOnly = true;
            // 
            // PrecioNocheReservacion
            // 
            this.PrecioNocheReservacion.HeaderText = "Precio";
            this.PrecioNocheReservacion.Name = "PrecioNocheReservacion";
            this.PrecioNocheReservacion.ReadOnly = true;
            // 
            // DisponibilidadReservacion
            // 
            this.DisponibilidadReservacion.HeaderText = "Disponible";
            this.DisponibilidadReservacion.Name = "DisponibilidadReservacion";
            this.DisponibilidadReservacion.ReadOnly = true;
            // 
            // CantidadReservacion
            // 
            this.CantidadReservacion.HeaderText = "Cantidad";
            this.CantidadReservacion.Name = "CantidadReservacion";
            // 
            // NumeroPersonasReservacion
            // 
            this.NumeroPersonasReservacion.HeaderText = "# Personas";
            this.NumeroPersonasReservacion.Name = "NumeroPersonasReservacion";
            // 
            // SubTotalReservacion
            // 
            this.SubTotalReservacion.HeaderText = "Subtotal";
            this.SubTotalReservacion.Name = "SubTotalReservacion";
            this.SubTotalReservacion.ReadOnly = true;
            // 
            // frmReservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbResumen);
            this.Controls.Add(this.gbDefinirestancia);
            this.Controls.Add(this.gbSeleccionacliente);
            this.Controls.Add(this.label13);
            this.Name = "frmReservaciones";
            this.Text = "frmReservaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gbSeleccionacliente.ResumeLayout(false);
            this.gbSeleccionacliente.PerformLayout();
            this.gbDefinirestancia.ResumeLayout(false);
            this.gbResumen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnticipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPais;
        private FontAwesome.Sharp.IconButton btnBuscardisponibilidad;
        private System.Windows.Forms.DataGridView dgvCliente;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiarfiltro;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbSeleccionacliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDefinirestancia;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.Label lbMontototal;
        private FontAwesome.Sharp.IconButton btnConfirmarreservacion;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpSalida;
        private System.Windows.Forms.DateTimePicker dtpEntrada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbMetodopago;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudAnticipo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RfcCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCliente;
        private FontAwesome.Sharp.IconButton btnClientenuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoHabitacionReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacidadReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioNocheReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisponibilidadReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPersonasReservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotalReservacion;
    }
}