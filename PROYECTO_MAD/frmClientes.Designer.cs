namespace PROYECTO_MAD
{
    partial class frmClientes
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRfc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.dtpFechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbEstadocivil = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEditar = new FontAwesome.Sharp.IconButton();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rfc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistroCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioCreadorCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.btnlimpiartxt = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Detalle Cliente";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
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
            this.label4.Text = "Apellidos:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(17, 109);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(222, 20);
            this.txtApellidos.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Correo Electronico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(17, 155);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(222, 20);
            this.txtCorreo.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "RFC:";
            // 
            // txtRfc
            // 
            this.txtRfc.Location = new System.Drawing.Point(17, 201);
            this.txtRfc.Name = "txtRfc";
            this.txtRfc.Size = new System.Drawing.Size(222, 20);
            this.txtRfc.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado Civil:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha Nacimiento:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Telefono:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(17, 339);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(222, 20);
            this.txtTel.TabIndex = 15;
            // 
            // dtpFechanacimiento
            // 
            this.dtpFechanacimiento.Location = new System.Drawing.Point(17, 294);
            this.dtpFechanacimiento.Name = "dtpFechanacimiento";
            this.dtpFechanacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechanacimiento.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1114, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 20);
            this.label10.TabIndex = 17;
            this.label10.Text = "Pais:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1114, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Estado:";
            // 
            // cbEstadocivil
            // 
            this.cbEstadocivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadocivil.FormattingEnabled = true;
            this.cbEstadocivil.Location = new System.Drawing.Point(17, 247);
            this.cbEstadocivil.Name = "cbEstadocivil";
            this.cbEstadocivil.Size = new System.Drawing.Size(222, 21);
            this.cbEstadocivil.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1114, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 20);
            this.label12.TabIndex = 21;
            this.label12.Text = "Ciudad:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 16;
            this.btnGuardar.Location = new System.Drawing.Point(17, 564);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(222, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.btnEditar.IconColor = System.Drawing.Color.White;
            this.btnEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditar.IconSize = 16;
            this.btnEditar.Location = new System.Drawing.Point(17, 592);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(222, 23);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCliente,
            this.ApellidosCliente,
            this.Rfc,
            this.TelefonoCliente,
            this.FechaRegistroCliente,
            this.UsuarioCreadorCliente});
            this.dgvClientes.Location = new System.Drawing.Point(255, 63);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(842, 623);
            this.dgvClientes.TabIndex = 26;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
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
            // Rfc
            // 
            this.Rfc.HeaderText = "RFC";
            this.Rfc.Name = "Rfc";
            this.Rfc.ReadOnly = true;
            // 
            // TelefonoCliente
            // 
            this.TelefonoCliente.HeaderText = "Telefono";
            this.TelefonoCliente.Name = "TelefonoCliente";
            this.TelefonoCliente.ReadOnly = true;
            // 
            // FechaRegistroCliente
            // 
            this.FechaRegistroCliente.HeaderText = "Fecha registro";
            this.FechaRegistroCliente.Name = "FechaRegistroCliente";
            this.FechaRegistroCliente.ReadOnly = true;
            // 
            // UsuarioCreadorCliente
            // 
            this.UsuarioCreadorCliente.HeaderText = "Usuario creador";
            this.UsuarioCreadorCliente.Name = "UsuarioCreadorCliente";
            this.UsuarioCreadorCliente.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(255, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(842, 51);
            this.label13.TabIndex = 27;
            this.label13.Text = "Lista de Clientes:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.White;
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 18;
            this.iconButton4.Location = new System.Drawing.Point(972, 26);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(57, 23);
            this.iconButton4.TabIndex = 28;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Visible = false;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.White;
            this.iconButton5.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.iconButton5.IconColor = System.Drawing.Color.Black;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 18;
            this.iconButton5.Location = new System.Drawing.Point(1035, 26);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(53, 23);
            this.iconButton5.TabIndex = 29;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Visible = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(539, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Buscar por:";
            this.label14.Visible = false;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(801, 29);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(165, 20);
            this.textBox8.TabIndex = 31;
            this.textBox8.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(615, 28);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(180, 21);
            this.comboBox3.TabIndex = 32;
            this.comboBox3.Visible = false;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1112, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(225, 31);
            this.label15.TabIndex = 34;
            this.label15.Text = "Domicilio:";
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(1117, 62);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(222, 21);
            this.cbPais.TabIndex = 35;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(1117, 108);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(222, 21);
            this.cbEstado.TabIndex = 36;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Location = new System.Drawing.Point(1117, 155);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(222, 21);
            this.cbCiudad.TabIndex = 37;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Dock = System.Windows.Forms.DockStyle.Right;
            this.label16.Location = new System.Drawing.Point(1103, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(246, 686);
            this.label16.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1114, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 20);
            this.label17.TabIndex = 39;
            this.label17.Text = "Calle:";
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(1117, 202);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(222, 20);
            this.txtCalle.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1114, 225);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(171, 20);
            this.label18.TabIndex = 41;
            this.label18.Text = "Numero:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(1117, 248);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(222, 20);
            this.txtNumero.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1114, 271);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(171, 20);
            this.label19.TabIndex = 43;
            this.label19.Text = "Codigo postal:";
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(1117, 294);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(222, 20);
            this.txtCp.TabIndex = 44;
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
            this.btnlimpiartxt.Location = new System.Drawing.Point(17, 621);
            this.btnlimpiartxt.Name = "btnlimpiartxt";
            this.btnlimpiartxt.Size = new System.Drawing.Size(222, 23);
            this.btnlimpiartxt.TabIndex = 45;
            this.btnlimpiartxt.Text = "Limpiar";
            this.btnlimpiartxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnlimpiartxt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnlimpiartxt.UseVisualStyleBackColor = false;
            this.btnlimpiartxt.Click += new System.EventHandler(this.btnlimpiartxt_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1349, 686);
            this.Controls.Add(this.btnlimpiartxt);
            this.Controls.Add(this.txtCp);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cbCiudad);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbEstadocivil);
            this.Controls.Add(this.dtpFechanacimiento);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRfc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRfc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.DateTimePicker dtpFechanacimiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbEstadocivil;
        private System.Windows.Forms.Label label12;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label13;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCp;
        private FontAwesome.Sharp.IconButton btnlimpiartxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rfc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistroCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioCreadorCliente;
    }
}