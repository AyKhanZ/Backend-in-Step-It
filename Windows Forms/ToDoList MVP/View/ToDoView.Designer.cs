namespace ToDoList
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.desc_textBox1 = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.IsImportant_checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.add_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.task_listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 450);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.desc_textBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.name_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.desc_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.IsImportant_checkBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.add_button, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.name_textBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(315, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // desc_textBox1
            // 
            this.desc_textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.desc_textBox1.Location = new System.Drawing.Point(160, 169);
            this.desc_textBox1.Name = "desc_textBox1";
            this.desc_textBox1.Size = new System.Drawing.Size(152, 27);
            this.desc_textBox1.TabIndex = 6;
            // 
            // name_label
            // 
            this.name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label.Location = new System.Drawing.Point(19, 45);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(118, 31);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Text name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // desc_label
            // 
            this.desc_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desc_label.AutoSize = true;
            this.desc_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.desc_label.Location = new System.Drawing.Point(13, 167);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(131, 31);
            this.desc_label.TabIndex = 1;
            this.desc_label.Text = "Description";
            this.desc_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IsImportant_checkBox1
            // 
            this.IsImportant_checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IsImportant_checkBox1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.IsImportant_checkBox1, 2);
            this.IsImportant_checkBox1.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsImportant_checkBox1.Location = new System.Drawing.Point(80, 266);
            this.IsImportant_checkBox1.Name = "IsImportant_checkBox1";
            this.IsImportant_checkBox1.Size = new System.Drawing.Size(155, 36);
            this.IsImportant_checkBox1.TabIndex = 2;
            this.IsImportant_checkBox1.Text = "Important";
            this.IsImportant_checkBox1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimePicker1, 2);
            this.dateTimePicker1.Location = new System.Drawing.Point(3, 345);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 27);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // add_button
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.add_button, 2);
            this.add_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_button.Location = new System.Drawing.Point(3, 397);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(309, 50);
            this.add_button.TabIndex = 4;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.add_button_MouseClick);
            // 
            // name_textBox
            // 
            this.name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.name_textBox.Location = new System.Drawing.Point(160, 47);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(152, 27);
            this.name_textBox.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.task_listBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(315, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 450);
            this.panel2.TabIndex = 1;
            // 
            // task_listBox1
            // 
            this.task_listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.task_listBox1.FormattingEnabled = true;
            this.task_listBox1.ItemHeight = 41;
            this.task_listBox1.Location = new System.Drawing.Point(0, 0);
            this.task_listBox1.Name = "task_listBox1";
            this.task_listBox1.Size = new System.Drawing.Size(729, 450);
            this.task_listBox1.TabIndex = 0;
            this.task_listBox1.SelectedIndexChanged += new System.EventHandler(this.task_listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Aykhan";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label name_label;
        private Label desc_label;
        private CheckBox IsImportant_checkBox1;
        private DateTimePicker dateTimePicker1;
        private Button add_button;
        private TextBox name_textBox;
        private ListBox task_listBox1;
        private TextBox desc_textBox1;
    }
}