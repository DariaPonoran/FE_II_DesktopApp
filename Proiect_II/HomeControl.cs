using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
