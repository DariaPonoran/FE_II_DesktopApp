using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_II
{
    public partial class Form2 : Form
    {
        public static class CancelCard 
        { 

            public static string Card { get; set; }
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex_visa = new Regex("^4[0-9]{12}(?:[0-9]{3})?$");
            Regex regex_mastercard = new Regex("^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$");
            Regex regex_visa_mastercard = new Regex("^(?:4[0-9]{12}(?:[0-9]{3})?|5[1-5][0-9]{14})$");
            Regex regex = new Regex("^([A-Z][a-zA-Z]*)(?=.*[a-z])(?=[^!@#$%&*_+/'?~`,.^()=])");
            Regex regex_year1 = new Regex("^20[2-9]{1}[4-9]{1}$");
            Regex regex_year2 = new Regex("^[2-9]{1}[4-9]{1}$");
            Regex regex_month = new Regex("^(0[1-9]{1})|(1[0-2]{1})$");
            Regex regex_cvv = new Regex("^([0-9]{3})$");
            if (textBoxCardholderName.Text != string.Empty && textBoxCardMonth.Text != string.Empty && textBoxCardNumber.Text != string.Empty && textBoxCardYear.Text != string.Empty && textBoxCVV.Text != string.Empty)
            {
                if ((regex_visa.IsMatch(textBoxCardNumber.Text) || regex_visa_mastercard.IsMatch(textBoxCardNumber.Text) || regex_mastercard.IsMatch(textBoxCardNumber.Text)) && regex_cvv.IsMatch(textBoxCVV.Text) && regex_month.IsMatch(textBoxCardMonth.Text) && (regex_year1.IsMatch(textBoxCardYear.Text) || regex_year2.IsMatch(textBoxCardYear.Text)) && regex.IsMatch(textBoxCardholderName.Text))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please enter right values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void buttonCancel_Click(object sender, EventArgs e)
        {
            CancelCard.Card = "cancelled";
            this.Close();
        }
    }
}
