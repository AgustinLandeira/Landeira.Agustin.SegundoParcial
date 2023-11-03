namespace formulario_login_
{
    partial class FmrOpciones
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
            btnFutbolista = new Button();
            label1 = new Label();
            btnBasketbolista = new Button();
            btnBeisbolista = new Button();
            SuspendLayout();
            // 
            // btnFutbolista
            // 
            btnFutbolista.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFutbolista.Location = new Point(265, 146);
            btnFutbolista.Name = "btnFutbolista";
            btnFutbolista.Size = new Size(281, 29);
            btnFutbolista.TabIndex = 0;
            btnFutbolista.Text = "Jugador de futbol";
            btnFutbolista.UseVisualStyleBackColor = true;
            btnFutbolista.Click += btnFutbolista_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(149, 41);
            label1.Name = "label1";
            label1.Size = new Size(568, 40);
            label1.TabIndex = 1;
            label1.Text = "Tipo de jugador a agregar";
            // 
            // btnBasketbolista
            // 
            btnBasketbolista.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBasketbolista.Location = new Point(265, 222);
            btnBasketbolista.Name = "btnBasketbolista";
            btnBasketbolista.Size = new Size(281, 29);
            btnBasketbolista.TabIndex = 2;
            btnBasketbolista.Text = "Jugador de basket";
            btnBasketbolista.UseVisualStyleBackColor = true;
            btnBasketbolista.Click += btnBasketbolista_Click;
            // 
            // btnBeisbolista
            // 
            btnBeisbolista.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnBeisbolista.Location = new Point(265, 303);
            btnBeisbolista.Name = "btnBeisbolista";
            btnBeisbolista.Size = new Size(281, 26);
            btnBeisbolista.TabIndex = 3;
            btnBeisbolista.Text = "Jugador de beisbol";
            btnBeisbolista.UseVisualStyleBackColor = true;
            btnBeisbolista.Click += btnBeisbolista_Click;
            // 
            // FmrOpciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBeisbolista);
            Controls.Add(btnBasketbolista);
            Controls.Add(label1);
            Controls.Add(btnFutbolista);
            Name = "FmrOpciones";
            Text = "FmrOpciones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFutbolista;
        private Label label1;
        private Button btnBasketbolista;
        private Button btnBeisbolista;
    }
}