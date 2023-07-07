namespace Game1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipTop1 = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.IBLScore = new System.Windows.Forms.Label();
            this.pipdown1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipTop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipdown1)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.InitialImage = null;
            this.bird.Location = new System.Drawing.Point(97, 308);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(126, 147);
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipTop1
            // 
            this.pipTop1.BackColor = System.Drawing.Color.Snow;
            this.pipTop1.Image = global::Game1.Properties.Resources.upperPipe;
            this.pipTop1.Location = new System.Drawing.Point(607, -108);
            this.pipTop1.Name = "pipTop1";
            this.pipTop1.Size = new System.Drawing.Size(51, 243);
            this.pipTop1.TabIndex = 2;
            this.pipTop1.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-100, 666);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1316, 113);
            this.ground.TabIndex = 5;
            this.ground.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // IBLScore
            // 
            this.IBLScore.AutoSize = true;
            this.IBLScore.BackColor = System.Drawing.Color.Chocolate;
            this.IBLScore.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IBLScore.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.IBLScore.Location = new System.Drawing.Point(12, 691);
            this.IBLScore.Name = "IBLScore";
            this.IBLScore.Size = new System.Drawing.Size(98, 32);
            this.IBLScore.TabIndex = 7;
            this.IBLScore.Text = "Score: 0";
            // 
            // pipdown1
            // 
            this.pipdown1.BackColor = System.Drawing.Color.Snow;
            this.pipdown1.Image = global::Game1.Properties.Resources.lowerPipe;
            this.pipdown1.Location = new System.Drawing.Point(607, 454);
            this.pipdown1.Name = "pipdown1";
            this.pipdown1.Size = new System.Drawing.Size(51, 288);
            this.pipdown1.TabIndex = 8;
            this.pipdown1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(951, 732);
            this.Controls.Add(this.IBLScore);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.pipdown1);
            this.Controls.Add(this.pipTop1);
            this.Name = "Form1";
            this.Text = "Flappy Aykhan";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipTop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipdown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox bird;
        private PictureBox pipTop1;
        private PictureBox ground;
        private System.Windows.Forms.Timer timer2;
        private Label IBLScore;
        private PictureBox pipdown1;
    }
}