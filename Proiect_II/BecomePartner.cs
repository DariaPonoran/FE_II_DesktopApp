using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_II
{
    public partial class BecomePartner : UserControl
    {
        public BecomePartner()
        {
            InitializeComponent();
        }

        private void buttonAddPartner_Click(object sender, EventArgs e)
        {

            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();
            Regex regex = new Regex("^([A-Z][a-zA-Z]*)(?=.*[a-z])(?=[^!@#$%&*_+/'?~`,.^()=])");
            string strCompRegex = @"(^[a-zA-Z0-9& ]*$)";
            Regex regex_company = new Regex(strCompRegex, RegexOptions.IgnoreCase);
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex regex_email = new Regex(strRegex, RegexOptions.IgnoreCase);
            string strRegexTel = @"(^[0-9]{10}$)";
            Regex regex_tel = new Regex(strRegexTel);
            Regex regex_pass = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@$/!%#_*?&])[A-Za-z\\d@$!/#%_*?&]{8,32}$");
            if (textBoxRestaurantName.Text != string.Empty && textBoxRestaurantEmail.Text != string.Empty && textBoxRestaurantPhoneNumber.Text != string.Empty && textBoxPersonName.Text != string.Empty && textBoxRestaurantCity.Text != string.Empty && textBoxRestaurantAdress.Text != string.Empty)
            {
                if(regex_company.IsMatch(textBoxRestaurantName.Text) && regex.IsMatch(textBoxRestaurantCity.Text) && regex.IsMatch(textBoxPersonName.Text) && regex_email.IsMatch(textBoxRestaurantEmail.Text) && regex_tel.IsMatch(textBoxRestaurantPhoneNumber.Text))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Restaurant WHERE email = '" + textBoxRestaurantEmail.Text + "' OR telefon = '" + textBoxRestaurantPhoneNumber.Text + "'", myCon);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Email address or/and phone number is already in use ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        SqlCommand cmd1 = new SqlCommand("INSERT INTO [Restaurant] (nume,adresa,telefon,oras,nume_contact,email) Values ('" + textBoxRestaurantName.Text + "','" + textBoxRestaurantAdress.Text + "','" + textBoxRestaurantPhoneNumber.Text + "','" + textBoxRestaurantCity.Text + "','" + textBoxPersonName.Text + "','" + textBoxRestaurantEmail.Text +"')", myCon);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("You are part of our team now", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
    }
}
