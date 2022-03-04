using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUI
{

    public class LoginInfo
    {
        public String username { get; set; }
        public String password { get; set; }
    }


    public partial class LoginFormUI : Form
    {
        LoginInfo loginInfo = new LoginInfo();
        public LoginFormUI()
        {
            InitializeComponent();
        }

    
        //username
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loginInfo.username = textBox1.Text;
        }
        //password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            loginInfo.password = textBox1.Text;
        }
    }
}
