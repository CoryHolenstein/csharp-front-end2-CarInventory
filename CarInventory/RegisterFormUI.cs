using CarInventory;
using System;
using System.Windows.Forms;
using static UserInformation.UserInformation;
using System.Net.Http;
using System.Net.Http.Json;
using LoginUI;

namespace RegisterUI
{
    public partial class RegisterFormUI : Form
    {

        String username = "",
           password = "",
           passwordConfirmation = "";

 

        public class RegisterInfo
        {
            public String username { get; set; }
            public String password { get; set; }
            public String passwordConfirmation { get; set; }

            public RegisterInfo(String user, String pass, String password_conf)
            {
                username = user;
                password = pass;
                passwordConfirmation = password_conf;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form loginUI = new Form();
            ((Control)ActiveForm).Hide();
            loginUI = new LoginFormUI();
            loginUI.Show();
     
        }
        //username text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            username = textBox1.Text;
        }
        //password text box
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            password = textBox2.Text;
        }
        //confirm password text box
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            passwordConfirmation = textBox3.Text;
        }

        public RegisterFormUI()
        {
            InitializeComponent();
        
        }
        //register account button
        private async void button2_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();

            var userInfo = new RegisterInfo(username, password, passwordConfirmation);
            var requestContent = JsonContent.Create(userInfo);

            var response = await client.PostAsync("http://localhost:3000/users/register", requestContent);
            var contents = await response.Content.ReadAsStringAsync();
            Console.WriteLine(response);

            var statusCode = (int)response.StatusCode;

            //for entity framework server
            if (statusCode == 500)
            {
                  Label_RegisterResponse.ForeColor = System.Drawing.Color.Red;
                Label_RegisterResponse.Text = "Server Error";

            } else if (statusCode == 400)
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Red;
                Label_RegisterResponse.Text = "Passwords must match and cannot be empty.";


            } else if (statusCode == 406)
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Red;
                Label_RegisterResponse.Text = "Username exists already.";
            }
            else if (statusCode == 411)
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Red;
                Label_RegisterResponse.Text = "Username and password must be between 6 and 15 characters.";



            }
            else if (statusCode == 200)
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Green;
                Label_RegisterResponse.Text = "Account Registered. Redirecting you...";
                Stored_UserName = userInfo.username;
                Form carInventoryform = new Form();
                ((Control)ActiveForm).Hide();
                carInventoryform = new CarInventory.CarInventoryUI();
                carInventoryform.Show();
            }

        }
    }
}
