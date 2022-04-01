using System;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Json;
using CarInventory;
using Microsoft.AspNetCore.Http;


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
           username = textBox1.Text;
        }
        //password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }

        private async void Button_LoginButton_Click(object sender, EventArgs e)
        {


            var client = new HttpClient();

            var userInfo = new LoginInfo(username, password);
            var requestContent = JsonContent.Create(userInfo);

            var response = await client.PostAsync("http://localhost:3000/users/login", requestContent);
            var contents = await response.Content.ReadAsStringAsync();



            var statusCode = (int)response.StatusCode;

            //for entity framework server
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

         //       HttpContext.Session.SetString(SessionUser, "Jarvik");
                //   Session["someKey1"] = "My Special Value";
                Form carInventoryform = new Form();
                ((Control)ActiveForm).Hide();
                carInventoryform = new CarInventoryUI();
                carInventoryform.Show();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            Form registerForm = new Form();
            ((Control)ActiveForm).Hide();
          
        //    registerForm = new RegisterFormUI();

            registerForm.Show();
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
