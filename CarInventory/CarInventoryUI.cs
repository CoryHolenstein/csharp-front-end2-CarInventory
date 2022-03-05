using System;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;

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

            var response = await client.PostAsync("http://localhost:3000/inventory/cars", requestContent);
            var contents = await response.Content.ReadAsStringAsync();
        



        }
    }
}
