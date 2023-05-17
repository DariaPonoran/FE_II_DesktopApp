namespace Proiect_II
{
    partial class BecomePartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BecomePartner));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBoxRestaurantName = new TextBox();
            textBoxRestaurantEmail = new TextBox();
            textBoxPersonName = new TextBox();
            textBoxRestaurantPhoneNumber = new TextBox();
            textBoxRestaurantCity = new TextBox();
            textBoxRestaurantAdress = new TextBox();
            buttonAddPartner = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(63, 57);
            label1.Name = "label1";
            label1.Size = new Size(612, 141);
            label1.TabIndex = 0;
            label1.Text = "Increase your restaurant sales \r\nand attract more customers \r\nwith our help";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(732, 312);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 531);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBoxRestaurantName
            // 
            textBoxRestaurantName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRestaurantName.Location = new Point(77, 269);
            textBoxRestaurantName.Name = "textBoxRestaurantName";
            textBoxRestaurantName.PlaceholderText = "Business Name";
            textBoxRestaurantName.Size = new Size(499, 32);
            textBoxRestaurantName.TabIndex = 8;
            // 
            // textBoxRestaurantEmail
            // 
            textBoxRestaurantEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRestaurantEmail.Location = new Point(77, 369);
            textBoxRestaurantEmail.Name = "textBoxRestaurantEmail";
            textBoxRestaurantEmail.PlaceholderText = "Email address";
            textBoxRestaurantEmail.Size = new Size(499, 32);
            textBoxRestaurantEmail.TabIndex = 9;
            // 
            // textBoxPersonName
            // 
            textBoxPersonName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPersonName.Location = new Point(77, 469);
            textBoxPersonName.Name = "textBoxPersonName";
            textBoxPersonName.PlaceholderText = "Your name";
            textBoxPersonName.Size = new Size(499, 32);
            textBoxPersonName.TabIndex = 10;
            // 
            // textBoxRestaurantPhoneNumber
            // 
            textBoxRestaurantPhoneNumber.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRestaurantPhoneNumber.Location = new Point(77, 569);
            textBoxRestaurantPhoneNumber.Name = "textBoxRestaurantPhoneNumber";
            textBoxRestaurantPhoneNumber.PlaceholderText = "Phone Number";
            textBoxRestaurantPhoneNumber.Size = new Size(499, 32);
            textBoxRestaurantPhoneNumber.TabIndex = 11;
            // 
            // textBoxRestaurantCity
            // 
            textBoxRestaurantCity.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRestaurantCity.Location = new Point(77, 669);
            textBoxRestaurantCity.Name = "textBoxRestaurantCity";
            textBoxRestaurantCity.PlaceholderText = "City Name";
            textBoxRestaurantCity.Size = new Size(499, 32);
            textBoxRestaurantCity.TabIndex = 12;
            // 
            // textBoxRestaurantAdress
            // 
            textBoxRestaurantAdress.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRestaurantAdress.Location = new Point(77, 769);
            textBoxRestaurantAdress.Name = "textBoxRestaurantAdress";
            textBoxRestaurantAdress.PlaceholderText = "Address";
            textBoxRestaurantAdress.Size = new Size(499, 32);
            textBoxRestaurantAdress.TabIndex = 13;
            // 
            // buttonAddPartner
            // 
            buttonAddPartner.BackColor = Color.RoyalBlue;
            buttonAddPartner.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddPartner.Location = new Point(77, 869);
            buttonAddPartner.Name = "buttonAddPartner";
            buttonAddPartner.Size = new Size(499, 45);
            buttonAddPartner.TabIndex = 14;
            buttonAddPartner.Text = "Sign Up";
            buttonAddPartner.UseVisualStyleBackColor = false;
            buttonAddPartner.Click += buttonAddPartner_Click;
            // 
            // BecomePartner
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.InactiveCaption;
            Controls.Add(buttonAddPartner);
            Controls.Add(textBoxRestaurantAdress);
            Controls.Add(textBoxRestaurantCity);
            Controls.Add(textBoxRestaurantPhoneNumber);
            Controls.Add(textBoxPersonName);
            Controls.Add(textBoxRestaurantEmail);
            Controls.Add(textBoxRestaurantName);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "BecomePartner";
            Size = new Size(1283, 944);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBoxRestaurantName;
        private TextBox textBoxRestaurantEmail;
        private TextBox textBoxPersonName;
        private TextBox textBoxRestaurantPhoneNumber;
        private TextBox textBoxRestaurantCity;
        private TextBox textBoxRestaurantAdress;
        private Button buttonAddPartner;
    }
}
