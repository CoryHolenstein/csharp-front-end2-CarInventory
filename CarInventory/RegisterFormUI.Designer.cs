
namespace RegisterUI
{
    partial class RegisterFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterFormUI));
            this.label_RegisterTxt = new System.Windows.Forms.Label();
            this.label_UsernameIdentifier = new System.Windows.Forms.Label();
            this.textbox_Username = new System.Windows.Forms.TextBox();
            this.label_PasswordIdentifier = new System.Windows.Forms.Label();
            this.textbox_Password = new System.Windows.Forms.TextBox();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.textbox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.button_LoginRedirect = new System.Windows.Forms.Button();
            this.button_RegisterAccount = new System.Windows.Forms.Button();
            this.Label_RegisterResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_RegisterTxt
            // 
            this.label_RegisterTxt.AutoSize = true;
            this.label_RegisterTxt.Font = new System.Drawing.Font("High Tower Text", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RegisterTxt.ForeColor = System.Drawing.Color.Brown;
            this.label_RegisterTxt.Location = new System.Drawing.Point(487, 9);
            this.label_RegisterTxt.Name = "label_RegisterTxt";
            this.label_RegisterTxt.Size = new System.Drawing.Size(187, 57);
            this.label_RegisterTxt.TabIndex = 0;
            this.label_RegisterTxt.Text = "Register";
            // 
            // label_UsernameIdentifier
            // 
            this.label_UsernameIdentifier.AutoSize = true;
            this.label_UsernameIdentifier.Location = new System.Drawing.Point(493, 176);
            this.label_UsernameIdentifier.Name = "label_UsernameIdentifier";
            this.label_UsernameIdentifier.Size = new System.Drawing.Size(79, 19);
            this.label_UsernameIdentifier.TabIndex = 1;
            this.label_UsernameIdentifier.Text = "Username:";
            // 
            // textbox_Username
            // 
            this.textbox_Username.Location = new System.Drawing.Point(497, 198);
            this.textbox_Username.Name = "textbox_Username";
            this.textbox_Username.Size = new System.Drawing.Size(174, 26);
            this.textbox_Username.TabIndex = 2;
            this.textbox_Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_PasswordIdentifier
            // 
            this.label_PasswordIdentifier.AutoSize = true;
            this.label_PasswordIdentifier.Location = new System.Drawing.Point(496, 244);
            this.label_PasswordIdentifier.Name = "label_PasswordIdentifier";
            this.label_PasswordIdentifier.Size = new System.Drawing.Size(76, 19);
            this.label_PasswordIdentifier.TabIndex = 3;
            this.label_PasswordIdentifier.Text = "Password:";
            // 
            // textbox_Password
            // 
            this.textbox_Password.Location = new System.Drawing.Point(497, 266);
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.Size = new System.Drawing.Size(177, 26);
            this.textbox_Password.TabIndex = 4;
            this.textbox_Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.Location = new System.Drawing.Point(496, 322);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(136, 19);
            this.label_ConfirmPassword.TabIndex = 5;
            this.label_ConfirmPassword.Text = "Confirm Password:";
            // 
            // textbox_ConfirmPassword
            // 
            this.textbox_ConfirmPassword.Location = new System.Drawing.Point(497, 344);
            this.textbox_ConfirmPassword.Name = "textbox_ConfirmPassword";
            this.textbox_ConfirmPassword.Size = new System.Drawing.Size(174, 26);
            this.textbox_ConfirmPassword.TabIndex = 6;
            this.textbox_ConfirmPassword.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button_LoginRedirect
            // 
            this.button_LoginRedirect.Location = new System.Drawing.Point(497, 376);
            this.button_LoginRedirect.Name = "button_LoginRedirect";
            this.button_LoginRedirect.Size = new System.Drawing.Size(83, 67);
            this.button_LoginRedirect.TabIndex = 7;
            this.button_LoginRedirect.Text = "Back To Login";
            this.button_LoginRedirect.UseVisualStyleBackColor = true;
            this.button_LoginRedirect.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_RegisterAccount
            // 
            this.button_RegisterAccount.Location = new System.Drawing.Point(586, 376);
            this.button_RegisterAccount.Name = "button_RegisterAccount";
            this.button_RegisterAccount.Size = new System.Drawing.Size(85, 67);
            this.button_RegisterAccount.TabIndex = 8;
            this.button_RegisterAccount.Text = "Register Account";
            this.button_RegisterAccount.UseVisualStyleBackColor = true;
            this.button_RegisterAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // Label_RegisterResponse
            // 
            this.Label_RegisterResponse.AutoSize = true;
            this.Label_RegisterResponse.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_RegisterResponse.Location = new System.Drawing.Point(393, 478);
            this.Label_RegisterResponse.Name = "Label_RegisterResponse";
            this.Label_RegisterResponse.Size = new System.Drawing.Size(0, 25);
            this.Label_RegisterResponse.TabIndex = 9;
            // 
            // RegisterFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 624);
            this.Controls.Add(this.Label_RegisterResponse);
            this.Controls.Add(this.button_RegisterAccount);
            this.Controls.Add(this.button_LoginRedirect);
            this.Controls.Add(this.textbox_ConfirmPassword);
            this.Controls.Add(this.label_ConfirmPassword);
            this.Controls.Add(this.textbox_Password);
            this.Controls.Add(this.label_PasswordIdentifier);
            this.Controls.Add(this.textbox_Username);
            this.Controls.Add(this.label_UsernameIdentifier);
            this.Controls.Add(this.label_RegisterTxt);
            this.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterFormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_RegisterTxt;
        private System.Windows.Forms.Label label_UsernameIdentifier;
        private System.Windows.Forms.TextBox textbox_Username;
        private System.Windows.Forms.Label label_PasswordIdentifier;
        private System.Windows.Forms.TextBox textbox_Password;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private System.Windows.Forms.TextBox textbox_ConfirmPassword;
        private System.Windows.Forms.Button button_LoginRedirect;
        private System.Windows.Forms.Button button_RegisterAccount;
        private System.Windows.Forms.Label Label_RegisterResponse;
    }
}

