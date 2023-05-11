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

namespace Proiect_II
{
    public partial class SignInControl : UserControl
    {
        public SignInControl()
        {
            InitializeComponent();
        }

        private void signInButton2_Click(object sender, EventArgs e)
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
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
                    HomeControl homeControl = new HomeControl();
                    parentForm.Controls.Add(homeControl);
                    homeControl.Dock = DockStyle.Fill;
                    homeControl.BringToFront();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
