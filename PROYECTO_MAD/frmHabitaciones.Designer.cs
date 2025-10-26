namespace PROYECTO_MAD
{
    partial class frmHabitaciones
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
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btneditar = new FontAwesome.Sharp.IconButton();
            this.btneliminar = new FontAwesome.Sharp.IconButton();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.NombreHotelHabitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoHabitacionHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroHabitacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPiso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoHabitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistroHabitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCreadorHabitaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.cbHotel = new System.Windows.Forms.ComboBox();
            this.cbTipohabitacion = new System.Windows.Forms.ComboBox();
            this.btnlimpiartxt = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.nudNropiso = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtNrohabitacion = new System.Windows.Forms.TextBox();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.cbfiltro = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNropiso)).BeginInit();
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
            this.label2.Text = "Detalle Habitacion";
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
            this.label4.Text = "Tipo de Habitacion:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nro de Habitacion:";
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
            this.btneliminar.Location = new System.Drawing.Point(17, 622);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(222, 23);
            this.btneliminar.TabIndex = 25;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreHotelHabitaciones,
            this.TipoHabitacionHabitacion,
            this.NroHabitacion,
            this.NroPiso,
            this.EstadoHabitaciones,
            this.FechaRegistroHabitaciones,
            this.UsuarioCreadorHabitaciones});
            this.dgvHabitaciones.Location = new System.Drawing.Point(255, 77);
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.Size = new System.Drawing.Size(1082, 609);
            this.dgvHabitaciones.TabIndex = 26;
            // 
            // NombreHotelHabitaciones
            // 
            this.NombreHotelHabitaciones.HeaderText = "Hotel";
            this.NombreHotelHabitaciones.Name = "NombreHotelHabitaciones";
            this.NombreHotelHabitaciones.ReadOnly = true;
            // 
            // TipoHabitacionHabitacion
            // 
            this.TipoHabitacionHabitacion.HeaderText = "Tipo de habitacion";
            this.TipoHabitacionHabitacion.Name = "TipoHabitacionHabitacion";
            this.TipoHabitacionHabitacion.ReadOnly = true;
            // 
            // NroHabitacion
            // 
            this.NroHabitacion.HeaderText = "# habitacion";
            this.NroHabitacion.Name = "NroHabitacion";
            this.NroHabitacion.ReadOnly = true;
            // 
            // NroPiso
            // 
            this.NroPiso.HeaderText = "# piso";
            this.NroPiso.Name = "NroPiso";
            this.NroPiso.ReadOnly = true;
            // 
            // EstadoHabitaciones
            // 
            this.EstadoHabitaciones.HeaderText = "Estado";
            this.EstadoHabitaciones.Name = "EstadoHabitaciones";
            this.EstadoHabitaciones.ReadOnly = true;
            // 
            // FechaRegistroHabitaciones
            // 
            this.FechaRegistroHabitaciones.HeaderText = "Fecha registro";
            this.FechaRegistroHabitaciones.Name = "FechaRegistroHabitaciones";
            this.FechaRegistroHabitaciones.ReadOnly = true;
            // 
            // UsuarioCreadorHabitaciones
            // 
            this.UsuarioCreadorHabitaciones.HeaderText = "Usuario creador";
            this.UsuarioCreadorHabitaciones.Name = "UsuarioCreadorHabitaciones";
            this.UsuarioCreadorHabitaciones.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(255, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(1082, 51);
            this.label13.TabIndex = 27;
            this.label13.Text = "Lista de habitaciones:";
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
            // cbTipohabitacion
            // 
            this.cbTipohabitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipohabitacion.FormattingEnabled = true;
            this.cbTipohabitacion.Location = new System.Drawing.Point(17, 109);
            this.cbTipohabitacion.Name = "cbTipohabitacion";
            this.cbTipohabitacion.Size = new System.Drawing.Size(222, 21);
            this.cbTipohabitacion.TabIndex = 34;
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
            this.btnlimpiartxt.Location = new System.Drawing.Point(17, 651);
            this.btnlimpiartxt.Name = "btnlimpiartxt";
            this.btnlimpiartxt.Size = new System.Drawing.Size(222, 23);
            this.btnlimpiartxt.TabIndex = 46;
            this.btnlimpiartxt.Text = "Limpiar";
            this.btnlimpiartxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiartxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiartxt.UseVisualStyleBackColor = false;
            this.btnlimpiartxt.Click += new System.EventHandler(this.btnlimpiartxt_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Nro de Piso:";
            // 
            // nudNropiso
            // 
            this.nudNropiso.Location = new System.Drawing.Point(17, 202);
            this.nudNropiso.Name = "nudNropiso";
            this.nudNropiso.Size = new System.Drawing.Size(222, 20);
            this.nudNropiso.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Estado:";
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(17, 248);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(222, 21);
            this.cbEstado.TabIndex = 50;
            // 
            // txtNrohabitacion
            // 
            this.txtNrohabitacion.Location = new System.Drawing.Point(17, 155);
            this.txtNrohabitacion.Name = "txtNrohabitacion";
            this.txtNrohabitacion.Size = new System.Drawing.Size(222, 20);
            this.txtNrohabitacion.TabIndex = 51;
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
            this.btnlimpiar.Location = new System.Drawing.Point(1264, 26);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(53, 23);
            this.btnlimpiar.TabIndex = 29;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Visible = false;
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
            this.btnbuscar.Location = new System.Drawing.Point(1201, 26);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(57, 23);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Visible = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(1030, 29);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(165, 20);
            this.txtbusqueda.TabIndex = 31;
            this.txtbusqueda.Visible = false;
            // 
            // cbfiltro
            // 
            this.cbfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfiltro.FormattingEnabled = true;
            this.cbfiltro.Location = new System.Drawing.Point(844, 28);
            this.cbfiltro.Name = "cbfiltro";
            this.cbfiltro.Size = new System.Drawing.Size(180, 21);
            this.cbfiltro.TabIndex = 32;
            this.cbfiltro.Visible = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(768, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Buscar por:";
            this.label14.Visible = false;
            // 
            // frmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.txtNrohabitacion);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudNropiso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnlimpiartxt);
            this.Controls.Add(this.cbTipohabitacion);
            this.Controls.Add(this.cbHotel);
            this.Controls.Add(this.cbfiltro);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btneditar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHabitaciones";
            this.Text = "frmHabitaciones";
            this.Load += new System.EventHandler(this.frmHabitaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNropiso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btneditar;
        private FontAwesome.Sharp.IconButton btneliminar;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbHotel;
        private System.Windows.Forms.ComboBox cbTipohabitacion;
        private FontAwesome.Sharp.IconButton btnlimpiartxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudNropiso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtNrohabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHotelHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoHabitacionHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroHabitacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistroHabitaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCreadorHabitaciones;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private FontAwesome.Sharp.IconButton btnbuscar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.ComboBox cbfiltro;
        private System.Windows.Forms.Label label14;
    }
}