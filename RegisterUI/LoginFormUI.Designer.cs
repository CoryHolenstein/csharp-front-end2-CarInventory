
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.textBox1.Location = new System.Drawing.Point(498, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(498, 333);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 26);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Label_UsernameInput
            // 
            this.Label_UsernameInput.AutoSize = true;
            this.Label_UsernameInput.Location = new System.Drawing.Point(494, 206);
            this.Label_UsernameInput.Name = "Label_UsernameInput";
            this.Label_UsernameInput.Size = new System.Drawing.Size(79, 19);
            this.Label_UsernameInput.TabIndex = 3;
            this.Label_UsernameInput.Text = "Username:";
            // 
            // Label_PasswordInput
            // 
            this.Label_PasswordInput.AutoSize = true;
            this.Label_PasswordInput.Location = new System.Drawing.Point(494, 300);
            this.Label_PasswordInput.Name = "Label_PasswordInput";
            this.Label_PasswordInput.Size = new System.Drawing.Size(76, 19);
            this.Label_PasswordInput.TabIndex = 4;
            this.Label_PasswordInput.Text = "Password:";
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
            this.label3.Location = new System.Drawing.Point(791, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "pass";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(498, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 73);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register New Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 624);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_LoginResponse);
            this.Controls.Add(this.Button_LoginButton);
            this.Controls.Add(this.Label_PasswordInput);
            this.Controls.Add(this.Label_UsernameInput);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label_LoginText);
            this.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginFormUI";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginFormUI_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

