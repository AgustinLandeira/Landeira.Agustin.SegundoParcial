namespace formulario_login_
{
    partial class FmrBeisbol
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtNombreBeisbol = new TextBox();
            txtPartidosBeisbol = new TextBox();
            txtAccesorio = new TextBox();
            txtEdadBeisbol = new TextBox();
            txtcantVueltas = new TextBox();
            txtApellidoBeisbol = new TextBox();
            btnAceptarBeisbol = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(206, 37);
            label1.Name = "label1";
            label1.Size = new Size(388, 40);
            label1.TabIndex = 0;
            label1.Text = "Jugador de beisbol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 122);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 122);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(300, 233);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 3;
            label4.Text = "Accesorio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(527, 122);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 4;
            label5.Text = "Edad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 233);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 5;
            label6.Text = "Partidos jugados:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(523, 233);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 6;
            label7.Text = "Cant vueltas:";
            // 
            // txtNombreBeisbol
            // 
            txtNombreBeisbol.Location = new Point(85, 122);
            txtNombreBeisbol.Name = "txtNombreBeisbol";
            txtNombreBeisbol.Size = new Size(125, 27);
            txtNombreBeisbol.TabIndex = 7;
            // 
            // txtPartidosBeisbol
            // 
            txtPartidosBeisbol.Location = new Point(157, 230);
            txtPartidosBeisbol.Name = "txtPartidosBeisbol";
            txtPartidosBeisbol.Size = new Size(125, 27);
            txtPartidosBeisbol.TabIndex = 8;
            // 
            // txtAccesorio
            // 
            txtAccesorio.Location = new Point(380, 230);
            txtAccesorio.Name = "txtAccesorio";
            txtAccesorio.Size = new Size(125, 27);
            txtAccesorio.TabIndex = 9;
            // 
            // txtEdadBeisbol
            // 
            txtEdadBeisbol.Location = new Point(587, 122);
            txtEdadBeisbol.Name = "txtEdadBeisbol";
            txtEdadBeisbol.Size = new Size(125, 27);
            txtEdadBeisbol.TabIndex = 10;
            // 
            // txtcantVueltas
            // 
            txtcantVueltas.Location = new Point(621, 226);
            txtcantVueltas.Name = "txtcantVueltas";
            txtcantVueltas.Size = new Size(125, 27);
            txtcantVueltas.TabIndex = 11;
            // 
            // txtApellidoBeisbol
            // 
            txtApellidoBeisbol.Location = new Point(349, 122);
            txtApellidoBeisbol.Name = "txtApellidoBeisbol";
            txtApellidoBeisbol.Size = new Size(125, 27);
            txtApellidoBeisbol.TabIndex = 12;
            // 
            // btnAceptarBeisbol
            // 
            btnAceptarBeisbol.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            btnAceptarBeisbol.FlatStyle = FlatStyle.Flat;
            btnAceptarBeisbol.Location = new Point(353, 340);
            btnAceptarBeisbol.Name = "btnAceptarBeisbol";
            btnAceptarBeisbol.Size = new Size(94, 29);
            btnAceptarBeisbol.TabIndex = 13;
            btnAceptarBeisbol.Text = "Aceptar";
            btnAceptarBeisbol.UseVisualStyleBackColor = true;
            btnAceptarBeisbol.Click += btnAceptarBeisbol_Click;
            // 
            // FmrBeisbol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_beisbol;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptarBeisbol);
            Controls.Add(txtApellidoBeisbol);
            Controls.Add(txtcantVueltas);
            Controls.Add(txtEdadBeisbol);
            Controls.Add(txtAccesorio);
            Controls.Add(txtPartidosBeisbol);
            Controls.Add(txtNombreBeisbol);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmrBeisbol";
            Text = "FmrBeisbol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtNombreBeisbol;
        private TextBox txtPartidosBeisbol;
        private TextBox txtAccesorio;
        private TextBox txtEdadBeisbol;
        private TextBox txtcantVueltas;
        private TextBox txtApellidoBeisbol;
        private Button btnAceptarBeisbol;
    }
}