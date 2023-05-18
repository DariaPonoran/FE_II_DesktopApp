using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proiect_II.Form1;

namespace Proiect_II
{
    public partial class SignInControl : UserControl
    {
        public SignInControl()
        {
            InitializeComponent();
        }
        //Ana: @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True"
        //Daria:@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Desktop\Proiect_II\Proiect_II\Database1.mdf;Integrated Security=True"

        private void signInButton2_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\Sem II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();
            if (textBoxSignInEmail.Text != string.Empty && textBoxSignInPass.Text != string.Empty)
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Client WHERE email = '" + textBoxSignInEmail.Text + "' AND parola = '" + textBoxSignInPass.Text + "'", myCon);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    Form parentForm = this.ParentForm;
                    AccountInfo accountInfo = new AccountInfo();
                    parentForm.Controls.Add(accountInfo);
                    accountInfo.Dock = DockStyle.Fill;
                    accountInfo.BringToFront();
                    string email = textBoxSignInEmail.Text;
                    UserEmailHolder.Email = email;
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
