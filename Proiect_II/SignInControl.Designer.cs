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
            textBoxPass = new TextBox();
            textBoxUser = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            SuspendLayout();
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(282, 198);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(145, 23);
            textBoxPass.TabIndex = 7;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(282, 158);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(145, 23);
            textBoxUser.TabIndex = 6;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(141, 195);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(100, 22);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(102, 159);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(139, 22);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email Address:";
            // 
            // SignInControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Name = "SignInControl";
            Size = new Size(569, 376);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPass;
        private TextBox textBoxUser;
        private Label passwordLabel;
        private Label emailLabel;
    }
}
