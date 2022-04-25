using System;
using System.Windows.Forms;
using System.Web;
using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Web.Script.Serialization;
using static UserInformation.UserInformation;
using System.Timers;
using System.Diagnostics;

namespace CarInventory
{
    public partial class CarInventoryUI : Form
    {
        int inventoryID = 0;
        String carBrand = "", carName = "", carColor = "", carType = "";

        public class CarInfo {
            public int inventoryID { get; set; }
            public String carBrand { get; set; }
            public String carName { get; set; }
            public String carColor { get; set; }
            public String carType { get; set; }

            public CarInfo(int inventoryID, String carBrand, String carName, String carColor, String carType) 
            {
                this.inventoryID = inventoryID;
                this.carBrand = carBrand;
                this.carName = carName;
                this.carColor = carColor;
                this.carType = carType;
            }
            public CarInfo(int inventoryID)
            {
                this.inventoryID = inventoryID;
          
            }
        }

       
       

        public CarInventoryUI()
        {
            InitializeComponent();
       
        }

        private void List_CarResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
        //get all vehicles 
        private async void Button_GetAllCars_Click(object sender, EventArgs e)
        {


      

            var client = new HttpClient();

            var carInfo = new CarInfo(inventoryID, carBrand, carName,carColor,carType);
            var requestContent = JsonContent.Create(carInfo);

            var response = await client.PostAsync("http://localhost:3000/inventory/getcars", requestContent);
            var contents = await response.Content.ReadAsStringAsync();

            //credits :https://stackoverflow.com/questions/15726197/parsing-a-json-array-using-json-net 
            //
             JArray contentsArray = JArray.Parse(contents);
            foreach (JObject o in contentsArray.Children<JObject>())
		{
			foreach (JProperty p in o.Properties())
			{
				string name = p.Name;
				//string value = (string)p.Value;
				Console.WriteLine(name + " -- " + p.Value);
                     list_CarResults.Items.Add(p.Value);
			}
		}
        }

        //update the cars information. fill out the boxes, select an Id and click update
        private async void Button_UpdateCar_Click(object sender, EventArgs e)
        {
           
           
            if (list_CarResults.SelectedIndex >= 0)
            {
                Console.WriteLine("selected item");
                //  Console.WriteLine(List_CarResults.SelectedItem.ToString());
                // if (List_CarResults.SelectedItem.ToString().Contains("InventoryID"))
                if (int.TryParse(list_CarResults.SelectedItem.ToString(), out int value))
                {
                    //call
                    Console.WriteLine("api call time baby");
                    var client = new HttpClient();


                    var inventoryID = list_CarResults.SelectedItem.ToString();

                    if (textbox_CarBrand.Text == "" || textbox_CarName.Text == "" || textbox_CarColor.Text == "" || textbox_CarType.Text == "")
                    {
                        Console.WriteLine("Please input all fields!");
                        Create_Error_List("Please input all fields!");
                    }
                    else
                    {
                        CarInfo updateCar = new CarInfo(int.Parse(inventoryID), textbox_CarBrand.Text, textbox_CarName.Text, textbox_CarColor.Text, textbox_CarType.Text);
                        var requestContent = JsonContent.Create(updateCar);
                        var response = await client.PostAsync("http://localhost:3000/inventory/updatecar", requestContent);
                        var contents = await response.Content.ReadAsStringAsync();
                        emptylistbox(this, e);
                      Button_GetAllCars_Click(this, e);
                    }
          
                    //int inventoryIDToSend = int.Parse(inventoryID);


                }
            }
            else if (list_CarResults.SelectedIndex < 0)
            {
                Console.WriteLine("no item selected.");
                Create_Error_List("Select an ID from the list!");
            }
        }

        //remvoe car button, works by clicking on the car ID in the list and clicking remove. 
        private async void Button_RemoveCar_Click(object sender, EventArgs e)
        {
            if (list_CarResults.SelectedIndex >= 0)
            {
                Console.WriteLine("selected item");
                //  Console.WriteLine(List_CarResults.SelectedItem.ToString());
                // if (List_CarResults.SelectedItem.ToString().Contains("InventoryID"))
                if (int.TryParse(list_CarResults.SelectedItem.ToString(), out int value))
                {
                    //call
                    Console.WriteLine("api call time baby");
                    var client = new HttpClient();


                    var inventoryID = list_CarResults.SelectedItem.ToString();
                    CarInfo deleteCar = new CarInfo(int.Parse(inventoryID));
                    //int inventoryIDToSend = int.Parse(inventoryID);

                    var requestContent = JsonContent.Create(deleteCar);

                    var response = await client.PostAsync("http://localhost:3000/inventory/deletecar", requestContent);
                    var contents = await response.Content.ReadAsStringAsync();
                
                    emptylistbox(this, e);
                    Button_GetAllCars_Click(this, e);

                }
            }
            else
            {
                Console.WriteLine("no item selected.");
                Create_Error_List("Select an ID from the list!");
            }

        }
        //addcar button
        private async void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int card = rnd.Next(100);
            var client = new HttpClient();

            
            if (textbox_CarBrand.Text == "" || textbox_CarName.Text == "" || textbox_CarColor.Text == "" || textbox_CarType.Text == "")
            {
                Console.WriteLine("Please input all fields!");
                Create_Error_List("Please input all fields!");

            }
            else
            {
                CarInfo newCar = new CarInfo(card, textbox_CarBrand.Text, textbox_CarName.Text, textbox_CarColor.Text, textbox_CarType.Text);
                Console.WriteLine(newCar.ToString());
                var requestContent = JsonContent.Create(newCar);

                var response = await client.PostAsync("http://localhost:3000/inventory/addcar", requestContent);
                var contents = await response.Content.ReadAsStringAsync();
                emptylistbox(this, e);
                Button_GetAllCars_Click(this, e);
            }
        }

        //empty the list box
        private void emptylistbox(object sender, EventArgs e)
        {
            list_CarResults.Items.Clear();
        }

        //Navigate to account settings page
        private void AccountSettings_Button_Click(object sender, EventArgs e)
        {
         
            Form accountSettingsForm = new Form();
            ((Control)ActiveForm).Hide();
            accountSettingsForm = new AccountSettingsUI();
            accountSettingsForm.Show();
        }

        //on page load, call inventory and display logged in username
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Button_GetAllCars_Click(this, e);
            label_ActiveUsername.Text = Stored_UserName;

        }

        //We use this to clear the errors list and set the button invisible
        private void ClearErrors_Button_Click(object sender, EventArgs e)
        {
            button_ClearErrors.Visible = false;
            UserError_Label.Text = "";
        }


        //When an error happens, we add it to the error list and make the clear errors button visible!
        //if the amount of characters in the label are over 75, we clear the label first to avoid piling up of error messages.
        private void Create_Error_List(String errorMessage)
        {
            int charCount = 0;
            foreach (char c in UserError_Label.Text)
            {
                charCount++;
            }
            if (charCount >= 75)
            {
                UserError_Label.Text = "";
            }


            UserError_Label.Text += errorMessage + "\n";

            button_ClearErrors.Visible = true;
        }

        //was going to use this timer to auto clear error messages for user, but it just created more problems and is not the best practice
        /*
        private void Initiate_UserError_LabelTimer (object sender, EventArgs e, String message)
        {
            System.Timers.Timer timer = new System.Timers.Timer();

            UserError_Label.Text = message;

            timer.Interval = 5000; // specify interval time as you want
            timer.Enabled = true;
            timer.Start();
            Console.WriteLine(timer.ToString() + " " + timer.Enabled + " " + timer.Interval );
            timer.Elapsed += OnTimedEvent;
      

        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Test");
            if (UserError_Label.InvokeRequired)
            {
                UserError_Label.Invoke(new MethodInvoker(delegate { UserError_Label.Text = ""; }));
            }

       
        }
        */
    
    }
}
