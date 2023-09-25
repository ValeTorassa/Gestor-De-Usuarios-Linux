namespace CRUD
{
    partial class FormUsuariosAM2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuariosAM2));
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtNombre = new TextBox();
            lblDestino = new Label();
            txtEmail = new TextBox();
            lblNombre = new Label();
            lblAgregaroModificar = new Label();
            txtUsername = new TextBox();
            txtApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            label3 = new Label();
            label4 = new Label();
            cmbConfiguraciones = new ComboBox();
            lblConfiguraciones = new Label();
            lbAsignados = new ListBox();
            cmbDisponibles = new ComboBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(168, 256);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(83, 26);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(31, 256);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(83, 26);
            btnAceptar.TabIndex = 36;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(90, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(118, 23);
            txtNombre.TabIndex = 34;
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(17, 166);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(54, 15);
            lblDestino.TabIndex = 33;
            lblDestino.Text = "Apellido:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(90, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(142, 23);
            txtEmail.TabIndex = 32;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(17, 124);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 31;
            lblNombre.Text = "Nombre:";
            // 
            // lblAgregaroModificar
            // 
            lblAgregaroModificar.AutoSize = true;
            lblAgregaroModificar.Location = new Point(47, 9);
            lblAgregaroModificar.Name = "lblAgregaroModificar";
            lblAgregaroModificar.Size = new Size(161, 15);
            lblAgregaroModificar.TabIndex = 28;
            lblAgregaroModificar.Text = "Agregar o Modificar Usuarios";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(90, 39);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(118, 23);
            txtUsername.TabIndex = 38;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(90, 168);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(118, 23);
            txtApellido.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 40;
            label1.Text = "UserName:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 82);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 41;
            label2.Text = "Email:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(497, 199);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 51;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(497, 36);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 50;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(269, 39);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 46;
            label3.Text = "Roles Disponibles:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(269, 129);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 53;
            label4.Text = "Roles Asignados:";
            // 
            // cmbConfiguraciones
            // 
            cmbConfiguraciones.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConfiguraciones.FormattingEnabled = true;
            cmbConfiguraciones.Location = new Point(117, 204);
            cmbConfiguraciones.Name = "cmbConfiguraciones";
            cmbConfiguraciones.Size = new Size(121, 23);
            cmbConfiguraciones.TabIndex = 54;
            // 
            // lblConfiguraciones
            // 
            lblConfiguraciones.AutoSize = true;
            lblConfiguraciones.Location = new Point(17, 207);
            lblConfiguraciones.Name = "lblConfiguraciones";
            lblConfiguraciones.Size = new Size(97, 15);
            lblConfiguraciones.TabIndex = 55;
            lblConfiguraciones.Text = "Configuraciones:";
            // 
            // lbAsignados
            // 
            lbAsignados.FormattingEnabled = true;
            lbAsignados.ItemHeight = 15;
            lbAsignados.Location = new Point(370, 129);
            lbAsignados.Name = "lbAsignados";
            lbAsignados.Size = new Size(120, 94);
            lbAsignados.TabIndex = 56;
            // 
            // cmbDisponibles
            // 
            cmbDisponibles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDisponibles.FormattingEnabled = true;
            cmbDisponibles.Location = new Point(370, 36);
            cmbDisponibles.Name = "cmbDisponibles";
            cmbDisponibles.Size = new Size(121, 23);
            cmbDisponibles.TabIndex = 57;
            // 
            // FormUsuariosAM2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(578, 294);
            Controls.Add(cmbDisponibles);
            Controls.Add(lbAsignados);
            Controls.Add(lblConfiguraciones);
            Controls.Add(cmbConfiguraciones);
            Controls.Add(label4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtApellido);
            Controls.Add(txtUsername);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(txtNombre);
            Controls.Add(lblDestino);
            Controls.Add(txtEmail);
            Controls.Add(lblNombre);
            Controls.Add(lblAgregaroModificar);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormUsuariosAM2";
            Text = "Agregar o Modificar Usuarios";
            Load += FormUsuariosAM2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtNombre;
        private Label lblDestino;
        private TextBox txtEmail;
        private Label lblNombre;
        private Label lblAgregaroModificar;
        private TextBox txtUsername;
        private TextBox txtApellido;
        private Label label1;
        private Label label2;
        private Button btnGuardarySALIT;
        private Button btnLimpiar;
        private Button btnAgregar;
        private CheckBox cbHabilitada;
        private Label label5;
        private Label label3;
        private ComboBox cmbRoles;
        private Label label4;
        private ComboBox cmbConfiguraciones;
        private Label lblConfiguraciones;
        private ListBox lbAsignados;
        private ComboBox cmbDisponibles;
    }
}