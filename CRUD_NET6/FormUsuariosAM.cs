using Modelo.Entidades;
using Controladora;
using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormUsuariosAM : Form
    {
        private Usuario usuario;
        private bool modificar = false;
        List<Rol> rolesAsignados;

        public FormUsuariosAM()
        {
            InitializeComponent();
            usuario = new Usuario();
            rolesAsignados = new List<Rol>();


            dgvRolesDisponibles.DataSource = null;
            dgvRolesDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRolesDisponibles.DataSource = ControladoraRol.Instancia.RecuperarRoles();


            LlenarCombo();
        }

        public FormUsuariosAM(Usuario usuarioModificar)
        {
            InitializeComponent();
            usuario = usuarioModificar;
            modificar = true;
            //Lo hago para no trabajar directamente sobre los roles del usuario, ocasionando cambios irreversibles
            rolesAsignados = usuarioModificar.Roles.ToList();
            ActualizarGrillas();
            LlenarCombo();
        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string mensaje;

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
                        Configuracion = (Configuraciones)cmbConfiguraciones.SelectedItem
                    };

                    foreach (DataGridViewRow row in dgvRolesAsignados.Rows)
                    {
                        if (row.DataBoundItem is Rol rol)
                        {
                            nuevoUsuario.Roles.Add(rol);
                        }
                    }

                    mensaje = ControladoraUsuario.Instancia.ModificarUsuario(nuevoUsuario);
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
                        Configuracion = (Configuraciones)cmbConfiguraciones.SelectedItem
                    };

                    foreach (DataGridViewRow row in dgvRolesAsignados.Rows)
                    {
                        if (row.DataBoundItem is Rol rol)
                        {
                            //ahora si les pasamos los roles
                            nuevoUsuario.Roles.Add(rol);
                        }
                    }

                    mensaje = ControladoraUsuario.Instancia.AgregarUsuario(nuevoUsuario);
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

        private void FormUsuariosAM_Load(object sender, EventArgs e)
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
            }
            else
            {
                lblAgregaroModificar.Text = "Agregar Usuario";
            }
        }

        private void ActualizarGrillas()
        {
            dgvRolesDisponibles.DataSource = null;
            dgvRolesDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRolesDisponibles.DataSource = ControladoraRol.Instancia.RecuperarRoles();

            dgvRolesAsignados.DataSource = null;
            dgvRolesAsignados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRolesAsignados.DataSource = rolesAsignados;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dgvRolesDisponibles.Rows.Count > 0)
            {
                var rolAgregado = (Rol)dgvRolesDisponibles.CurrentRow.DataBoundItem;

                bool rolYaExiste = rolesAsignados.Any(p => p.Nombre == rolAgregado.Nombre);

                if (!rolYaExiste)
                {
                    if (rolAgregado.Habilitado)
                    {
                        rolesAsignados.Add(rolAgregado);
                        ActualizarGrillas();
                    }
                    else
                    {
                        MessageBox.Show("El rol esta deshabilitado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if (rolAgregado.Habilitado)
                    {
                        MessageBox.Show("El rol ya está asociado al usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("El rol ya está asociado al usuario y está deshabilitado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }


                /*
                if (!rolYaExiste)
                {
                    rolesAsignados.Add(rolAgregado);
                    ActualizarGrillas();
                }
                else
                {
                    MessageBox.Show("El rol ya está asociado al usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                 */
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRolesAsignados.Rows.Count > 0)
            {
                var rolEliminado = (Rol)dgvRolesAsignados.CurrentRow.DataBoundItem;

                if (rolesAsignados.Contains(rolEliminado))
                {
                    rolesAsignados.Remove(rolEliminado);
                    ActualizarGrillas();
                }
                else
                {
                    MessageBox.Show("El rol seleccionado no está asociado al usuario.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LlenarCombo()
        {
            cmbConfiguraciones.DataSource = null;
            cmbConfiguraciones.DataSource = ControladoraConfiguracion.Instancia.RecuperarConfiguraciones();
        }
    }
}
