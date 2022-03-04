using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
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

            if (response.IsSuccessStatusCode)
            {
                // the request failed somehow
                Label_LoginResponse.ForeColor = System.Drawing.Color.Green;
                Label_LoginResponse.Text = "Request Success!";
            } else 
            {
                Label_LoginResponse.ForeColor = System.Drawing.Color.Red;
                Label_LoginResponse.Text = "Request Failed!";
            }


        }

        private void Label_LoginResponse_Click(object sender, EventArgs e)
        {

        }



    }
}
//https://zetcode.com/csharp/getpostrequest/
