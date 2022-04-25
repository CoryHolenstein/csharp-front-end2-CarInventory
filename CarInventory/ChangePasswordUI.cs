using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using static UserInformation.UserInformation;

namespace CarInventory
{
    public partial class ChangePasswordUI : Form
    {
        String newPassword = "", newPasswordConf = "";


        public ChangePasswordUI()
        {
            InitializeComponent();
        }

        public class NewPasswordInfo
        {
            public String username { get; set; }    
            public String newPassword { get; set; }    
            public String newPasswordConf { get; set; }


            public NewPasswordInfo(String user, String newPass, String newPassConf)
            {
                username = user;
                newPassword = newPass; 
                newPasswordConf = newPassConf; 
            }
        }

        private void password_TextBox_TextChanged(object sender, EventArgs e)
        {
            newPassword = textbox_password.Text;
        }

        private void confirmPassword_TextBox_TextChanged(object sender, EventArgs e)
        {
            newPasswordConf =  textbox_ConfirmPassword.Text;
        }

        private async void SaveInformation_Button_Click(object sender, EventArgs e)
        {
            var client = new HttpClient();
           // String username = Stored_UserName;

 
            var passInfo = new NewPasswordInfo(Stored_UserName, newPassword, newPasswordConf);
            Console.WriteLine(passInfo + " " + newPassword + " " + newPasswordConf);
            var requestContent = JsonContent.Create(passInfo);


            var response = await client.PostAsync("http://localhost:3000/users/updatepass", requestContent);
            var contents = await response.Content.ReadAsStringAsync();
            Console.WriteLine(response);

            var statusCode = (int)response.StatusCode;

            //for entity framework server
            if (statusCode == 500)
            {
                PasswordUpdateResponse_Label.ForeColor = System.Drawing.Color.Red;
                PasswordUpdateResponse_Label.Text = "Server Error";

            }
            else if (statusCode == 400)
            {
                PasswordUpdateResponse_Label.ForeColor = System.Drawing.Color.Red;
                PasswordUpdateResponse_Label.Text = "Passwords must match and cannot be empty.";


            }
            else if (statusCode == 411)
            {
                PasswordUpdateResponse_Label.ForeColor = System.Drawing.Color.Red;
                PasswordUpdateResponse_Label.Text = "Password must be between 6 and 15 characters.";



            }
            else if (statusCode == 200)
            {
                PasswordUpdateResponse_Label.ForeColor = System.Drawing.Color.Green;
                PasswordUpdateResponse_Label.Text = "Password changed!";
                ((Control)ActiveForm).Hide();
       
            }
        }
    }
}
