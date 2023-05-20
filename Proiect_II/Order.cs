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
        string currentDate;
        int randomID;
        public Order()
        {
            InitializeComponent();
        }
        public void GetCurier()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\Sem II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
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
                }
            }
            CurierName.Name = numeCurier;
            CurierName.Prenume = prenumeCurier;
        }

        private void LoadOrder(object sender, EventArgs e)
        {
            currentDate = DateTime.Now.ToString();
            label7.Text = CurierName.Name + " " + CurierName.Prenume;
            label5.Text = currentDate.ToString();
            label3.Text = OrderTotal.Total.ToString();
        }

        public void AddOrder()
        {
            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\An III\Sem II\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();

            currentDate = "Mai";
            //DateTime.Now.ToString("dd-MM-yyyy")
            SqlCommand cmd = new SqlCommand("INSERT INTO [Comenzi] (id_client,id_restaurant,id_curier,data_comanda,adresa_livrare,total) Values ('" + ClientHolder.IDClient + "','" + RestaurantHolder.IDRestaurnat + "','" + randomID + "','" + currentDate + "','" + ClientAddress.Address + "','" + OrderTotal.Total + "')", myCon); 
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order is on the way!", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
