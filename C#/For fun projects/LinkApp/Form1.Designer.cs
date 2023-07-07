namespace LinkApp
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
            this.link_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.link_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // link_button
            // 
            this.link_button.Location = new System.Drawing.Point(694, 149);
            this.link_button.Name = "link_button";
            this.link_button.Size = new System.Drawing.Size(94, 29);
            this.link_button.TabIndex = 0;
            this.link_button.Text = "Open Link";
            this.link_button.UseVisualStyleBackColor = true;
            this.link_button.Click += new System.EventHandler(this.link_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter link:";
            // 
            // link_textBox
            // 
            this.link_textBox.Location = new System.Drawing.Point(99, 151);
            this.link_textBox.Name = "link_textBox";
            this.link_textBox.Size = new System.Drawing.Size(568, 27);
            this.link_textBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.link_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.link_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button link_button;
        private Label label1;
        private TextBox link_textBox;
    }
}