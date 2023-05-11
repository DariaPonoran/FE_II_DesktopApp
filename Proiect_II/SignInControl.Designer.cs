namespace Proiect_II
{
    partial class SignInControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInControl));
            panel1 = new Panel();
            signInButton2 = new Button();
            panel2 = new Panel();
            textBoxSignInEmail = new TextBox();
            textBoxSignInPass = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(textBoxSignInPass);
            panel1.Controls.Add(textBoxSignInEmail);
            panel1.Controls.Add(signInButton2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 781);
            panel1.TabIndex = 0;
            // 
            // signInButton2
            // 
            signInButton2.BackColor = Color.Tomato;
            signInButton2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signInButton2.Location = new Point(55, 439);
            signInButton2.Margin = new Padding(3, 4, 3, 4);
            signInButton2.Name = "signInButton2";
            signInButton2.Size = new Size(258, 44);
            signInButton2.TabIndex = 2;
            signInButton2.Text = "Sign In";
            signInButton2.UseVisualStyleBackColor = false;
            signInButton2.Click += signInButton2_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(362, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 781);
            panel2.TabIndex = 1;
            // 
            // textBoxSignInEmail
            // 
            textBoxSignInEmail.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSignInEmail.Location = new Point(55, 229);
            textBoxSignInEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxSignInEmail.Name = "textBoxSignInEmail";
            textBoxSignInEmail.PlaceholderText = "Email Address";
            textBoxSignInEmail.Size = new Size(258, 32);
            textBoxSignInEmail.TabIndex = 25;
            // 
            // textBoxSignInPass
            // 
            textBoxSignInPass.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSignInPass.Location = new Point(55, 343);
            textBoxSignInPass.Margin = new Padding(3, 4, 3, 4);
            textBoxSignInPass.Name = "textBoxSignInPass";
            textBoxSignInPass.PlaceholderText = "Password";
            textBoxSignInPass.Size = new Size(258, 32);
            textBoxSignInPass.TabIndex = 26;
            // 
            // SignInControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SignInControl";
            Size = new Size(1283, 781);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button signInButton2;
        private TextBox textBoxSignInPass;
        private TextBox textBoxSignInEmail;
    }
}
