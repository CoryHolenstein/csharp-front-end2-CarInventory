namespace CarInventory
{
    partial class ChangePasswordUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordUI));
            this.label_NewPassword = new System.Windows.Forms.Label();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.textbox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.button_SaveInformation = new System.Windows.Forms.Button();
            this.PasswordUpdateResponse_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_NewPassword
            // 
            this.label_NewPassword.AutoSize = true;
            this.label_NewPassword.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NewPassword.Location = new System.Drawing.Point(101, 87);
            this.label_NewPassword.Name = "label_NewPassword";
            this.label_NewPassword.Size = new System.Drawing.Size(187, 32);
            this.label_NewPassword.TabIndex = 0;
            this.label_NewPassword.Text = "New Password:";
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.Font = new System.Drawing.Font("High Tower Text", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ConfirmPassword.Location = new System.Drawing.Point(91, 185);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(208, 29);
            this.label_ConfirmPassword.TabIndex = 1;
            this.label_ConfirmPassword.Text = "Confirm Password:";
            // 
            // textbox_password
            // 
            this.textbox_password.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_password.Location = new System.Drawing.Point(307, 92);
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.Size = new System.Drawing.Size(122, 30);
            this.textbox_password.TabIndex = 2;
            this.textbox_password.TextChanged += new System.EventHandler(this.password_TextBox_TextChanged);
            // 
            // textbox_ConfirmPassword
            // 
            this.textbox_ConfirmPassword.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_ConfirmPassword.Location = new System.Drawing.Point(310, 185);
            this.textbox_ConfirmPassword.Name = "textbox_ConfirmPassword";
            this.textbox_ConfirmPassword.Size = new System.Drawing.Size(119, 30);
            this.textbox_ConfirmPassword.TabIndex = 3;
            this.textbox_ConfirmPassword.TextChanged += new System.EventHandler(this.confirmPassword_TextBox_TextChanged);
            // 
            // button_SaveInformation
            // 
            this.button_SaveInformation.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SaveInformation.Location = new System.Drawing.Point(299, 291);
            this.button_SaveInformation.Name = "button_SaveInformation";
            this.button_SaveInformation.Size = new System.Drawing.Size(130, 58);
            this.button_SaveInformation.TabIndex = 4;
            this.button_SaveInformation.Text = "Save";
            this.button_SaveInformation.UseVisualStyleBackColor = true;
            this.button_SaveInformation.Click += new System.EventHandler(this.SaveInformation_Button_Click);
            // 
            // PasswordUpdateResponse_Label
            // 
            this.PasswordUpdateResponse_Label.AutoSize = true;
            this.PasswordUpdateResponse_Label.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordUpdateResponse_Label.Location = new System.Drawing.Point(306, 241);
            this.PasswordUpdateResponse_Label.Name = "PasswordUpdateResponse_Label";
            this.PasswordUpdateResponse_Label.Size = new System.Drawing.Size(0, 19);
            this.PasswordUpdateResponse_Label.TabIndex = 5;
            // 
            // ChangePasswordUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(667, 381);
            this.Controls.Add(this.PasswordUpdateResponse_Label);
            this.Controls.Add(this.button_SaveInformation);
            this.Controls.Add(this.textbox_ConfirmPassword);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.label_ConfirmPassword);
            this.Controls.Add(this.label_NewPassword);
            this.Font = new System.Drawing.Font("High Tower Text", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ChangePasswordUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePasswordUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_NewPassword;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.TextBox textbox_ConfirmPassword;
        private System.Windows.Forms.Button button_SaveInformation;
        private System.Windows.Forms.Label PasswordUpdateResponse_Label;
    }
}