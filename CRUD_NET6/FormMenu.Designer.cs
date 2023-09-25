namespace CRUD
{
    partial class FormMenu
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
            btnRoles = new Button();
            btnUsuarios = new Button();
            lblMenu = new Label();
            btnConfiguracion = new Button();
            SuspendLayout();
            // 
            // btnRoles
            // 
            btnRoles.Location = new Point(12, 33);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(165, 48);
            btnRoles.TabIndex = 0;
            btnRoles.Text = "Roles";
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(12, 187);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(165, 48);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(82, 9);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(38, 15);
            lblMenu.TabIndex = 3;
            lblMenu.Text = "Menu";
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.Location = new Point(12, 109);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(165, 48);
            btnConfiguracion.TabIndex = 4;
            btnConfiguracion.Text = "Configuracion";
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.wallpapersden_com_linux_retro_1920x1080;
            ClientSize = new Size(186, 247);
            Controls.Add(btnConfiguracion);
            Controls.Add(lblMenu);
            Controls.Add(btnUsuarios);
            Controls.Add(btnRoles);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRoles;
        private Button btnUsuarios;
        private Label lblMenu;
        private Button btnConfiguracion;
    }
}