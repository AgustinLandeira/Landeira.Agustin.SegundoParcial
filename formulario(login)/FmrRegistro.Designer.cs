namespace formulario_login_
{
    partial class FmrRegistro
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
            lstRegistro = new ListBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            Eliminar = new Button();
            btnGuardarDatos = new Button();
            btnRecuperarDatos = new Button();
            groupBox1 = new GroupBox();
            btnOrdenar = new Button();
            label2 = new Label();
            label1 = new Label();
            BtnRadioPartAsc = new RadioButton();
            BtnRadioPartDesc = new RadioButton();
            BtnRadioEdadDesc = new RadioButton();
            BtnRadioEdadAsc = new RadioButton();
            btbUsuarios = new Button();
            label3 = new Label();
            lblTiempo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lstRegistro
            // 
            lstRegistro.Font = new Font("Sylfaen", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lstRegistro.FormattingEnabled = true;
            lstRegistro.ItemHeight = 19;
            lstRegistro.Location = new Point(1, 2);
            lstRegistro.Name = "lstRegistro";
            lstRegistro.Size = new Size(976, 289);
            lstRegistro.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Location = new Point(531, 313);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar jugador";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.FlatAppearance.BorderColor = Color.Cyan;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Location = new Point(696, 313);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(139, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar jugador";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Eliminar
            // 
            Eliminar.FlatAppearance.BorderColor = Color.FromArgb(128, 255, 255);
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.Location = new Point(851, 313);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(139, 29);
            Eliminar.TabIndex = 3;
            Eliminar.Text = "Eliminar jugador";
            Eliminar.UseVisualStyleBackColor = true;
            Eliminar.Click += Eliminar_Click;
            // 
            // btnGuardarDatos
            // 
            btnGuardarDatos.FlatAppearance.BorderColor = Color.Red;
            btnGuardarDatos.FlatStyle = FlatStyle.Flat;
            btnGuardarDatos.Location = new Point(616, 409);
            btnGuardarDatos.Name = "btnGuardarDatos";
            btnGuardarDatos.Size = new Size(159, 29);
            btnGuardarDatos.TabIndex = 4;
            btnGuardarDatos.Text = "Guardar datos";
            btnGuardarDatos.UseVisualStyleBackColor = true;
            btnGuardarDatos.Click += btnGuardarDatos_Click;
            // 
            // btnRecuperarDatos
            // 
            btnRecuperarDatos.FlatAppearance.BorderColor = Color.Red;
            btnRecuperarDatos.FlatStyle = FlatStyle.Flat;
            btnRecuperarDatos.Location = new Point(795, 409);
            btnRecuperarDatos.Name = "btnRecuperarDatos";
            btnRecuperarDatos.Size = new Size(204, 29);
            btnRecuperarDatos.TabIndex = 5;
            btnRecuperarDatos.Text = "Recuperar datos guardados";
            btnRecuperarDatos.UseVisualStyleBackColor = true;
            btnRecuperarDatos.Click += btnRecuperarDatos_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOrdenar);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnRadioPartAsc);
            groupBox1.Controls.Add(BtnRadioPartDesc);
            groupBox1.Controls.Add(BtnRadioEdadDesc);
            groupBox1.Controls.Add(BtnRadioEdadAsc);
            groupBox1.Location = new Point(12, 297);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(446, 141);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Orden";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(154, 42);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(94, 29);
            btnOrdenar.TabIndex = 6;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 42);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 5;
            label2.Text = "Por partidos ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 4;
            label1.Text = "Por edad";
            // 
            // BtnRadioPartAsc
            // 
            BtnRadioPartAsc.AutoSize = true;
            BtnRadioPartAsc.Location = new Point(308, 65);
            BtnRadioPartAsc.Name = "BtnRadioPartAsc";
            BtnRadioPartAsc.Size = new Size(107, 24);
            BtnRadioPartAsc.TabIndex = 3;
            BtnRadioPartAsc.TabStop = true;
            BtnRadioPartAsc.Text = "Ascendente";
            BtnRadioPartAsc.UseVisualStyleBackColor = true;
            // 
            // BtnRadioPartDesc
            // 
            BtnRadioPartDesc.AutoSize = true;
            BtnRadioPartDesc.Location = new Point(308, 111);
            BtnRadioPartDesc.Name = "BtnRadioPartDesc";
            BtnRadioPartDesc.Size = new Size(116, 24);
            BtnRadioPartDesc.TabIndex = 2;
            BtnRadioPartDesc.TabStop = true;
            BtnRadioPartDesc.Text = "Descendente";
            BtnRadioPartDesc.UseVisualStyleBackColor = true;
            // 
            // BtnRadioEdadDesc
            // 
            BtnRadioEdadDesc.AutoSize = true;
            BtnRadioEdadDesc.Location = new Point(6, 111);
            BtnRadioEdadDesc.Name = "BtnRadioEdadDesc";
            BtnRadioEdadDesc.Size = new Size(116, 24);
            BtnRadioEdadDesc.TabIndex = 1;
            BtnRadioEdadDesc.TabStop = true;
            BtnRadioEdadDesc.Text = "Descendente";
            BtnRadioEdadDesc.UseVisualStyleBackColor = true;
            // 
            // BtnRadioEdadAsc
            // 
            BtnRadioEdadAsc.AutoSize = true;
            BtnRadioEdadAsc.Location = new Point(6, 65);
            BtnRadioEdadAsc.Name = "BtnRadioEdadAsc";
            BtnRadioEdadAsc.Size = new Size(107, 24);
            BtnRadioEdadAsc.TabIndex = 0;
            BtnRadioEdadAsc.TabStop = true;
            BtnRadioEdadAsc.Text = "Ascendente";
            BtnRadioEdadAsc.UseVisualStyleBackColor = true;
            // 
            // btbUsuarios
            // 
            btbUsuarios.FlatAppearance.BorderColor = Color.Red;
            btbUsuarios.FlatStyle = FlatStyle.Flat;
            btbUsuarios.Location = new Point(464, 409);
            btbUsuarios.Name = "btbUsuarios";
            btbUsuarios.Size = new Size(146, 29);
            btbUsuarios.TabIndex = 7;
            btbUsuarios.Text = "Usuarios iniciados";
            btbUsuarios.UseVisualStyleBackColor = true;
            btbUsuarios.Click += btbUsuarios_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ravie", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(635, 378);
            label3.Name = "label3";
            label3.Size = new Size(200, 17);
            label3.TabIndex = 8;
            label3.Text = "Tiempo transcurrido:";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Ravie", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTiempo.Location = new Point(851, 376);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(67, 19);
            lblTiempo.TabIndex = 9;
            lblTiempo.Text = "label4";
            // 
            // FmrRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 450);
            Controls.Add(lblTiempo);
            Controls.Add(label3);
            Controls.Add(btbUsuarios);
            Controls.Add(groupBox1);
            Controls.Add(btnRecuperarDatos);
            Controls.Add(btnGuardarDatos);
            Controls.Add(Eliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lstRegistro);
            Name = "FmrRegistro";
            Text = "Registro";
            FormClosing += FmrRegistro_FormClosing;
            Load += FmrRegistro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstRegistro;
        private Button btnAgregar;
        private Button btnModificar;
        private Button Eliminar;
        private Button btnGuardarDatos;
        private Button btnRecuperarDatos;
        private GroupBox groupBox1;
        private RadioButton BtnRadioEdadAsc;
        private Label label2;
        private Label label1;
        private RadioButton BtnRadioPartAsc;
        private RadioButton BtnRadioPartDesc;
        private RadioButton BtnRadioEdadDesc;
        private Button btnOrdenar;
        private Button btbUsuarios;
        private Label label3;
        private Label lblTiempo;
    }
}