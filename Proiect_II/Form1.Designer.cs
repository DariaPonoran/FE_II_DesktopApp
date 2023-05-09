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
            homeButon = new Button();
            button3 = new Button();
            button2 = new Button();
            homeButton = new Button();
            signInControl1 = new SignInControl();
            homeControl1 = new HomeControl();
            signUpControl1 = new SignUpControl();
            accountInfo1 = new AccountInfo();
            shoppingCart1 = new ShoppingCart();
            clujRestaurants1 = new ClujRestaurants();
            becomeRider1 = new BecomeRider();
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
            signUp.Location = new Point(872, 4);
            signUp.Name = "signUp";
            signUp.Size = new Size(125, 42);
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
            signIn.Location = new Point(1000, 4);
            signIn.Name = "signIn";
            signIn.Size = new Size(125, 42);
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
            panel2.Name = "panel2";
            panel2.Size = new Size(1128, 56);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Black;
            closeButton.Image = (Image)resources.GetObject("closeButton.Image");
            closeButton.Location = new Point(1073, 7);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(50, 43);
            closeButton.TabIndex = 4;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(218, 37);
            label1.TabIndex = 1;
            label1.Text = "DAC Delivery";
            // 
            // logoPicture
            // 
            logoPicture.Image = (Image)resources.GetObject("logoPicture.Image");
            logoPicture.Location = new Point(0, 3);
            logoPicture.Name = "logoPicture";
            logoPicture.Size = new Size(86, 50);
            logoPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            logoPicture.TabIndex = 0;
            logoPicture.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkRed;
            panel3.Controls.Add(homeButon);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(homeButton);
            panel3.Controls.Add(signIn);
            panel3.Controls.Add(signUp);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(1128, 45);
            panel3.TabIndex = 3;
            // 
            // homeButon
            // 
            homeButon.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            homeButon.BackColor = Color.DarkRed;
            homeButon.FlatStyle = FlatStyle.Flat;
            homeButon.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            homeButon.Image = (Image)resources.GetObject("homeButon.Image");
            homeButon.ImageAlign = ContentAlignment.MiddleLeft;
            homeButon.Location = new Point(12, 0);
            homeButon.Name = "homeButon";
            homeButon.Size = new Size(112, 42);
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
            button3.Font = new Font("SansSerif", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.BottomLeft;
            button3.Location = new Point(742, 4);
            button3.Name = "button3";
            button3.Size = new Size(124, 39);
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
            button2.Font = new Font("SansSerif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.BottomLeft;
            button2.Location = new Point(130, 2);
            button2.Name = "button2";
            button2.Size = new Size(144, 39);
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
            homeButton.Location = new Point(-807, 0);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(112, 42);
            homeButton.TabIndex = 3;
            homeButton.Text = "Home";
            homeButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            homeButton.UseVisualStyleBackColor = false;
            // 
            // signInControl1
            // 
            signInControl1.BackgroundImageLayout = ImageLayout.Stretch;
            signInControl1.Location = new Point(0, 104);
            signInControl1.Margin = new Padding(3, 4, 3, 4);
            signInControl1.Name = "signInControl1";
            signInControl1.Size = new Size(1123, 586);
            signInControl1.TabIndex = 4;
            signInControl1.Load += signInControl1_Load;
            // 
            // homeControl1
            // 
            homeControl1.BackColor = Color.RosyBrown;
            homeControl1.Location = new Point(0, 104);
            homeControl1.Margin = new Padding(3, 4, 3, 4);
            homeControl1.Name = "homeControl1";
            homeControl1.Size = new Size(1128, 1350);
            homeControl1.TabIndex = 0;
            // 
            // signUpControl1
            // 
            signUpControl1.Location = new Point(0, 104);
            signUpControl1.Margin = new Padding(3, 4, 3, 4);
            signUpControl1.Name = "signUpControl1";
            signUpControl1.Size = new Size(1123, 586);
            signUpControl1.TabIndex = 0;
            // 
            // accountInfo1
            // 
            accountInfo1.Location = new Point(0, 104);
            accountInfo1.Margin = new Padding(3, 4, 3, 4);
            accountInfo1.Name = "accountInfo1";
            accountInfo1.Size = new Size(1123, 586);
            accountInfo1.TabIndex = 5;
            // 
            // shoppingCart1
            // 
            shoppingCart1.BackColor = SystemColors.Info;
            shoppingCart1.Location = new Point(0, 104);
            shoppingCart1.Margin = new Padding(3, 4, 3, 4);
            shoppingCart1.Name = "shoppingCart1";
            shoppingCart1.Size = new Size(1123, 586);
            shoppingCart1.TabIndex = 6;
            // 
            // clujRestaurants1
            // 
            clujRestaurants1.Location = new Point(0, 104);
            clujRestaurants1.Name = "clujRestaurants1";
            clujRestaurants1.Size = new Size(1123, 586);
            clujRestaurants1.TabIndex = 7;
            // 
            // becomeRider1
            // 
            becomeRider1.BackColor = SystemColors.ButtonHighlight;
            becomeRider1.Location = new Point(0, 104);
            becomeRider1.Name = "becomeRider1";
            becomeRider1.Size = new Size(1123, 944);
            becomeRider1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1126, 688);
            Controls.Add(becomeRider1);
            Controls.Add(clujRestaurants1);
            Controls.Add(shoppingCart1);
            Controls.Add(accountInfo1);
            Controls.Add(signUpControl1);
            Controls.Add(homeControl1);
            Controls.Add(signInControl1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPicture).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
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
        private Button button2;
        private Button button3;
        private AccountInfo accountInfo1;
        private ShoppingCart shoppingCart1;
        private Button homeButon;
        private ClujRestaurants clujRestaurants1;
        private BecomeRider becomeRider1;
    }
}