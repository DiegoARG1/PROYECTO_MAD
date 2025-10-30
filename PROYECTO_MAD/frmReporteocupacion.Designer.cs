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
            this.dgvReporteOcupacion = new System.Windows.Forms.DataGridView();
            this.CiudadReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreHotelReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnioMesReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoHabitacionReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadHabitacionesReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeOcupacionReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPersonasReporteOcupacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.btnGenerarReporte = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAnio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.cboHotel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteOcupacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReporteOcupacion
            // 
            this.dgvReporteOcupacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporteOcupacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CiudadReporteOcupacion,
            this.NombreHotelReporteOcupacion,
            this.AnioMesReporteOcupacion,
            this.TipoHabitacionReporteOcupacion,
            this.CantidadHabitacionesReporteOcupacion,
            this.PorcentajeOcupacionReporteOcupacion,
            this.CantidadPersonasReporteOcupacion});
            this.dgvReporteOcupacion.Location = new System.Drawing.Point(-1, 54);
            this.dgvReporteOcupacion.Name = "dgvReporteOcupacion";
            this.dgvReporteOcupacion.Size = new System.Drawing.Size(1350, 634);
            this.dgvReporteOcupacion.TabIndex = 26;
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
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.BackColor = System.Drawing.Color.White;
            this.btnGenerarReporte.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporte.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnGenerarReporte.IconColor = System.Drawing.Color.Black;
            this.btnGenerarReporte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerarReporte.IconSize = 18;
            this.btnGenerarReporte.Location = new System.Drawing.Point(1221, 16);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(57, 23);
            this.btnGenerarReporte.TabIndex = 28;
            this.btnGenerarReporte.UseVisualStyleBackColor = false;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(1284, 16);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(53, 23);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(482, 16);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(135, 21);
            this.cboPais.TabIndex = 32;
            this.cboPais.SelectedIndexChanged += new System.EventHandler(this.cboPais_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Año:";
            // 
            // cboAnio
            // 
            this.cboAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnio.FormattingEnabled = true;
            this.cboAnio.Location = new System.Drawing.Point(351, 16);
            this.cboAnio.Name = "cboAnio";
            this.cboAnio.Size = new System.Drawing.Size(83, 21);
            this.cboAnio.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(442, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Pais:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(829, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ciudad:";
            // 
            // cboCiudad
            // 
            this.cboCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(884, 16);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(135, 21);
            this.cboCiudad.TabIndex = 37;
            this.cboCiudad.SelectedIndexChanged += new System.EventHandler(this.cboCiudad_SelectedIndexChanged);
            // 
            // cboHotel
            // 
            this.cboHotel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHotel.FormattingEnabled = true;
            this.cboHotel.Location = new System.Drawing.Point(1070, 16);
            this.cboHotel.Name = "cboHotel";
            this.cboHotel.Size = new System.Drawing.Size(145, 21);
            this.cboHotel.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1025, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Hotel:";
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(688, 16);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(135, 21);
            this.cboEstado.TabIndex = 41;
            this.cboEstado.SelectedIndexChanged += new System.EventHandler(this.cboEstado_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(633, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Estado:";
            // 
            // frmReporteocupacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboHotel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboAnio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPais);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGenerarReporte);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvReporteOcupacion);
            this.Name = "frmReporteocupacion";
            this.Text = "frmReporteocupacion";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteOcupacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvReporteOcupacion;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton btnGenerarReporte;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAnio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.ComboBox cboHotel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CiudadReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreHotelReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnioMesReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoHabitacionReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadHabitacionesReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeOcupacionReporteOcupacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPersonasReporteOcupacion;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label label5;
    }
}