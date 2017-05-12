namespace Курсовая_БД_ООП.Forms
{
    partial class Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.userNameErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User name:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxUsername.Location = new System.Drawing.Point(150, 38);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(221, 23);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxPassword.Location = new System.Drawing.Point(150, 91);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(221, 23);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxUsername_KeyDown);
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.signInButton.Location = new System.Drawing.Point(248, 148);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(123, 34);
            this.signInButton.TabIndex = 3;
            this.signInButton.Text = "Sign in";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // userNameErrorLabel
            // 
            this.userNameErrorLabel.AutoSize = true;
            this.userNameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.userNameErrorLabel.Location = new System.Drawing.Point(256, 64);
            this.userNameErrorLabel.Name = "userNameErrorLabel";
            this.userNameErrorLabel.Size = new System.Drawing.Size(115, 13);
            this.userNameErrorLabel.TabIndex = 3;
            this.userNameErrorLabel.Text = "User name is incorrect!";
            this.userNameErrorLabel.Visible = false;
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(261, 117);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(110, 13);
            this.passwordErrorLabel.TabIndex = 3;
            this.passwordErrorLabel.Text = "Password is incorrect!";
            this.passwordErrorLabel.Visible = false;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 206);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.userNameErrorLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label userNameErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
    }
}