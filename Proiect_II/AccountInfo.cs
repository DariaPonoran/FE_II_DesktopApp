using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proiect_II.Form1;

namespace Proiect_II
{
    public partial class AccountInfo : UserControl
    {

        int IDRestaurant = 0;
        string password;
        public AccountInfo()
        {
            InitializeComponent();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void load_AccountInfo(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();

            DataSet dsClient = new DataSet();
            SqlDataAdapter daClient = new SqlDataAdapter("SELECT * FROM Client", myCon);
            daClient.Fill(dsClient, "Client");

            DataSet dsComenzi = new DataSet();
            SqlDataAdapter daComenzi = new SqlDataAdapter("SELECT * FROM Comenzi", myCon);
            daComenzi.Fill(dsComenzi, "Comenzi");

            DataSet dsRestaurant = new DataSet();
            SqlDataAdapter daRestaurant = new SqlDataAdapter("SELECT * FROM Restaurant", myCon);
            daRestaurant.Fill(dsRestaurant, "Restaurant");

            myCon.Close();

            string email = UserEmailHolder.Email;

            foreach (DataRow dr in dsClient.Tables["Client"].Rows)
            {
                if (email == dr.ItemArray.GetValue(3).ToString())
                {
                    ClientHolder.IDClient = int.Parse(dr.ItemArray.GetValue(0).ToString());
                    ClientAddress.Address = dr.ItemArray.GetValue(7).ToString();
                    textBoxFirstName.Text = dr.ItemArray.GetValue(2).ToString();
                    textBoxLastName.Text = dr.ItemArray.GetValue(1).ToString();
                    textBoxEmail.Text = dr.ItemArray.GetValue(3).ToString();
                    textBoxPhoneNumber.Text = dr.ItemArray.GetValue(4).ToString();
                    textBoxCity.Text = dr.ItemArray.GetValue(5).ToString();
                    if (dr.ItemArray.GetValue(7).ToString() != "")
                    {
                        string[] words = dr.ItemArray.GetValue(7).ToString().Split(' ');
                        if (words.Length == 4)
                        {
                            textBoxStreet.Text = words[0];
                            textBoxApartament.Text = words[1];
                            textBoxBuilding.Text = words[2];
                            textBoxNumber.Text = words[3];
                        }
                        else if (words.Length == 5)
                        {
                            textBoxStreet.Text = words[0] + " " + words[1];
                            textBoxApartament.Text = words[2];
                            textBoxBuilding.Text = words[3];
                            textBoxNumber.Text = words[4];
                        }
                        else if (words.Length == 6)
                        {
                            textBoxStreet.Text = words[0] + " " + words[1] + " " + words[2];
                            textBoxApartament.Text = words[3];
                            textBoxBuilding.Text = words[4];
                            textBoxNumber.Text = words[5];
                        }
                    }
                }
            }
            listBox1.Items.Clear();
            foreach (DataRow dr in dsComenzi.Tables["Comenzi"].Rows)
            {
                if (ClientHolder.IDClient == int.Parse(dr.ItemArray.GetValue(1).ToString()))
                {
                    IDRestaurant = int.Parse(dr.ItemArray.GetValue(2).ToString());
                    foreach (DataRow dr1 in dsRestaurant.Tables["Restaurant"].Rows)
                    {
                        if (IDRestaurant == int.Parse(dr1.ItemArray.GetValue(0).ToString()))
                        {
                            listBox1.Items.Add("Order Number: " + dr.ItemArray.GetValue(7).ToString());
                            listBox1.Items.Add("Total: " + dr.ItemArray.GetValue(6).ToString());
                            listBox1.Items.Add("Restaurant: " + dr1.ItemArray.GetValue(1).ToString());
                            listBox1.Items.Add(" ");
                        }
                    }
                }
            }
        }

        private void buttonSaveMod_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            Regex regex = new Regex("^([A-Z][a-zA-Z]*)(?=.*[a-z])(?=[^!@#$%&*_+/'?~`,.^()=])");
            string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            Regex regex_email = new Regex(strRegex, RegexOptions.IgnoreCase);
            string strRegexTel = @"(^[0-9]{10}$)";
            string strRegexNr = @"(^[0-9]{1,2}$)";
            Regex regex_nr = new Regex(strRegexNr);
            Regex regex_tel = new Regex(strRegexTel);
            string strRegBuild = @"^([A-Z][0-9])$";
            Regex regex_build = new Regex(strRegBuild);
            if (regex.IsMatch(textBoxLastName.Text) && regex.IsMatch(textBoxFirstName.Text) && regex_email.IsMatch(textBoxEmail.Text) && regex_tel.IsMatch(textBoxPhoneNumber.Text) && regex.IsMatch(textBoxCity.Text) && regex.IsMatch(textBoxStreet.Text) && regex_nr.IsMatch(textBoxNumber.Text) && regex_nr.IsMatch(textBoxApartament.Text) && regex_build.IsMatch(textBoxBuilding.Text))
            {
                string address = textBoxStreet.Text + " " + textBoxApartament.Text + " " + textBoxBuilding.Text + " " + textBoxNumber.Text;
                string command = "UPDATE Client set nume= '" + textBoxLastName.Text + "', prenume = '" + textBoxFirstName.Text + "', email = '" + textBoxEmail.Text + "', telefon = '" + textBoxPhoneNumber.Text + "', oras = '" + textBoxCity.Text + "', adresa = '" + address + "' where email = '" + textBoxEmail.Text + "'";
                using (SqlCommand cmd = new SqlCommand(command, myCon))
                {
                    myCon.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Account Details Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter right values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteAccount_Click(object sender, EventArgs e)
        {

            string email = UserEmailHolder.Email;
            string command_comenzi = "DELETE FROM Comenzi where (id_client = '" + ClientHolder.IDClient + "')";
            string command = "DELETE FROM Client where (email = '" + email + "')";
            using (SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True"))
            {
                myCon.Open();
                SqlTransaction sqlTransaction = myCon.BeginTransaction();
                try
                { 
                    using(SqlCommand cmd = new SqlCommand(command_comenzi, myCon, sqlTransaction))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    using(SqlCommand cmd = new SqlCommand(command, myCon, sqlTransaction))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    sqlTransaction.Commit();
                    MessageBox.Show("Account Deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form = new Form1();
                    form.Show();
                }
                catch(Exception ex)
                {
                    sqlTransaction.Rollback();
                }
            }
           
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();

            Regex regex_pass = new Regex("^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@$/!%#_*?&])[A-Za-z\\d@$!/#%_*?&]{8,32}$");

            DataSet dsClient = new DataSet();
            SqlDataAdapter daClient = new SqlDataAdapter("SELECT * FROM Client", myCon);
            daClient.Fill(dsClient, "Client");

            myCon.Close();

            foreach (DataRow dr in dsClient.Tables["Client"].Rows)
            {
                if (ClientHolder.IDClient == int.Parse(dr.ItemArray.GetValue(0).ToString()))
                {
                    password = dr.ItemArray.GetValue(6).ToString();
                    if (textBoxNewPassword.Text != string.Empty && textBoxOldPassword.Text != string.Empty && textBoxConfirmPassword.Text != string.Empty)
                    {
                        if (password == textBoxOldPassword.Text)
                        {
                            if (textBoxNewPassword.Text != password)
                            {
                                if (regex_pass.IsMatch(textBoxNewPassword.Text))
                                {
                                    if (textBoxNewPassword.Text == textBoxConfirmPassword.Text)
                                    {
                                        string command = "UPDATE Client set parola = '" + textBoxNewPassword.Text + "' where id_client = '" + ClientHolder.IDClient + "'";
                                        using (SqlCommand cmd = new SqlCommand(command, myCon))
                                        {
                                            myCon.Open();
                                            cmd.ExecuteNonQuery();
                                        }
                                        MessageBox.Show("Password Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                MessageBox.Show("Current password and new password are the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect current password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter values in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
