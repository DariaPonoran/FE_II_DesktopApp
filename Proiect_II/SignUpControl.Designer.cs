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
            textBoxPass = new TextBox();
            textBoxEmail = new TextBox();
            passwordLabel = new Label();
            emailLabel = new Label();
            textBoxLastName = new TextBox();
            textBoxFirstName = new TextBox();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            SuspendLayout();
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(249, 228);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(145, 23);
            textBoxPass.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(249, 188);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(145, 23);
            textBoxEmail.TabIndex = 10;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(116, 225);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(100, 22);
            passwordLabel.TabIndex = 9;
            passwordLabel.Text = "Password:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(81, 185);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(139, 22);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email Address:";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(249, 145);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(145, 23);
            textBoxLastName.TabIndex = 15;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(249, 105);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(145, 23);
            textBoxFirstName.TabIndex = 14;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(108, 142);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(112, 22);
            lastNameLabel.TabIndex = 13;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(112, 102);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(108, 22);
            firstNameLabel.TabIndex = 12;
            firstNameLabel.Text = "First Name:";
            // 
            // SignUpControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxEmail);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Name = "SignUpControl";
            Size = new Size(503, 436);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPass;
        private TextBox textBoxEmail;
        private Label passwordLabel;
        private Label emailLabel;
        private TextBox textBoxLastName;
        private TextBox textBoxFirstName;
        private Label lastNameLabel;
        private Label firstNameLabel;
    }
}
