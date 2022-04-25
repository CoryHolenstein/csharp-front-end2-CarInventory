
namespace LoginUI
{
    partial class LoginFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFormUI));
            this.Label_LoginText = new System.Windows.Forms.Label();
            this.textbox_Username = new System.Windows.Forms.TextBox();
            this.textbox_Password = new System.Windows.Forms.TextBox();
            this.label_UsernameIdentifier = new System.Windows.Forms.Label();
            this.label_PasswordIdentifier = new System.Windows.Forms.Label();
            this.Button_LoginButton = new System.Windows.Forms.Button();
            this.Label_LoginResponse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_RegisterRedirect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_LoginText
            // 
            this.Label_LoginText.AutoSize = true;
            this.Label_LoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LoginText.ForeColor = System.Drawing.Color.Brown;
            this.Label_LoginText.Location = new System.Drawing.Point(521, 9);
            this.Label_LoginText.Name = "Label_LoginText";
            this.Label_LoginText.Size = new System.Drawing.Size(142, 55);
            this.Label_LoginText.TabIndex = 0;
            this.Label_LoginText.Text = "Login";
            // 
            // textbox_Username
            // 
            this.textbox_Username.Location = new System.Drawing.Point(498, 237);
            this.textbox_Username.Name = "textbox_Username";
            this.textbox_Username.Size = new System.Drawing.Size(180, 26);
            this.textbox_Username.TabIndex = 1;
            this.textbox_Username.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textbox_Password
            // 
            this.textbox_Password.Location = new System.Drawing.Point(498, 333);
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.Size = new System.Drawing.Size(180, 26);
            this.textbox_Password.TabIndex = 2;
            this.textbox_Password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label_UsernameIdentifier
            // 
            this.label_UsernameIdentifier.AutoSize = true;
            this.label_UsernameIdentifier.Location = new System.Drawing.Point(494, 206);
            this.label_UsernameIdentifier.Name = "label_UsernameIdentifier";
            this.label_UsernameIdentifier.Size = new System.Drawing.Size(79, 19);
            this.label_UsernameIdentifier.TabIndex = 3;
            this.label_UsernameIdentifier.Text = "Username:";
            // 
            // label_PasswordIdentifier
            // 
            this.label_PasswordIdentifier.AutoSize = true;
            this.label_PasswordIdentifier.Location = new System.Drawing.Point(494, 300);
            this.label_PasswordIdentifier.Name = "label_PasswordIdentifier";
            this.label_PasswordIdentifier.Size = new System.Drawing.Size(76, 19);
            this.label_PasswordIdentifier.TabIndex = 4;
            this.label_PasswordIdentifier.Text = "Password:";
            // 
            // Button_LoginButton
            // 
            this.Button_LoginButton.Location = new System.Drawing.Point(591, 365);
            this.Button_LoginButton.Name = "Button_LoginButton";
            this.Button_LoginButton.Size = new System.Drawing.Size(87, 73);
            this.Button_LoginButton.TabIndex = 5;
            this.Button_LoginButton.Text = "Login";
            this.Button_LoginButton.UseVisualStyleBackColor = true;
            this.Button_LoginButton.Click += new System.EventHandler(this.Button_LoginButton_Click);
            // 
            // Label_LoginResponse
            // 
            this.Label_LoginResponse.AutoSize = true;
            this.Label_LoginResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LoginResponse.ForeColor = System.Drawing.Color.Red;
            this.Label_LoginResponse.Location = new System.Drawing.Point(405, 467);
            this.Label_LoginResponse.Name = "Label_LoginResponse";
            this.Label_LoginResponse.Size = new System.Drawing.Size(0, 29);
            this.Label_LoginResponse.TabIndex = 6;
            this.Label_LoginResponse.Click += new System.EventHandler(this.Label_LoginResponse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(756, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "LoginInfo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tan;
            this.label2.Location = new System.Drawing.Point(787, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Tan;
            this.label3.Location = new System.Drawing.Point(778, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "password";
            // 
            // button_RegisterRedirect
            // 
            this.button_RegisterRedirect.Location = new System.Drawing.Point(498, 365);
            this.button_RegisterRedirect.Name = "button_RegisterRedirect";
            this.button_RegisterRedirect.Size = new System.Drawing.Size(87, 73);
            this.button_RegisterRedirect.TabIndex = 10;
            this.button_RegisterRedirect.Text = "Register New Account";
            this.button_RegisterRedirect.UseVisualStyleBackColor = true;
            this.button_RegisterRedirect.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 624);
            this.Controls.Add(this.button_RegisterRedirect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_LoginResponse);
            this.Controls.Add(this.Button_LoginButton);
            this.Controls.Add(this.label_PasswordIdentifier);
            this.Controls.Add(this.label_UsernameIdentifier);
            this.Controls.Add(this.textbox_Password);
            this.Controls.Add(this.textbox_Username);
            this.Controls.Add(this.Label_LoginText);
            this.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginFormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginFormUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_LoginText;
        private System.Windows.Forms.TextBox textbox_Username;
        private System.Windows.Forms.TextBox textbox_Password;
        private System.Windows.Forms.Label label_UsernameIdentifier;
        private System.Windows.Forms.Label label_PasswordIdentifier;
        private System.Windows.Forms.Button Button_LoginButton;
        private System.Windows.Forms.Label Label_LoginResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_RegisterRedirect;
    }
}

