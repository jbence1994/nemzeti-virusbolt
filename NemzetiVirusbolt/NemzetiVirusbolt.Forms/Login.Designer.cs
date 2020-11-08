namespace NemzetiVirusbolt.Forms
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRegistry = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.userIdText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userIdTLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistry
            // 
            this.buttonRegistry.BackColor = System.Drawing.Color.Green;
            this.buttonRegistry.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonRegistry.ForeColor = System.Drawing.Color.Yellow;
            this.buttonRegistry.Location = new System.Drawing.Point(246, 354);
            this.buttonRegistry.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRegistry.Name = "buttonRegistry";
            this.buttonRegistry.Padding = new System.Windows.Forms.Padding(5);
            this.buttonRegistry.Size = new System.Drawing.Size(103, 46);
            this.buttonRegistry.TabIndex = 0;
            this.buttonRegistry.Text = "Registry";
            this.buttonRegistry.UseVisualStyleBackColor = false;
            this.buttonRegistry.Click += new System.EventHandler(this.buttonRegistry_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Green;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.ForeColor = System.Drawing.Color.Yellow;
            this.buttonLogin.Location = new System.Drawing.Point(419, 353);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 47);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // userIdText
            // 
            this.userIdText.Location = new System.Drawing.Point(374, 83);
            this.userIdText.Name = "userIdText";
            this.userIdText.Size = new System.Drawing.Size(173, 27);
            this.userIdText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(374, 146);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(173, 27);
            this.passwordText.TabIndex = 2;
            this.passwordText.UseSystemPasswordChar = true;
            // 
            // userIdTLabel
            // 
            this.userIdTLabel.AutoSize = true;
            this.userIdTLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.userIdTLabel.Location = new System.Drawing.Point(207, 87);
            this.userIdTLabel.Name = "userIdTLabel";
            this.userIdTLabel.Size = new System.Drawing.Size(68, 23);
            this.userIdTLabel.TabIndex = 3;
            this.userIdTLabel.Text = "User ID";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordLabel.Location = new System.Drawing.Point(207, 150);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(85, 23);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userIdTLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userIdText);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonRegistry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistry;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox userIdText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label userIdTLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}

