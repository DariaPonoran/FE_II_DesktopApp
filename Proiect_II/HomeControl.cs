using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proiect_II
{
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 2);
            e.Graphics.DrawLine(pen, 25, 75, 1220, 75);
            e.Graphics.DrawLine(pen, 25, 10, 1220, 10);
            e.Graphics.DrawLine(pen, 25, 440, 1220, 440);
            e.Graphics.DrawLine(pen, 25, 805, 1220, 805);
        }

        private void buttonPartner_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            BecomePartner becomePartner1 = new BecomePartner();
            parentForm.Controls.Add(becomePartner1);
            becomePartner1.Size = new Size(1283, 500);
            becomePartner1.Dock = DockStyle.Fill;
            becomePartner1.BringToFront();
        }

        private void buttonRider_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            BecomeRider becomeRider1 = new BecomeRider();
            parentForm.Controls.Add(becomeRider1);
            becomeRider1.Size = new Size(1283, 500);
            becomeRider1.Dock = DockStyle.Fill;
            becomeRider1.BringToFront();

        }
        /*
        private void searchButton_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            if (radioButtonCluj.Checked)
            {
                ClujRestaurants clujRestaurants1 = new ClujRestaurants();
                parentForm.Controls.Add(clujRestaurants1);
                clujRestaurants1.Dock = DockStyle.Fill;
                clujRestaurants1.BringToFront();
            }
            else
            {
                // Aici puteți adăuga cod pentru a gestiona cazul în care radioButtonCluj nu este activat.
            }
        }
        */
        private void searchButton_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;
            if (radioButtonCluj.Checked)
            {
                DataSet dsRestaurants = new DataSet();
                using (SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FACULTATE\An3Sem2\II\Proiect3\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True"))
                {
                    myCon.Open();
                    SqlDataAdapter daRestaurants = new SqlDataAdapter("SELECT * FROM Restaurante WHERE oras==Cluj", myCon);
                    daRestaurants.Fill(dsRestaurants, "Restaurante");
                }

                ClujRestaurants clujRestaurants1 = new ClujRestaurants(dsRestaurants);
                parentForm.Controls.Add(clujRestaurants1);
                clujRestaurants1.Dock = DockStyle.Fill;
                clujRestaurants1.BringToFront();
            }
        }

    }
}
