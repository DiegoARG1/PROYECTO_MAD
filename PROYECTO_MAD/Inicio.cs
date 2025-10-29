using PROYECTO_MAD.Entidad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAD
{
    public partial class Inicio : Form
    {
        private Usuario usuarioActual;
        public Inicio(Usuario usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        // funciones
        private bool ValidarPermiso(string nombreControl)
        {
            // El administrador siempre tiene acceso a todo.
            if (usuarioActual.oRol.Descripcion == "ADMINISTRADOR")
            {
                return true;
            }

            // Para otros roles, verificamos si el permiso existe en su lista.
            bool tienePermiso = usuarioActual.oPermisos.Any(p => p.NombreMenu == nombreControl);

            return tienePermiso;
        }
        private void AbrirForm(Form formularioHijo,bool centrado = false)
        {
            // 1. Asegúrate de que el panel esté vacío antes de agregar un nuevo formulario.
            if (this.contenedor.Controls.Count > 0)
            {
                this.contenedor.Controls.RemoveAt(0);
            }

            // 2. Configura el formulario hijo para que se comporte como un control, no como una ventana.
            formularioHijo.TopLevel = false; // La propiedad clave. Indica que no es una ventana de nivel superior.
            formularioHijo.FormBorderStyle = FormBorderStyle.None; // Le quita el borde y la barra de título.
            this.contenedor.Controls.Add(formularioHijo);

            if (centrado)
            {
                // --- Si queremos centrarlo ---

                // Nos aseguramos de que no se estire ni se ancle a los bordes
                formularioHijo.Dock = DockStyle.None;
                formularioHijo.Anchor = AnchorStyles.None;

                // Calculamos la posición central
                int x = (this.contenedor.Width - formularioHijo.Width) / 2;
                int y = (this.contenedor.Height - formularioHijo.Height) / 2;

                // Movemos el formulario a esa posición
                formularioHijo.Location = new Point(x, y);
            }
            else
            {
                // --- Si no, usamos la lógica que ya tenías ---
                formularioHijo.Dock = DockStyle.Fill;
            }


            formularioHijo.Show();
        }


        // Elementos del form
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuempleados_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menuempleados"))
            {
                AbrirForm(new frmEmpleados(this.usuarioActual));

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuhoteles_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menuhoteles"))
            {
                AbrirForm(new frmHoteles(this.usuarioActual));

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuhabitaciones_Click(object sender, EventArgs e)
        {
            
        }

        private void menuclientes_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menuclientes"))
            {
                AbrirForm(new frmClientes(usuarioActual));

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void registrarTipoDeHabitacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menuhabitaciones"))
            {
                AbrirForm(new frmTipohabitaciones(usuarioActual));

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void registrarHabitacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menuhabitaciones"))
            {
                AbrirForm(new frmHabitaciones(usuarioActual));

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuhistorial_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menuhistorial"))
            {
                AbrirForm(new frmHistorialclientes());

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menureservaciones_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menureservaciones"))
            {
                AbrirForm(new frmReservaciones(usuarioActual));

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menucancelaciones_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menucancelaciones"))
            {
                AbrirForm(new frmCancelaciones(usuarioActual),true);

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menucheckin_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menucheckin"))
            {
                AbrirForm(new frmCheckin(usuarioActual), true);

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menucheckout_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menucheckout"))
            {
                AbrirForm(new frmCheckout(usuarioActual), true);

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuacercade_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola soy informacion", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menureporteocupacion_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menureporteocupacion"))
            {
                AbrirForm(new frmReporteocupacion());

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menureporteventas_Click(object sender, EventArgs e)
        {
            if (ValidarPermiso("menureporteventas"))
            {
                AbrirForm(new frmReporteventas());

            }
            else
            {
                MessageBox.Show("No cuenta con los permisos necesarios...", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
