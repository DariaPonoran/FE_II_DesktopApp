using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_II
{
    public partial class SignUpControl : UserControl
    {
        public SignUpControl()
        {
            InitializeComponent();
        }
        private void alreadyHaveAccountSignUpButton_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            SignInControl signInControl1 = new SignInControl();
            parentForm.Controls.Add(signInControl1);
            signInControl1.Dock = DockStyle.Fill;
            signInControl1.BringToFront();
        }

        private void RegisterSignUpButton_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();
            Regex regex = new Regex ("^([A-Z][a-zA-Z]*)(?=.*[a-z])(?=[^!@#$%&*_+/'?~`,.^()=])");
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex regex_email = new Regex(strRegex, RegexOptions.IgnoreCase);
            string strRegexTel = @"(^[0-9]{10}$)";
            Regex regex_tel = new Regex(strRegexTel);
            Regex regex_pass = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@$/!%#_*?&])[A-Za-z\\d@$!/#%_*?&]{8,32}$");
            if (textBoxClientPrenume.Text != string.Empty && textBoxClientNumeFam.Text != string.Empty && textBoxClientEmail.Text != string.Empty && textBoxClientNrTel.Text != string.Empty && textBoxClientPass.Text != string.Empty && textBoxClientPassConf.Text != string.Empty && textBoxClientOras.Text != string.Empty)
            {
                if (regex.IsMatch(textBoxClientPrenume.Text) && regex.IsMatch(textBoxClientNumeFam.Text) && regex.IsMatch(textBoxClientOras.Text) && !regex.IsMatch(textBoxClientNrTel.Text) && regex_email.IsMatch(textBoxClientEmail.Text) && regex_tel.IsMatch(textBoxClientNrTel.Text) && regex_pass.IsMatch(textBoxClientPass.Text))
                {
                    if (textBoxClientPass.Text == textBoxClientPassConf.Text)
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Client WHERE email = '" + textBoxClientEmail.Text + "' OR telefon = '" + textBoxClientNrTel.Text + "' OR parola = '" + textBoxClientPass.Text + "'", myCon);
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
                            SqlCommand cmd1 = new SqlCommand("INSERT INTO [Client] (nume,prenume,email,telefon,oras,parola) Values ('" + textBoxClientNumeFam.Text + "','" + textBoxClientPrenume.Text + "','" + textBoxClientEmail.Text + "','" + textBoxClientNrTel.Text + "','" + textBoxClientOras.Text + "','" + textBoxClientPass.Text + "')", myCon);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
