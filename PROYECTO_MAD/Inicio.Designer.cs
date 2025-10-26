namespace PROYECTO_MAD
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuempleados = new FontAwesome.Sharp.IconMenuItem();
            this.menuhoteles = new FontAwesome.Sharp.IconMenuItem();
            this.menuhabitaciones = new FontAwesome.Sharp.IconMenuItem();
            this.submenutipohabitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuhabitaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuclientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuhistorial = new FontAwesome.Sharp.IconMenuItem();
            this.menureservaciones = new FontAwesome.Sharp.IconMenuItem();
            this.menucancelaciones = new FontAwesome.Sharp.IconMenuItem();
            this.menucheckin = new FontAwesome.Sharp.IconMenuItem();
            this.menucheckout = new FontAwesome.Sharp.IconMenuItem();
            this.menureportes = new FontAwesome.Sharp.IconMenuItem();
            this.menureporteocupacion = new System.Windows.Forms.ToolStripMenuItem();
            this.menureporteventas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuacercade = new FontAwesome.Sharp.IconMenuItem();
            this.menutitulo = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedor = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.White;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuempleados,
            this.menuhoteles,
            this.menuhabitaciones,
            this.menuclientes,
            this.menuhistorial,
            this.menureservaciones,
            this.menucancelaciones,
            this.menucheckin,
            this.menucheckout,
            this.menureportes,
            this.menuacercade});
            this.menu.Location = new System.Drawing.Point(0, 60);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1349, 73);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuempleados
            // 
            this.menuempleados.AutoSize = false;
            this.menuempleados.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuempleados.IconColor = System.Drawing.Color.Black;
            this.menuempleados.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuempleados.IconSize = 50;
            this.menuempleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuempleados.Name = "menuempleados";
            this.menuempleados.Size = new System.Drawing.Size(77, 69);
            this.menuempleados.Text = "Empleados";
            this.menuempleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuempleados.Click += new System.EventHandler(this.menuempleados_Click);
            // 
            // menuhoteles
            // 
            this.menuhoteles.AutoSize = false;
            this.menuhoteles.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.menuhoteles.IconColor = System.Drawing.Color.Black;
            this.menuhoteles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuhoteles.IconSize = 50;
            this.menuhoteles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuhoteles.Name = "menuhoteles";
            this.menuhoteles.Size = new System.Drawing.Size(77, 69);
            this.menuhoteles.Text = "Hoteles";
            this.menuhoteles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuhoteles.Click += new System.EventHandler(this.menuhoteles_Click);
            // 
            // menuhabitaciones
            // 
            this.menuhabitaciones.AutoSize = false;
            this.menuhabitaciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenutipohabitaciones,
            this.submenuhabitaciones});
            this.menuhabitaciones.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.menuhabitaciones.IconColor = System.Drawing.Color.Black;
            this.menuhabitaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuhabitaciones.IconSize = 50;
            this.menuhabitaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuhabitaciones.Name = "menuhabitaciones";
            this.menuhabitaciones.Size = new System.Drawing.Size(77, 69);
            this.menuhabitaciones.Text = "Habitaciones";
            this.menuhabitaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuhabitaciones.Click += new System.EventHandler(this.menuhabitaciones_Click);
            // 
            // submenutipohabitaciones
            // 
            this.submenutipohabitaciones.Name = "submenutipohabitaciones";
            this.submenutipohabitaciones.Size = new System.Drawing.Size(224, 22);
            this.submenutipohabitaciones.Text = "Registrar Tipo de Habitacion";
            this.submenutipohabitaciones.Click += new System.EventHandler(this.registrarTipoDeHabitacionToolStripMenuItem_Click);
            // 
            // submenuhabitaciones
            // 
            this.submenuhabitaciones.Name = "submenuhabitaciones";
            this.submenuhabitaciones.Size = new System.Drawing.Size(224, 22);
            this.submenuhabitaciones.Text = "Registrar Habitaciones";
            this.submenuhabitaciones.Click += new System.EventHandler(this.registrarHabitacionesToolStripMenuItem_Click);
            // 
            // menuclientes
            // 
            this.menuclientes.AutoSize = false;
            this.menuclientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.menuclientes.IconColor = System.Drawing.Color.Black;
            this.menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuclientes.IconSize = 50;
            this.menuclientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuclientes.Name = "menuclientes";
            this.menuclientes.Size = new System.Drawing.Size(77, 69);
            this.menuclientes.Text = "Clientes";
            this.menuclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuclientes.Click += new System.EventHandler(this.menuclientes_Click);
            // 
            // menuhistorial
            // 
            this.menuhistorial.AutoSize = false;
            this.menuhistorial.IconChar = FontAwesome.Sharp.IconChar.ContactBook;
            this.menuhistorial.IconColor = System.Drawing.Color.Black;
            this.menuhistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuhistorial.IconSize = 50;
            this.menuhistorial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuhistorial.Name = "menuhistorial";
            this.menuhistorial.Size = new System.Drawing.Size(77, 69);
            this.menuhistorial.Text = "Historial";
            this.menuhistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuhistorial.Click += new System.EventHandler(this.menuhistorial_Click);
            // 
            // menureservaciones
            // 
            this.menureservaciones.AutoSize = false;
            this.menureservaciones.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.menureservaciones.IconColor = System.Drawing.Color.Black;
            this.menureservaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureservaciones.IconSize = 50;
            this.menureservaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureservaciones.Name = "menureservaciones";
            this.menureservaciones.Size = new System.Drawing.Size(77, 69);
            this.menureservaciones.Text = "Reservaciones";
            this.menureservaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menureservaciones.Click += new System.EventHandler(this.menureservaciones_Click);
            // 
            // menucancelaciones
            // 
            this.menucancelaciones.AutoSize = false;
            this.menucancelaciones.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.menucancelaciones.IconColor = System.Drawing.Color.Black;
            this.menucancelaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucancelaciones.IconSize = 50;
            this.menucancelaciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucancelaciones.Name = "menucancelaciones";
            this.menucancelaciones.Size = new System.Drawing.Size(95, 69);
            this.menucancelaciones.Text = "Cancelaciones";
            this.menucancelaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menucancelaciones.Click += new System.EventHandler(this.menucancelaciones_Click);
            // 
            // menucheckin
            // 
            this.menucheckin.AutoSize = false;
            this.menucheckin.IconChar = FontAwesome.Sharp.IconChar.SquareCheck;
            this.menucheckin.IconColor = System.Drawing.Color.Black;
            this.menucheckin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucheckin.IconSize = 50;
            this.menucheckin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucheckin.Name = "menucheckin";
            this.menucheckin.Size = new System.Drawing.Size(122, 69);
            this.menucheckin.Text = "Check In";
            this.menucheckin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menucheckin.Click += new System.EventHandler(this.menucheckin_Click);
            // 
            // menucheckout
            // 
            this.menucheckout.AutoSize = false;
            this.menucheckout.IconChar = FontAwesome.Sharp.IconChar.Suitcase;
            this.menucheckout.IconColor = System.Drawing.Color.Black;
            this.menucheckout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menucheckout.IconSize = 50;
            this.menucheckout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menucheckout.Name = "menucheckout";
            this.menucheckout.Size = new System.Drawing.Size(77, 69);
            this.menucheckout.Text = "Check Out";
            this.menucheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menucheckout.Click += new System.EventHandler(this.menucheckout_Click);
            // 
            // menureportes
            // 
            this.menureportes.AutoSize = false;
            this.menureportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menureporteocupacion,
            this.menureporteventas});
            this.menureportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.menureportes.IconColor = System.Drawing.Color.Black;
            this.menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menureportes.IconSize = 50;
            this.menureportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menureportes.Name = "menureportes";
            this.menureportes.Size = new System.Drawing.Size(77, 69);
            this.menureportes.Text = "Reportes";
            this.menureportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menureporteocupacion
            // 
            this.menureporteocupacion.Name = "menureporteocupacion";
            this.menureporteocupacion.Size = new System.Drawing.Size(190, 22);
            this.menureporteocupacion.Text = "Reporte de ocupacion";
            this.menureporteocupacion.Click += new System.EventHandler(this.menureporteocupacion_Click);
            // 
            // menureporteventas
            // 
            this.menureporteventas.Name = "menureporteventas";
            this.menureporteventas.Size = new System.Drawing.Size(190, 22);
            this.menureporteventas.Text = "Reporte de ventas";
            this.menureporteventas.Click += new System.EventHandler(this.menureporteventas_Click);
            // 
            // menuacercade
            // 
            this.menuacercade.AutoSize = false;
            this.menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuacercade.IconColor = System.Drawing.Color.Black;
            this.menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuacercade.IconSize = 50;
            this.menuacercade.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuacercade.Name = "menuacercade";
            this.menuacercade.Size = new System.Drawing.Size(77, 69);
            this.menuacercade.Text = "Acerca de";
            this.menuacercade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuacercade.Click += new System.EventHandler(this.menuacercade_Click);
            // 
            // menutitulo
            // 
            this.menutitulo.AutoSize = false;
            this.menutitulo.BackColor = System.Drawing.Color.SteelBlue;
            this.menutitulo.Location = new System.Drawing.Point(0, 0);
            this.menutitulo.Name = "menutitulo";
            this.menutitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menutitulo.Size = new System.Drawing.Size(1349, 60);
            this.menutitulo.TabIndex = 1;
            this.menutitulo.Text = "menuStrip2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Hospedaje";
            // 
            // contenedor
            // 
            this.contenedor.BackColor = System.Drawing.Color.SteelBlue;
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 133);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(1349, 725);
            this.contenedor.TabIndex = 3;
            this.contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.contenedor_Paint);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 858);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menutitulo);
            this.MainMenuStrip = this.menu;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menutitulo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconMenuItem menuempleados;
        private FontAwesome.Sharp.IconMenuItem menuhoteles;
        private FontAwesome.Sharp.IconMenuItem menuhabitaciones;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menureservaciones;
        private FontAwesome.Sharp.IconMenuItem menucancelaciones;
        private FontAwesome.Sharp.IconMenuItem menucheckin;
        private FontAwesome.Sharp.IconMenuItem menucheckout;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuhistorial;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.ToolStripMenuItem menureporteocupacion;
        private System.Windows.Forms.ToolStripMenuItem menureporteventas;
        private System.Windows.Forms.ToolStripMenuItem submenutipohabitaciones;
        private System.Windows.Forms.ToolStripMenuItem submenuhabitaciones;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
    }
}

