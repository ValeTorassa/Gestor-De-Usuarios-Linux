using Controladora;
using Modelo.Entidades;
using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormUsuariosDGV : Form
    {
        public FormUsuariosDGV()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormUsuariosAM2 formUsuariosAM2 = new FormUsuariosAM2();
            formUsuariosAM2.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                FormUsuariosAM2 formUsuariosAM2 = new FormUsuariosAM2(usuario);
                formUsuariosAM2.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count > 0)
            {
                var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                var mensaje = ControladoraUsuario.Instancia.EliminarUsuario(usuario);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
        }


        private void ActualizarGrilla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.DataSource = ControladoraUsuario.Instancia.RecuperarUsuarios();
        }

        private void FormUsuariosDGV_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();

            CargarRolesdeUsuario();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            CargarRolesdeUsuario();
        }


        private void CargarRolesdeUsuario()
        {
            if (dgvUsuarios.Rows.Count > 0 && dgvUsuarios.SelectedRows.Count > 0)
            {
                dgvRolesAsignados.DataSource = null;
                dgvRolesAsignados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                var usuario = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
                dgvRolesAsignados.DataSource = usuario.Roles;
            }
        }
    }
}
