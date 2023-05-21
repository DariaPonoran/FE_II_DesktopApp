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
using static Proiect_II.Form2;

namespace Proiect_II
{
    public partial class ShoppingCart : UserControl
    {
        List<string> product_names = new List<string>();
        List<string> product_price = new List<string>();
        double suma = 0;
        double price = 0;
        public ShoppingCart()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0 && listBox3.Items.Count == 0)
            {
                MessageBox.Show("Shopping Cart Is Empty!", "Error");
            }
            else
            {
                Form parentForm = this.ParentForm;
                Order order = new Order();
                if (radioButtonCard.Checked)
                {
                    if (ActiveOrder.Active == false)
                    {
                        Form2 form = new Form2();
                        form.ShowDialog();
                        if (CancelCard.Card == null)
                        {
                            parentForm.Controls.Add(order);
                            order.GetCurier();
                            order.AddOrder();
                            order.Dock = DockStyle.Fill;
                            order.BringToFront();
                            if (parentForm is Form1 form1)
                            {
                                form1.button6.Visible = true;
                            }
                            ActiveOrder.Active = true;
                        }
                        else
                        {
                            MessageBox.Show("Payment Method Cancelled!", "Error");
                            CancelCard.Card = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Order Is Already Ongoing", "Error");
                    }
                }

                if (radioButtonCash.Checked)
                {
                    if (ActiveOrder.Active == false)
                    {
                        parentForm.Controls.Add(order);
                        order.GetCurier();
                        order.AddOrder();
                        order.Dock = DockStyle.Fill;
                        order.BringToFront();
                        if (parentForm is Form1 form1)
                        {
                            form1.button6.Visible = true;
                        }
                        ActiveOrder.Active = true;
                    }
                    else
                    {
                        MessageBox.Show("Order Is Already Ongoing", "Error");
                    }
                }
            }
        }

        public void ShoppingCartLoad()
        {
            if (ItemsClass.itemsList_names != null && ItemsClass.itemsList_prices != null)
            {
                foreach (string item in ItemsClass.itemsList_names)
                {
                    listBox1.Items.Add(item);
                }

                foreach (string item in ItemsClass.itemsList_prices)
                {
                    listBox3.Items.Add(item);
                    suma += Convert.ToDouble(item);
                }
            }
            textBox1.Text = suma.ToString();
            OrderTotal.Total = suma;
        }

        public void LoadShopping(object sender, EventArgs e)
        {
            if(ShoppingCartLoaded.Loaded == false)
            {
                ShoppingCartLoad();
                ShoppingCartLoaded.Loaded = true;
            }
        }

        private void buttonDeleteItem_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (ActiveOrder.Active == false)
            {
                if (index != -1)
                {
                    listBox1.Items.RemoveAt(index);
                    //listBox2.Items.RemoveAt(index);
                    price = Convert.ToDouble(listBox3.Items[index].ToString());
                    listBox3.Items.RemoveAt(index);
                    suma -= price;
                    textBox1.Text = suma.ToString();
                    if (suma == 0)
                    {
                        RestaurantHolder.IDRestaurnat = 0;
                    }

                }
            }
            else
            {
                MessageBox.Show("Cannot Delete Items When Order Is Ongoing!", "Error");
            }

        }

        public void closeForm()
        {

        }
    }
}
