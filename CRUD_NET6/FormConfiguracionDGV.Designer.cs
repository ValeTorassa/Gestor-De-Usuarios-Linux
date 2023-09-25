namespace CRUD
{
    partial class FormConfiguracionDGV
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracionDGV));
            dgvConfiguraciones = new DataGridView();
            lblTitulo = new Label();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvConfiguraciones).BeginInit();
            SuspendLayout();
            // 
            // dgvConfiguraciones
            // 
            dgvConfiguraciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConfiguraciones.Location = new Point(12, 30);
            dgvConfiguraciones.Name = "dgvConfiguraciones";
            dgvConfiguraciones.RowTemplate.Height = 25;
            dgvConfiguraciones.Size = new Size(458, 195);
            dgvConfiguraciones.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(202, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(83, 15);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Configuracion";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 257);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(184, 257);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(75, 23);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(375, 257);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FormConfiguracionDGV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(487, 292);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvConfiguraciones);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConfiguracionDGV";
            Text = "Configuraciones";
            Load += FormConfiguracionDGV_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConfiguraciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvConfiguraciones;
        private Label lblTitulo;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}