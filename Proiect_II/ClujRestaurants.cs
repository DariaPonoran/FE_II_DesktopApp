using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_II
{
    public partial class ClujRestaurants : UserControl
    {
        private DataSet _restaurantsDataSet;

        public ClujRestaurants(DataSet restaurantsDataSet)
        {
            InitializeComponent();
            _restaurantsDataSet = restaurantsDataSet;
            GenerateRestaurantPanels();
        }

        public ClujRestaurants()
        {
        }

        private void GenerateRestaurantPanels()
        {
            foreach (DataRow row in _restaurantsDataSet.Tables["Restaurante"].Rows)
            {
                Panel panel = new Panel();
                Label nameLabel = new Label
                {
                    Text = row["Nume"].ToString(),
                    AutoSize = true
                };

                panel.Controls.Add(nameLabel);
                this.Controls.Add(panel);
            }
        }



        private void ClujRestaurants_Load(object sender, EventArgs e)
        {

        }
    }
}
