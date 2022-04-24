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
            this.NewPassword_Label = new System.Windows.Forms.Label();
            this.ConfirmPassword_Label = new System.Windows.Forms.Label();
            this.password_Textbox = new System.Windows.Forms.TextBox();
            this.username_TextBox = new System.Windows.Forms.TextBox();
            this.SaveInformation_Button = new System.Windows.Forms.Button();
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
            // password_Textbox
            // 
            this.password_Textbox.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_Textbox.Location = new System.Drawing.Point(307, 92);
            this.password_Textbox.Name = "password_Textbox";
            this.password_Textbox.Size = new System.Drawing.Size(122, 30);
            this.password_Textbox.TabIndex = 2;
            // 
            // username_TextBox
            // 
            this.username_TextBox.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_TextBox.Location = new System.Drawing.Point(310, 185);
            this.username_TextBox.Name = "username_TextBox";
            this.username_TextBox.Size = new System.Drawing.Size(119, 30);
            this.username_TextBox.TabIndex = 3;
            // 
            // SaveInformation_Button
            // 
            this.SaveInformation_Button.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveInformation_Button.Location = new System.Drawing.Point(299, 278);
            this.SaveInformation_Button.Name = "SaveInformation_Button";
            this.SaveInformation_Button.Size = new System.Drawing.Size(130, 58);
            this.SaveInformation_Button.TabIndex = 4;
            this.SaveInformation_Button.Text = "Save";
            this.SaveInformation_Button.UseVisualStyleBackColor = true;
            // 
            // ChangePasswordUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(667, 381);
            this.Controls.Add(this.SaveInformation_Button);
            this.Controls.Add(this.username_TextBox);
            this.Controls.Add(this.password_Textbox);
            this.Controls.Add(this.ConfirmPassword_Label);
            this.Controls.Add(this.NewPassword_Label);
            this.Font = new System.Drawing.Font("High Tower Text", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ChangePasswordUI";
            this.Text = "ChangePasswordUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewPassword_Label;
        private System.Windows.Forms.Label ConfirmPassword_Label;
        private System.Windows.Forms.TextBox password_Textbox;
        private System.Windows.Forms.TextBox username_TextBox;
        private System.Windows.Forms.Button SaveInformation_Button;
    }
}