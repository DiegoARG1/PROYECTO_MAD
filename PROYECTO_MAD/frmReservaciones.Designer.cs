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
            this.cbrol = new System.Windows.Forms.ComboBox();
            this.btnbuscardisponibilidad = new FontAwesome.Sharp.IconButton();
            this.dgwempleados = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RfcCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorreoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclientenuevo = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnconfirmarreservacion = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.NombreHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoHabitacionReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidadReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioNocheReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisponibilidadReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPersonasReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotalReservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwempleados)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbrol
            // 
            this.cbrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbrol.FormattingEnabled = true;
            this.cbrol.Location = new System.Drawing.Point(39, 25);
            this.cbrol.Name = "cbrol";
            this.cbrol.Size = new System.Drawing.Size(127, 28);
            this.cbrol.TabIndex = 20;
            this.cbrol.SelectedIndexChanged += new System.EventHandler(this.cbrol_SelectedIndexChanged);
            // 
            // btnbuscardisponibilidad
            // 
            this.btnbuscardisponibilidad.BackColor = System.Drawing.Color.SteelBlue;
            this.btnbuscardisponibilidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuscardisponibilidad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscardisponibilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscardisponibilidad.ForeColor = System.Drawing.Color.White;
            this.btnbuscardisponibilidad.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscardisponibilidad.IconColor = System.Drawing.Color.White;
            this.btnbuscardisponibilidad.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscardisponibilidad.IconSize = 16;
            this.btnbuscardisponibilidad.Location = new System.Drawing.Point(165, 153);
            this.btnbuscardisponibilidad.Name = "btnbuscardisponibilidad";
            this.btnbuscardisponibilidad.Size = new System.Drawing.Size(222, 32);
            this.btnbuscardisponibilidad.TabIndex = 23;
            this.btnbuscardisponibilidad.Text = "BuscarDisponibilidad";
            this.btnbuscardisponibilidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuscardisponibilidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnbuscardisponibilidad.UseVisualStyleBackColor = false;
            this.btnbuscardisponibilidad.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // dgwempleados
            // 
            this.dgwempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwempleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.ApellidosCliente,
            this.RfcCliente,
            this.CorreoCliente,
            this.TelefonoCliente});
            this.dgwempleados.Location = new System.Drawing.Point(7, 62);
            this.dgwempleados.Name = "dgwempleados";
            this.dgwempleados.Size = new System.Drawing.Size(548, 190);
            this.dgwempleados.TabIndex = 26;
            this.dgwempleados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwempleados_CellContentClick);
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
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.White;
            this.btnbuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnbuscar.IconColor = System.Drawing.Color.Black;
            this.btnbuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnbuscar.IconSize = 18;
            this.btnbuscar.Location = new System.Drawing.Point(439, 33);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(57, 23);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.UseVisualStyleBackColor = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.White;
            this.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.IconSize = 18;
            this.btnlimpiar.Location = new System.Drawing.Point(502, 32);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(53, 23);
            this.btnlimpiar.TabIndex = 29;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(268, 30);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(165, 26);
            this.txtbusqueda.TabIndex = 31;
            // 
            // cbfiltro
            // 
            this.cbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfiltro.FormattingEnabled = true;
            this.cbfiltro.Location = new System.Drawing.Point(82, 28);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(180, 28);
            this.cbfiltro.TabIndex = 32;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnclientenuevo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbfiltro);
            this.groupBox1.Controls.Add(this.txtbusqueda);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.btnlimpiar);
            this.groupBox1.Controls.Add(this.dgwempleados);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 296);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecciona el cliente";
            // 
            // btnclientenuevo
            // 
            this.btnclientenuevo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnclientenuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclientenuevo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnclientenuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientenuevo.ForeColor = System.Drawing.Color.White;
            this.btnclientenuevo.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnclientenuevo.IconColor = System.Drawing.Color.White;
            this.btnclientenuevo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnclientenuevo.IconSize = 16;
            this.btnclientenuevo.Location = new System.Drawing.Point(165, 258);
            this.btnclientenuevo.Name = "btnclientenuevo";
            this.btnclientenuevo.Size = new System.Drawing.Size(222, 32);
            this.btnclientenuevo.TabIndex = 53;
            this.btnclientenuevo.Text = "Cliente Nuevo";
            this.btnclientenuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclientenuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnclientenuevo.UseVisualStyleBackColor = false;
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbrol);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnbuscardisponibilidad);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 191);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Definir Estancia";
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(295, 83);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(260, 26);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 83);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(257, 26);
            this.dateTimePicker1.TabIndex = 29;
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
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(407, 25);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(148, 28);
            this.comboBox3.TabIndex = 27;
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
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(216, 25);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(130, 28);
            this.comboBox2.TabIndex = 25;
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
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.numericUpDown1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnconfirmarreservacion);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(5, 554);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 130);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen y Confirmacion";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 28);
            this.comboBox1.TabIndex = 41;
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
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(82, 39);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(111, 26);
            this.numericUpDown1.TabIndex = 39;
            this.numericUpDown1.ThousandsSeparator = true;
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "$0.00";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // btnconfirmarreservacion
            // 
            this.btnconfirmarreservacion.BackColor = System.Drawing.Color.ForestGreen;
            this.btnconfirmarreservacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfirmarreservacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnconfirmarreservacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmarreservacion.ForeColor = System.Drawing.Color.White;
            this.btnconfirmarreservacion.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnconfirmarreservacion.IconColor = System.Drawing.Color.White;
            this.btnconfirmarreservacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnconfirmarreservacion.IconSize = 20;
            this.btnconfirmarreservacion.Location = new System.Drawing.Point(333, 89);
            this.btnconfirmarreservacion.Name = "btnconfirmarreservacion";
            this.btnconfirmarreservacion.Size = new System.Drawing.Size(222, 32);
            this.btnconfirmarreservacion.TabIndex = 23;
            this.btnconfirmarreservacion.Text = "Confirmar Reservacion";
            this.btnconfirmarreservacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconfirmarreservacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconfirmarreservacion.UseVisualStyleBackColor = false;
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreHotel,
            this.TipoHabitacionReservacion,
            this.CapacidadReservacion,
            this.PrecioNocheReservacion,
            this.DisponibilidadReservacion,
            this.CantidadReservacion,
            this.NumeroPersonasReservacion,
            this.SubTotalReservacion});
            this.dataGridView2.Location = new System.Drawing.Point(571, 88);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(772, 596);
            this.dataGridView2.TabIndex = 56;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
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
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "frmReservaciones";
            this.Text = "frmReservaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgwempleados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbrol;
        private FontAwesome.Sharp.IconButton btnbuscardisponibilidad;
        private System.Windows.Forms.DataGridView dgwempleados;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbfiltro;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnconfirmarreservacion;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn RfcCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorreoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCliente;
        private FontAwesome.Sharp.IconButton btnclientenuevo;
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