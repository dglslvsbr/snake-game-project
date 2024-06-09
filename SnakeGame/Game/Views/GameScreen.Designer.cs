namespace SnakeGame.Game.Views
{
    partial class GameScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            Map = new PictureBox();
            CountFood = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Map).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Map
            // 
            Map.BackColor = Color.Black;
            Map.Location = new Point(2, 40);
            Map.Name = "Map";
            Map.Size = new Size(329, 268);
            Map.TabIndex = 0;
            Map.TabStop = false;
            // 
            // CountFood
            // 
            CountFood.AutoSize = true;
            CountFood.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CountFood.ForeColor = Color.White;
            CountFood.Location = new Point(178, 8);
            CountFood.Name = "CountFood";
            CountFood.Size = new Size(26, 29);
            CountFood.TabIndex = 2;
            CountFood.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 34);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // GameScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(334, 311);
            Controls.Add(pictureBox1);
            Controls.Add(CountFood);
            Controls.Add(Map);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GameScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game Screen";
            ((System.ComponentModel.ISupportInitialize)Map).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Map;
        private Label CountFood;
        private PictureBox pictureBox1;
    }
}