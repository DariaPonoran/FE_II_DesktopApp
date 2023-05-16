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
    public partial class ClujRestaurants : UserControl
    {
        public ClujRestaurants()
        {
            InitializeComponent();
            LoadRestaurantData();
        }

        private void LoadRestaurantData()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FACULTATE\An3Sem2\II\Proiect4\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();

            string selectCommand = "SELECT * FROM Restaurant WHERE Oras = 'Cluj-Napoca'";

            SqlCommand cmd = new SqlCommand(selectCommand, myCon);

            SqlDataReader dr = cmd.ExecuteReader();

            int panelOffset = 0;

            while (dr.Read())
            {
                Panel newPanel = new Panel();
                newPanel.Location = new Point(10, 10 + panelOffset);
                newPanel.BackColor=Color.White;
                newPanel.Name = "panel" + dr["id_restaurant"].ToString();
                newPanel.Size = new Size(600, 200); // Change this as needed

                Label newLabel = new Label();
                newLabel.AutoSize = true;
                newLabel.Location = new Point(170, 30); // Position inside the panel
                newLabel.Name = "label" + dr["id_restaurant"].ToString();
                newLabel.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                newLabel.Text = dr["Nume"].ToString() +"\n"+ "Oras: " + dr["Oras"].ToString() + "\n" + "Telefon: " + dr["Telefon"].ToString();

                newPanel.Controls.Add(newLabel);

                PictureBox newPictureBox = new PictureBox();
                newPictureBox.Location = new Point(5, 20); // Position inside the panel
                newPictureBox.Name = "pictureBox" + dr["id_restaurant"].ToString();
                newPictureBox.Size = new Size(150, 150); // Change this as needed
                newPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                try
                {
                    string imageName = dr["Poza"].ToString();
                    newPictureBox.Image = Image.FromFile(@"D:\FACULTATE\An3Sem2\II\Proiect4\FE_II_DesktopApp\Proiect_II\" + imageName);
                }
                catch
                {
                    // Handle the case where the image file is not found, or any other exceptions
                    newPictureBox.Image = new Bitmap(newPictureBox.Width, newPictureBox.Height);
                    using (Graphics g = Graphics.FromImage(newPictureBox.Image))
                    {
                        g.Clear(Color.Black);
                    }
                }

                newPanel.Controls.Add(newPictureBox);

                Button newButton = new Button();
                newButton.Location = new Point(170, 100); // Position inside the panel
                newButton.Name = "button" + dr["id_restaurant"].ToString();
                newButton.Text = "Order"; // Change this as needed
                newButton.Size = new Size(175, 40); // Change this as needed
                newButton.Click += (sender, e) =>
                {
                    Button clickedButton = sender as Button;
                    int restaurantId = (int)clickedButton.Tag;
                    RestaurantProductsUserControl restaurantProductsControl = new RestaurantProductsUserControl();
                    restaurantProductsControl.LoadRestaurantProducts(restaurantId);
                    this.Parent.Controls.Add(restaurantProductsControl);
                    restaurantProductsControl.BringToFront();
                };

                newPanel.Controls.Add(newButton);

                this.Controls.Add(newPanel);

                panelOffset += 220;
            }

            dr.Close();
            myCon.Close();
        }



        private void ClujRestaurants_Load(object sender, EventArgs e)
        {

        }

    }
}
