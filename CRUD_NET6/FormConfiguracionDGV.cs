using Controladora;
using Modelo.Entidades;
using System;
using System.Windows.Forms;

namespace CRUD
{
    public partial class FormConfiguracionDGV : Form
    {
        public FormConfiguracionDGV()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormConfiguracionAM formConfiguracionAM = new FormConfiguracionAM();
            formConfiguracionAM.ShowDialog();
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvConfiguraciones.Rows.Count > 0)
            {
                var configuracion = (Configuraciones)dgvConfiguraciones.CurrentRow.DataBoundItem;
                FormConfiguracionAM formConfiguracionAM = new FormConfiguracionAM(configuracion);
                formConfiguracionAM.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvConfiguraciones.Rows.Count > 0)
            {
                var configuracion = (Configuraciones)dgvConfiguraciones.CurrentRow.DataBoundItem;
                var mensaje = ControladoraConfiguracion.Instancia.EliminarConfiguracion(configuracion);
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGrilla();
            }
        }

        private void ActualizarGrilla()
        {
            dgvConfiguraciones.DataSource = null;
            dgvConfiguraciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConfiguraciones.DataSource = ControladoraConfiguracion.Instancia.RecuperarConfiguraciones();
        }

        private void FormConfiguracionDGV_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}
