namespace CarInventory
{
    partial class AccountSettingsUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountSettingsUI));
            this.AccountSettings_Label = new System.Windows.Forms.Label();
            this.label_UsernameIdentifier = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_PasswordIdentifier = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_ChangePassword = new System.Windows.Forms.Button();
            this.button_MainPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AccountSettings_Label
            // 
            this.AccountSettings_Label.AutoSize = true;
            this.AccountSettings_Label.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountSettings_Label.Location = new System.Drawing.Point(404, 9);
            this.AccountSettings_Label.Name = "AccountSettings_Label";
            this.AccountSettings_Label.Size = new System.Drawing.Size(367, 57);
            this.AccountSettings_Label.TabIndex = 0;
            this.AccountSettings_Label.Text = "Account Settings";
            // 
            // label_UsernameIdentifier
            // 
            this.label_UsernameIdentifier.AutoSize = true;
            this.label_UsernameIdentifier.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UsernameIdentifier.Location = new System.Drawing.Point(414, 176);
            this.label_UsernameIdentifier.Name = "label_UsernameIdentifier";
            this.label_UsernameIdentifier.Size = new System.Drawing.Size(117, 28);
            this.label_UsernameIdentifier.TabIndex = 1;
            this.label_UsernameIdentifier.Text = "Username:";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(537, 183);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(45, 19);
            this.label_Username.TabIndex = 2;
            this.label_Username.Text = "label1";
            // 
            // label_PasswordIdentifier
            // 
            this.label_PasswordIdentifier.AutoSize = true;
            this.label_PasswordIdentifier.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PasswordIdentifier.Location = new System.Drawing.Point(414, 253);
            this.label_PasswordIdentifier.Name = "label_PasswordIdentifier";
            this.label_PasswordIdentifier.Size = new System.Drawing.Size(111, 28);
            this.label_PasswordIdentifier.TabIndex = 3;
            this.label_PasswordIdentifier.Text = "Password:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(541, 267);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(45, 19);
            this.label_Password.TabIndex = 4;
            this.label_Password.Text = "label1";
            // 
            // button_ChangePassword
            // 
            this.button_ChangePassword.Location = new System.Drawing.Point(634, 253);
            this.button_ChangePassword.Name = "button_ChangePassword";
            this.button_ChangePassword.Size = new System.Drawing.Size(68, 33);
            this.button_ChangePassword.TabIndex = 5;
            this.button_ChangePassword.Text = "Change";
            this.button_ChangePassword.UseVisualStyleBackColor = true;
            this.button_ChangePassword.Click += new System.EventHandler(this.ChangePassword_Button_Click);
            // 
            // button_MainPage
            // 
            this.button_MainPage.Location = new System.Drawing.Point(511, 448);
            this.button_MainPage.Name = "button_MainPage";
            this.button_MainPage.Size = new System.Drawing.Size(114, 47);
            this.button_MainPage.TabIndex = 6;
            this.button_MainPage.Text = "Main Page";
            this.button_MainPage.UseVisualStyleBackColor = true;
            this.button_MainPage.Click += new System.EventHandler(this.MainPage_Button_Click);
            // 
            // AccountSettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.button_MainPage);
            this.Controls.Add(this.button_ChangePassword);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_PasswordIdentifier);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_UsernameIdentifier);
            this.Controls.Add(this.AccountSettings_Label);
            this.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountSettingsUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountSettingsUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountSettings_Label;
        private System.Windows.Forms.Label label_UsernameIdentifier;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_PasswordIdentifier;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_ChangePassword;
        private System.Windows.Forms.Button button_MainPage;
    }
}