namespace Proiect_II
{
    partial class SignUpControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpControl));
            panel1 = new Panel();
            panel2 = new Panel();
            alreadyHaveAccountSignUpButton = new Button();
            RegisterSignUpButton = new Button();
            secondNameSignUpTextBox = new TextBox();
            emailSignUpTextBox = new TextBox();
            passwordSignUpTextBox = new TextBox();
            firstNameSignUpTextBox = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(320, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(803, 586);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(alreadyHaveAccountSignUpButton);
            panel2.Controls.Add(RegisterSignUpButton);
            panel2.Controls.Add(secondNameSignUpTextBox);
            panel2.Controls.Add(emailSignUpTextBox);
            panel2.Controls.Add(passwordSignUpTextBox);
            panel2.Controls.Add(firstNameSignUpTextBox);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(322, 586);
            panel2.TabIndex = 2;
            // 
            // alreadyHaveAccountSignUpButton
            // 
            alreadyHaveAccountSignUpButton.BackColor = Color.Snow;
            alreadyHaveAccountSignUpButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            alreadyHaveAccountSignUpButton.ForeColor = Color.Red;
            alreadyHaveAccountSignUpButton.Location = new Point(1, 442);
            alreadyHaveAccountSignUpButton.Name = "alreadyHaveAccountSignUpButton";
            alreadyHaveAccountSignUpButton.Size = new Size(318, 30);
            alreadyHaveAccountSignUpButton.TabIndex = 5;
            alreadyHaveAccountSignUpButton.Text = "Already have an account?";
            alreadyHaveAccountSignUpButton.UseVisualStyleBackColor = false;
            alreadyHaveAccountSignUpButton.Click += alreadyHaveAccountSignUpButton_Click;
            // 
            // RegisterSignUpButton
            // 
            RegisterSignUpButton.BackColor = Color.Tomato;
            RegisterSignUpButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterSignUpButton.Location = new Point(43, 363);
            RegisterSignUpButton.Name = "RegisterSignUpButton";
            RegisterSignUpButton.Size = new Size(218, 35);
            RegisterSignUpButton.TabIndex = 4;
            RegisterSignUpButton.Text = "Register";
            RegisterSignUpButton.UseVisualStyleBackColor = false;
            // 
            // secondNameSignUpTextBox
            // 
            secondNameSignUpTextBox.BorderStyle = BorderStyle.None;
            secondNameSignUpTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            secondNameSignUpTextBox.Location = new Point(43, 183);
            secondNameSignUpTextBox.Name = "secondNameSignUpTextBox";
            secondNameSignUpTextBox.Size = new Size(218, 20);
            secondNameSignUpTextBox.TabIndex = 3;
            secondNameSignUpTextBox.Text = "Enter your second name:";
            // 
            // emailSignUpTextBox
            // 
            emailSignUpTextBox.BorderStyle = BorderStyle.None;
            emailSignUpTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            emailSignUpTextBox.Location = new Point(43, 239);
            emailSignUpTextBox.Name = "emailSignUpTextBox";
            emailSignUpTextBox.Size = new Size(218, 20);
            emailSignUpTextBox.TabIndex = 2;
            emailSignUpTextBox.Text = "Enter your email address:";
            // 
            // passwordSignUpTextBox
            // 
            passwordSignUpTextBox.BorderStyle = BorderStyle.None;
            passwordSignUpTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            passwordSignUpTextBox.Location = new Point(43, 295);
            passwordSignUpTextBox.Name = "passwordSignUpTextBox";
            passwordSignUpTextBox.Size = new Size(218, 20);
            passwordSignUpTextBox.TabIndex = 1;
            passwordSignUpTextBox.Text = "Enter your password:";
            // 
            // firstNameSignUpTextBox
            // 
            firstNameSignUpTextBox.BorderStyle = BorderStyle.None;
            firstNameSignUpTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            firstNameSignUpTextBox.Location = new Point(43, 127);
            firstNameSignUpTextBox.Name = "firstNameSignUpTextBox";
            firstNameSignUpTextBox.Size = new Size(218, 20);
            firstNameSignUpTextBox.TabIndex = 0;
            firstNameSignUpTextBox.Text = "Enter your first name:";
            // 
            // SignUpControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SignUpControl";
            Size = new Size(1123, 586);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button alreadyHaveAccountSignUpButton;
        private Button RegisterSignUpButton;
        private TextBox secondNameSignUpTextBox;
        private TextBox emailSignUpTextBox;
        private TextBox passwordSignUpTextBox;
        private TextBox firstNameSignUpTextBox;
    }
}
