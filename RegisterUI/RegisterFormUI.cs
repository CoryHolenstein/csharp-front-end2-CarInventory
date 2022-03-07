using CarInventory;
using System;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Json;


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




            if (contents.Contains("errormessage"))
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Red;
                Label_RegisterResponse.Text = contents.ToString(); 
            }
            else
            {
                Label_RegisterResponse.ForeColor = System.Drawing.Color.Green;
                Label_RegisterResponse.Text = "Correct! Redirecting you...";


                Form carInventoryform = new Form();
                ((Control)ActiveForm).Hide();
                carInventoryform = new CarInventoryUI();
                carInventoryform.Show();

            }

        }
    }
}
