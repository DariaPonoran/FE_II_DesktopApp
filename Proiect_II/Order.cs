using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Proiect_II.Form1;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proiect_II
{
    public partial class Order : UserControl
    {
        int clientId = 0;
        string adresaLivrare;
        int count = 0;
        string numeCurier;
        string prenumeCurier;
        string telefonCurier;
        DateTime currentDate;
        int randomID;
        int time;
        int stop = 0;
        int stop2 = 0;
        int number = 0;
        public string DateTimeValue { get; set; }
        public Order()
        {
            InitializeComponent();
        }
        public void GetCurier()
        {

            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();
            string command = "SELECT COUNT(id_curier) FROM Curier";
            using (SqlCommand cmd = new SqlCommand(command, myCon))
            {
                count = (int)cmd.ExecuteScalar();
            }
            Random random = new Random();
            randomID = random.Next(1, count + 1);

            DataSet dsCurier = new DataSet();
            SqlDataAdapter daCurier = new SqlDataAdapter("SELECT * FROM Curier", myCon);
            daCurier.Fill(dsCurier, "Curier");

            myCon.Close();
            foreach (DataRow dr in dsCurier.Tables["Curier"].Rows)
            {
                if (randomID == int.Parse(dr.ItemArray.GetValue(0).ToString()))
                {
                    numeCurier = dr.ItemArray.GetValue(1).ToString();
                    prenumeCurier = dr.ItemArray.GetValue(2).ToString();
                    telefonCurier = dr.ItemArray.GetValue(4).ToString();
                }
            }
            CurierName.Name = numeCurier;
            CurierName.Prenume = prenumeCurier;
            CurierName.Telefon = telefonCurier;
        }

        private void LoadOrder(object sender, EventArgs e)
        {
            if (stop == 0)
            {
                Random random = new Random();
                time = random.Next(15, 30);
            }
            stop++;
            label10.Text = CurierName.Telefon;
            label7.Text = CurierName.Name + " " + CurierName.Prenume;
            label5.Text = time.ToString() + " : 00 minutes";
            label3.Text = randomNumberGenerator().ToString();
            if (ItemsClass.itemsList_names != null && ItemsClass.itemsList_prices != null)
            {
                ItemsClass.itemsList_prices.Clear();
                ItemsClass.itemsList_names.Clear();
            }
        }
        public int randomNumberGenerator()
        {
            if (stop2 == 0)
            {
                Random random = new Random();
                number = random.Next(1, 9999);
            }
            stop2++;
            return number;
        }
        public void AddOrder()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();

            currentDate = DateTime.Now;
            using (SqlCommand cmd = new SqlCommand("INSERT INTO [Comenzi] (id_client,id_restaurant,id_curier,data_comanda,adresa_livrare,total,nr_comanda) Values ('" + ClientHolder.IDClient + "','" + RestaurantHolder.IDRestaurnat + "','" + randomID + "' , @DateTimeValue , '" + ClientAddress.Address + "','" + OrderTotal.Total +"','" +label3.Text+ "')", myCon))
            {
                cmd.Parameters.AddWithValue("@DateTimeValue", currentDate);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Order is on the way!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = string.Empty;
            label7.Text = string.Empty;
            label5.Text = string.Empty;
            label3.Text = string.Empty;
            ActiveOrder.Active = false;
            ShoppingCartLoaded.Loaded = false;
            Form parentForm = this.ParentForm;
            ShoppingCart shoppingCart = new ShoppingCart();
            if (parentForm is Form1 form1)
            {
                form1.button6.Visible = false;
            }
            parentForm.Controls.Add(shoppingCart);
            shoppingCart.Dock = DockStyle.Fill;
            shoppingCart.BringToFront();

            
        }
    }
}
