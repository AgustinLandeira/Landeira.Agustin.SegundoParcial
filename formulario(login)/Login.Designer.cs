namespace formulario_login_
{
    partial class Login
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
            txtIniciarSesion = new TextBox();
            txtContraseña = new TextBox();
            lbl1 = new Label();
            lbl2 = new Label();
            btn_IniciarSesion = new Button();
            lblMostrar = new Label();
            lblOcultar = new Label();
            SuspendLayout();
            // 
            // txtIniciarSesion
            // 
            txtIniciarSesion.Location = new Point(248, 147);
            txtIniciarSesion.Name = "txtIniciarSesion";
            txtIniciarSesion.Size = new Size(256, 27);
            txtIniciarSesion.TabIndex = 0;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(248, 278);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(256, 27);
            txtContraseña.TabIndex = 1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = SystemColors.ButtonHighlight;
            lbl1.ForeColor = SystemColors.ActiveCaptionText;
            lbl1.Location = new Point(272, 96);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(200, 20);
            lbl1.TabIndex = 2;
            lbl1.Text = "Ingrese su correo electronico";
            lbl1.Click += label1_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = SystemColors.ButtonHighlight;
            lbl2.ForeColor = SystemColors.ActiveCaptionText;
            lbl2.Location = new Point(300, 213);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(151, 20);
            lbl2.TabIndex = 3;
            lbl2.Text = "Ingrese su contraseña";
            // 
            // btn_IniciarSesion
            // 
            btn_IniciarSesion.Location = new Point(288, 366);
            btn_IniciarSesion.Name = "btn_IniciarSesion";
            btn_IniciarSesion.Size = new Size(173, 29);
            btn_IniciarSesion.TabIndex = 4;
            btn_IniciarSesion.Text = "Iniciar sesion";
            btn_IniciarSesion.UseVisualStyleBackColor = true;
            btn_IniciarSesion.Click += btn_IniciarSesion_Click;
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.BackColor = SystemColors.ButtonHighlight;
            lblMostrar.Location = new Point(527, 285);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new Size(60, 20);
            lblMostrar.TabIndex = 5;
            lblMostrar.Text = "Mostrar";
            lblMostrar.Click += lblMostrar_Click;
            // 
            // lblOcultar
            // 
            lblOcultar.AutoSize = true;
            lblOcultar.BackColor = SystemColors.ButtonHighlight;
            lblOcultar.Location = new Point(527, 285);
            lblOcultar.Name = "lblOcultar";
            lblOcultar.Size = new Size(57, 20);
            lblOcultar.TabIndex = 6;
            lblOcultar.Text = "Ocultar";
            lblOcultar.Click += lblOcultar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_login;
            ClientSize = new Size(720, 448);
            Controls.Add(lblOcultar);
            Controls.Add(lblMostrar);
            Controls.Add(btn_IniciarSesion);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(txtContraseña);
            Controls.Add(txtIniciarSesion);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIniciarSesion;
        private TextBox txtContraseña;
        private Label lbl1;
        private Label lbl2;
        private Button btn_IniciarSesion;
        private Label lblMostrar;
        private Label lblOcultar;
    }
}