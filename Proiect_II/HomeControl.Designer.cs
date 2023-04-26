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
            cityLabel = new Label();
            pictureBoxPizza = new PictureBox();
            label2 = new Label();
            vScrollBar1 = new VScrollBar();
            radioButtonCluj = new RadioButton();
            radioButtonBucuresti = new RadioButton();
            radioButtonTimisoara = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).BeginInit();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.OrangeRed;
            searchButton.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            searchButton.Location = new Point(702, 167);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(89, 42);
            searchButton.TabIndex = 0;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            cityLabel.Location = new Point(274, 175);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(169, 23);
            cityLabel.TabIndex = 2;
            cityLabel.Text = "Choose your city:";
            // 
            // pictureBoxPizza
            // 
            pictureBoxPizza.Image = (Image)resources.GetObject("pictureBoxPizza.Image");
            pictureBoxPizza.Location = new Point(250, 281);
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
            label2.Location = new Point(274, 71);
            label2.Name = "label2";
            label2.Size = new Size(388, 38);
            label2.TabIndex = 5;
            label2.Text = "Enter your delivery address to check if our service \r\nis available in your location.";
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(1106, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(22, 720);
            vScrollBar1.TabIndex = 6;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // radioButtonCluj
            // 
            radioButtonCluj.AutoSize = true;
            radioButtonCluj.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonCluj.Location = new Point(513, 142);
            radioButtonCluj.Name = "radioButtonCluj";
            radioButtonCluj.Size = new Size(64, 27);
            radioButtonCluj.TabIndex = 7;
            radioButtonCluj.TabStop = true;
            radioButtonCluj.Text = "Cluj";
            radioButtonCluj.UseVisualStyleBackColor = true;
            // 
            // radioButtonBucuresti
            // 
            radioButtonBucuresti.AutoSize = true;
            radioButtonBucuresti.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonBucuresti.Location = new Point(513, 175);
            radioButtonBucuresti.Name = "radioButtonBucuresti";
            radioButtonBucuresti.Size = new Size(110, 27);
            radioButtonBucuresti.TabIndex = 8;
            radioButtonBucuresti.TabStop = true;
            radioButtonBucuresti.Text = "Bucuresti";
            radioButtonBucuresti.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimisoara
            // 
            radioButtonTimisoara.AutoSize = true;
            radioButtonTimisoara.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonTimisoara.Location = new Point(513, 208);
            radioButtonTimisoara.Name = "radioButtonTimisoara";
            radioButtonTimisoara.Size = new Size(116, 27);
            radioButtonTimisoara.TabIndex = 9;
            radioButtonTimisoara.TabStop = true;
            radioButtonTimisoara.Text = "Timisoara";
            radioButtonTimisoara.UseVisualStyleBackColor = true;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(radioButtonTimisoara);
            Controls.Add(radioButtonBucuresti);
            Controls.Add(radioButtonCluj);
            Controls.Add(vScrollBar1);
            Controls.Add(label2);
            Controls.Add(pictureBoxPizza);
            Controls.Add(cityLabel);
            Controls.Add(searchButton);
            Name = "HomeControl";
            Size = new Size(1128, 720);
            ((System.ComponentModel.ISupportInitialize)pictureBoxPizza).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private Label cityLabel;
        private PictureBox pictureBoxPizza;
        private Label label2;
        private VScrollBar vScrollBar1;
        private RadioButton radioButtonCluj;
        private RadioButton radioButtonBucuresti;
        private RadioButton radioButtonTimisoara;
    }
}
