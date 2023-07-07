using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private string? selectedState; 

        private Regex regex = new("[A-Z,a-z,!?]");

        public void OilTotalPrice()
        {
            selectedState = Oil_comboBox.SelectedItem?.ToString();
                 
            #region if list
            if (selectedState == "Ai-92")
            {
                OilPriceByOil_textBox.Text = "1.00";
            }
            else if (selectedState == "Premium")
            {
                OilPriceByOil_textBox.Text = "2.00";
            }
            else if (selectedState == "Dizel")
            {
                OilPriceByOil_textBox.Text = "0.80";
            }
            else if (selectedState == "Ai-95")
            {
                OilPriceByOil_textBox.Text = "0.90";
            }
            else if (selectedState == "Ai-98")
            {
                OilPriceByOil_textBox.Text = "1.20";
            }
            else if (selectedState == "Ai-100")
            {
                OilPriceByOil_textBox.Text = "1.30";
            }
            #endregion

            double _OilPrice = double.Parse(OilPriceByOil_textBox.Text); 
                if (Volume_radioButton.Checked)
                    {
                        Price_textBox.Text = "0.00";
                        Volume_textBox.Enabled = true;
                        Price_textBox.Enabled = false;

                    if (!regex.IsMatch(Volume_textBox.Text))
                    {
                        bool result;
                        result = Double.TryParse(Volume_textBox.Text, out OilPrice);
                        TotalOilPrice_AZN_label.Text = Math.Round((double)(OilPrice * _OilPrice), 2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error! No althabit !");
                    }
                }
                else if (Price_radioButton.Checked)
                {
                    Volume_textBox.Text = "0";
                    Price_textBox.Enabled = true;
                    Volume_textBox.Enabled = false;

                    if (!regex.IsMatch(Price_textBox.Text))
                    {
                        bool result;
                        result = Double.TryParse(Price_textBox.Text, out OilPrice);
                        TotalOilPrice_AZN_label.Text = OilPrice.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Error! No althabit !");
                    }
                }
        }


        public void MealTotalprice_DonerEt()
        {
            if (!regex.IsMatch(DonerEtCount_textBox.Text))
            {
                int count;
                Int32.TryParse(DonerEtCount_textBox.Text, out count);
                double price;
                double.TryParse(DonerEtPrice_textBox1.Text, out price);
                double result = count * price;
                if (DonerEt_checkBox1.Checked)
                {
                    MealPrice += Math.Round(result);
                }
                else
                {
                    if (MealPrice > 0) MealPrice -= Math.Round(result);
                }
                TotalMealPrice_label.Text = MealPrice.ToString();
            }
            else
            {
                MessageBox.Show("Error! No althabit !");
            }
            
        }
        public void MealTotalprice_DonerToyuq()
        {
            if (!regex.IsMatch(DonerTouyqCount_textBox2.Text))
            {
                int count;
                Int32.TryParse(DonerTouyqCount_textBox2.Text, out count);
                double price;
                double.TryParse(DonerToyuqPrice_textBox2.Text, out price);
                double result = count * price;
                if (DonerToyuq_checkBox2.Checked)
                {
                    MealPrice += Math.Round(result);
                }
                else
                {
                    if (MealPrice > 0) MealPrice -= Math.Round(result);
                }
                TotalMealPrice_label.Text = MealPrice.ToString();
            }
            else { 
                MessageBox.Show("Error! No althabit !");
            }
        }
        public void MealTotalprice_Ayran()
        {
            if (!regex.IsMatch(AyranCount_textBox3.Text))
            {
                int count;
                Int32.TryParse(AyranCount_textBox3.Text, out count);
                double price;
                double.TryParse(AyranPrice_textBox3.Text, out price);
                double result = count * price;
                if (Ayran_checkBox3.Checked)
                {
                    MealPrice += Math.Round(result);
                }
                else
                {
                    if (MealPrice > 0) MealPrice -= Math.Round(result);
                }
                TotalMealPrice_label.Text = MealPrice.ToString();

            }
            else
            {
                MessageBox.Show("Error! No althabit !");
            }
        }
        public void MealTotalprice_CocaCola()
        {
            if (!regex.IsMatch(CocaColaCount_textBox4.Text))
            {
                int count;
                Int32.TryParse(CocaColaCount_textBox4.Text, out count);
                double price;
                double.TryParse(CocaColaPrice_textBox4.Text, out price);
                double result = count * price;
                if (CocaCola_checkBox4.Checked)
                {
                    MealPrice += Math.Round(result);
                }
                else 
                {
                    if (MealPrice > 0) MealPrice -= Math.Round(result);
                }
                TotalMealPrice_label.Text = MealPrice.ToString();
            }
            else
            {
                MessageBox.Show("Error! No althabit !");
            }
        }

    }
}
