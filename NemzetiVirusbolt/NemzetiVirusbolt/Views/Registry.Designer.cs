namespace NemzetiVirusbolt
{
    partial class Registry
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
            this.nameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.password2Text = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password2Label = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.registryNowButton = new System.Windows.Forms.Button();
            this.registryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(320, 82);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(125, 27);
            this.nameText.TabIndex = 0;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(320, 228);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(125, 27);
            this.emailText.TabIndex = 0;
            // 
            // password2Text
            // 
            this.password2Text.Location = new System.Drawing.Point(320, 179);
            this.password2Text.Name = "password2Text";
            this.password2Text.Size = new System.Drawing.Size(125, 27);
            this.password2Text.TabIndex = 0;
            this.password2Text.UseSystemPasswordChar = true;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(320, 126);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(125, 27);
            this.passwordText.TabIndex = 0;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(166, 82);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(57, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(166, 130);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(85, 23);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // password2Label
            // 
            this.password2Label.AutoSize = true;
            this.password2Label.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password2Label.Location = new System.Drawing.Point(166, 178);
            this.password2Label.Name = "password2Label";
            this.password2Label.Size = new System.Drawing.Size(134, 28);
            this.password2Label.TabIndex = 1;
            this.password2Label.Text = "Password again";
            this.password2Label.UseCompatibleTextRendering = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.Location = new System.Drawing.Point(166, 228);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(54, 23);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "Email";
            // 
            // registryNowButton
            // 
            this.registryNowButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registryNowButton.Location = new System.Drawing.Point(264, 343);
            this.registryNowButton.Name = "registryNowButton";
            this.registryNowButton.Size = new System.Drawing.Size(94, 29);
            this.registryNowButton.TabIndex = 2;
            this.registryNowButton.Text = "Registry";
            this.registryNowButton.UseVisualStyleBackColor = true;
            this.registryNowButton.Click += new System.EventHandler(this.registryNowButton_Click);
            // 
            // registryLabel
            // 
            this.registryLabel.AutoSize = true;
            this.registryLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.registryLabel.Location = new System.Drawing.Point(238, 9);
            this.registryLabel.Name = "registryLabel";
            this.registryLabel.Size = new System.Drawing.Size(135, 41);
            this.registryLabel.TabIndex = 3;
            this.registryLabel.Text = "Registry";
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registryLabel);
            this.Controls.Add(this.registryNowButton);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.password2Label);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.password2Text);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.nameText);
            this.Name = "Registry";
            this.Text = "Registry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox password2Text;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label password2Label;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button registryNowButton;
        private System.Windows.Forms.Label registryLabel;
    }
}