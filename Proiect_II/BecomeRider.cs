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
    public partial class BecomeRider : UserControl
    {
        public BecomeRider()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void becomeRiderBtn_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\Sem II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();
            Regex regex = new Regex("^([A-Z][a-zA-Z]*)(?=.*[a-z])(?=[^!@#$%&*_+/'?~`,.^()=])");
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex regex_email = new Regex(strRegex, RegexOptions.IgnoreCase);
            string strRegexTel = @"(^[0-9]{10}$)";
            Regex regex_tel = new Regex(strRegexTel);
            if (textBoxCurierName.Text != string.Empty && textBoxCurierPrenume.Text != string.Empty && textBoxCurierEmail.Text != string.Empty && textBoxCurierPhoneNumber.Text != string.Empty && textBoxCurierCity.Text != string.Empty)
            {
                if (regex.IsMatch(textBoxCurierName.Text) && regex.IsMatch(textBoxCurierPrenume.Text) && regex.IsMatch(textBoxCurierCity.Text) && !regex.IsMatch(textBoxCurierPhoneNumber.Text) && regex_email.IsMatch(textBoxCurierEmail.Text) && regex_tel.IsMatch(textBoxCurierPhoneNumber.Text))
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Curier WHERE email = '" + textBoxCurierEmail.Text + "' OR telefon = '" + textBoxCurierPhoneNumber.Text + "'", myCon);
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
                        SqlCommand cmd1 = new SqlCommand("INSERT INTO [Curier] (nume,prenume,email,telefon,oras) Values ('" + textBoxCurierName.Text + "','" + textBoxCurierPrenume.Text + "','" + textBoxCurierEmail.Text + "','" + textBoxCurierPhoneNumber.Text + "','" + textBoxCurierCity.Text + "')", myCon);
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
