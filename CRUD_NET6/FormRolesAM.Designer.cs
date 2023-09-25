namespace CRUD
{
    partial class FormRolesAM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRolesAM));
            txtNombre = new TextBox();
            lbl = new Label();
            lblPasaporte = new Label();
            lblAgregaroModificar = new Label();
            txtDescripcion = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            cbHabilitado = new CheckBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(137, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 9;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(36, 84);
            lbl.Name = "lbl";
            lbl.Size = new Size(72, 15);
            lbl.TabIndex = 8;
            lbl.Text = "Descripcion:";
            // 
            // lblPasaporte
            // 
            lblPasaporte.AutoSize = true;
            lblPasaporte.Location = new Point(41, 40);
            lblPasaporte.Name = "lblPasaporte";
            lblPasaporte.Size = new Size(54, 15);
            lblPasaporte.TabIndex = 6;
            lblPasaporte.Text = "Nombre:";
            // 
            // lblAgregaroModificar
            // 
            lblAgregaroModificar.AutoSize = true;
            lblAgregaroModificar.Location = new Point(90, 9);
            lblAgregaroModificar.Name = "lblAgregaroModificar";
            lblAgregaroModificar.Size = new Size(165, 15);
            lblAgregaroModificar.TabIndex = 5;
            lblAgregaroModificar.Text = "Agregar o Modificar Pasajeros";
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
            btnAceptar.Location = new Point(12, 171);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(83, 26);
            btnAceptar.TabIndex = 14;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(247, 171);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 26);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbHabilitado
            // 
            cbHabilitado.AutoSize = true;
            cbHabilitado.Location = new Point(137, 122);
            cbHabilitado.Name = "cbHabilitado";
            cbHabilitado.Size = new Size(81, 19);
            cbHabilitado.TabIndex = 16;
            cbHabilitado.Text = "Habilitado";
            cbHabilitado.UseVisualStyleBackColor = true;
            // 
            // FormRolesAM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(342, 220);
            Controls.Add(cbHabilitado);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombre);
            Controls.Add(lbl);
            Controls.Add(lblPasaporte);
            Controls.Add(lblAgregaroModificar);
            Name = "FormRolesAM";
            Text = "Agregar o Modificar Roles";
            Load += FormRolesAM_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label lbl;
        private Label lblPasaporte;
        private Label lblAgregaroModificar;
        private TextBox txtDescripcion;
        private Button btnAceptar;
        private Button btnCancelar;
        private CheckBox cbHabilitado;
    }
}