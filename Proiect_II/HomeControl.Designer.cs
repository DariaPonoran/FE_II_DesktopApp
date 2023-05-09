namespace Proiect_II
{
    partial class HomeControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            searchButton = new Button();
            radioButtonCluj = new RadioButton();
            radioButtonBucuresti = new RadioButton();
            radioButtonTimisoara = new RadioButton();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            buttonRider = new Button();
            buttonPartner = new Button();
            label4 = new Label();
            label_partner_desc = new Label();
            label_rider = new Label();
            label_partner = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.OrangeRed;
            searchButton.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(72, 319);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(118, 42);
            searchButton.TabIndex = 0;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // radioButtonCluj
            // 
            radioButtonCluj.AutoSize = true;
            radioButtonCluj.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonCluj.Location = new Point(72, 128);
            radioButtonCluj.Name = "radioButtonCluj";
            radioButtonCluj.Size = new Size(93, 43);
            radioButtonCluj.TabIndex = 7;
            radioButtonCluj.TabStop = true;
            radioButtonCluj.Text = "Cluj";
            radioButtonCluj.UseVisualStyleBackColor = true;
            // 
            // radioButtonBucuresti
            // 
            radioButtonBucuresti.AutoSize = true;
            radioButtonBucuresti.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonBucuresti.Location = new Point(72, 180);
            radioButtonBucuresti.Name = "radioButtonBucuresti";
            radioButtonBucuresti.Size = new Size(172, 43);
            radioButtonBucuresti.TabIndex = 8;
            radioButtonBucuresti.TabStop = true;
            radioButtonBucuresti.Text = "Bucuresti";
            radioButtonBucuresti.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimisoara
            // 
            radioButtonTimisoara.AutoSize = true;
            radioButtonTimisoara.Font = new Font("Century Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonTimisoara.Location = new Point(72, 233);
            radioButtonTimisoara.Name = "radioButtonTimisoara";
            radioButtonTimisoara.Size = new Size(179, 43);
            radioButtonTimisoara.TabIndex = 9;
            radioButtonTimisoara.TabStop = true;
            radioButtonTimisoara.Text = "Timisoara";
            radioButtonTimisoara.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(radioButtonCluj);
            panel1.Controls.Add(radioButtonTimisoara);
            panel1.Controls.Add(radioButtonBucuresti);
            panel1.Location = new Point(622, 118);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 568);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(78, 52);
            label1.Name = "label1";
            label1.Size = new Size(930, 46);
            label1.TabIndex = 12;
            label1.Text = "Choose yor city to check the available restaurants:";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(3, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(623, 568);
            panel2.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(582, 1101);
            label2.Name = "label2";
            label2.Size = new Size(422, 37);
            label2.TabIndex = 14;
            label2.Text = "Want To Become A Partner?";
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(677, 1148);
            button1.Name = "button1";
            button1.Size = new Size(290, 42);
            button1.TabIndex = 15;
            button1.Text = "Click Here To Join Us";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(13, 17);
            label3.Name = "label3";
            label3.Size = new Size(289, 28);
            label3.TabIndex = 16;
            label3.Text = "Work With DAC Delivery";
            // 
            // panel3
            // 
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(buttonRider);
            panel3.Controls.Add(buttonPartner);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label_partner_desc);
            panel3.Controls.Add(label_rider);
            panel3.Controls.Add(label_partner);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(13, 691);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1098, 635);
            panel3.TabIndex = 17;
            panel3.Paint += panel3_Paint;
            // 
            // buttonRider
            // 
            buttonRider.BackColor = Color.LightSalmon;
            buttonRider.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRider.Location = new Point(604, 482);
            buttonRider.Name = "buttonRider";
            buttonRider.Size = new Size(203, 35);
            buttonRider.TabIndex = 24;
            buttonRider.Text = "Ride with us";
            buttonRider.UseVisualStyleBackColor = false;
            buttonRider.Click += buttonRider_Click;
            // 
            // buttonPartner
            // 
            buttonPartner.BackColor = Color.LightSalmon;
            buttonPartner.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPartner.Location = new Point(604, 210);
            buttonPartner.Name = "buttonPartner";
            buttonPartner.Size = new Size(203, 35);
            buttonPartner.TabIndex = 23;
            buttonPartner.Text = "Partner with us";
            buttonPartner.UseVisualStyleBackColor = false;
            buttonPartner.Click += buttonPartner_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(609, 413);
            label4.Name = "label4";
            label4.Size = new Size(338, 44);
            label4.TabIndex = 22;
            label4.Text = "Earn money by delivering food from\r\nrestaurants. All you need is a bike.\r\n";
            // 
            // label_partner_desc
            // 
            label_partner_desc.AutoSize = true;
            label_partner_desc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_partner_desc.Location = new Point(609, 142);
            label_partner_desc.Name = "label_partner_desc";
            label_partner_desc.Size = new Size(316, 42);
            label_partner_desc.TabIndex = 21;
            label_partner_desc.Text = "DAC Delivery helps restaurants grow \r\nwith online orders and loyality programs\r\n";
            // 
            // label_rider
            // 
            label_rider.AutoSize = true;
            label_rider.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_rider.Location = new Point(609, 370);
            label_rider.Name = "label_rider";
            label_rider.Size = new Size(124, 28);
            label_rider.TabIndex = 20;
            label_rider.Text = "As a rider";
            // 
            // label_partner
            // 
            label_partner.AutoSize = true;
            label_partner.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_partner.Location = new Point(609, 104);
            label_partner.Name = "label_partner";
            label_partner.Size = new Size(155, 28);
            label_partner.TabIndex = 19;
            label_partner.Text = "As a partner";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.motorbike;
            pictureBox2.Location = new Point(121, 370);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(318, 179);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(121, 104);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "HomeControl";
            Size = new Size(1123, 1388);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private RadioButton radioButtonCluj;
        private RadioButton radioButtonBucuresti;
        private RadioButton radioButtonTimisoara;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Button button1;
        private Label label3;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label_rider;
        private Label label_partner;
        private Label label_partner_desc;
        private Label label4;
        private Button buttonRider;
        private Button buttonPartner;
    }
}
