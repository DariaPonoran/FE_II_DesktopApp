namespace Proiect_II
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            textBoxCardholderName = new TextBox();
            textBoxCardMonth = new TextBox();
            textBoxCVV = new TextBox();
            textBoxCardNumber = new TextBox();
            textBoxCardYear = new TextBox();
            button1 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxCardholderName
            // 
            textBoxCardholderName.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCardholderName.Location = new Point(297, 162);
            textBoxCardholderName.Name = "textBoxCardholderName";
            textBoxCardholderName.PlaceholderText = "Cardholder Name";
            textBoxCardholderName.Size = new Size(289, 32);
            textBoxCardholderName.TabIndex = 0;
            // 
            // textBoxCardMonth
            // 
            textBoxCardMonth.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCardMonth.Location = new Point(297, 224);
            textBoxCardMonth.Name = "textBoxCardMonth";
            textBoxCardMonth.PlaceholderText = "12";
            textBoxCardMonth.Size = new Size(80, 32);
            textBoxCardMonth.TabIndex = 1;
            // 
            // textBoxCVV
            // 
            textBoxCVV.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCVV.Location = new Point(503, 224);
            textBoxCVV.Name = "textBoxCVV";
            textBoxCVV.PlaceholderText = "CVV";
            textBoxCVV.Size = new Size(83, 32);
            textBoxCVV.TabIndex = 2;
            // 
            // textBoxCardNumber
            // 
            textBoxCardNumber.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCardNumber.Location = new Point(297, 101);
            textBoxCardNumber.Name = "textBoxCardNumber";
            textBoxCardNumber.PlaceholderText = "Card Number";
            textBoxCardNumber.Size = new Size(289, 32);
            textBoxCardNumber.TabIndex = 3;
            // 
            // textBoxCardYear
            // 
            textBoxCardYear.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCardYear.Location = new Point(401, 224);
            textBoxCardYear.Name = "textBoxCardYear";
            textBoxCardYear.PlaceholderText = "2026";
            textBoxCardYear.Size = new Size(80, 32);
            textBoxCardYear.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(297, 279);
            button1.Name = "button1";
            button1.Size = new Size(184, 34);
            button1.TabIndex = 5;
            button1.Text = "Confirm And Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(122, 39);
            label1.Name = "label1";
            label1.Size = new Size(441, 34);
            label1.TabIndex = 6;
            label1.Text = "Please Enter Your Card Details: ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(78, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.LightCoral;
            buttonCancel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCancel.Location = new Point(487, 279);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(99, 34);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(673, 364);
            ControlBox = false;
            Controls.Add(buttonCancel);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxCardYear);
            Controls.Add(textBoxCardNumber);
            Controls.Add(textBoxCVV);
            Controls.Add(textBoxCardMonth);
            Controls.Add(textBoxCardholderName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCardholderName;
        private TextBox textBoxCardMonth;
        private TextBox textBoxCVV;
        private TextBox textBoxCardNumber;
        private TextBox textBoxCardYear;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonCancel;
    }
}