using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proiect_II
{
    public partial class Form1 : Form
    {
        public static class UserEmailHolder
        {
            public static string Email { get; set; }
        }

        public Form1()
        {
            UserEmailHolder.Email = string.Empty;
            InitializeComponent();
            LoadImageInPictureBox();
            LoadImageOnButtonClose(closeButton, "Cross.png");
            LoadImageOnButton(homeButton, "Home.png");
            signUpControl1.Visible = false;
            signInControl1.Visible = false;
            shoppingCart1.Visible = false;
            accountInfo1.Visible = false;
            clujRestaurants1.Visible = false;
            bucurestiRestaurants1.Visible = false;
            timisoaraRestaurants1.Visible = false;
            restaurantProductsUserControl1.Visible = false;
            becomeRider1.Visible = false;
            order1.Visible = false;
            if (UserEmailHolder.Email != string.Empty)
            {
                button5.Visible = false;
                button4.Visible = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            signUpControl1.Visible = false;
            homeControl1.Visible = false;
            signInControl1.Visible = true;
            shoppingCart1.Visible = false;
            accountInfo1.Visible = false;
            becomeRider1.Visible = false;
            clujRestaurants1.Visible = false;
            bucurestiRestaurants1.Visible = false;
            timisoaraRestaurants1.Visible = false;
            restaurantProductsUserControl1.Visible = false;
            order1.Visible = false;
            signInControl1.BringToFront();
        }


        private void signUp_Click(object sender, EventArgs e)
        {
            homeControl1.Visible = false;
            signInControl1.Visible = false;
            signUpControl1.Visible = true;
            shoppingCart1.Visible = false;
            accountInfo1.Visible = false;
            becomeRider1.Visible = false;
            clujRestaurants1.Visible = false;
            bucurestiRestaurants1.Visible = false;
            timisoaraRestaurants1.Visible = false;
            restaurantProductsUserControl1.Visible = false;
            order1.Visible = false;
            signUpControl1.BringToFront();
        }
        private void LoadImageInPictureBox()
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "pizzaLogo.png");
            logoPicture.Image = Image.FromFile(imagePath);
        }
        private void LoadImageOnButton(Button button, string imageName)
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", imageName);
            button.Image = Image.FromFile(imagePath);
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }
        private void LoadImageOnButtonClose(Button button, string imageName)
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", imageName);
            button.Image = Image.FromFile(imagePath);
            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.TextImageRelation = TextImageRelation.ImageBeforeText;
        }


        private void signInControl1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            homeControl1.Visible = false;
            signInControl1.Visible = false;
            signUpControl1.Visible = false;
            shoppingCart1.Visible = false;
            accountInfo1.Visible = true;
            becomeRider1.Visible = false;
            clujRestaurants1.Visible = false;
            bucurestiRestaurants1.Visible = false;
            timisoaraRestaurants1.Visible = false;
            restaurantProductsUserControl1.Visible = false;
            order1.Visible = false;
            accountInfo1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            homeControl1.Visible = false;
            signInControl1.Visible = false;
            signUpControl1.Visible = false;
            shoppingCart1.Visible = true;
            accountInfo1.Visible = false;
            becomeRider1.Visible = false;
            clujRestaurants1.Visible = false;
            bucurestiRestaurants1.Visible = false;
            timisoaraRestaurants1.Visible = false;
            restaurantProductsUserControl1.Visible = false;
            order1.Visible = true;
            shoppingCart1.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeButon_Click_1(object sender, EventArgs e)
        {
            signUpControl1.Visible = false;
            homeControl1.Visible = true;
            signInControl1.Visible = false;
            shoppingCart1.Visible = false;
            accountInfo1.Visible = false;
            becomeRider1.Visible = false;
            clujRestaurants1.Visible = false;
            bucurestiRestaurants1.Visible = false;
            timisoaraRestaurants1.Visible = false;
            restaurantProductsUserControl1.Visible = false;
            order1.Visible = false;
            homeControl1.BringToFront();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            order1.BringToFront();
            order1.Visible = true;
            accountInfo1.Visible = true;
            homeControl1.Visible = false;
            signInControl1.Visible = false;
            signUpControl1.Visible = false;
            shoppingCart1.Visible = true;
            becomeRider1.Visible = false;
            clujRestaurants1.Visible = false;
            bucurestiRestaurants1.Visible = false;
            timisoaraRestaurants1.Visible = false;
            restaurantProductsUserControl1.Visible = false;
        }
    }
}