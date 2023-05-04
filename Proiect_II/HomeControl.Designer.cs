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
            panel1.SuspendLayout();
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
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "HomeControl";
            Size = new Size(1123, 720);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
