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
            signInPasswordTextBox = new TextBox();
            signInEmailTextBox = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(signInButton2);
            panel1.Controls.Add(signInPasswordTextBox);
            panel1.Controls.Add(signInEmailTextBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 586);
            panel1.TabIndex = 0;
            // 
            // signInButton2
            // 
            signInButton2.BackColor = Color.Tomato;
            signInButton2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signInButton2.Location = new Point(48, 311);
            signInButton2.Name = "signInButton2";
            signInButton2.Size = new Size(202, 33);
            signInButton2.TabIndex = 2;
            signInButton2.Text = "Sign In";
            signInButton2.UseVisualStyleBackColor = false;
            // 
            // signInPasswordTextBox
            // 
            signInPasswordTextBox.BorderStyle = BorderStyle.None;
            signInPasswordTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            signInPasswordTextBox.Location = new Point(48, 243);
            signInPasswordTextBox.Name = "signInPasswordTextBox";
            signInPasswordTextBox.Size = new Size(202, 20);
            signInPasswordTextBox.TabIndex = 1;
            signInPasswordTextBox.Text = "Type your password:";
            // 
            // signInEmailTextBox
            // 
            signInEmailTextBox.BorderStyle = BorderStyle.None;
            signInEmailTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point);
            signInEmailTextBox.Location = new Point(48, 192);
            signInEmailTextBox.Name = "signInEmailTextBox";
            signInEmailTextBox.Size = new Size(202, 20);
            signInEmailTextBox.TabIndex = 0;
            signInEmailTextBox.Text = "Type your email:";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(317, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(806, 586);
            panel2.TabIndex = 1;
            // 
            // SignInControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SignInControl";
            Size = new Size(1123, 586);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox signInPasswordTextBox;
        private TextBox signInEmailTextBox;
        private Panel panel2;
        private Button signInButton2;
    }
}
