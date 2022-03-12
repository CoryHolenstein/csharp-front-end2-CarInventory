using CarInventory;
using System;
using System.Windows.Forms;

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

            var response = await client.PostAsync("https://localhost:44364/api/Register", requestContent);
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
                Label_RegisterResponse.Text = "Username exists already.";
            } else if (statusCode == 406)
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Red;
                Label_RegisterResponse.Text = "Passwords must match.";
            }else if (statusCode == 200)
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Green;
                Label_RegisterResponse.Text = "Account Registered. Redirecting you...";

                Form carInventoryform = new Form();
                ((Control)ActiveForm).Hide();
                carInventoryform = new CarInventoryUI();
                carInventoryform.Show();
            }

            /*
             * for node js server
            if (contents.Contains("errormessagePassMatch"))
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Red;
                Label_RegisterResponse.Text = "Passwords must match.";
            } 
            else if (contents.Contains("errormessageUserExists")) 
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Red;
                Label_RegisterResponse.Text = "Username exists already.";
            }
            else if (contents.Contains("errormessageFields"))
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Red;
                Label_RegisterResponse.Text = "Please fill out all fields!";
            }
            else if (contents.Contains("errormessageLength"))
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Red;
                Label_RegisterResponse.Text = "Usernames and passwords should be atleast 6 characters and at most 15 characters.";
            }
            else if (contents.Contains("successResIns"))
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Green;
                Label_RegisterResponse.Text = "Account Registered... Redirecting you.";


                Form carInventoryform = new Form();
                ((Control)ActiveForm).Hide();
                carInventoryform = new CarInventoryUI();
                carInventoryform.Show();

            }
            */
        }
    }
}
