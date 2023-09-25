using Modelo.Entidades;
using Controladora;
using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormRolesAM : Form
    {
        private Rol rol;
        private bool modificar = false;

        public FormRolesAM()
        {
            InitializeComponent();
        }

        public FormRolesAM(Rol rolModificar)
        {
            InitializeComponent();
            rol = rolModificar;
            modificar = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modificar)
                {
                    rol.Nombre = txtNombre.Text;
                    rol.Descripcion = txtDescripcion.Text;
                    rol.Habilitado = cbHabilitado.Checked;

                    var mensaje = ControladoraRol.Instancia.ModificarRol(rol);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var nuevoRol = new Rol()
                    {
                        Nombre = txtNombre.Text,
                        Descripcion = txtDescripcion.Text,
                        Habilitado = cbHabilitado.Checked
                    };

                    var mensaje = ControladoraRol.Instancia.AgregarRol(nuevoRol);
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

        private void FormRolesAM_Load_1(object sender, EventArgs e)
        {
            if (modificar)
            {
                lblAgregaroModificar.Text = "Modificar Rol";
                txtNombre.Enabled = false;
                txtNombre.Text = rol.Nombre;
                txtDescripcion.Text = rol.Descripcion;
                cbHabilitado.Checked = rol.Habilitado;
            }
            else
            {
                lblAgregaroModificar.Text = "Agregar Rol";
            }
        }
    }
}
