namespace WinFormsApp1
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
            this.PetrolStation_groupBox = new System.Windows.Forms.GroupBox();
            this.OilPriceByOil_textBox = new System.Windows.Forms.TextBox();
            this.Volume_textBox = new System.Windows.Forms.TextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.AZN_label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AZN_label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Price_radioButton = new System.Windows.Forms.RadioButton();
            this.Volume_radioButton = new System.Windows.Forms.RadioButton();
            this.Price_label = new System.Windows.Forms.Label();
            this.Oil_label = new System.Windows.Forms.Label();
            this.TotalOilPrice_groupBox = new System.Windows.Forms.GroupBox();
            this.TotalOilPrice_AZN_label = new System.Windows.Forms.Label();
            this.TotalOilPriceAZN_label3 = new System.Windows.Forms.Label();
            this.Oil_comboBox = new System.Windows.Forms.ComboBox();
            this.MiniCafe_groupBox = new System.Windows.Forms.GroupBox();
            this.CocaColaCount_textBox4 = new System.Windows.Forms.TextBox();
            this.AyranCount_textBox3 = new System.Windows.Forms.TextBox();
            this.DonerTouyqCount_textBox2 = new System.Windows.Forms.TextBox();
            this.DonerEtCount_textBox = new System.Windows.Forms.TextBox();
            this.CocaColaPrice_textBox4 = new System.Windows.Forms.TextBox();
            this.AyranPrice_textBox3 = new System.Windows.Forms.TextBox();
            this.DonerToyuqPrice_textBox2 = new System.Windows.Forms.TextBox();
            this.DonerEtPrice_textBox1 = new System.Windows.Forms.TextBox();
            this.CocaCola_checkBox4 = new System.Windows.Forms.CheckBox();
            this.Ayran_checkBox3 = new System.Windows.Forms.CheckBox();
            this.DonerToyuq_checkBox2 = new System.Windows.Forms.CheckBox();
            this.PriceMiniCafe_label = new System.Windows.Forms.Label();
            this.Count_label = new System.Windows.Forms.Label();
            this.DonerEt_checkBox1 = new System.Windows.Forms.CheckBox();
            this.TotalMealPrice_groupBox = new System.Windows.Forms.GroupBox();
            this.TotalMealPrice_label = new System.Windows.Forms.Label();
            this.TotalMealPriceAZN_label4 = new System.Windows.Forms.Label();
            this.Totalprice_groupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TotalEndPrice_AZN_label = new System.Windows.Forms.Label();
            this.TotalEndPriceAZN_label = new System.Windows.Forms.Label();
            this.totalprice_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PetrolStation_groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TotalOilPrice_groupBox.SuspendLayout();
            this.MiniCafe_groupBox.SuspendLayout();
            this.TotalMealPrice_groupBox.SuspendLayout();
            this.Totalprice_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PetrolStation_groupBox
            // 
            this.PetrolStation_groupBox.Controls.Add(this.OilPriceByOil_textBox);
            this.PetrolStation_groupBox.Controls.Add(this.Volume_textBox);
            this.PetrolStation_groupBox.Controls.Add(this.Price_textBox);
            this.PetrolStation_groupBox.Controls.Add(this.AZN_label2);
            this.PetrolStation_groupBox.Controls.Add(this.label1);
            this.PetrolStation_groupBox.Controls.Add(this.AZN_label1);
            this.PetrolStation_groupBox.Controls.Add(this.panel1);
            this.PetrolStation_groupBox.Controls.Add(this.Price_label);
            this.PetrolStation_groupBox.Controls.Add(this.Oil_label);
            this.PetrolStation_groupBox.Controls.Add(this.TotalOilPrice_groupBox);
            this.PetrolStation_groupBox.Controls.Add(this.Oil_comboBox);
            this.PetrolStation_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PetrolStation_groupBox.Location = new System.Drawing.Point(3, 3);
            this.PetrolStation_groupBox.Name = "PetrolStation_groupBox";
            this.PetrolStation_groupBox.Size = new System.Drawing.Size(391, 368);
            this.PetrolStation_groupBox.TabIndex = 0;
            this.PetrolStation_groupBox.TabStop = false;
            this.PetrolStation_groupBox.Text = "Petrol station";
            // 
            // OilPriceByOil_textBox
            // 
            this.OilPriceByOil_textBox.BackColor = System.Drawing.SystemColors.Info;
            this.OilPriceByOil_textBox.Enabled = false;
            this.OilPriceByOil_textBox.Location = new System.Drawing.Point(135, 86);
            this.OilPriceByOil_textBox.Name = "OilPriceByOil_textBox";
            this.OilPriceByOil_textBox.Size = new System.Drawing.Size(151, 27);
            this.OilPriceByOil_textBox.TabIndex = 17;
            this.OilPriceByOil_textBox.Text = "1,00";
            // 
            // Volume_textBox
            // 
            this.Volume_textBox.Location = new System.Drawing.Point(193, 143);
            this.Volume_textBox.Name = "Volume_textBox";
            this.Volume_textBox.Size = new System.Drawing.Size(84, 27);
            this.Volume_textBox.TabIndex = 16;
            this.Volume_textBox.Text = "0";
            this.Volume_textBox.TextChanged += new System.EventHandler(this.Volume_textBox_TextChanged);
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(193, 176);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(84, 27);
            this.Price_textBox.TabIndex = 12;
            this.Price_textBox.Text = "0.00";
            this.Price_textBox.TextChanged += new System.EventHandler(this.Price_textBox_TextChanged);
            // 
            // AZN_label2
            // 
            this.AZN_label2.AutoSize = true;
            this.AZN_label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AZN_label2.Location = new System.Drawing.Point(289, 179);
            this.AZN_label2.Name = "AZN_label2";
            this.AZN_label2.Size = new System.Drawing.Size(46, 20);
            this.AZN_label2.TabIndex = 9;
            this.AZN_label2.Text = "AZN .";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(289, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "L .";
            // 
            // AZN_label1
            // 
            this.AZN_label1.AutoSize = true;
            this.AZN_label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AZN_label1.Location = new System.Drawing.Point(289, 86);
            this.AZN_label1.Name = "AZN_label1";
            this.AZN_label1.Size = new System.Drawing.Size(46, 20);
            this.AZN_label1.TabIndex = 7;
            this.AZN_label1.Text = "AZN .";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Price_radioButton);
            this.panel1.Controls.Add(this.Volume_radioButton);
            this.panel1.Location = new System.Drawing.Point(21, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 56);
            this.panel1.TabIndex = 6;
            // 
            // Price_radioButton
            // 
            this.Price_radioButton.AutoSize = true;
            this.Price_radioButton.Location = new System.Drawing.Point(12, 29);
            this.Price_radioButton.Name = "Price_radioButton";
            this.Price_radioButton.Size = new System.Drawing.Size(62, 24);
            this.Price_radioButton.TabIndex = 6;
            this.Price_radioButton.TabStop = true;
            this.Price_radioButton.Text = "Price";
            this.Price_radioButton.UseVisualStyleBackColor = true;
            this.Price_radioButton.CheckedChanged += new System.EventHandler(this.Price_radioButton_CheckedChanged);
            // 
            // Volume_radioButton
            // 
            this.Volume_radioButton.AutoSize = true;
            this.Volume_radioButton.Location = new System.Drawing.Point(12, 3);
            this.Volume_radioButton.Name = "Volume_radioButton";
            this.Volume_radioButton.Size = new System.Drawing.Size(80, 24);
            this.Volume_radioButton.TabIndex = 5;
            this.Volume_radioButton.TabStop = true;
            this.Volume_radioButton.Text = "Volume";
            this.Volume_radioButton.UseVisualStyleBackColor = true;
            this.Volume_radioButton.CheckedChanged += new System.EventHandler(this.Volume_radioButton_CheckedChanged);
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price_label.Location = new System.Drawing.Point(33, 86);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(41, 20);
            this.Price_label.TabIndex = 5;
            this.Price_label.Text = "Price";
            // 
            // Oil_label
            // 
            this.Oil_label.AutoSize = true;
            this.Oil_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Oil_label.Location = new System.Drawing.Point(33, 38);
            this.Oil_label.Name = "Oil_label";
            this.Oil_label.Size = new System.Drawing.Size(28, 20);
            this.Oil_label.TabIndex = 4;
            this.Oil_label.Text = "Oil";
            // 
            // TotalOilPrice_groupBox
            // 
            this.TotalOilPrice_groupBox.Controls.Add(this.TotalOilPrice_AZN_label);
            this.TotalOilPrice_groupBox.Controls.Add(this.TotalOilPriceAZN_label3);
            this.TotalOilPrice_groupBox.Location = new System.Drawing.Point(21, 217);
            this.TotalOilPrice_groupBox.Name = "TotalOilPrice_groupBox";
            this.TotalOilPrice_groupBox.Size = new System.Drawing.Size(309, 106);
            this.TotalOilPrice_groupBox.TabIndex = 3;
            this.TotalOilPrice_groupBox.TabStop = false;
            this.TotalOilPrice_groupBox.Text = "Total oil price";
            // 
            // TotalOilPrice_AZN_label
            // 
            this.TotalOilPrice_AZN_label.AutoSize = true;
            this.TotalOilPrice_AZN_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalOilPrice_AZN_label.Location = new System.Drawing.Point(91, 36);
            this.TotalOilPrice_AZN_label.Name = "TotalOilPrice_AZN_label";
            this.TotalOilPrice_AZN_label.Size = new System.Drawing.Size(81, 46);
            this.TotalOilPrice_AZN_label.TabIndex = 11;
            this.TotalOilPrice_AZN_label.Text = "0,00";
            // 
            // TotalOilPriceAZN_label3
            // 
            this.TotalOilPriceAZN_label3.AutoSize = true;
            this.TotalOilPriceAZN_label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalOilPriceAZN_label3.Location = new System.Drawing.Point(231, 62);
            this.TotalOilPriceAZN_label3.Name = "TotalOilPriceAZN_label3";
            this.TotalOilPriceAZN_label3.Size = new System.Drawing.Size(46, 20);
            this.TotalOilPriceAZN_label3.TabIndex = 10;
            this.TotalOilPriceAZN_label3.Text = "AZN .";
            // 
            // Oil_comboBox
            // 
            this.Oil_comboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Oil_comboBox.FormattingEnabled = true;
            this.Oil_comboBox.Items.AddRange(new object[] {
            "Ai-92",
            "Ai-95",
            "Ai-98",
            "Ai-100",
            "Dizel",
            "Premium"});
            this.Oil_comboBox.Location = new System.Drawing.Point(135, 38);
            this.Oil_comboBox.Name = "Oil_comboBox";
            this.Oil_comboBox.Size = new System.Drawing.Size(151, 28);
            this.Oil_comboBox.TabIndex = 0;
            this.Oil_comboBox.Text = "Ai-92";
            this.Oil_comboBox.SelectedIndexChanged += new System.EventHandler(this.Oil_comboBox_SelectedIndexChanged);
            // 
            // MiniCafe_groupBox
            // 
            this.MiniCafe_groupBox.Controls.Add(this.CocaColaCount_textBox4);
            this.MiniCafe_groupBox.Controls.Add(this.AyranCount_textBox3);
            this.MiniCafe_groupBox.Controls.Add(this.DonerTouyqCount_textBox2);
            this.MiniCafe_groupBox.Controls.Add(this.DonerEtCount_textBox);
            this.MiniCafe_groupBox.Controls.Add(this.CocaColaPrice_textBox4);
            this.MiniCafe_groupBox.Controls.Add(this.AyranPrice_textBox3);
            this.MiniCafe_groupBox.Controls.Add(this.DonerToyuqPrice_textBox2);
            this.MiniCafe_groupBox.Controls.Add(this.DonerEtPrice_textBox1);
            this.MiniCafe_groupBox.Controls.Add(this.CocaCola_checkBox4);
            this.MiniCafe_groupBox.Controls.Add(this.Ayran_checkBox3);
            this.MiniCafe_groupBox.Controls.Add(this.DonerToyuq_checkBox2);
            this.MiniCafe_groupBox.Controls.Add(this.PriceMiniCafe_label);
            this.MiniCafe_groupBox.Controls.Add(this.Count_label);
            this.MiniCafe_groupBox.Controls.Add(this.DonerEt_checkBox1);
            this.MiniCafe_groupBox.Controls.Add(this.TotalMealPrice_groupBox);
            this.MiniCafe_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MiniCafe_groupBox.Location = new System.Drawing.Point(400, 3);
            this.MiniCafe_groupBox.Name = "MiniCafe_groupBox";
            this.MiniCafe_groupBox.Size = new System.Drawing.Size(391, 368);
            this.MiniCafe_groupBox.TabIndex = 1;
            this.MiniCafe_groupBox.TabStop = false;
            this.MiniCafe_groupBox.Text = "Mini-Cafe";
            // 
            // CocaColaCount_textBox4
            // 
            this.CocaColaCount_textBox4.Location = new System.Drawing.Point(293, 155);
            this.CocaColaCount_textBox4.Name = "CocaColaCount_textBox4";
            this.CocaColaCount_textBox4.Size = new System.Drawing.Size(54, 27);
            this.CocaColaCount_textBox4.TabIndex = 18;
            this.CocaColaCount_textBox4.TextChanged += new System.EventHandler(this.CocaCola_checkBox4_CheckedChanged);
            // 
            // AyranCount_textBox3
            // 
            this.AyranCount_textBox3.Location = new System.Drawing.Point(293, 122);
            this.AyranCount_textBox3.Name = "AyranCount_textBox3";
            this.AyranCount_textBox3.Size = new System.Drawing.Size(54, 27);
            this.AyranCount_textBox3.TabIndex = 17;
            this.AyranCount_textBox3.TextChanged += new System.EventHandler(this.Ayran_checkBox3_CheckedChanged);
            // 
            // DonerTouyqCount_textBox2
            // 
            this.DonerTouyqCount_textBox2.Location = new System.Drawing.Point(293, 89);
            this.DonerTouyqCount_textBox2.Name = "DonerTouyqCount_textBox2";
            this.DonerTouyqCount_textBox2.Size = new System.Drawing.Size(54, 27);
            this.DonerTouyqCount_textBox2.TabIndex = 16;
            this.DonerTouyqCount_textBox2.TextChanged += new System.EventHandler(this.DonerToyuq_checkBox2_CheckedChanged);
            // 
            // DonerEtCount_textBox
            // 
            this.DonerEtCount_textBox.Location = new System.Drawing.Point(293, 56);
            this.DonerEtCount_textBox.Name = "DonerEtCount_textBox";
            this.DonerEtCount_textBox.Size = new System.Drawing.Size(54, 27);
            this.DonerEtCount_textBox.TabIndex = 15;
            this.DonerEtCount_textBox.TextChanged += new System.EventHandler(this.DonerEt_checkBox1_CheckedChanged);
            // 
            // CocaColaPrice_textBox4
            // 
            this.CocaColaPrice_textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.CocaColaPrice_textBox4.Enabled = false;
            this.CocaColaPrice_textBox4.Location = new System.Drawing.Point(217, 155);
            this.CocaColaPrice_textBox4.Name = "CocaColaPrice_textBox4";
            this.CocaColaPrice_textBox4.Size = new System.Drawing.Size(54, 27);
            this.CocaColaPrice_textBox4.TabIndex = 14;
            this.CocaColaPrice_textBox4.Text = "3.00";
            // 
            // AyranPrice_textBox3
            // 
            this.AyranPrice_textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.AyranPrice_textBox3.Enabled = false;
            this.AyranPrice_textBox3.Location = new System.Drawing.Point(217, 122);
            this.AyranPrice_textBox3.Name = "AyranPrice_textBox3";
            this.AyranPrice_textBox3.Size = new System.Drawing.Size(54, 27);
            this.AyranPrice_textBox3.TabIndex = 13;
            this.AyranPrice_textBox3.Text = "2.00";
            // 
            // DonerToyuqPrice_textBox2
            // 
            this.DonerToyuqPrice_textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.DonerToyuqPrice_textBox2.Enabled = false;
            this.DonerToyuqPrice_textBox2.Location = new System.Drawing.Point(217, 89);
            this.DonerToyuqPrice_textBox2.Name = "DonerToyuqPrice_textBox2";
            this.DonerToyuqPrice_textBox2.Size = new System.Drawing.Size(54, 27);
            this.DonerToyuqPrice_textBox2.TabIndex = 12;
            this.DonerToyuqPrice_textBox2.Text = "5.00";
            // 
            // DonerEtPrice_textBox1
            // 
            this.DonerEtPrice_textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.DonerEtPrice_textBox1.Enabled = false;
            this.DonerEtPrice_textBox1.Location = new System.Drawing.Point(217, 56);
            this.DonerEtPrice_textBox1.Name = "DonerEtPrice_textBox1";
            this.DonerEtPrice_textBox1.Size = new System.Drawing.Size(54, 27);
            this.DonerEtPrice_textBox1.TabIndex = 11;
            this.DonerEtPrice_textBox1.Text = "7.00";
            // 
            // CocaCola_checkBox4
            // 
            this.CocaCola_checkBox4.AutoSize = true;
            this.CocaCola_checkBox4.Location = new System.Drawing.Point(21, 158);
            this.CocaCola_checkBox4.Name = "CocaCola_checkBox4";
            this.CocaCola_checkBox4.Size = new System.Drawing.Size(100, 24);
            this.CocaCola_checkBox4.TabIndex = 10;
            this.CocaCola_checkBox4.Text = "Coca-Cola";
            this.CocaCola_checkBox4.UseVisualStyleBackColor = true;
            this.CocaCola_checkBox4.CheckedChanged += new System.EventHandler(this.CocaCola_checkBox4_CheckedChanged);
            // 
            // Ayran_checkBox3
            // 
            this.Ayran_checkBox3.AutoSize = true;
            this.Ayran_checkBox3.Location = new System.Drawing.Point(21, 125);
            this.Ayran_checkBox3.Name = "Ayran_checkBox3";
            this.Ayran_checkBox3.Size = new System.Drawing.Size(69, 24);
            this.Ayran_checkBox3.TabIndex = 9;
            this.Ayran_checkBox3.Text = "Ayran";
            this.Ayran_checkBox3.UseVisualStyleBackColor = true;
            this.Ayran_checkBox3.CheckedChanged += new System.EventHandler(this.Ayran_checkBox3_CheckedChanged);
            // 
            // DonerToyuq_checkBox2
            // 
            this.DonerToyuq_checkBox2.AutoSize = true;
            this.DonerToyuq_checkBox2.Location = new System.Drawing.Point(21, 92);
            this.DonerToyuq_checkBox2.Name = "DonerToyuq_checkBox2";
            this.DonerToyuq_checkBox2.Size = new System.Drawing.Size(114, 24);
            this.DonerToyuq_checkBox2.TabIndex = 8;
            this.DonerToyuq_checkBox2.Text = "Doner touyq";
            this.DonerToyuq_checkBox2.UseVisualStyleBackColor = true;
            this.DonerToyuq_checkBox2.CheckedChanged += new System.EventHandler(this.DonerToyuq_checkBox2_CheckedChanged);
            // 
            // PriceMiniCafe_label
            // 
            this.PriceMiniCafe_label.AutoSize = true;
            this.PriceMiniCafe_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriceMiniCafe_label.Location = new System.Drawing.Point(230, 23);
            this.PriceMiniCafe_label.Name = "PriceMiniCafe_label";
            this.PriceMiniCafe_label.Size = new System.Drawing.Size(41, 20);
            this.PriceMiniCafe_label.TabIndex = 7;
            this.PriceMiniCafe_label.Text = "Price";
            // 
            // Count_label
            // 
            this.Count_label.AutoSize = true;
            this.Count_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Count_label.Location = new System.Drawing.Point(299, 23);
            this.Count_label.Name = "Count_label";
            this.Count_label.Size = new System.Drawing.Size(48, 20);
            this.Count_label.TabIndex = 6;
            this.Count_label.Text = "Count";
            // 
            // DonerEt_checkBox1
            // 
            this.DonerEt_checkBox1.AutoSize = true;
            this.DonerEt_checkBox1.Location = new System.Drawing.Point(21, 59);
            this.DonerEt_checkBox1.Name = "DonerEt_checkBox1";
            this.DonerEt_checkBox1.Size = new System.Drawing.Size(89, 24);
            this.DonerEt_checkBox1.TabIndex = 5;
            this.DonerEt_checkBox1.Text = "Doner et";
            this.DonerEt_checkBox1.UseVisualStyleBackColor = true;
            this.DonerEt_checkBox1.CheckedChanged += new System.EventHandler(this.DonerEt_checkBox1_CheckedChanged);
            // 
            // TotalMealPrice_groupBox
            // 
            this.TotalMealPrice_groupBox.Controls.Add(this.TotalMealPrice_label);
            this.TotalMealPrice_groupBox.Controls.Add(this.TotalMealPriceAZN_label4);
            this.TotalMealPrice_groupBox.Location = new System.Drawing.Point(21, 217);
            this.TotalMealPrice_groupBox.Name = "TotalMealPrice_groupBox";
            this.TotalMealPrice_groupBox.Size = new System.Drawing.Size(309, 106);
            this.TotalMealPrice_groupBox.TabIndex = 4;
            this.TotalMealPrice_groupBox.TabStop = false;
            this.TotalMealPrice_groupBox.Text = "Total meal price";
            // 
            // TotalMealPrice_label
            // 
            this.TotalMealPrice_label.AutoSize = true;
            this.TotalMealPrice_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalMealPrice_label.Location = new System.Drawing.Point(90, 36);
            this.TotalMealPrice_label.Name = "TotalMealPrice_label";
            this.TotalMealPrice_label.Size = new System.Drawing.Size(81, 46);
            this.TotalMealPrice_label.TabIndex = 12;
            this.TotalMealPrice_label.Text = "0,00";
            // 
            // TotalMealPriceAZN_label4
            // 
            this.TotalMealPriceAZN_label4.AutoSize = true;
            this.TotalMealPriceAZN_label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalMealPriceAZN_label4.Location = new System.Drawing.Point(224, 62);
            this.TotalMealPriceAZN_label4.Name = "TotalMealPriceAZN_label4";
            this.TotalMealPriceAZN_label4.Size = new System.Drawing.Size(46, 20);
            this.TotalMealPriceAZN_label4.TabIndex = 10;
            this.TotalMealPriceAZN_label4.Text = "AZN .";
            // 
            // Totalprice_groupBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Totalprice_groupBox, 2);
            this.Totalprice_groupBox.Controls.Add(this.pictureBox1);
            this.Totalprice_groupBox.Controls.Add(this.TotalEndPrice_AZN_label);
            this.Totalprice_groupBox.Controls.Add(this.TotalEndPriceAZN_label);
            this.Totalprice_groupBox.Controls.Add(this.totalprice_button);
            this.Totalprice_groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Totalprice_groupBox.Location = new System.Drawing.Point(3, 377);
            this.Totalprice_groupBox.Name = "Totalprice_groupBox";
            this.Totalprice_groupBox.Size = new System.Drawing.Size(788, 152);
            this.Totalprice_groupBox.TabIndex = 2;
            this.Totalprice_groupBox.TabStop = false;
            this.Totalprice_groupBox.Text = "Total price";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\Ayxan@s fotos\\Личные\\1x\\Asset 3.png";
            this.pictureBox1.Location = new System.Drawing.Point(20, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 75);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // TotalEndPrice_AZN_label
            // 
            this.TotalEndPrice_AZN_label.AutoSize = true;
            this.TotalEndPrice_AZN_label.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalEndPrice_AZN_label.Location = new System.Drawing.Point(426, 58);
            this.TotalEndPrice_AZN_label.Name = "TotalEndPrice_AZN_label";
            this.TotalEndPrice_AZN_label.Size = new System.Drawing.Size(121, 67);
            this.TotalEndPrice_AZN_label.TabIndex = 12;
            this.TotalEndPrice_AZN_label.Text = "0,00";
            // 
            // TotalEndPriceAZN_label
            // 
            this.TotalEndPriceAZN_label.AutoSize = true;
            this.TotalEndPriceAZN_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalEndPriceAZN_label.Location = new System.Drawing.Point(626, 97);
            this.TotalEndPriceAZN_label.Name = "TotalEndPriceAZN_label";
            this.TotalEndPriceAZN_label.Size = new System.Drawing.Size(61, 28);
            this.TotalEndPriceAZN_label.TabIndex = 11;
            this.TotalEndPriceAZN_label.Text = "AZN .";
            // 
            // totalprice_button
            // 
            this.totalprice_button.BackColor = System.Drawing.Color.Chartreuse;
            this.totalprice_button.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalprice_button.ForeColor = System.Drawing.Color.Black;
            this.totalprice_button.Location = new System.Drawing.Point(155, 37);
            this.totalprice_button.Name = "totalprice_button";
            this.totalprice_button.Size = new System.Drawing.Size(218, 75);
            this.totalprice_button.TabIndex = 0;
            this.totalprice_button.Text = "Price";
            this.totalprice_button.UseVisualStyleBackColor = false;
            this.totalprice_button.Click += new System.EventHandler(this.totalprice_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.MiniCafe_groupBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Totalprice_groupBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PetrolStation_groupBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.30075F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.69925F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 532);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 532);
            this.panel3.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(794, 532);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Aykhan Petrol Station";
            this.PetrolStation_groupBox.ResumeLayout(false);
            this.PetrolStation_groupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TotalOilPrice_groupBox.ResumeLayout(false);
            this.TotalOilPrice_groupBox.PerformLayout();
            this.MiniCafe_groupBox.ResumeLayout(false);
            this.MiniCafe_groupBox.PerformLayout();
            this.TotalMealPrice_groupBox.ResumeLayout(false);
            this.TotalMealPrice_groupBox.PerformLayout();
            this.Totalprice_groupBox.ResumeLayout(false);
            this.Totalprice_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox PetrolStation_groupBox;
        private ComboBox Oil_comboBox;
        private GroupBox MiniCafe_groupBox;
        private GroupBox Totalprice_groupBox;
        private Label AZN_label2;
        private Label label1;
        private Label AZN_label1;
        private Panel panel1;
        private RadioButton Price_radioButton;
        private RadioButton Volume_radioButton;
        private Label Price_label;
        private Label Oil_label;
        private GroupBox TotalOilPrice_groupBox;
        private Label TotalOilPriceAZN_label3;
        private TextBox DonerEtPrice_textBox1;
        private CheckBox CocaCola_checkBox4;
        private CheckBox Ayran_checkBox3;
        private CheckBox DonerToyuq_checkBox2;
        private Label PriceMiniCafe_label;
        private Label Count_label;
        private CheckBox DonerEt_checkBox1;
        private GroupBox TotalMealPrice_groupBox;
        private Label TotalMealPriceAZN_label4;
        private Button totalprice_button;
        private TextBox DonerToyuqPrice_textBox2;
        private TextBox CocaColaPrice_textBox4;
        private TextBox AyranPrice_textBox3;
        private TextBox CocaColaCount_textBox4;
        private TextBox AyranCount_textBox3;
        private TextBox DonerTouyqCount_textBox2;
        private TextBox DonerEtCount_textBox;
        private TextBox OilPriceByOil_textBox;
        private TextBox Volume_textBox;
        private TextBox Price_textBox;
        private Label TotalOilPrice_AZN_label;
        private Label TotalEndPriceAZN_label;
        private Label TotalMealPrice_label;
        private Label TotalEndPrice_AZN_label;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
    }
}