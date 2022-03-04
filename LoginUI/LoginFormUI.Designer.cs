
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
            this.Label_LoginText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Label_UsernameInput = new System.Windows.Forms.Label();
            this.Label_PasswordInput = new System.Windows.Forms.Label();
            this.Button_LoginButton = new System.Windows.Forms.Button();
            this.Label_LoginResponse = new System.Windows.Forms.Label();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 250);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(512, 351);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Label_UsernameInput
            // 
            this.Label_UsernameInput.AutoSize = true;
            this.Label_UsernameInput.Location = new System.Drawing.Point(518, 216);
            this.Label_UsernameInput.Name = "Label_UsernameInput";
            this.Label_UsernameInput.Size = new System.Drawing.Size(87, 20);
            this.Label_UsernameInput.TabIndex = 3;
            this.Label_UsernameInput.Text = "Username:";
            // 
            // Label_PasswordInput
            // 
            this.Label_PasswordInput.AutoSize = true;
            this.Label_PasswordInput.Location = new System.Drawing.Point(518, 314);
            this.Label_PasswordInput.Name = "Label_PasswordInput";
            this.Label_PasswordInput.Size = new System.Drawing.Size(82, 20);
            this.Label_PasswordInput.TabIndex = 4;
            this.Label_PasswordInput.Text = "Password:";
            // 
            // Button_LoginButton
            // 
            this.Button_LoginButton.Location = new System.Drawing.Point(555, 402);
            this.Button_LoginButton.Name = "Button_LoginButton";
            this.Button_LoginButton.Size = new System.Drawing.Size(87, 35);
            this.Button_LoginButton.TabIndex = 5;
            this.Button_LoginButton.Text = "Login";
            this.Button_LoginButton.UseVisualStyleBackColor = true;
            // 
            // Label_LoginResponse
            // 
            this.Label_LoginResponse.AutoSize = true;
            this.Label_LoginResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_LoginResponse.ForeColor = System.Drawing.Color.Red;
            this.Label_LoginResponse.Location = new System.Drawing.Point(507, 467);
            this.Label_LoginResponse.Name = "Label_LoginResponse";
            this.Label_LoginResponse.Size = new System.Drawing.Size(217, 29);
            this.Label_LoginResponse.TabIndex = 6;
            this.Label_LoginResponse.Text = "<Login Response>";
            // 
            // LoginFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 657);
            this.Controls.Add(this.Label_LoginResponse);
            this.Controls.Add(this.Button_LoginButton);
            this.Controls.Add(this.Label_PasswordInput);
            this.Controls.Add(this.Label_UsernameInput);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label_LoginText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginFormUI";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_LoginText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Label_UsernameInput;
        private System.Windows.Forms.Label Label_PasswordInput;
        private System.Windows.Forms.Button Button_LoginButton;
        private System.Windows.Forms.Label Label_LoginResponse;
    }
}

