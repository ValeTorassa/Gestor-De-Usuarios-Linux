using Controladora;
using Modelo.Entidades;
using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormRolesDGV : Form
    {
        public FormRolesDGV()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormRolesAM formRolesAM = new FormRolesAM();
            formRolesAM.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.Rows.Count > 0)
            {
                var rol = (Rol)dgvRoles.CurrentRow.DataBoundItem;
                FormRolesAM formRolesAM = new FormRolesAM(rol);
                formRolesAM.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvRoles.Rows.Count > 0)
            {
                var rol = (Rol)dgvRoles.CurrentRow.DataBoundItem;

                if (ControladoraRol.Instancia.PuedeEliminarRol(rol))
                {
                    var mensaje = ControladoraRol.Instancia.EliminarRol(rol);
                    MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGrilla();
                }
                else
                {
                    MessageBox.Show("No se puede eliminar un rol asociado a un usuario, primero elimina el usuario asociado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void ActualizarGrilla()
        {
            dgvRoles.DataSource = null;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.DataSource = ControladoraRol.Instancia.RecuperarRoles();
        }

        private void FormRolesDGV_Load_1(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
