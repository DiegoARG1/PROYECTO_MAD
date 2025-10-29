namespace PROYECTO_MAD
{
    partial class frmCancelaciones
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
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.txtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEstatusActual = new System.Windows.Forms.Label();
            this.lblMontoAnticipo = new System.Windows.Forms.Label();
            this.lblFechaCheckIn = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblMensajeReembolso = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfirmarCancelacion = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBuscar.Location = new System.Drawing.Point(518, 14);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblEstatusActual);
            this.groupBox1.Controls.Add(this.lblMontoAnticipo);
            this.groupBox1.Controls.Add(this.lblFechaCheckIn);
            this.groupBox1.Controls.Add(this.lblHotel);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-5, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 184);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            // 
            // lblEstatusActual
            // 
            this.lblEstatusActual.BackColor = System.Drawing.Color.White;
            this.lblEstatusActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstatusActual.Location = new System.Drawing.Point(147, 146);
            this.lblEstatusActual.Name = "lblEstatusActual";
            this.lblEstatusActual.Size = new System.Drawing.Size(164, 20);
            this.lblEstatusActual.TabIndex = 52;
            this.lblEstatusActual.Text = "#####################";
            // 
            // lblMontoAnticipo
            // 
            this.lblMontoAnticipo.BackColor = System.Drawing.Color.White;
            this.lblMontoAnticipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAnticipo.Location = new System.Drawing.Point(182, 117);
            this.lblMontoAnticipo.Name = "lblMontoAnticipo";
            this.lblMontoAnticipo.Size = new System.Drawing.Size(164, 20);
            this.lblMontoAnticipo.TabIndex = 51;
            this.lblMontoAnticipo.Text = "#####################";
            // 
            // lblFechaCheckIn
            // 
            this.lblFechaCheckIn.BackColor = System.Drawing.Color.White;
            this.lblFechaCheckIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCheckIn.Location = new System.Drawing.Point(182, 84);
            this.lblFechaCheckIn.Name = "lblFechaCheckIn";
            this.lblFechaCheckIn.Size = new System.Drawing.Size(164, 20);
            this.lblFechaCheckIn.TabIndex = 50;
            this.lblFechaCheckIn.Text = "#####################";
            // 
            // lblHotel
            // 
            this.lblHotel.BackColor = System.Drawing.Color.White;
            this.lblHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotel.Location = new System.Drawing.Point(88, 53);
            this.lblHotel.Name = "lblHotel";
            this.lblHotel.Size = new System.Drawing.Size(164, 20);
            this.lblHotel.TabIndex = 49;
            this.lblHotel.Text = "#####################";
            // 
            // lblCliente
            // 
            this.lblCliente.BackColor = System.Drawing.Color.White;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(88, 24);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(164, 20);
            this.lblCliente.TabIndex = 44;
            this.lblCliente.Text = "#####################";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(124, 31);
            this.label16.TabIndex = 43;
            this.label16.Text = "Estatus Actual:";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 31);
            this.label15.TabIndex = 42;
            this.label15.Text = "Monto de Anticipo:";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 31);
            this.label14.TabIndex = 41;
            this.label14.Text = "Fecha de Check In:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 31);
            this.label12.TabIndex = 40;
            this.label12.Text = "Hotel:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 31);
            this.label11.TabIndex = 39;
            this.label11.Text = "Cliente:";
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
            this.groupBox3.Controls.Add(this.lblMensajeReembolso);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnConfirmarCancelacion);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(-5, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(643, 82);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resumen y Confirmacion";
            // 
            // lblMensajeReembolso
            // 
            this.lblMensajeReembolso.BackColor = System.Drawing.Color.White;
            this.lblMensajeReembolso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeReembolso.Location = new System.Drawing.Point(17, 50);
            this.lblMensajeReembolso.Name = "lblMensajeReembolso";
            this.lblMensajeReembolso.Size = new System.Drawing.Size(386, 22);
            this.lblMensajeReembolso.TabIndex = 38;
            this.lblMensajeReembolso.Text = "#####################";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(386, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "Consecuencias de la cancelacion:";
            // 
            // btnConfirmarCancelacion
            // 
            this.btnConfirmarCancelacion.BackColor = System.Drawing.Color.Firebrick;
            this.btnConfirmarCancelacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarCancelacion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarCancelacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarCancelacion.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCancelacion.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnConfirmarCancelacion.IconColor = System.Drawing.Color.White;
            this.btnConfirmarCancelacion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmarCancelacion.IconSize = 20;
            this.btnConfirmarCancelacion.Location = new System.Drawing.Point(409, 35);
            this.btnConfirmarCancelacion.Name = "btnConfirmarCancelacion";
            this.btnConfirmarCancelacion.Size = new System.Drawing.Size(222, 32);
            this.btnConfirmarCancelacion.TabIndex = 23;
            this.btnConfirmarCancelacion.Text = "Confirmar Cancelacion";
            this.btnConfirmarCancelacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarCancelacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarCancelacion.UseVisualStyleBackColor = false;
            this.btnConfirmarCancelacion.Click += new System.EventHandler(this.btnConfirmarCancelacion_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(638, 44);
            this.label13.TabIndex = 27;
            this.label13.Text = "Detalle Cancelacion";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmCancelaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(638, 318);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "frmCancelaciones";
            this.Text = "frmCancelacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnBuscar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.TextBox txtCodigoBusqueda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton btnConfirmarCancelacion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblEstatusActual;
        private System.Windows.Forms.Label lblMontoAnticipo;
        private System.Windows.Forms.Label lblFechaCheckIn;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblMensajeReembolso;
    }
}