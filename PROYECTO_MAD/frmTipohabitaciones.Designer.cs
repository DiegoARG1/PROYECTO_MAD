namespace PROYECTO_MAD
{
    partial class frmTipohabitaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTipocama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.dgvTipohabitacion = new System.Windows.Forms.DataGridView();
            this.NombreHotelTipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroCamas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoCamas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioNoche = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistroTipoHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCreadorTiposHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.cbHotel = new System.Windows.Forms.ComboBox();
            this.nudCamas = new System.Windows.Forms.NumericUpDown();
            this.nudCapacidad = new System.Windows.Forms.NumericUpDown();
            this.nudPrecionoche = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cAire = new System.Windows.Forms.CheckBox();
            this.cTv = new System.Windows.Forms.CheckBox();
            this.cWifi = new System.Windows.Forms.CheckBox();
            this.cToallas = new System.Windows.Forms.CheckBox();
            this.cAseopersonal = new System.Windows.Forms.CheckBox();
            this.cMinibar = new System.Windows.Forms.CheckBox();
            this.cTerraza = new System.Windows.Forms.CheckBox();
            this.btnlimpiartxt = new FontAwesome.Sharp.IconButton();
            this.txtNivel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipohabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecionoche)).BeginInit();
            this.SuspendLayout();
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle Tipo Habitacion";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotel:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nivel:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nro de camas:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo de camas:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Capacidad:";
            // 
            // txtTipocama
            // 
            this.txtTipocama.Location = new System.Drawing.Point(17, 201);
            this.txtTipocama.Name = "txtTipocama";
            this.txtTipocama.Size = new System.Drawing.Size(222, 20);
            this.txtTipocama.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Precio por noche:";
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
            this.btnguardar.Location = new System.Drawing.Point(17, 565);
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
            this.btneditar.Location = new System.Drawing.Point(17, 594);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(222, 23);
            this.btneditar.TabIndex = 24;
            this.btneditar.Text = "Editar";
            this.btneditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneditar.UseVisualStyleBackColor = false;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btneliminar.IconColor = System.Drawing.Color.White;
            this.btneliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btneliminar.IconSize = 16;
            this.btneliminar.Location = new System.Drawing.Point(17, 651);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(222, 23);
            this.btneliminar.TabIndex = 25;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Visible = false;
            // 
            // dgvTipohabitacion
            // 
            this.dgvTipohabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipohabitacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreHotelTipoHabitacion,
            this.Nivel,
            this.NroCamas,
            this.TipoCamas,
            this.Capacidad,
            this.PrecioNoche,
            this.FechaRegistroTipoHabitacion,
            this.UsuarioCreadorTiposHabitacion});
            this.dgvTipohabitacion.Location = new System.Drawing.Point(255, 77);
            this.dgvTipohabitacion.Name = "dgvTipohabitacion";
            this.dgvTipohabitacion.Size = new System.Drawing.Size(1082, 609);
            this.dgvTipohabitacion.TabIndex = 26;
            this.dgvTipohabitacion.SelectionChanged += new System.EventHandler(this.dgvTipohabitacion_SelectionChanged);
            // 
            // NombreHotelTipoHabitacion
            // 
            this.NombreHotelTipoHabitacion.HeaderText = "Hotel";
            this.NombreHotelTipoHabitacion.Name = "NombreHotelTipoHabitacion";
            this.NombreHotelTipoHabitacion.ReadOnly = true;
            // 
            // Nivel
            // 
            this.Nivel.HeaderText = "Nivel";
            this.Nivel.Name = "Nivel";
            this.Nivel.ReadOnly = true;
            // 
            // NroCamas
            // 
            this.NroCamas.HeaderText = "# Camas";
            this.NroCamas.Name = "NroCamas";
            this.NroCamas.ReadOnly = true;
            // 
            // TipoCamas
            // 
            this.TipoCamas.HeaderText = "Tipo camas";
            this.TipoCamas.Name = "TipoCamas";
            this.TipoCamas.ReadOnly = true;
            // 
            // Capacidad
            // 
            this.Capacidad.HeaderText = "Capacidad";
            this.Capacidad.Name = "Capacidad";
            this.Capacidad.ReadOnly = true;
            // 
            // PrecioNoche
            // 
            this.PrecioNoche.HeaderText = "Precio por noche";
            this.PrecioNoche.Name = "PrecioNoche";
            this.PrecioNoche.ReadOnly = true;
            // 
            // FechaRegistroTipoHabitacion
            // 
            this.FechaRegistroTipoHabitacion.HeaderText = "Fecha registro";
            this.FechaRegistroTipoHabitacion.Name = "FechaRegistroTipoHabitacion";
            this.FechaRegistroTipoHabitacion.ReadOnly = true;
            // 
            // UsuarioCreadorTiposHabitacion
            // 
            this.UsuarioCreadorTiposHabitacion.HeaderText = "Usuario creador";
            this.UsuarioCreadorTiposHabitacion.Name = "UsuarioCreadorTiposHabitacion";
            this.UsuarioCreadorTiposHabitacion.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(255, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1082, 51);
            this.label13.TabIndex = 27;
            this.label13.Text = "Lista de Tipos de habitaciones:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbHotel
            // 
            this.cbHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHotel.FormattingEnabled = true;
            this.cbHotel.Location = new System.Drawing.Point(17, 63);
            this.cbHotel.Name = "cbHotel";
            this.cbHotel.Size = new System.Drawing.Size(222, 21);
            this.cbHotel.TabIndex = 33;
            this.cbHotel.SelectedIndexChanged += new System.EventHandler(this.cbHotel_SelectedIndexChanged);
            // 
            // nudCamas
            // 
            this.nudCamas.Location = new System.Drawing.Point(17, 156);
            this.nudCamas.Name = "nudCamas";
            this.nudCamas.Size = new System.Drawing.Size(222, 20);
            this.nudCamas.TabIndex = 35;
            // 
            // nudCapacidad
            // 
            this.nudCapacidad.Location = new System.Drawing.Point(17, 247);
            this.nudCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCapacidad.Name = "nudCapacidad";
            this.nudCapacidad.Size = new System.Drawing.Size(222, 20);
            this.nudCapacidad.TabIndex = 36;
            this.nudCapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPrecionoche
            // 
            this.nudPrecionoche.DecimalPlaces = 2;
            this.nudPrecionoche.Location = new System.Drawing.Point(17, 293);
            this.nudPrecionoche.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudPrecionoche.Name = "nudPrecionoche";
            this.nudPrecionoche.Size = new System.Drawing.Size(222, 20);
            this.nudPrecionoche.TabIndex = 37;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 31);
            this.label9.TabIndex = 38;
            this.label9.Text = "Amenidades:";
            // 
            // cAire
            // 
            this.cAire.AutoSize = true;
            this.cAire.BackColor = System.Drawing.Color.White;
            this.cAire.FlatAppearance.BorderSize = 2;
            this.cAire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAire.Location = new System.Drawing.Point(17, 351);
            this.cAire.Name = "cAire";
            this.cAire.Size = new System.Drawing.Size(131, 19);
            this.cAire.TabIndex = 39;
            this.cAire.Text = "Aire acondicionado";
            this.cAire.UseVisualStyleBackColor = false;
            // 
            // cTv
            // 
            this.cTv.AutoSize = true;
            this.cTv.BackColor = System.Drawing.Color.White;
            this.cTv.FlatAppearance.BorderSize = 2;
            this.cTv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTv.Location = new System.Drawing.Point(17, 376);
            this.cTv.Name = "cTv";
            this.cTv.Size = new System.Drawing.Size(40, 19);
            this.cTv.TabIndex = 40;
            this.cTv.Text = "TV";
            this.cTv.UseVisualStyleBackColor = false;
            // 
            // cWifi
            // 
            this.cWifi.AutoSize = true;
            this.cWifi.BackColor = System.Drawing.Color.White;
            this.cWifi.FlatAppearance.BorderSize = 2;
            this.cWifi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cWifi.Location = new System.Drawing.Point(17, 401);
            this.cWifi.Name = "cWifi";
            this.cWifi.Size = new System.Drawing.Size(50, 19);
            this.cWifi.TabIndex = 41;
            this.cWifi.Text = "WIFI";
            this.cWifi.UseVisualStyleBackColor = false;
            // 
            // cToallas
            // 
            this.cToallas.AutoSize = true;
            this.cToallas.BackColor = System.Drawing.Color.White;
            this.cToallas.FlatAppearance.BorderSize = 2;
            this.cToallas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cToallas.Location = new System.Drawing.Point(17, 426);
            this.cToallas.Name = "cToallas";
            this.cToallas.Size = new System.Drawing.Size(66, 19);
            this.cToallas.TabIndex = 42;
            this.cToallas.Text = "Toallas";
            this.cToallas.UseVisualStyleBackColor = false;
            // 
            // cAseopersonal
            // 
            this.cAseopersonal.AutoSize = true;
            this.cAseopersonal.BackColor = System.Drawing.Color.White;
            this.cAseopersonal.FlatAppearance.BorderSize = 2;
            this.cAseopersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cAseopersonal.Location = new System.Drawing.Point(17, 451);
            this.cAseopersonal.Name = "cAseopersonal";
            this.cAseopersonal.Size = new System.Drawing.Size(170, 19);
            this.cAseopersonal.TabIndex = 43;
            this.cAseopersonal.Text = "Articulos de aseo personal";
            this.cAseopersonal.UseVisualStyleBackColor = false;
            // 
            // cMinibar
            // 
            this.cMinibar.AutoSize = true;
            this.cMinibar.BackColor = System.Drawing.Color.White;
            this.cMinibar.FlatAppearance.BorderSize = 2;
            this.cMinibar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMinibar.Location = new System.Drawing.Point(17, 476);
            this.cMinibar.Name = "cMinibar";
            this.cMinibar.Size = new System.Drawing.Size(69, 19);
            this.cMinibar.TabIndex = 44;
            this.cMinibar.Text = "MiniBar";
            this.cMinibar.UseVisualStyleBackColor = false;
            // 
            // cTerraza
            // 
            this.cTerraza.AutoSize = true;
            this.cTerraza.BackColor = System.Drawing.Color.White;
            this.cTerraza.FlatAppearance.BorderSize = 2;
            this.cTerraza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTerraza.Location = new System.Drawing.Point(17, 501);
            this.cTerraza.Name = "cTerraza";
            this.cTerraza.Size = new System.Drawing.Size(68, 19);
            this.cTerraza.TabIndex = 45;
            this.cTerraza.Text = "Terraza";
            this.cTerraza.UseVisualStyleBackColor = false;
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
            this.btnlimpiartxt.Location = new System.Drawing.Point(17, 623);
            this.btnlimpiartxt.Name = "btnlimpiartxt";
            this.btnlimpiartxt.Size = new System.Drawing.Size(222, 23);
            this.btnlimpiartxt.TabIndex = 46;
            this.btnlimpiartxt.Text = "Limpiar";
            this.btnlimpiartxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiartxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiartxt.UseVisualStyleBackColor = false;
            this.btnlimpiartxt.Click += new System.EventHandler(this.btnlimpiartxt_Click);
            // 
            // txtNivel
            // 
            this.txtNivel.Location = new System.Drawing.Point(17, 109);
            this.txtNivel.Name = "txtNivel";
            this.txtNivel.Size = new System.Drawing.Size(222, 20);
            this.txtNivel.TabIndex = 47;
            // 
            // frmTipohabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.txtNivel);
            this.Controls.Add(this.btnlimpiartxt);
            this.Controls.Add(this.cTerraza);
            this.Controls.Add(this.cMinibar);
            this.Controls.Add(this.cAseopersonal);
            this.Controls.Add(this.cToallas);
            this.Controls.Add(this.cWifi);
            this.Controls.Add(this.cTv);
            this.Controls.Add(this.cAire);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudPrecionoche);
            this.Controls.Add(this.nudCapacidad);
            this.Controls.Add(this.nudCamas);
            this.Controls.Add(this.cbHotel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvTipohabitacion);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTipocama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTipohabitaciones";
            this.Text = "frmTipohabitaciones";
            this.Load += new System.EventHandler(this.frmTipohabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipohabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCamas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecionoche)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipocama;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.DataGridView dgvTipohabitacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbHotel;
        private System.Windows.Forms.NumericUpDown nudCamas;
        private System.Windows.Forms.NumericUpDown nudCapacidad;
        private System.Windows.Forms.NumericUpDown nudPrecionoche;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cAire;
        private System.Windows.Forms.CheckBox cTv;
        private System.Windows.Forms.CheckBox cWifi;
        private System.Windows.Forms.CheckBox cToallas;
        private System.Windows.Forms.CheckBox cAseopersonal;
        private System.Windows.Forms.CheckBox cMinibar;
        private System.Windows.Forms.CheckBox cTerraza;
        private FontAwesome.Sharp.IconButton btnlimpiartxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHotelTipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroCamas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoCamas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioNoche;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistroTipoHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCreadorTiposHabitacion;
        private System.Windows.Forms.TextBox txtNivel;
    }
}