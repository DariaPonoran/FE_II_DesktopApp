﻿using System;
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
    public partial class RestaurantProductsUserControl : UserControl
    {
        public int RestaurantId { get; set; }

        public RestaurantProductsUserControl()
        {
            InitializeComponent();

        }
        public void LoadRestaurantProducts(int restaurantId)
        {
            Controls.Clear();

            SqlConnection myCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\FACULTATE\An3Sem2\II\Proiect5\FE_II_DesktopApp\Proiect_II\Database1.mdf;Integrated Security=True");
            myCon.Open();

            string selectCommand = "SELECT * FROM Produs WHERE id_restaurant = @RestaurantId";
            SqlCommand cmd = new SqlCommand(selectCommand, myCon);
            cmd.Parameters.AddWithValue("@RestaurantId", restaurantId);

            SqlDataReader dr = cmd.ExecuteReader();

            int panelOffset = 0;

            while (dr.Read())
            {
                Panel newPanel = new Panel();
                newPanel.Location = new Point(10, 10 + panelOffset);
                newPanel.BackColor = Color.White;
                newPanel.Name = "panel" + dr["id_produs"].ToString();
                newPanel.Size = new Size(800, 200);

                Label nameLabel = new Label();
                nameLabel.AutoSize = true;
                nameLabel.Location = new Point(10, 10);
                nameLabel.Name = "nameLabel" + dr["id_produs"].ToString();
                nameLabel.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                nameLabel.Text = dr["Nume"].ToString();

                newPanel.Controls.Add(nameLabel);

                Label priceLabel = new Label();
                priceLabel.AutoSize = true;
                priceLabel.Location = new Point(10, 40);
                priceLabel.Name = "priceLabel" + dr["id_produs"].ToString();
                priceLabel.Font = new Font("Century Gothic", 14, FontStyle.Bold);
                priceLabel.Text = "Pret: " + dr["Pret"].ToString();

                newPanel.Controls.Add(priceLabel);

                Label descriptionLabel = new Label();
                descriptionLabel.AutoSize = true;
                descriptionLabel.Location = new Point(10, 80);
                descriptionLabel.Name = "descriptionLabel" + dr["id_produs"].ToString();
                descriptionLabel.Font = new Font("Century Gothic", 10);
                descriptionLabel.Text = dr["Descriere"].ToString();

                newPanel.Controls.Add(descriptionLabel);

                Label weightLabel = new Label();
                weightLabel.AutoSize = true;
                weightLabel.Location = new Point(10, 100);
                weightLabel.Name = "weightLabel" + dr["id_produs"].ToString();
                weightLabel.Font = new Font("Century Gothic", 10, FontStyle.Bold);
                weightLabel.Text ="Gramaj:"+ dr["Gramaj"].ToString();

                newPanel.Controls.Add(weightLabel);

                Button addToCartButton = new Button();
                addToCartButton.Location = new Point(10, 140); 
                addToCartButton.Name = "addToCartButton" + dr["id_produs"].ToString();
                addToCartButton.Text = "Adauga in cos";
                addToCartButton.Size = new Size(200, 40);

                newPanel.Controls.Add(addToCartButton);

                this.Controls.Add(newPanel);

                panelOffset += 220; 
            }

            dr.Close();
            myCon.Close();

        }

        private void RestaurantProductsUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
