namespace SnakeGame
{
    partial class HomeScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            ImageSnake = new PictureBox();
            ImageFood = new PictureBox();
            Btn_Jogar = new Button();
            Btn_Help = new Button();
            ((System.ComponentModel.ISupportInitialize)ImageSnake).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageFood).BeginInit();
            SuspendLayout();
            // 
            // ImageSnake
            // 
            ImageSnake.Image = (Image)resources.GetObject("ImageSnake.Image");
            ImageSnake.Location = new Point(112, 12);
            ImageSnake.Name = "ImageSnake";
            ImageSnake.Size = new Size(124, 131);
            ImageSnake.TabIndex = 0;
            ImageSnake.TabStop = false;
            // 
            // ImageFood
            // 
            ImageFood.Image = (Image)resources.GetObject("ImageFood.Image");
            ImageFood.Location = new Point(74, 12);
            ImageFood.Name = "ImageFood";
            ImageFood.Size = new Size(55, 55);
            ImageFood.TabIndex = 1;
            ImageFood.TabStop = false;
            // 
            // Btn_Jogar
            // 
            Btn_Jogar.BackColor = Color.Black;
            Btn_Jogar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Jogar.ForeColor = Color.White;
            Btn_Jogar.Location = new Point(112, 182);
            Btn_Jogar.Name = "Btn_Jogar";
            Btn_Jogar.Size = new Size(124, 40);
            Btn_Jogar.TabIndex = 2;
            Btn_Jogar.Text = "Jogar";
            Btn_Jogar.UseVisualStyleBackColor = false;
            Btn_Jogar.Click += Btn_Jogar_Click;
            // 
            // Btn_Help
            // 
            Btn_Help.BackColor = Color.Black;
            Btn_Help.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Help.ForeColor = Color.White;
            Btn_Help.Location = new Point(112, 228);
            Btn_Help.Name = "Btn_Help";
            Btn_Help.Size = new Size(124, 40);
            Btn_Help.TabIndex = 3;
            Btn_Help.Text = "Como Jogar";
            Btn_Help.UseVisualStyleBackColor = false;
            Btn_Help.Click += Btn_Help_Click;
            // 
            // HomeScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(334, 311);
            Controls.Add(Btn_Help);
            Controls.Add(Btn_Jogar);
            Controls.Add(ImageFood);
            Controls.Add(ImageSnake);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "HomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Screen";
            ((System.ComponentModel.ISupportInitialize)ImageSnake).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageFood).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ImageSnake;
        private PictureBox ImageFood;
        private Button Btn_Jogar;
        private Button Btn_Help;
    }
}
