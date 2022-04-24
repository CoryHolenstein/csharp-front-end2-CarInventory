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
            this.AccountSettings_Label = new System.Windows.Forms.Label();
            this.UsernameIdentifier_Label = new System.Windows.Forms.Label();
            this.Username_Label = new System.Windows.Forms.Label();
            this.PasswordIdentifier_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.ChangePassword_Button = new System.Windows.Forms.Button();
            this.MainPage_Button = new System.Windows.Forms.Button();
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
            // UsernameIdentifier_Label
            // 
            this.UsernameIdentifier_Label.AutoSize = true;
            this.UsernameIdentifier_Label.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameIdentifier_Label.Location = new System.Drawing.Point(414, 176);
            this.UsernameIdentifier_Label.Name = "UsernameIdentifier_Label";
            this.UsernameIdentifier_Label.Size = new System.Drawing.Size(117, 28);
            this.UsernameIdentifier_Label.TabIndex = 1;
            this.UsernameIdentifier_Label.Text = "Username:";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(537, 183);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(45, 19);
            this.Username_Label.TabIndex = 2;
            this.Username_Label.Text = "label1";
            // 
            // PasswordIdentifier_Label
            // 
            this.PasswordIdentifier_Label.AutoSize = true;
            this.PasswordIdentifier_Label.Font = new System.Drawing.Font("High Tower Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordIdentifier_Label.Location = new System.Drawing.Point(414, 253);
            this.PasswordIdentifier_Label.Name = "PasswordIdentifier_Label";
            this.PasswordIdentifier_Label.Size = new System.Drawing.Size(111, 28);
            this.PasswordIdentifier_Label.TabIndex = 3;
            this.PasswordIdentifier_Label.Text = "Password:";
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(541, 267);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(45, 19);
            this.Password_Label.TabIndex = 4;
            this.Password_Label.Text = "label1";
            // 
            // ChangePassword_Button
            // 
            this.ChangePassword_Button.Location = new System.Drawing.Point(634, 253);
            this.ChangePassword_Button.Name = "ChangePassword_Button";
            this.ChangePassword_Button.Size = new System.Drawing.Size(68, 33);
            this.ChangePassword_Button.TabIndex = 5;
            this.ChangePassword_Button.Text = "Change";
            this.ChangePassword_Button.UseVisualStyleBackColor = true;
            // 
            // MainPage_Button
            // 
            this.MainPage_Button.Location = new System.Drawing.Point(511, 448);
            this.MainPage_Button.Name = "MainPage_Button";
            this.MainPage_Button.Size = new System.Drawing.Size(114, 47);
            this.MainPage_Button.TabIndex = 6;
            this.MainPage_Button.Text = "Main Page";
            this.MainPage_Button.UseVisualStyleBackColor = true;
            // 
            // AccountSettingsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.MainPage_Button);
            this.Controls.Add(this.ChangePassword_Button);
            this.Controls.Add(this.Password_Label);
            this.Controls.Add(this.PasswordIdentifier_Label);
            this.Controls.Add(this.Username_Label);
            this.Controls.Add(this.UsernameIdentifier_Label);
            this.Controls.Add(this.AccountSettings_Label);
            this.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccountSettingsUI";
            this.Text = "AccountSettingsUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AccountSettings_Label;
        private System.Windows.Forms.Label UsernameIdentifier_Label;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.Label PasswordIdentifier_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button ChangePassword_Button;
        private System.Windows.Forms.Button MainPage_Button;
    }
}