namespace Proiect_II
{
    partial class ShoppingCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCart));
            listBox1 = new ListBox();
            label1 = new Label();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            listBox3 = new ListBox();
            label4 = new Label();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(466, 129);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(182, 214);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(466, 93);
            label1.Name = "label1";
            label1.Size = new Size(69, 35);
            label1.TabIndex = 1;
            label1.Text = "Products";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(654, 129);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(70, 214);
            listBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(653, 91);
            label2.Name = "label2";
            label2.Size = new Size(68, 35);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(730, 91);
            label3.Name = "label3";
            label3.Size = new Size(45, 35);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(730, 129);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(79, 214);
            listBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(845, 141);
            label4.Name = "label4";
            label4.Size = new Size(48, 35);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(913, 144);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(845, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 109);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton2.Location = new Point(14, 67);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(62, 21);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cash";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton1.Location = new Point(13, 28);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Card";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(845, 196);
            label5.Name = "label5";
            label5.Size = new Size(117, 35);
            label5.TabIndex = 9;
            label5.Text = "Payment method:";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Gabriola", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(466, 416);
            button1.Name = "button1";
            button1.Size = new Size(150, 39);
            button1.TabIndex = 10;
            button1.Text = "Place order";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(491, 353);
            label6.Name = "label6";
            label6.Size = new Size(102, 35);
            label6.TabIndex = 11;
            label6.Text = "Quantity - or +";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(612, 361);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(322, 214);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(listBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "ShoppingCart";
            Size = new Size(1123, 586);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private ListBox listBox3;
        private Label label4;
        private TextBox textBox1;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox textBox2;
        private PictureBox pictureBox1;
    }
}
