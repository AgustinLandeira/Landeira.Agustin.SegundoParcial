namespace formulario_login_
{
    partial class FmrFutbol
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
            lblJugador = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            txtApellido = new TextBox();
            txtPartidosJugados = new TextBox();
            txtAño = new TextBox();
            txtCantGoles = new TextBox();
            txtPosicion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblPartidos = new Label();
            txtGoles = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblJugador
            // 
            lblJugador.AutoSize = true;
            lblJugador.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblJugador.Location = new Point(220, 32);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(376, 40);
            lblJugador.TabIndex = 0;
            lblJugador.Text = "Jugador de Futbol";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(94, 122);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 122);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(259, 122);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(349, 122);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 27);
            txtApellido.TabIndex = 4;
            // 
            // txtPartidosJugados
            // 
            txtPartidosJugados.Location = new Point(141, 210);
            txtPartidosJugados.Name = "txtPartidosJugados";
            txtPartidosJugados.Size = new Size(125, 27);
            txtPartidosJugados.TabIndex = 5;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(582, 122);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(125, 27);
            txtAño.TabIndex = 6;
            // 
            // txtCantGoles
            // 
            txtCantGoles.Location = new Point(349, 203);
            txtCantGoles.Name = "txtCantGoles";
            txtCantGoles.Size = new Size(125, 27);
            txtCantGoles.TabIndex = 7;
            // 
            // txtPosicion
            // 
            txtPosicion.Location = new Point(582, 203);
            txtPosicion.Name = "txtPosicion";
            txtPosicion.Size = new Size(125, 27);
            txtPosicion.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(509, 122);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 9;
            label1.Text = "Edad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(509, 210);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 10;
            label2.Text = "Posicion:";
            // 
            // lblPartidos
            // 
            lblPartidos.AutoSize = true;
            lblPartidos.Location = new Point(12, 210);
            lblPartidos.Name = "lblPartidos";
            lblPartidos.Size = new Size(123, 20);
            lblPartidos.TabIndex = 11;
            lblPartidos.Text = "Partidos Jugados:";
            // 
            // txtGoles
            // 
            txtGoles.AutoSize = true;
            txtGoles.Location = new Point(278, 210);
            txtGoles.Name = "txtGoles";
            txtGoles.Size = new Size(49, 20);
            txtGoles.TabIndex = 12;
            txtGoles.Text = "Goles:";
            // 
            // btnAceptar
            // 
            btnAceptar.FlatAppearance.BorderColor = Color.Aqua;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Location = new Point(318, 336);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(134, 29);
            btnAceptar.TabIndex = 13;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FmrFutbol
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_futbol;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(txtGoles);
            Controls.Add(lblPartidos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPosicion);
            Controls.Add(txtCantGoles);
            Controls.Add(txtAño);
            Controls.Add(txtPartidosJugados);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtNombre);
            Controls.Add(lblJugador);
            Name = "FmrFutbol";
            Text = "FmrFutbol";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJugador;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private TextBox txtPartidosJugados;
        private TextBox txtAño;
        private TextBox txtCantGoles;
        private TextBox txtPosicion;
        private Label label1;
        private Label label2;
        private Label lblPartidos;
        private Label txtGoles;
        private Button btnAceptar;
    }
}