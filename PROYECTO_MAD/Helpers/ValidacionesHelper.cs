using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_MAD.Helpers
{
    public static class ValidacionesHelper
    {
        public static bool ValidarContrasena(string contrasena, TextBox txtContrasena = null)
        {
            if (contrasena.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.", "Contraseña Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena?.Focus();
                return false;
            }
            // Regla 2: Al menos una letra mayúscula
            // Regex.IsMatch busca si el patrón existe en el texto
            if (!Regex.IsMatch(contrasena, @"[A-Z]"))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra mayúscula.", "Contraseña Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena?.Focus();
                return false;
            }
            // Regla 3: Al menos una letra minúscula
            if (!Regex.IsMatch(contrasena, @"[a-z]"))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra minúscula.", "Contraseña Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena?.Focus();
                return false;
            }
            // Regla 4: Al menos un carácter especial
            // El patrón @"[^a-zA-Z0-9]" busca cualquier carácter que NO sea letra ni número
            if (!Regex.IsMatch(contrasena, @"[^a-zA-Z0-9]"))
            {
                MessageBox.Show("La contraseña debe contener al menos un carácter especial (ej. $, !, ?, *, etc.).", "Contraseña Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrasena?.Focus();
                return false;
            }

            return true;
        }

        public static bool ValidarDomicilio(
        string pais, string estado, string ciudad,
        string calle, string numero, string codigoPostal)
        {
            if (string.IsNullOrEmpty(pais) ||
                string.IsNullOrEmpty(estado) ||
                string.IsNullOrEmpty(ciudad) ||
                string.IsNullOrEmpty(calle) ||
                string.IsNullOrEmpty(numero) ||
                string.IsNullOrEmpty(codigoPostal)
               )
            {
                MessageBox.Show("Ingrese todos los datos.", "Dato Requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Validación falló
            }

            return true; // Validación exitosa
        }
    }
}
