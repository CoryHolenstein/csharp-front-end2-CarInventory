using System;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Web.Script.Serialization;

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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            var client = new HttpClient();

            int card = rnd.Next(100);
            if (TextBox_CarBrand.Text == "" || TextBox_CarName.Text == "" || TextBox_CarColor.Text == "" || TextBox_CarType.Text == "")
            {
                Console.WriteLine("Please input all fields!");
            } else
            {
                CarInfo newCar = new CarInfo(card, TextBox_CarBrand.Text, TextBox_CarName.Text, TextBox_CarColor.Text, TextBox_CarType.Text);
                Console.WriteLine(newCar.ToString());
                var requestContent = JsonContent.Create(newCar);

                var response = await client.PostAsync("http://localhost:3000/inventory/addcar", requestContent);
                var contents = await response.Content.ReadAsStringAsync();
            }
        }

        public CarInventoryUI()
        {
            InitializeComponent();
        }

        private void List_CarResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
                     List_CarResults.Items.Add(name + " -- " + p.Value);
			}
		}
        }
    }
}
