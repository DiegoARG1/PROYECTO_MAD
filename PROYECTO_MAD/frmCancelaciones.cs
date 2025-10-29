using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_MAD.DAO;
using PROYECTO_MAD.Entidad;

namespace PROYECTO_MAD
{
    public partial class frmCancelaciones : Form
    {   // Variables
        private Usuario usuarioLogueado;
        private Reservacion reservacionActual = null;

        // Funciones
        private void LimpiarFormulario()
        {
            txtCodigoBusqueda.Clear();

            lblCliente.Text = "####################";
            lblHotel.Text = "####################";
            lblFechaCheckIn.Text = "####################";
            lblMontoAnticipo.Text = "###.##";
            lblEstatusActual.Text = "####################";
            lblMensajeReembolso.Text = "";
            lblMensajeReembolso.ForeColor = SystemColors.ControlText;

            reservacionActual = null;
            btnConfirmarCancelacion.Enabled = false;
            txtCodigoBusqueda.Focus();
        }

        // Elementos del Form
        public frmCancelaciones(Usuario usuarioQueInicioSesion)
        {
            InitializeComponent();
            this.usuarioLogueado = usuarioQueInicioSesion;
            LimpiarFormulario();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string codigoTexto = txtCodigoBusqueda.Text.Trim().Replace("\r", "").Replace("\n", "");

            lblCliente.Text = "####################";
            lblHotel.Text = "####################";
            lblFechaCheckIn.Text = "####################";
            lblMontoAnticipo.Text = "###.##";
            lblEstatusActual.Text = "####################";
            lblMensajeReembolso.Text = "";
            lblMensajeReembolso.ForeColor = SystemColors.ControlText;
            reservacionActual = null;
            btnConfirmarCancelacion.Enabled = false;

            if (!Guid.TryParse(codigoTexto, out Guid codigoGuid))
            {
                MessageBox.Show("El código de reservación ingresado no tiene un formato válido.", "Código Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                reservacionActual = ReservacionesDAO.ObtenerReservacionPorCodigo(codigoGuid);

                if (reservacionActual == null)
                {
                    MessageBox.Show("No se encontró ninguna reservación con ese código.", "No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // llena los labels del form
                lblCliente.Text = reservacionActual.NombreCliente;
                lblHotel.Text = reservacionActual.NombreHotel;
                lblFechaCheckIn.Text = reservacionActual.FechaEntrada.ToString("dd/MM/yyyy");
                lblMontoAnticipo.Text = reservacionActual.Anticipo.ToString("C2");
                lblEstatusActual.Text = reservacionActual.Estado;

                // revisa que la reservacion este activa
                if (reservacionActual.Estado != "Activa")
                {
                    lblMensajeReembolso.Text = $"Esta reservación ya está '{reservacionActual.Estado}'. No se puede cancelar.";
                    lblMensajeReembolso.ForeColor = Color.OrangeRed;
                    btnConfirmarCancelacion.Enabled = false;
                }
                else
                {
                    // Revisa lo de los 3 dias
                    double diasAntes = (reservacionActual.FechaEntrada.Date - DateTime.Today).TotalDays;

                    if (diasAntes >= 3)
                    {
                        lblMensajeReembolso.Text = $"CANCELACIÓN PERMITIDA CON REEMBOLSO DE {reservacionActual.Anticipo:C2}";
                        lblMensajeReembolso.ForeColor = Color.Green;
                        btnConfirmarCancelacion.Enabled = true;
                    }
                    else
                    {
                        lblMensajeReembolso.Text = "CANCELACIÓN PERMITIDA SIN REEMBOLSO (fecha muy cercana)";
                        lblMensajeReembolso.ForeColor = Color.Red;
                        btnConfirmarCancelacion.Enabled = true; // Enable confirmation
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la reservación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarFormulario();
            }
        }
        private void btnConfirmarCancelacion_Click(object sender, EventArgs e)
        {
            if (reservacionActual == null || reservacionActual.Estado != "Activa")
            {
                MessageBox.Show("No hay una reservacion activa cargada para cancelar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // determina el monto a reenbolsar
            decimal montoReembolso = 0m;
            double diasAntes = (reservacionActual.FechaEntrada.Date - DateTime.Today).TotalDays;
            bool conReembolso = (diasAntes >= 3);

            if (conReembolso)
            {
                montoReembolso = reservacionActual.Anticipo;
            }

            string mensajeConfirmacion = conReembolso ?
                $"¿Está seguro de cancelar la reservación {reservacionActual.IdReservacion}? Se aplicará un reembolso de {montoReembolso:C2}." :
                $"¿Está seguro de cancelar la reservación {reservacionActual.IdReservacion}? ADVERTENCIA: NO se aplicará reembolso.";

            DialogResult confirmacion = MessageBox.Show(mensajeConfirmacion, "Confirmar Cancelación",
                                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    bool exito = ReservacionesDAO.CancelarReservacion(reservacionActual.IdReservacion, montoReembolso, this.usuarioLogueado.IdUsuario);

                    if (exito)
                    {
                        MessageBox.Show("¡Reservación cancelada con éxito!", "Cancelación Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarFormulario();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo completar la cancelación. La reservación podría haber sido modificada por otro usuario.", "Error de Concurrencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LimpiarFormulario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cancelar la reservación: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
