using System;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Json;

namespace LoginUI
{

 


    public partial class LoginFormUI : Form
    {
        String username = "",
            password = "";
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

       


            if (contents.Contains("errormessage"))
            {
                Label_LoginResponse.ForeColor = System.Drawing.Color.Red;
                Label_LoginResponse.Text = "Wrong Username or Password.";
            } else
            {
                Label_LoginResponse.ForeColor = System.Drawing.Color.Green;
                Label_LoginResponse.Text = "Correct! Redirecting you...";
            }


        }

        private void Label_LoginResponse_Click(object sender, EventArgs e)
        {

        }



    }
}
//https://zetcode.com/csharp/getpostrequest/
