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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FormRolesDGV formRolesDGV = new FormRolesDGV();
            formRolesDGV.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuariosDGV formUsuariosDGV = new FormUsuariosDGV();
            formUsuariosDGV.ShowDialog();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FormConfiguracionDGV formConfiguracionDGV = new FormConfiguracionDGV();
            formConfiguracionDGV.ShowDialog();
        }
    }
}
