namespace Proiect_II
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            signUp = new Button();
            signIn = new Button();
            panel2 = new Panel();
            closeButton = new Button();
            label1 = new Label();
            logoPicture = new PictureBox();
            panel3 = new Panel();
            button8 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            homeButon = new Button();
            button3 = new Button();
            button2 = new Button();
            homeButton = new Button();
            signInControl1 = new SignInControl();
            homeControl1 = new HomeControl();
            signUpControl1 = new SignUpControl();
            accountInfo1 = new AccountInfo();
            shoppingCart1 = new ShoppingCart();
            becomeRider1 = new BecomeRider();
            order1 = new Order();
            restaurantProductsUserControl1 = new RestaurantProductsUserControl();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPicture).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.DarkRed;
            button1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(125, 42);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
            // 
            // signUp
            // 
            signUp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            signUp.BackColor = Color.DarkRed;
            signUp.FlatStyle = FlatStyle.Flat;
            signUp.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            signUp.ImageAlign = ContentAlignment.MiddleLeft;
            signUp.Location = new Point(1020, -68);
            signUp.Margin = new Padding(4);
            signUp.Name = "signUp";
            signUp.Size = new Size(143, 56);
            signUp.TabIndex = 1;
            signUp.Text = "Sign up";
            signUp.TextImageRelation = TextImageRelation.ImageBeforeText;
            signUp.UseVisualStyleBackColor = false;
            signUp.Click += signUp_Click;
            // 
            // signIn
            // 
            signIn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            signIn.BackColor = Color.DarkRed;
            signIn.FlatStyle = FlatStyle.Flat;
            signIn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            signIn.ImageAlign = ContentAlignment.MiddleLeft;
            signIn.Location = new Point(1167, -68);
            signIn.Margin = new Padding(4);
            signIn.Name = "signIn";
            signIn.Size = new Size(143, 56);
            signIn.TabIndex = 2;
            signIn.Text = "Sign In";
            signIn.TextImageRelation = TextImageRelation.ImageBeforeText;
            signIn.UseVisualStyleBackColor = false;
            signIn.Click += signIn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(closeButton);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(logoPicture);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1313, 74);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Black;
            closeButton.Image = (Image)resources.GetObject("closeButton.Image");
            closeButton.Location = new Point(1226, 9);
            closeButton.Margin = new Padding(4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(57, 58);
            closeButton.TabIndex = 4;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(105, 12);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 46);
            label1.TabIndex = 1;
            label1.Text = "DAC Delivery";
            // 
            // logoPicture
            // 
            logoPicture.Image = (Image)resources.GetObject("logoPicture.Image");
            logoPicture.Location = new Point(0, 4);
            logoPicture.Margin = new Padding(4);
            logoPicture.Name = "logoPicture";
            logoPicture.Size = new Size(98, 67);
            logoPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPicture.TabIndex = 0;
            logoPicture.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(homeButon);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(homeButton);
            panel3.Controls.Add(signIn);
            panel3.Controls.Add(signUp);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 74);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1313, 60);
            panel3.TabIndex = 3;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button8.BackColor = Color.DarkRed;
            button8.FlatAppearance.BorderColor = Color.Black;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(333, 4);
            button8.Margin = new Padding(4);
            button8.Name = "button8";
            button8.Size = new Size(143, 52);
            button8.TabIndex = 11;
            button8.Text = "Log Out";
            button8.TextImageRelation = TextImageRelation.ImageBeforeText;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.BurlyWood;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(702, 5);
            button6.Margin = new Padding(4);
            button6.Name = "button6";
            button6.Size = new Size(166, 52);
            button6.TabIndex = 9;
            button6.Text = "Order";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button5.BackColor = Color.DarkRed;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(1162, 6);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(143, 52);
            button5.TabIndex = 8;
            button5.Text = "Sign In";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = false;
            button5.Click += signIn_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.BackColor = Color.DarkRed;
            button4.FlatAppearance.BorderColor = Color.Black;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(1016, 6);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(143, 52);
            button4.TabIndex = 7;
            button4.Text = "Sign up";
            button4.TextImageRelation = TextImageRelation.ImageBeforeText;
            button4.UseVisualStyleBackColor = false;
            button4.Click += signUp_Click;
            // 
            // homeButon
            // 
            homeButon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            homeButon.BackColor = Color.DarkRed;
            homeButon.FlatStyle = FlatStyle.Flat;
            homeButon.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            homeButon.Image = (Image)resources.GetObject("homeButon.Image");
            homeButon.ImageAlign = ContentAlignment.MiddleLeft;
            homeButon.Location = new Point(25, 4);
            homeButon.Margin = new Padding(4);
            homeButon.Name = "homeButon";
            homeButon.Size = new Size(128, 52);
            homeButon.TabIndex = 6;
            homeButon.Text = "Home";
            homeButon.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeButon.UseVisualStyleBackColor = false;
            homeButon.Click += homeButon_Click_1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button3.BackColor = Color.DarkRed;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.BottomLeft;
            button3.Location = new Point(872, 6);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(142, 52);
            button3.TabIndex = 5;
            button3.Text = "   Cart";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.Location = new Point(161, 4);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(164, 52);
            button2.TabIndex = 4;
            button2.Text = "  Account";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // homeButton
            // 
            homeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            homeButton.BackColor = Color.DarkRed;
            homeButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            homeButton.Image = (Image)resources.GetObject("homeButton.Image");
            homeButton.ImageAlign = ContentAlignment.MiddleLeft;
            homeButton.Location = new Point(-898, 0);
            homeButton.Margin = new Padding(4);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(128, 56);
            homeButton.TabIndex = 3;
            homeButton.Text = "Home";
            homeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeButton.UseVisualStyleBackColor = false;
            // 
            // signInControl1
            // 
            signInControl1.BackgroundImageLayout = ImageLayout.Stretch;
            signInControl1.Location = new Point(0, 139);
            signInControl1.Margin = new Padding(4, 6, 4, 6);
            signInControl1.Name = "signInControl1";
            signInControl1.Size = new Size(1313, 781);
            signInControl1.TabIndex = 4;
            signInControl1.Load += signInControl1_Load;
            // 
            // homeControl1
            // 
            homeControl1.BackColor = Color.RosyBrown;
            homeControl1.Location = new Point(0, 139);
            homeControl1.Margin = new Padding(4, 6, 4, 6);
            homeControl1.Name = "homeControl1";
            homeControl1.Size = new Size(1313, 1800);
            homeControl1.TabIndex = 0;
            // 
            // signUpControl1
            // 
            signUpControl1.Location = new Point(0, 139);
            signUpControl1.Margin = new Padding(4, 6, 4, 6);
            signUpControl1.Name = "signUpControl1";
            signUpControl1.Size = new Size(1313, 781);
            signUpControl1.TabIndex = 0;
            // 
            // accountInfo1
            // 
            accountInfo1.BackColor = Color.AntiqueWhite;
            accountInfo1.Location = new Point(0, 139);
            accountInfo1.Margin = new Padding(4, 6, 4, 6);
            accountInfo1.Name = "accountInfo1";
            accountInfo1.Size = new Size(1313, 781);
            accountInfo1.TabIndex = 5;
            // 
            // shoppingCart1
            // 
            shoppingCart1.AutoSize = true;
            shoppingCart1.AutoValidate = AutoValidate.EnablePreventFocusChange;
            shoppingCart1.BackColor = SystemColors.Info;
            shoppingCart1.Location = new Point(0, 139);
            shoppingCart1.Margin = new Padding(4, 6, 4, 6);
            shoppingCart1.Name = "shoppingCart1";
            shoppingCart1.Size = new Size(1313, 781);
            shoppingCart1.TabIndex = 6;
            // 
            // becomeRider1
            // 
            becomeRider1.BackColor = SystemColors.ButtonHighlight;
            becomeRider1.Location = new Point(-8, 138);
            becomeRider1.Margin = new Padding(4, 6, 4, 6);
            becomeRider1.Name = "becomeRider1";
            becomeRider1.Size = new Size(1313, 1259);
            becomeRider1.TabIndex = 8;
            // 
            // order1
            // 
            order1.BackColor = Color.FromArgb(243, 222, 212);
            order1.Location = new Point(2, 138);
            order1.Margin = new Padding(7, 8, 7, 8);
            order1.Name = "order1";
            order1.Size = new Size(1284, 781);
            order1.TabIndex = 10;
            // 
            // restaurantProductsUserControl1
            // 
            restaurantProductsUserControl1.Location = new Point(0, 138);
            restaurantProductsUserControl1.Margin = new Padding(7, 8, 7, 8);
            restaurantProductsUserControl1.Name = "restaurantProductsUserControl1";
            restaurantProductsUserControl1.RestaurantId = 0;
            restaurantProductsUserControl1.Size = new Size(1313, 781);
            restaurantProductsUserControl1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1313, 758);
            Controls.Add(restaurantProductsUserControl1);
            Controls.Add(order1);
            Controls.Add(becomeRider1);
            Controls.Add(shoppingCart1);
            Controls.Add(accountInfo1);
            Controls.Add(signUpControl1);
            Controls.Add(homeControl1);
            Controls.Add(signInControl1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPicture).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button signIn;
        private Button signUp;
        private Button button1;
        private Panel panel2;
        private Button closeButton;
        private Label label1;
        private PictureBox logoPicture;
        private Panel panel3;
        private Button homeButton;
        private SignInControl signInControl1;
        private HomeControl homeControl1;
        private SignUpControl signUpControl1;
        public Button button2;
        public Button button3;
        private AccountInfo accountInfo1;
        private ShoppingCart shoppingCart1;
        private Button homeButon;
        private ClujRestaurants clujRestaurants1;
        private BecomeRider becomeRider1;
        public Button button5;
        public Button button4;
        public Button button6;
        private Order order1;
        private BucurestiRestaurants bucurestiRestaurants1;
        private TimisoaraRestaurants timisoaraRestaurants1;
        private RestaurantProductsUserControl restaurantProductsUserControl1;
        public Button button8;
    }
}