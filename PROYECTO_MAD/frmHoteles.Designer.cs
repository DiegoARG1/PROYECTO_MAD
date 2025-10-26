namespace PROYECTO_MAD
{
    partial class frmHoteles
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.dgvHoteles = new System.Windows.Forms.DataGridView();
            this.NombreHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaisHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CiudadHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroHabitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicioOperaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistroHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCreadorHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.dtpIniciooperaciones = new System.Windows.Forms.DateTimePicker();
            this.nudNropisos = new System.Windows.Forms.NumericUpDown();
            this.nudNrohabitaciones = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlimpiartxt = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNropisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrohabitaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle Hotel:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Hotel:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(17, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Pais:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ciudad:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(17, 247);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(222, 20);
            this.txtCalle.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Numero:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Codigo postal:";
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(17, 339);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(222, 20);
            this.txtCp.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 362);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Numero de habitaciones:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Numero de pisos:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Inicio de operaciones:";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnguardar.IconColor = System.Drawing.Color.White;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.IconSize = 16;
            this.btnguardar.Location = new System.Drawing.Point(17, 564);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(222, 23);
            this.btnguardar.TabIndex = 23;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btneditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditar.ForeColor = System.Drawing.Color.White;
            this.btneditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btneditar.IconColor = System.Drawing.Color.White;
            this.btneditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneditar.IconSize = 16;
            this.btneditar.Location = new System.Drawing.Point(17, 593);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(222, 23);
            this.btneditar.TabIndex = 24;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // dgvHoteles
            // 
            this.dgvHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreHotel,
            this.PaisHotel,
            this.EstadoHotel,
            this.CiudadHotel,
            this.NroHabitaciones,
            this.NroPisos,
            this.FechaInicioOperaciones,
            this.FechaRegistroHotel,
            this.UsuarioCreadorHotel});
            this.dgvHoteles.Location = new System.Drawing.Point(265, 74);
            this.dgvHoteles.Name = "dgvHoteles";
            this.dgvHoteles.Size = new System.Drawing.Size(1072, 612);
            this.dgvHoteles.TabIndex = 26;
            this.dgvHoteles.SelectionChanged += new System.EventHandler(this.dgvHoteles_SelectionChanged);
            // 
            // NombreHotel
            // 
            this.NombreHotel.HeaderText = "Nombre";
            this.NombreHotel.Name = "NombreHotel";
            this.NombreHotel.ReadOnly = true;
            // 
            // PaisHotel
            // 
            this.PaisHotel.HeaderText = "Pais";
            this.PaisHotel.Name = "PaisHotel";
            this.PaisHotel.ReadOnly = true;
            // 
            // EstadoHotel
            // 
            this.EstadoHotel.HeaderText = "Estado";
            this.EstadoHotel.Name = "EstadoHotel";
            this.EstadoHotel.ReadOnly = true;
            // 
            // CiudadHotel
            // 
            this.CiudadHotel.HeaderText = "Ciudad";
            this.CiudadHotel.Name = "CiudadHotel";
            this.CiudadHotel.ReadOnly = true;
            // 
            // NroHabitaciones
            // 
            this.NroHabitaciones.HeaderText = "# Habitaciones";
            this.NroHabitaciones.Name = "NroHabitaciones";
            this.NroHabitaciones.ReadOnly = true;
            // 
            // NroPisos
            // 
            this.NroPisos.HeaderText = "# Pisos";
            this.NroPisos.Name = "NroPisos";
            this.NroPisos.ReadOnly = true;
            // 
            // FechaInicioOperaciones
            // 
            this.FechaInicioOperaciones.HeaderText = "Inicio de operaciones";
            this.FechaInicioOperaciones.Name = "FechaInicioOperaciones";
            this.FechaInicioOperaciones.ReadOnly = true;
            // 
            // FechaRegistroHotel
            // 
            this.FechaRegistroHotel.HeaderText = "Fecha registro";
            this.FechaRegistroHotel.Name = "FechaRegistroHotel";
            this.FechaRegistroHotel.ReadOnly = true;
            // 
            // UsuarioCreadorHotel
            // 
            this.UsuarioCreadorHotel.HeaderText = "Usuario creador";
            this.UsuarioCreadorHotel.Name = "UsuarioCreadorHotel";
            this.UsuarioCreadorHotel.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(265, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1072, 51);
            this.label13.TabIndex = 27;
            this.label13.Text = "Lista de Hoteles:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnbuscar.Location = new System.Drawing.Point(1208, 25);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(57, 23);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Visible = false;
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
            this.btnlimpiar.Location = new System.Drawing.Point(1271, 25);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(53, 23);
            this.btnlimpiar.TabIndex = 29;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Visible = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(775, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Buscar por:";
            this.label14.Visible = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(1037, 28);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(165, 20);
            this.txtbusqueda.TabIndex = 31;
            this.txtbusqueda.Visible = false;
            // 
            // cbfiltro
            // 
            this.cbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfiltro.FormattingEnabled = true;
            this.cbfiltro.Location = new System.Drawing.Point(851, 27);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(180, 21);
            this.cbfiltro.TabIndex = 32;
            this.cbfiltro.Visible = false;
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(17, 109);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(222, 21);
            this.cbPais.TabIndex = 33;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPaishotel_SelectedIndexChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(17, 155);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(222, 21);
            this.cbEstado.TabIndex = 34;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(17, 201);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(222, 21);
            this.cbCiudad.TabIndex = 35;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(17, 293);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(222, 20);
            this.txtNumero.TabIndex = 36;
            // 
            // dtpIniciooperaciones
            // 
            this.dtpIniciooperaciones.Location = new System.Drawing.Point(17, 479);
            this.dtpIniciooperaciones.Name = "dtpIniciooperaciones";
            this.dtpIniciooperaciones.Size = new System.Drawing.Size(222, 20);
            this.dtpIniciooperaciones.TabIndex = 37;
            // 
            // nudNropisos
            // 
            this.nudNropisos.Location = new System.Drawing.Point(12, 433);
            this.nudNropisos.Name = "nudNropisos";
            this.nudNropisos.Size = new System.Drawing.Size(222, 20);
            this.nudNropisos.TabIndex = 38;
            // 
            // nudNrohabitaciones
            // 
            this.nudNrohabitaciones.Location = new System.Drawing.Point(17, 385);
            this.nudNrohabitaciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNrohabitaciones.Name = "nudNrohabitaciones";
            this.nudNrohabitaciones.Size = new System.Drawing.Size(222, 20);
            this.nudNrohabitaciones.TabIndex = 39;
            this.nudNrohabitaciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 686);
            this.label1.TabIndex = 0;
            // 
            // btnlimpiartxt
            // 
            this.btnlimpiartxt.BackColor = System.Drawing.Color.Goldenrod;
            this.btnlimpiartxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiartxt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlimpiartxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiartxt.ForeColor = System.Drawing.Color.White;
            this.btnlimpiartxt.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnlimpiartxt.IconColor = System.Drawing.Color.White;
            this.btnlimpiartxt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiartxt.IconSize = 16;
            this.btnlimpiartxt.Location = new System.Drawing.Point(17, 622);
            this.btnlimpiartxt.Name = "btnlimpiartxt";
            this.btnlimpiartxt.Size = new System.Drawing.Size(222, 23);
            this.btnlimpiartxt.TabIndex = 40;
            this.btnlimpiartxt.Text = "Limpiar";
            this.btnlimpiartxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiartxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiartxt.UseVisualStyleBackColor = false;
            this.btnlimpiartxt.Click += new System.EventHandler(this.btnlimpiartxt_Click);
            // 
            // frmHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.btnlimpiartxt);
            this.Controls.Add(this.nudNrohabitaciones);
            this.Controls.Add(this.nudNropisos);
            this.Controls.Add(this.dtpIniciooperaciones);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.cbfiltro);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dgvHoteles);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Name = "frmHoteles";
            this.Text = "frmHoteles";
            this.Load += new System.EventHandler(this.frmHoteles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoteles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNropisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNrohabitaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneditar;
        private System.Windows.Forms.DataGridView dgvHoteles;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbfiltro;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DateTimePicker dtpIniciooperaciones;
        private System.Windows.Forms.NumericUpDown nudNropisos;
        private System.Windows.Forms.NumericUpDown nudNrohabitaciones;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnlimpiartxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaisHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicioOperaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistroHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCreadorHotel;
    }
}