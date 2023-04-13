using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Proiect_II
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            LoadImageInPictureBox();
            LoadImageOnButtonClose(closeButton, "Cross.png");
            LoadImageOnButton(homeButton, "Home.png");
            signInControl1.Visible = false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signIn_Click(object sender, EventArgs e)
        {
            homeControl2.Visible = false;
            signInControl1.Visible = true;
            signInControl1.BringToFront();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            signInControl1.Visible = false;
            homeControl2.Visible = true;
            homeControl2.BringToFront();

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
        
       
    }
}