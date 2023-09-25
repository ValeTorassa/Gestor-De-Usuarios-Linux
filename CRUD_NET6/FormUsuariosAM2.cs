using Controladora;
using Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormUsuariosAM2 : Form
    {
        private Usuario usuario;
        private bool modificar = false;

        public FormUsuariosAM2()
        {
            InitializeComponent();
            LlenarCombo();
        }

        public FormUsuariosAM2(Usuario usuarioModificar)
        {
            InitializeComponent();
            usuario = usuarioModificar;
            modificar = true;
            LlenarCombo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if (modificar)
                {
                    var nuevoUsuario = new Usuario()
                    {
                        NombreDeUsuario = txtUsername.Text,
                        Email = txtEmail.Text,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Configuracion = (Configuraciones)cmbConfiguraciones.SelectedItem,
                        Roles = lbAsignados.Items.Cast<Rol>().ToList()
                    };


                    var mensaje = ControladoraUsuario.Instancia.ModificarUsuario(nuevoUsuario);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var nuevoUsuario = new Usuario()
                    {
                        NombreDeUsuario = txtUsername.Text,
                        Email = txtEmail.Text,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        Configuracion = (Configuraciones)cmbConfiguraciones.SelectedItem,
                        Roles = lbAsignados.Items.Cast<Rol>().ToList()
                    };

                    var mensaje = ControladoraUsuario.Instancia.AgregarUsuario(nuevoUsuario);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cmbDisponibles.SelectedItem != null && !lbAsignados.Items.Contains(cmbDisponibles.SelectedItem))
            {
                lbAsignados.Items.Add(cmbDisponibles.SelectedItem);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbAsignados.Items.Clear();
        }

        private void LlenarCombo()
        {
            cmbConfiguraciones.DataSource = null;
            cmbConfiguraciones.DataSource = ControladoraConfiguracion.Instancia.RecuperarConfiguraciones();

            cmbDisponibles.DataSource = null;
            cmbDisponibles.DataSource = ControladoraRol.Instancia.RecuperarRoles();
        }

        private void FormUsuariosAM2_Load(object sender, EventArgs e)
        {
            if (modificar)
            {
                lblAgregaroModificar.Text = "Modificar Usuario";
                txtUsername.Enabled = false;
                txtUsername.Text = usuario.NombreDeUsuario;
                txtEmail.Text = usuario.Email;
                txtNombre.Text = usuario.Nombre;
                txtApellido.Text = usuario.Apellido;
                cmbConfiguraciones.SelectedItem = usuario.Configuracion;
                lbAsignados.Items.AddRange(usuario.Roles.ToArray());
            }
            else
            {
                lblAgregaroModificar.Text = "Agregar Usuario";
            }
        }


        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar un email", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar un nombre", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Debe ingresar un apellido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
