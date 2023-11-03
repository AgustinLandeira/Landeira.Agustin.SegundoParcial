namespace formulario_login_
{
    partial class FmrBasket
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
            txtPuntos = new TextBox();
            txtPartidosBasket = new TextBox();
            txtObjetivo = new TextBox();
            txtNombreBasket = new TextBox();
            txtApellidoBasket = new TextBox();
            txtEdadBasket = new TextBox();
            label1 = new Label();
            lblApellido = new Label();
            label3 = new Label();
            label4 = new Label();
            lblNombre = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAceptarBasket = new Button();
            SuspendLayout();
            // 
            // txtPuntos
            // 
            txtPuntos.Location = new Point(337, 204);
            txtPuntos.Name = "txtPuntos";
            txtPuntos.Size = new Size(125, 27);
            txtPuntos.TabIndex = 0;
            // 
            // txtPartidosBasket
            // 
            txtPartidosBasket.Location = new Point(140, 204);
            txtPartidosBasket.Name = "txtPartidosBasket";
            txtPartidosBasket.Size = new Size(125, 27);
            txtPartidosBasket.TabIndex = 1;
            // 
            // txtObjetivo
            // 
            txtObjetivo.Location = new Point(576, 204);
            txtObjetivo.Name = "txtObjetivo";
            txtObjetivo.Size = new Size(125, 27);
            txtObjetivo.TabIndex = 2;
            // 
            // txtNombreBasket
            // 
            txtNombreBasket.Location = new Point(85, 100);
            txtNombreBasket.Name = "txtNombreBasket";
            txtNombreBasket.Size = new Size(125, 27);
            txtNombreBasket.TabIndex = 3;
            // 
            // txtApellidoBasket
            // 
            txtApellidoBasket.Location = new Point(328, 100);
            txtApellidoBasket.Name = "txtApellidoBasket";
            txtApellidoBasket.Size = new Size(125, 27);
            txtApellidoBasket.TabIndex = 4;
            // 
            // txtEdadBasket
            // 
            txtEdadBasket.Location = new Point(576, 103);
            txtEdadBasket.Name = "txtEdadBasket";
            txtEdadBasket.Size = new Size(125, 27);
            txtEdadBasket.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(205, 26);
            label1.Name = "label1";
            label1.Size = new Size(390, 40);
            label1.TabIndex = 6;
            label1.Text = "Jugador de basket";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(245, 103);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 7;
            lblApellido.Text = "Apellido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 204);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 8;
            label3.Text = "objetivo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(488, 103);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 103);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 204);
            label6.Name = "label6";
            label6.Size = new Size(122, 20);
            label6.TabIndex = 11;
            label6.Text = "Partidos jugados:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(271, 204);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 12;
            label7.Text = "Puntos: ";
            // 
            // btnAceptarBasket
            // 
            btnAceptarBasket.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            btnAceptarBasket.FlatStyle = FlatStyle.Flat;
            btnAceptarBasket.Location = new Point(353, 324);
            btnAceptarBasket.Name = "btnAceptarBasket";
            btnAceptarBasket.Size = new Size(94, 29);
            btnAceptarBasket.TabIndex = 13;
            btnAceptarBasket.Text = "Aceptar";
            btnAceptarBasket.UseVisualStyleBackColor = true;
            btnAceptarBasket.Click += btnAceptarBasket_Click;
            // 
            // FmrBasket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptarBasket);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblApellido);
            Controls.Add(label1);
            Controls.Add(txtEdadBasket);
            Controls.Add(txtApellidoBasket);
            Controls.Add(txtNombreBasket);
            Controls.Add(txtObjetivo);
            Controls.Add(txtPartidosBasket);
            Controls.Add(txtPuntos);
            Name = "FmrBasket";
            Text = "FmrBasket";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPuntos;
        private TextBox txtPartidosBasket;
        private TextBox txtObjetivo;
        private TextBox txtNombreBasket;
        private TextBox txtApellidoBasket;
        private TextBox txtEdadBasket;
        private Label label1;
        private Label lblApellido;
        private Label label3;
        private Label label4;
        private Label lblNombre;
        private Label label6;
        private Label label7;
        private Button btnAceptarBasket;
    }
}