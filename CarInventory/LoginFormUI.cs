using System;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Json;
using CarInventory;
using static UserInformation.UserInformation;
using Microsoft.AspNetCore.Http;
using System.Web;
using RegisterUI;

namespace LoginUI
{




    public partial class LoginFormUI : Form
    {
       
        String username = "",
            password = "";

        const String SessionUser = "";
        public class LoginInfo
        {
            public String username { get; set; }
            public String password { get; set; }

            public LoginInfo(String user, String pass)
            {
                username = user;
                password = pass;
            }
        }

     
        public LoginFormUI()
        {
            InitializeComponent();
        }

    
        //username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           username = textbox_Username.Text;
        }
        //password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textbox_Password.Text;
        }

        private async void Button_LoginButton_Click(object sender, EventArgs e)
        {


            var client = new HttpClient();

            var userInfo = new LoginInfo(username, password);
            var requestContent = JsonContent.Create(userInfo);

            var response = await client.PostAsync("http://localhost:3000/users/login", requestContent);
            var contents = await response.Content.ReadAsStringAsync();



            var statusCode = (int)response.StatusCode;

        
            if (statusCode == 500)
            {
                Label_LoginResponse.ForeColor = System.Drawing.Color.Red;
                Label_LoginResponse.Text = "Server Error";

            }
            else if (statusCode == 400)
            {
                 Label_LoginResponse.ForeColor = System.Drawing.Color.Red;
                 Label_LoginResponse.Text = "User not found or wrong password entered.";


            }  
            else if (statusCode == 200)
            {
                 Label_LoginResponse.ForeColor = System.Drawing.Color.Green;
                 Label_LoginResponse.Text = "Logged in. Redirecting you...";

                Stored_UserName = userInfo.username;
                Form carInventoryform = new Form();
                ((Control)ActiveForm).Hide();
                carInventoryform = new CarInventory.CarInventoryUI();
                carInventoryform.Show();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Form registerUI = new Form();
            ((Control)ActiveForm).Hide();
            registerUI = new RegisterFormUI();
            registerUI.Show();
        }

        private void LoginFormUI_Load(object sender, EventArgs e)
        {

        }

        private void Label_LoginResponse_Click(object sender, EventArgs e)
        {

        }



    }
}
//https://zetcode.com/csharp/getpostrequest/
