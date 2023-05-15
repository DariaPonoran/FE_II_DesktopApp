namespace Proiect_II
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(243, 222, 212);
            label1.Font = new Font("Leelawadee UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(468, 62);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 0;
            label1.Text = "Track your order here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(42, 207);
            label2.Name = "label2";
            label2.Size = new Size(205, 18);
            label2.TabIndex = 1;
            label2.Text = "Order with the number:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 210);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 2;
            label3.Text = "label3-id comanda";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(42, 307);
            label4.Name = "label4";
            label4.Size = new Size(161, 18);
            label4.TabIndex = 3;
            label4.Text = "Will be arriving at:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 310);
            label5.Name = "label5";
            label5.Size = new Size(259, 15);
            label5.TabIndex = 4;
            label5.Text = "generare random o perioada pana in jum de ora";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(42, 402);
            label6.Name = "label6";
            label6.Size = new Size(64, 18);
            label6.TabIndex = 5;
            label6.Text = "Driver:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(123, 405);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(559, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(487, 336);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 222, 212);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Order";
            Size = new Size(1123, 586);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
    }
}
