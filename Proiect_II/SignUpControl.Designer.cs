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
            textBoxClientOras = new TextBox();
            textBoxClientNrTel = new TextBox();
            textBoxClientPassConf = new TextBox();
            textBoxClientPass = new TextBox();
            textBoxClientEmail = new TextBox();
            textBoxClientNumeFam = new TextBox();
            textBoxClientPrenume = new TextBox();
            alreadyHaveAccountSignUpButton = new Button();
            RegisterSignUpButton = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(366, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 781);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBoxClientOras);
            panel2.Controls.Add(textBoxClientNrTel);
            panel2.Controls.Add(textBoxClientPassConf);
            panel2.Controls.Add(textBoxClientPass);
            panel2.Controls.Add(textBoxClientEmail);
            panel2.Controls.Add(textBoxClientNumeFam);
            panel2.Controls.Add(textBoxClientPrenume);
            panel2.Controls.Add(alreadyHaveAccountSignUpButton);
            panel2.Controls.Add(RegisterSignUpButton);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(368, 781);
            panel2.TabIndex = 2;
            // 
            // textBoxClientOras
            // 
            textBoxClientOras.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClientOras.Location = new Point(40, 482);
            textBoxClientOras.Margin = new Padding(3, 4, 3, 4);
            textBoxClientOras.Name = "textBoxClientOras";
            textBoxClientOras.PlaceholderText = "City";
            textBoxClientOras.Size = new Size(258, 32);
            textBoxClientOras.TabIndex = 30;
            // 
            // textBoxClientNrTel
            // 
            textBoxClientNrTel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClientNrTel.Location = new Point(40, 286);
            textBoxClientNrTel.Margin = new Padding(3, 4, 3, 4);
            textBoxClientNrTel.Name = "textBoxClientNrTel";
            textBoxClientNrTel.PlaceholderText = "Phone Number";
            textBoxClientNrTel.Size = new Size(258, 32);
            textBoxClientNrTel.TabIndex = 29;
            // 
            // textBoxClientPassConf
            // 
            textBoxClientPassConf.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClientPassConf.Location = new Point(40, 415);
            textBoxClientPassConf.Margin = new Padding(3, 4, 3, 4);
            textBoxClientPassConf.Name = "textBoxClientPassConf";
            textBoxClientPassConf.PlaceholderText = "Confirm Password";
            textBoxClientPassConf.Size = new Size(258, 32);
            textBoxClientPassConf.TabIndex = 28;
            textBoxClientPassConf.UseSystemPasswordChar = true;
            // 
            // textBoxClientPass
            // 
            textBoxClientPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClientPass.Location = new Point(40, 354);
            textBoxClientPass.Margin = new Padding(3, 4, 3, 4);
            textBoxClientPass.Name = "textBoxClientPass";
            textBoxClientPass.PlaceholderText = "Password";
            textBoxClientPass.Size = new Size(258, 32);
            textBoxClientPass.TabIndex = 27;
            textBoxClientPass.UseSystemPasswordChar = true;
            // 
            // textBoxClientEmail
            // 
            textBoxClientEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClientEmail.Location = new Point(40, 221);
            textBoxClientEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxClientEmail.Name = "textBoxClientEmail";
            textBoxClientEmail.PlaceholderText = "Email Address";
            textBoxClientEmail.Size = new Size(258, 32);
            textBoxClientEmail.TabIndex = 26;
            // 
            // textBoxClientNumeFam
            // 
            textBoxClientNumeFam.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClientNumeFam.Location = new Point(40, 153);
            textBoxClientNumeFam.Margin = new Padding(3, 4, 3, 4);
            textBoxClientNumeFam.Name = "textBoxClientNumeFam";
            textBoxClientNumeFam.PlaceholderText = "Last Name";
            textBoxClientNumeFam.Size = new Size(258, 32);
            textBoxClientNumeFam.TabIndex = 25;
            // 
            // textBoxClientPrenume
            // 
            textBoxClientPrenume.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxClientPrenume.Location = new Point(40, 87);
            textBoxClientPrenume.Margin = new Padding(3, 4, 3, 4);
            textBoxClientPrenume.Name = "textBoxClientPrenume";
            textBoxClientPrenume.PlaceholderText = "First Name";
            textBoxClientPrenume.Size = new Size(258, 32);
            textBoxClientPrenume.TabIndex = 24;
            // 
            // alreadyHaveAccountSignUpButton
            // 
            alreadyHaveAccountSignUpButton.BackColor = Color.Snow;
            alreadyHaveAccountSignUpButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            alreadyHaveAccountSignUpButton.ForeColor = Color.Red;
            alreadyHaveAccountSignUpButton.Location = new Point(2, 614);
            alreadyHaveAccountSignUpButton.Margin = new Padding(3, 4, 3, 4);
            alreadyHaveAccountSignUpButton.Name = "alreadyHaveAccountSignUpButton";
            alreadyHaveAccountSignUpButton.Size = new Size(363, 40);
            alreadyHaveAccountSignUpButton.TabIndex = 5;
            alreadyHaveAccountSignUpButton.Text = "Already have an account?";
            alreadyHaveAccountSignUpButton.UseVisualStyleBackColor = false;
            alreadyHaveAccountSignUpButton.Click += alreadyHaveAccountSignUpButton_Click;
            // 
            // RegisterSignUpButton
            // 
            RegisterSignUpButton.BackColor = Color.Tomato;
            RegisterSignUpButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RegisterSignUpButton.Location = new Point(40, 540);
            RegisterSignUpButton.Margin = new Padding(3, 4, 3, 4);
            RegisterSignUpButton.Name = "RegisterSignUpButton";
            RegisterSignUpButton.Size = new Size(258, 47);
            RegisterSignUpButton.TabIndex = 4;
            RegisterSignUpButton.Text = "Register";
            RegisterSignUpButton.UseVisualStyleBackColor = false;
            RegisterSignUpButton.Click += RegisterSignUpButton_Click;
            // 
            // SignUpControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignUpControl";
            Size = new Size(1283, 781);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button alreadyHaveAccountSignUpButton;
        private Button RegisterSignUpButton;
        private TextBox textBoxClientPrenume;
        private TextBox textBoxClientPass;
        private TextBox textBoxClientEmail;
        private TextBox textBoxClientNumeFam;
        private TextBox textBoxClientPassConf;
        private TextBox textBoxClientNrTel;
        private TextBox textBoxClientOras;
    }
}
