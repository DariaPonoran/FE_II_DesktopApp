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
            radioButtonCash = new RadioButton();
            radioButtonCard = new RadioButton();
            label5 = new Label();
            button1 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            buttonDeleteItem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(533, 172);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(207, 284);
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(533, 124);
            label1.Name = "label1";
            label1.Size = new Size(86, 45);
            label1.TabIndex = 1;
            label1.Text = "Products";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(747, 172);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.None;
            listBox2.Size = new Size(79, 284);
            listBox2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(746, 121);
            label2.Name = "label2";
            label2.Size = new Size(87, 45);
            label2.TabIndex = 3;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(834, 121);
            label3.Name = "label3";
            label3.Size = new Size(56, 45);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(834, 172);
            listBox3.Margin = new Padding(3, 4, 3, 4);
            listBox3.Name = "listBox3";
            listBox3.SelectionMode = SelectionMode.None;
            listBox3.Size = new Size(90, 284);
            listBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(966, 188);
            label4.Name = "label4";
            label4.Size = new Size(61, 45);
            label4.TabIndex = 6;
            label4.Text = "Total:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1043, 192);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonCash);
            groupBox1.Controls.Add(radioButtonCard);
            groupBox1.Location = new Point(966, 312);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(229, 145);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButtonCash
            // 
            radioButtonCash.AutoSize = true;
            radioButtonCash.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonCash.Location = new Point(16, 89);
            radioButtonCash.Margin = new Padding(3, 4, 3, 4);
            radioButtonCash.Name = "radioButtonCash";
            radioButtonCash.Size = new Size(75, 25);
            radioButtonCash.TabIndex = 1;
            radioButtonCash.TabStop = true;
            radioButtonCash.Text = "Cash";
            radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // radioButtonCard
            // 
            radioButtonCard.AutoSize = true;
            radioButtonCard.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonCard.Location = new Point(15, 37);
            radioButtonCard.Margin = new Padding(3, 4, 3, 4);
            radioButtonCard.Name = "radioButtonCard";
            radioButtonCard.Size = new Size(75, 25);
            radioButtonCard.TabIndex = 0;
            radioButtonCard.TabStop = true;
            radioButtonCard.Text = "Card";
            radioButtonCard.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(966, 261);
            label5.Name = "label5";
            label5.Size = new Size(148, 45);
            label5.TabIndex = 9;
            label5.Text = "Payment method:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Gabriola", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(533, 555);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(171, 52);
            button1.TabIndex = 10;
            button1.Text = "Place order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Gabriola", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(561, 471);
            label6.Name = "label6";
            label6.Size = new Size(130, 45);
            label6.TabIndex = 11;
            label6.Text = "Quantity - or +";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(699, 481);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 172);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(368, 285);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // buttonDeleteItem
            // 
            buttonDeleteItem.BackColor = SystemColors.GradientActiveCaption;
            buttonDeleteItem.BackgroundImageLayout = ImageLayout.None;
            buttonDeleteItem.Font = new Font("Gabriola", 12F, FontStyle.Italic, GraphicsUnit.Point);
            buttonDeleteItem.Location = new Point(834, 478);
            buttonDeleteItem.Margin = new Padding(3, 4, 3, 4);
            buttonDeleteItem.Name = "buttonDeleteItem";
            buttonDeleteItem.Size = new Size(123, 38);
            buttonDeleteItem.TabIndex = 14;
            buttonDeleteItem.Text = "Delete Item";
            buttonDeleteItem.UseVisualStyleBackColor = false;
            buttonDeleteItem.Click += buttonDeleteItem_Click;
            // 
            // ShoppingCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = SystemColors.Info;
            Controls.Add(buttonDeleteItem);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ShoppingCart";
            Size = new Size(1283, 781);
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
        private RadioButton radioButtonCash;
        private RadioButton radioButtonCard;
        private Label label5;
        private Button button1;
        private Label label6;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Button buttonDeleteItem;
    }
}
