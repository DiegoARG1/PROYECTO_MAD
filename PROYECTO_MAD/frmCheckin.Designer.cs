namespace PROYECTO_MAD
{
    partial class frmCheckin
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
            this.btnbuscar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnconfirmarreservacion = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TipoHabitacionCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroPersonasCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NroHabitacion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnbuscar.Location = new System.Drawing.Point(518, 14);
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
            this.btnlimpiar.Location = new System.Drawing.Point(581, 14);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(53, 23);
            this.btnlimpiar.TabIndex = 29;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(347, 16);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(165, 20);
            this.txtbusqueda.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Codigo de reservacion:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btnconfirmarreservacion);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-5, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 56);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirmacion";
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
            this.btnconfirmarreservacion.Location = new System.Drawing.Point(409, 18);
            this.btnconfirmarreservacion.Name = "btnconfirmarreservacion";
            this.btnconfirmarreservacion.Size = new System.Drawing.Size(222, 32);
            this.btnconfirmarreservacion.TabIndex = 23;
            this.btnconfirmarreservacion.Text = "Confirmar Check In";
            this.btnconfirmarreservacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconfirmarreservacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnconfirmarreservacion.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(638, 44);
            this.label13.TabIndex = 27;
            this.label13.Text = "Detalle CheckIn";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoHabitacionCheckIn,
            this.NroPersonasCheckIn,
            this.NroHabitacion});
            this.dataGridView1.Location = new System.Drawing.Point(5, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(629, 258);
            this.dataGridView1.TabIndex = 55;
            // 
            // TipoHabitacionCheckIn
            // 
            this.TipoHabitacionCheckIn.HeaderText = "Tipo de habitacion";
            this.TipoHabitacionCheckIn.Name = "TipoHabitacionCheckIn";
            this.TipoHabitacionCheckIn.ReadOnly = true;
            // 
            // NroPersonasCheckIn
            // 
            this.NroPersonasCheckIn.HeaderText = "# Personas";
            this.NroPersonasCheckIn.Name = "NroPersonasCheckIn";
            this.NroPersonasCheckIn.ReadOnly = true;
            // 
            // NroHabitacion
            // 
            this.NroHabitacion.HeaderText = "# Habitacion";
            this.NroHabitacion.Name = "NroHabitacion";
            // 
            // frmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(638, 367);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Name = "frmCheckin";
            this.Text = "frmCheckin";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnconfirmarreservacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoHabitacionCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroPersonasCheckIn;
        private System.Windows.Forms.DataGridViewComboBoxColumn NroHabitacion;
    }
}