using Modelo.Entidades;
using Controladora;
using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormConfiguracionAM : Form
    {
        private Configuraciones configuracion;
        private bool modificar = false;

        public FormConfiguracionAM()
        {
            InitializeComponent();
        }

        public FormConfiguracionAM(Configuraciones configuracionModificar)
        {
            InitializeComponent();
            configuracion = configuracionModificar;
            modificar = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modificar)
                {
                    configuracion.NombreConfiguracion = txtNombre.Text;
                    configuracion.Descripcion = txtDescripcion.Text;
                    configuracion.Valor = numValor.Value;
                    configuracion.Notificaciones = cbNotificaciones.Checked;

                    var mensaje = ControladoraConfiguracion.Instancia.ModificarConfiguracion(configuracion);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var nuevaConfiguracion = new Configuraciones()
                    {
                        NombreConfiguracion = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        Valor = numValor.Value,
                        Notificaciones = cbNotificaciones.Checked
                    };

                    var mensaje = ControladoraConfiguracion.Instancia.AgregarConfiguracion(nuevaConfiguracion);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void FormConfiguracionAM_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                lblAgregaroModificar.Text = "Modificar Configuración";
                txtNombre.Enabled = false;
                txtNombre.Text = configuracion.NombreConfiguracion;
                txtDescripcion.Text = configuracion.Descripcion;
                numValor.Value = configuracion.Valor;
                cbNotificaciones.Checked = configuracion.Notificaciones;
            }
            else
            {
                lblAgregaroModificar.Text = "Agregar Configuración";
            }
        }
    }
}
