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
            textBox1 = new TextBox();
            addressLabel = new Label();
            pictureBoxPizza = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.OrangeRed;
            searchButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.Location = new Point(518, 224);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(89, 42);
            searchButton.TabIndex = 0;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(653, 178);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            addressLabel.Location = new Point(274, 178);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(183, 23);
            addressLabel.TabIndex = 2;
            addressLabel.Text = "Enter your address:";
            // 
            // pictureBoxPizza
            // 
            pictureBoxPizza.Image = (Image)resources.GetObject("pictureBoxPizza.Image");
            pictureBoxPizza.Location = new Point(265, 294);
            pictureBoxPizza.Name = "pictureBoxPizza";
            pictureBoxPizza.Size = new Size(675, 350);
            pictureBoxPizza.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPizza.TabIndex = 3;
            pictureBoxPizza.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(274, 108);
            label2.Name = "label2";
            label2.Size = new Size(388, 38);
            label2.TabIndex = 5;
            label2.Text = "Enter your delivery address to check if our service \r\nis available in your location.";
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(label2);
            Controls.Add(pictureBoxPizza);
            Controls.Add(addressLabel);
            Controls.Add(textBox1);
            Controls.Add(searchButton);
            Name = "HomeControl";
            Size = new Size(1153, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private TextBox textBox1;
        private Label addressLabel;
        private PictureBox pictureBoxPizza;
        private Label label2;
    }
}
