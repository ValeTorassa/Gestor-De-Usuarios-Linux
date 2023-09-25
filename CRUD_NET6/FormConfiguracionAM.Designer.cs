namespace CRUD
{
    partial class FormConfiguracionAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracionAM));
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            lblNombre = new Label();
            lblAgregaroModificar = new Label();
            txtDescripcion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cbNotificaciones = new CheckBox();
            numValor = new NumericUpDown();
            lblValor = new Label();
            ((System.ComponentModel.ISupportInitialize)numValor).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 9;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(36, 84);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 8;
            lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(41, 40);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre:";
            // 
            // lblAgregaroModificar
            // 
            lblAgregaroModificar.AutoSize = true;
            lblAgregaroModificar.Location = new Point(90, 9);
            lblAgregaroModificar.Name = "lblAgregaroModificar";
            lblAgregaroModificar.Size = new Size(113, 15);
            lblAgregaroModificar.TabIndex = 5;
            lblAgregaroModificar.Text = "Agregar o Modificar";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(137, 81);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(193, 23);
            txtDescripcion.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 234);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(83, 26);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(247, 234);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 26);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbNotificaciones
            // 
            cbNotificaciones.AutoSize = true;
            cbNotificaciones.Location = new Point(103, 170);
            cbNotificaciones.Name = "cbNotificaciones";
            cbNotificaciones.Size = new Size(102, 19);
            cbNotificaciones.TabIndex = 16;
            cbNotificaciones.Text = "Notificaciones";
            cbNotificaciones.UseVisualStyleBackColor = true;
            // 
            // numValor
            // 
            numValor.DecimalPlaces = 2;
            numValor.Location = new Point(135, 124);
            numValor.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numValor.Name = "numValor";
            numValor.Size = new Size(120, 23);
            numValor.TabIndex = 17;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(72, 126);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 18;
            lblValor.Text = "Valor:";
            // 
            // FormConfiguracionAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(491, 272);
            Controls.Add(lblValor);
            Controls.Add(numValor);
            Controls.Add(cbNotificaciones);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblAgregaroModificar);
            Name = "FormConfiguracionAM";
            Text = "Agregar o Modificar Configuraciones";
            Load += FormConfiguracionAM_Load;
            ((System.ComponentModel.ISupportInitialize)numValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtNombre;
        private Label lblDescripcion;
        private Label lblNombre;
        private Label lblAgregaroModificar;
        private TextBox txtDescripcion;
        private Button btnAceptar;
        private Button btnCancelar;
        private CheckBox cbNotificaciones;
        private NumericUpDown numValor;
        private Label lblValor;
    }
}