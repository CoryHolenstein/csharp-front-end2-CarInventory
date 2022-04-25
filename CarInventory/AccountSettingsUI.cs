using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UserInformation.UserInformation;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class AccountSettingsUI : Form
    {
        public AccountSettingsUI()
        {
            InitializeComponent();
        }



        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            label_Username.Text = Stored_UserName;
            label_Password.Text = "***";

        }

        private void ChangePassword_Button_Click(object sender, EventArgs e)
        {
            ChangePasswordUI changePassUI = new ChangePasswordUI();
            changePassUI.Show();
        }

        private void MainPage_Button_Click(object sender, EventArgs e)
        {
            Form carInventoryform = new Form();
            ((Control)ActiveForm).Hide();
            carInventoryform = new CarInventory.CarInventoryUI();
            carInventoryform.Show();
        }
    }
}
