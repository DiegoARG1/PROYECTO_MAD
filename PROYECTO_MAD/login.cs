using PROYECTO_MAD.Negocio;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            string contrasenia = txtContrasenia.Text;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasenia))
            {
                MessageBox.Show("Ingresa todos los datos.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsuarioN negocio = new UsuarioN();

            Usuario Usuarioactivo = negocio.Login(correo, contrasenia); 
            if (Usuarioactivo != null)
            {
                Inicio form = new Inicio(Usuarioactivo);
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Correo o contraseña incorrectos.","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
