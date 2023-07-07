namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Price_textBox.Enabled = false;
            Volume_textBox.Enabled = false;
        }
        private double OilPrice = 0;
        private double MealPrice = 0;

        private void Oil_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OilTotalPrice();
        }


        private void Volume_textBox_TextChanged(object sender, EventArgs e)
        {
            OilTotalPrice();
        }
        private void Price_textBox_TextChanged(object sender, EventArgs e) { 
            OilTotalPrice();
        }


        private void Volume_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            OilTotalPrice();
        }
        private void Price_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            OilTotalPrice();
        }



        private void DonerToyuq_checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            MealTotalprice_DonerToyuq();
        }
        private void DonerEt_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MealTotalprice_DonerEt();
        }
        private void Ayran_checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            MealTotalprice_Ayran();
        }
        private void CocaCola_checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            MealTotalprice_CocaCola();
        }



        private void totalprice_button_Click(object sender, EventArgs e)
        {
            TotalEndPrice_AZN_label.Text = (OilPrice + MealPrice).ToString();
        }

        // I accidentally created and can't delete
        private void MiniCafe_groupBox_Enter(object sender, EventArgs e)
        {
        }
    }
}


