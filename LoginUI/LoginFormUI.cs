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

        private void Button_LoginButton_Click(object sender, EventArgs e)
        {

            Task<Uri> UriOutput = SendLoginInfo(username, password);
        }

        public static async Task<Uri> SendLoginInfo(String username, String password)
        {
            HttpClient client = new HttpClient();

            var url = "http://127.0.0.1:3000/testpoint";
            var request = WebRequest.Create(url);
            request.Method = "POST";

            var UserInfo = new LoginInfo(username, password);
            var json = JsonSerializer.Serialize(UserInfo);
            Console.Write(json);
            Console.WriteLine(JsonSerializer.Serialize(UserInfo));
            byte[] byteArray = Encoding.UTF8.GetBytes(json);

            var reqStream = request.GetRequestStream();
            reqStream.Write(byteArray, 0, byteArray.Length);



            var response = request.GetResponse();
            var respStream = response.GetResponseStream();

            var reader = new StreamReader(respStream);
            string data = reader.ReadToEnd();
            Console.WriteLine(data);

            client.Dispose();
            response.Close();

            return response.ResponseUri;
        }


    }
}
//https://zetcode.com/csharp/getpostrequest/
