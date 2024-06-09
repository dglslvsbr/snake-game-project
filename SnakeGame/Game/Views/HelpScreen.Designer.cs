namespace SnakeGame.Game.Views
{
    partial class HelpScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpScreen));
            Btn_Voltar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ImageFood = new PictureBox();
            ImageSnake = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ImageFood).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageSnake).BeginInit();
            SuspendLayout();
            // 
            // Btn_Voltar
            // 
            Btn_Voltar.BackColor = Color.Black;
            Btn_Voltar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Voltar.ForeColor = Color.White;
            Btn_Voltar.Location = new Point(110, 259);
            Btn_Voltar.Name = "Btn_Voltar";
            Btn_Voltar.Size = new Size(124, 40);
            Btn_Voltar.TabIndex = 3;
            Btn_Voltar.Text = "Voltar";
            Btn_Voltar.UseVisualStyleBackColor = false;
            Btn_Voltar.Click += Btn_Voltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 150);
            label1.Name = "label1";
            label1.Size = new Size(83, 16);
            label1.TabIndex = 4;
            label1.Text = "Movimentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(16, 176);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "W - Cima";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gold;
            label3.Location = new Point(16, 191);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "S - Baixo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(16, 206);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 7;
            label4.Text = "A - Esquerda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Gold;
            label5.Location = new Point(16, 221);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 8;
            label5.Text = "D - Direita";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(138, 150);
            label6.Name = "label6";
            label6.Size = new Size(66, 16);
            label6.TabIndex = 9;
            label6.Text = "Objetivos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Gold;
            label7.Location = new Point(138, 176);
            label7.Name = "label7";
            label7.Size = new Size(184, 15);
            label7.TabIndex = 10;
            label7.Text = "1. Não colidir com você mesmo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Black;
            label8.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Gold;
            label8.Location = new Point(138, 191);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 11;
            label8.Text = "2. Não sair do mapa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Black;
            label9.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Gold;
            label9.Location = new Point(138, 206);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 12;
            label9.Text = "3. Coma as frutas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Black;
            label10.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Gold;
            label10.Location = new Point(138, 221);
            label10.Name = "label10";
            label10.Size = new Size(116, 15);
            label10.TabIndex = 13;
            label10.Text = "4. Torne-se grande!";
            // 
            // ImageFood
            // 
            ImageFood.Image = (Image)resources.GetObject("ImageFood.Image");
            ImageFood.Location = new Point(83, 22);
            ImageFood.Name = "ImageFood";
            ImageFood.Size = new Size(55, 55);
            ImageFood.TabIndex = 14;
            ImageFood.TabStop = false;
            // 
            // ImageSnake
            // 
            ImageSnake.BackColor = Color.Black;
            ImageSnake.Image = (Image)resources.GetObject("ImageSnake.Image");
            ImageSnake.Location = new Point(133, 12);
            ImageSnake.Name = "ImageSnake";
            ImageSnake.Size = new Size(124, 131);
            ImageSnake.TabIndex = 15;
            ImageSnake.TabStop = false;
            // 
            // HelpScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(334, 311);
            Controls.Add(ImageSnake);
            Controls.Add(ImageFood);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Btn_Voltar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HelpScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Help Screen";
            ((System.ComponentModel.ISupportInitialize)ImageFood).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageSnake).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Voltar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox ImageFood;
        private PictureBox ImageSnake;
    }
}