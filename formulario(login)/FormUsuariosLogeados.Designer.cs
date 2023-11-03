namespace formulario_login_
{
    partial class FormUsuariosLogeados
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
            label1 = new Label();
            lstUsuarios = new ListBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(206, 34);
            label1.Name = "label1";
            label1.Size = new Size(388, 40);
            label1.TabIndex = 0;
            label1.Text = "Usuarios iniciados";
            // 
            // lstUsuarios
            // 
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 20;
            lstUsuarios.Location = new Point(12, 90);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(776, 264);
            lstUsuarios.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(296, 390);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(208, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormUsuariosLogeados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(lstUsuarios);
            Controls.Add(label1);
            Name = "FormUsuariosLogeados";
            Text = "FormUsuariosLogeados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstUsuarios;
        private Button btnAceptar;
    }
}