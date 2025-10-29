namespace PROYECTO_MAD
{
    partial class frmCheckout
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
            this.txtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.lblAnticipoPagado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalHospedaje = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMontoPendiente = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfirmarCheckOut = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblHotel = new System.Windows.Forms.Label();
            this.lblFechaCheckIn = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.lblFechaCheckOut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRFC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbResumen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).BeginInit();
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
            this.btnbuscar.Location = new System.Drawing.Point(604, 15);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(57, 23);
            this.btnbuscar.TabIndex = 28;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
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
            this.btnlimpiar.Location = new System.Drawing.Point(667, 15);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(53, 23);
            this.btnlimpiar.TabIndex = 29;
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtCodigoBusqueda
            // 
            this.txtCodigoBusqueda.Location = new System.Drawing.Point(433, 17);
            this.txtCodigoBusqueda.Name = "txtCodigoBusqueda";
            this.txtCodigoBusqueda.Size = new System.Drawing.Size(165, 20);
            this.txtCodigoBusqueda.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Codigo de reservacion:";
            // 
            // gbResumen
            // 
            this.gbResumen.BackColor = System.Drawing.Color.White;
            this.gbResumen.Controls.Add(this.label16);
            this.gbResumen.Controls.Add(this.cbMetodoPago);
            this.gbResumen.Controls.Add(this.lblAnticipoPagado);
            this.gbResumen.Controls.Add(this.label10);
            this.gbResumen.Controls.Add(this.lblTotalHospedaje);
            this.gbResumen.Controls.Add(this.label7);
            this.gbResumen.Controls.Add(this.lblMontoPendiente);
            this.gbResumen.Controls.Add(this.label8);
            this.gbResumen.Controls.Add(this.btnConfirmarCheckOut);
            this.gbResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbResumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResumen.Location = new System.Drawing.Point(-5, 343);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(747, 138);
            this.gbResumen.TabIndex = 54;
            this.gbResumen.TabStop = false;
            this.gbResumen.Text = "Resumen y Confirmacion";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(369, 40);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 31);
            this.label16.TabIndex = 62;
            this.label16.Text = "Metodo de Pago:";
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Location = new System.Drawing.Point(513, 36);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(222, 28);
            this.cbMetodoPago.TabIndex = 61;
            // 
            // lblAnticipoPagado
            // 
            this.lblAnticipoPagado.BackColor = System.Drawing.Color.White;
            this.lblAnticipoPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnticipoPagado.Location = new System.Drawing.Point(163, 60);
            this.lblAnticipoPagado.Name = "lblAnticipoPagado";
            this.lblAnticipoPagado.Size = new System.Drawing.Size(212, 20);
            this.lblAnticipoPagado.TabIndex = 60;
            this.lblAnticipoPagado.Text = "$0.00";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 31);
            this.label10.TabIndex = 59;
            this.label10.Text = "Anticipo Pagado:";
            // 
            // lblTotalHospedaje
            // 
            this.lblTotalHospedaje.BackColor = System.Drawing.Color.White;
            this.lblTotalHospedaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHospedaje.Location = new System.Drawing.Point(161, 29);
            this.lblTotalHospedaje.Name = "lblTotalHospedaje";
            this.lblTotalHospedaje.Size = new System.Drawing.Size(214, 20);
            this.lblTotalHospedaje.TabIndex = 58;
            this.lblTotalHospedaje.Text = "$0.00";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 31);
            this.label7.TabIndex = 42;
            this.label7.Text = "Total Hospedaje:";
            // 
            // lblMontoPendiente
            // 
            this.lblMontoPendiente.BackColor = System.Drawing.Color.White;
            this.lblMontoPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoPendiente.Location = new System.Drawing.Point(211, 101);
            this.lblMontoPendiente.Name = "lblMontoPendiente";
            this.lblMontoPendiente.Size = new System.Drawing.Size(296, 22);
            this.lblMontoPendiente.TabIndex = 38;
            this.lblMontoPendiente.Text = "$0.00";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "MONTO PENDIENTE:";
            // 
            // btnConfirmarCheckOut
            // 
            this.btnConfirmarCheckOut.BackColor = System.Drawing.Color.ForestGreen;
            this.btnConfirmarCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarCheckOut.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnConfirmarCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarCheckOut.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnConfirmarCheckOut.IconColor = System.Drawing.Color.White;
            this.btnConfirmarCheckOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfirmarCheckOut.IconSize = 20;
            this.btnConfirmarCheckOut.Location = new System.Drawing.Point(513, 91);
            this.btnConfirmarCheckOut.Name = "btnConfirmarCheckOut";
            this.btnConfirmarCheckOut.Size = new System.Drawing.Size(222, 32);
            this.btnConfirmarCheckOut.TabIndex = 23;
            this.btnConfirmarCheckOut.Text = "Confirmar CheckOut";
            this.btnConfirmarCheckOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmarCheckOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfirmarCheckOut.UseVisualStyleBackColor = false;
            this.btnConfirmarCheckOut.Click += new System.EventHandler(this.btnConfirmarCheckOut_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(742, 44);
            this.label13.TabIndex = 27;
            this.label13.Text = "Detalle CheckOut";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 31);
            this.label14.TabIndex = 41;
            this.label14.Text = "Fecha de Check In:";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dgvDetalleFactura);
            this.groupBox1.Controls.Add(this.lblFechaCheckOut);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblRFC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFechaCheckIn);
            this.groupBox1.Controls.Add(this.lblHotel);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-5, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 294);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Factura";
            // 
            // dgvDetalleFactura
            // 
            this.dgvDetalleFactura.AllowUserToAddRows = false;
            this.dgvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleFactura.Location = new System.Drawing.Point(10, 107);
            this.dgvDetalleFactura.Name = "dgvDetalleFactura";
            this.dgvDetalleFactura.Size = new System.Drawing.Size(731, 183);
            this.dgvDetalleFactura.TabIndex = 57;
            // 
            // lblFechaCheckOut
            // 
            this.lblFechaCheckOut.BackColor = System.Drawing.Color.White;
            this.lblFechaCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCheckOut.Location = new System.Drawing.Point(571, 84);
            this.lblFechaCheckOut.Name = "lblFechaCheckOut";
            this.lblFechaCheckOut.Size = new System.Drawing.Size(164, 20);
            this.lblFechaCheckOut.TabIndex = 56;
            this.lblFechaCheckOut.Text = "#####################";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 31);
            this.label6.TabIndex = 55;
            this.label6.Text = "Fecha de CheckOut:";
            // 
            // lblRFC
            // 
            this.lblRFC.BackColor = System.Drawing.Color.White;
            this.lblRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRFC.Location = new System.Drawing.Point(571, 22);
            this.lblRFC.Name = "lblRFC";
            this.lblRFC.Size = new System.Drawing.Size(164, 20);
            this.lblRFC.TabIndex = 54;
            this.lblRFC.Text = "#####################";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(500, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 31);
            this.label3.TabIndex = 53;
            this.label3.Text = "RFC:";
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(742, 481);
            this.Controls.Add(this.gbResumen);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.txtCodigoBusqueda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.gbResumen.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnbuscar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.TextBox txtCodigoBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbResumen;
        private FontAwesome.Sharp.IconButton btnConfirmarCheckOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMontoPendiente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblHotel;
        private System.Windows.Forms.Label lblFechaCheckIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRFC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblFechaCheckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDetalleFactura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalHospedaje;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAnticipoPagado;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbMetodoPago;
    }
}