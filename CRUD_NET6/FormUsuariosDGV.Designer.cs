namespace CRUD
{
    partial class FormUsuariosDGV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuariosDGV));
            btnEliminar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            lblUsuarios = new Label();
            dgvUsuarios = new DataGridView();
            dgvRolesAsignados = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRolesAsignados).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(498, 242);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(242, 242);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 242);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblUsuarios
            // 
            lblUsuarios.AutoSize = true;
            lblUsuarios.Location = new Point(241, 9);
            lblUsuarios.Name = "lblUsuarios";
            lblUsuarios.Size = new Size(52, 15);
            lblUsuarios.TabIndex = 6;
            lblUsuarios.Text = "Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(12, 28);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(561, 195);
            dgvUsuarios.TabIndex = 5;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // dgvRolesAsignados
            // 
            dgvRolesAsignados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRolesAsignados.Location = new Point(588, 67);
            dgvRolesAsignados.Name = "dgvRolesAsignados";
            dgvRolesAsignados.RowTemplate.Height = 25;
            dgvRolesAsignados.Size = new Size(238, 131);
            dgvRolesAsignados.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(664, 49);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 11;
            label1.Text = "Roles Asignados";
            // 
            // FormUsuariosDGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(849, 279);
            Controls.Add(label1);
            Controls.Add(dgvRolesAsignados);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lblUsuarios);
            Controls.Add(dgvUsuarios);
            Name = "FormUsuariosDGV";
            Text = "Usuarios";
            Load += FormUsuariosDGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRolesAsignados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminar;
        private Button btnModificar;
        private Button btnAgregar;
        private Label lblUsuarios;
        private DataGridView dgvUsuarios;
        private DataGridView dgvRolesAsignados;
        private Label label1;
    }
}