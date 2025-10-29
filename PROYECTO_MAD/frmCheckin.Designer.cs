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
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.txtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConfirmarCheckIn = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvHabitacionesPorAsignar = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacionesPorAsignar)).BeginInit();
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
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(581, 14);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(53, 23);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtCodigoBusqueda
            // 
            this.txtCodigoBusqueda.Location = new System.Drawing.Point(347, 16);
            this.txtCodigoBusqueda.Name = "txtCodigoBusqueda";
            this.txtCodigoBusqueda.Size = new System.Drawing.Size(165, 20);
            this.txtCodigoBusqueda.TabIndex = 31;
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
            this.groupBox3.Controls.Add(this.btnConfirmarCheckIn);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-5, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 56);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirmacion";
            // 
            // btnConfirmarCheckIn
            // 
            this.btnConfirmarCheckIn.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmarCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarCheckIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarCheckIn.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCheckIn.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnConfirmarCheckIn.IconColor = System.Drawing.Color.White;
            this.btnConfirmarCheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmarCheckIn.IconSize = 20;
            this.btnConfirmarCheckIn.Location = new System.Drawing.Point(409, 18);
            this.btnConfirmarCheckIn.Name = "btnConfirmarCheckIn";
            this.btnConfirmarCheckIn.Size = new System.Drawing.Size(222, 32);
            this.btnConfirmarCheckIn.TabIndex = 23;
            this.btnConfirmarCheckIn.Text = "Confirmar Check In";
            this.btnConfirmarCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarCheckIn.UseVisualStyleBackColor = false;
            this.btnConfirmarCheckIn.Click += new System.EventHandler(this.btnConfirmarCheckIn_Click);
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
            // dgvHabitacionesPorAsignar
            // 
            this.dgvHabitacionesPorAsignar.AllowUserToAddRows = false;
            this.dgvHabitacionesPorAsignar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitacionesPorAsignar.Location = new System.Drawing.Point(5, 47);
            this.dgvHabitacionesPorAsignar.Name = "dgvHabitacionesPorAsignar";
            this.dgvHabitacionesPorAsignar.Size = new System.Drawing.Size(629, 258);
            this.dgvHabitacionesPorAsignar.TabIndex = 55;
            // 
            // frmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(638, 367);
            this.Controls.Add(this.dgvHabitacionesPorAsignar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtCodigoBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Name = "frmCheckin";
            this.Text = "frmCheckin";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitacionesPorAsignar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.TextBox txtCodigoBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnConfirmarCheckIn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvHabitacionesPorAsignar;
    }
}