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
            this.NewPassword_Label = new System.Windows.Forms.Label();
            this.ConfirmPassword_Label = new System.Windows.Forms.Label();
            this.password_TextBox = new System.Windows.Forms.TextBox();
            this.confirmPassword_TextBox = new System.Windows.Forms.TextBox();
            this.SaveInformation_Button = new System.Windows.Forms.Button();
            this.PasswordUpdateResponse_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewPassword_Label
            // 
            this.NewPassword_Label.AutoSize = true;
            this.NewPassword_Label.Font = new System.Drawing.Font("High Tower Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPassword_Label.Location = new System.Drawing.Point(101, 87);
            this.NewPassword_Label.Name = "NewPassword_Label";
            this.NewPassword_Label.Size = new System.Drawing.Size(187, 32);
            this.NewPassword_Label.TabIndex = 0;
            this.NewPassword_Label.Text = "New Password:";
            // 
            // ConfirmPassword_Label
            // 
            this.ConfirmPassword_Label.AutoSize = true;
            this.ConfirmPassword_Label.Font = new System.Drawing.Font("High Tower Text", 18.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPassword_Label.Location = new System.Drawing.Point(91, 185);
            this.ConfirmPassword_Label.Name = "ConfirmPassword_Label";
            this.ConfirmPassword_Label.Size = new System.Drawing.Size(208, 29);
            this.ConfirmPassword_Label.TabIndex = 1;
            this.ConfirmPassword_Label.Text = "Confirm Password:";
            // 
            // password_TextBox
            // 
            this.password_TextBox.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_TextBox.Location = new System.Drawing.Point(307, 92);
            this.password_TextBox.Name = "password_TextBox";
            this.password_TextBox.Size = new System.Drawing.Size(122, 30);
            this.password_TextBox.TabIndex = 2;
            this.password_TextBox.TextChanged += new System.EventHandler(this.password_TextBox_TextChanged);
            // 
            // confirmPassword_TextBox
            // 
            this.confirmPassword_TextBox.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPassword_TextBox.Location = new System.Drawing.Point(310, 185);
            this.confirmPassword_TextBox.Name = "confirmPassword_TextBox";
            this.confirmPassword_TextBox.Size = new System.Drawing.Size(119, 30);
            this.confirmPassword_TextBox.TabIndex = 3;
            this.confirmPassword_TextBox.TextChanged += new System.EventHandler(this.confirmPassword_TextBox_TextChanged);
            // 
            // SaveInformation_Button
            // 
            this.SaveInformation_Button.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveInformation_Button.Location = new System.Drawing.Point(299, 291);
            this.SaveInformation_Button.Name = "SaveInformation_Button";
            this.SaveInformation_Button.Size = new System.Drawing.Size(130, 58);
            this.SaveInformation_Button.TabIndex = 4;
            this.SaveInformation_Button.Text = "Save";
            this.SaveInformation_Button.UseVisualStyleBackColor = true;
            this.SaveInformation_Button.Click += new System.EventHandler(this.SaveInformation_Button_Click);
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
            this.Controls.Add(this.SaveInformation_Button);
            this.Controls.Add(this.confirmPassword_TextBox);
            this.Controls.Add(this.password_TextBox);
            this.Controls.Add(this.ConfirmPassword_Label);
            this.Controls.Add(this.NewPassword_Label);
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

        private System.Windows.Forms.Label NewPassword_Label;
        private System.Windows.Forms.Label ConfirmPassword_Label;
        private System.Windows.Forms.TextBox password_TextBox;
        private System.Windows.Forms.TextBox confirmPassword_TextBox;
        private System.Windows.Forms.Button SaveInformation_Button;
        private System.Windows.Forms.Label PasswordUpdateResponse_Label;
    }
}