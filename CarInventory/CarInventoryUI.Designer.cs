
namespace CarInventory
{
    partial class CarInventoryUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInventoryUI));
            this.label1 = new System.Windows.Forms.Label();
            this.list_CarResults = new System.Windows.Forms.ListBox();
            this.button_GetAllCars = new System.Windows.Forms.Button();
            this.textbox_CarBrand = new System.Windows.Forms.TextBox();
            this.label_AddCarIdentifier = new System.Windows.Forms.Label();
            this.label_CarBrandIdentifier = new System.Windows.Forms.Label();
            this.textbox_CarName = new System.Windows.Forms.TextBox();
            this.label_CarNameIdentifier = new System.Windows.Forms.Label();
            this.textbox_CarColor = new System.Windows.Forms.TextBox();
            this.textbox_CarType = new System.Windows.Forms.TextBox();
            this.label_CarColorIdentifier = new System.Windows.Forms.Label();
            this.label_CarTypeIdentifier = new System.Windows.Forms.Label();
            this.button_AddCar = new System.Windows.Forms.Button();
            this.button_RemoveCar = new System.Windows.Forms.Button();
            this.button_UpdateCar = new System.Windows.Forms.Button();
            this.label_ActiveUsername = new System.Windows.Forms.Label();
            this.label_ActiveUserIdentifier = new System.Windows.Forms.Label();
            this.toolTip_updateCar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_RemoveCar = new System.Windows.Forms.ToolTip(this.components);
            this.UserError_Label = new System.Windows.Forms.Label();
            this.button_AccountSettings = new System.Windows.Forms.Button();
            this.button_ClearErrors = new System.Windows.Forms.Button();
            this.toolTip_GetInventory = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_AddCar = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(442, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Inventory";
            // 
            // list_CarResults
            // 
            this.list_CarResults.BackColor = System.Drawing.Color.Silver;
            this.list_CarResults.FormattingEnabled = true;
            this.list_CarResults.ItemHeight = 19;
            this.list_CarResults.Location = new System.Drawing.Point(239, 52);
            this.list_CarResults.Name = "list_CarResults";
            this.list_CarResults.Size = new System.Drawing.Size(661, 308);
            this.list_CarResults.TabIndex = 1;
            this.list_CarResults.SelectedIndexChanged += new System.EventHandler(this.List_CarResults_SelectedIndexChanged);
            // 
            // button_GetAllCars
            // 
            this.button_GetAllCars.Location = new System.Drawing.Point(469, 367);
            this.button_GetAllCars.Name = "button_GetAllCars";
            this.button_GetAllCars.Size = new System.Drawing.Size(105, 56);
            this.button_GetAllCars.TabIndex = 2;
            this.button_GetAllCars.Text = "Get Inventory";
            this.toolTip_updateCar.SetToolTip(this.button_GetAllCars, "Manually update the Inventory List. Probably not necessary.");
            this.button_GetAllCars.UseVisualStyleBackColor = true;
            this.button_GetAllCars.Click += new System.EventHandler(this.Button_GetAllCars_Click);
            // 
            // textbox_CarBrand
            // 
            this.textbox_CarBrand.Location = new System.Drawing.Point(239, 515);
            this.textbox_CarBrand.Name = "textbox_CarBrand";
            this.textbox_CarBrand.Size = new System.Drawing.Size(118, 26);
            this.textbox_CarBrand.TabIndex = 3;
            // 
            // label_AddCarIdentifier
            // 
            this.label_AddCarIdentifier.AutoSize = true;
            this.label_AddCarIdentifier.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AddCarIdentifier.Location = new System.Drawing.Point(512, 459);
            this.label_AddCarIdentifier.Name = "label_AddCarIdentifier";
            this.label_AddCarIdentifier.Size = new System.Drawing.Size(131, 25);
            this.label_AddCarIdentifier.TabIndex = 4;
            this.label_AddCarIdentifier.Text = "Add New Car";
            // 
            // label_CarBrandIdentifier
            // 
            this.label_CarBrandIdentifier.AutoSize = true;
            this.label_CarBrandIdentifier.Location = new System.Drawing.Point(257, 493);
            this.label_CarBrandIdentifier.Name = "label_CarBrandIdentifier";
            this.label_CarBrandIdentifier.Size = new System.Drawing.Size(76, 19);
            this.label_CarBrandIdentifier.TabIndex = 5;
            this.label_CarBrandIdentifier.Text = "Car Brand";
            // 
            // textbox_CarName
            // 
            this.textbox_CarName.Location = new System.Drawing.Point(432, 515);
            this.textbox_CarName.Name = "textbox_CarName";
            this.textbox_CarName.Size = new System.Drawing.Size(112, 26);
            this.textbox_CarName.TabIndex = 6;
            // 
            // label_CarNameIdentifier
            // 
            this.label_CarNameIdentifier.AutoSize = true;
            this.label_CarNameIdentifier.Location = new System.Drawing.Point(445, 493);
            this.label_CarNameIdentifier.Name = "label_CarNameIdentifier";
            this.label_CarNameIdentifier.Size = new System.Drawing.Size(76, 19);
            this.label_CarNameIdentifier.TabIndex = 7;
            this.label_CarNameIdentifier.Text = "Car Name";
            // 
            // textbox_CarColor
            // 
            this.textbox_CarColor.Location = new System.Drawing.Point(623, 515);
            this.textbox_CarColor.Name = "textbox_CarColor";
            this.textbox_CarColor.Size = new System.Drawing.Size(122, 26);
            this.textbox_CarColor.TabIndex = 8;
            // 
            // textbox_CarType
            // 
            this.textbox_CarType.Location = new System.Drawing.Point(787, 515);
            this.textbox_CarType.Name = "textbox_CarType";
            this.textbox_CarType.Size = new System.Drawing.Size(113, 26);
            this.textbox_CarType.TabIndex = 9;
            // 
            // label_CarColorIdentifier
            // 
            this.label_CarColorIdentifier.AutoSize = true;
            this.label_CarColorIdentifier.Location = new System.Drawing.Point(643, 493);
            this.label_CarColorIdentifier.Name = "label_CarColorIdentifier";
            this.label_CarColorIdentifier.Size = new System.Drawing.Size(76, 19);
            this.label_CarColorIdentifier.TabIndex = 10;
            this.label_CarColorIdentifier.Text = "Car Color";
            // 
            // label_CarTypeIdentifier
            // 
            this.label_CarTypeIdentifier.AutoSize = true;
            this.label_CarTypeIdentifier.Location = new System.Drawing.Point(802, 493);
            this.label_CarTypeIdentifier.Name = "label_CarTypeIdentifier";
            this.label_CarTypeIdentifier.Size = new System.Drawing.Size(74, 19);
            this.label_CarTypeIdentifier.TabIndex = 11;
            this.label_CarTypeIdentifier.Text = "Car Type";
            // 
            // button_AddCar
            // 
            this.button_AddCar.Location = new System.Drawing.Point(462, 577);
            this.button_AddCar.Name = "button_AddCar";
            this.button_AddCar.Size = new System.Drawing.Size(112, 55);
            this.button_AddCar.TabIndex = 12;
            this.button_AddCar.Text = "Add Car";
            this.toolTip_AddCar.SetToolTip(this.button_AddCar, "Fill out the text boxes and add a car. An ID will be randomly generated for it. ");
            this.button_AddCar.UseVisualStyleBackColor = true;
            this.button_AddCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_RemoveCar
            // 
            this.button_RemoveCar.Location = new System.Drawing.Point(595, 368);
            this.button_RemoveCar.Name = "button_RemoveCar";
            this.button_RemoveCar.Size = new System.Drawing.Size(109, 55);
            this.button_RemoveCar.TabIndex = 13;
            this.button_RemoveCar.Text = "Remove Car";
            this.toolTip_RemoveCar.SetToolTip(this.button_RemoveCar, "To delete a car, select an ID from the list before clicking remove. ");
            this.button_RemoveCar.UseVisualStyleBackColor = true;
            this.button_RemoveCar.Click += new System.EventHandler(this.Button_RemoveCar_Click);
            // 
            // button_UpdateCar
            // 
            this.button_UpdateCar.Location = new System.Drawing.Point(595, 577);
            this.button_UpdateCar.Name = "button_UpdateCar";
            this.button_UpdateCar.Size = new System.Drawing.Size(112, 55);
            this.button_UpdateCar.TabIndex = 14;
            this.button_UpdateCar.Text = "Update Car";
            this.toolTip_updateCar.SetToolTip(this.button_UpdateCar, "To update a car, fill out its information and select an ID.\r\n");
            this.button_UpdateCar.UseVisualStyleBackColor = true;
            this.button_UpdateCar.Click += new System.EventHandler(this.Button_UpdateCar_Click);
            // 
            // label_ActiveUsername
            // 
            this.label_ActiveUsername.AutoSize = true;
            this.label_ActiveUsername.Font = new System.Drawing.Font("High Tower Text", 16F);
            this.label_ActiveUsername.Location = new System.Drawing.Point(1003, 144);
            this.label_ActiveUsername.Name = "label_ActiveUsername";
            this.label_ActiveUsername.Size = new System.Drawing.Size(0, 26);
            this.label_ActiveUsername.TabIndex = 15;
            // 
            // label_ActiveUserIdentifier
            // 
            this.label_ActiveUserIdentifier.AutoSize = true;
            this.label_ActiveUserIdentifier.Font = new System.Drawing.Font("High Tower Text", 20F);
            this.label_ActiveUserIdentifier.Location = new System.Drawing.Point(971, 96);
            this.label_ActiveUserIdentifier.Name = "label_ActiveUserIdentifier";
            this.label_ActiveUserIdentifier.Size = new System.Drawing.Size(157, 32);
            this.label_ActiveUserIdentifier.TabIndex = 16;
            this.label_ActiveUserIdentifier.Text = "Logged in as:";
            // 
            // toolTip_updateCar
            // 
            this.toolTip_updateCar.AutoPopDelay = 20000;
            this.toolTip_updateCar.InitialDelay = 500;
            this.toolTip_updateCar.ReshowDelay = 100;
            // 
            // toolTip_RemoveCar
            // 
            this.toolTip_RemoveCar.AutoPopDelay = 20000;
            this.toolTip_RemoveCar.ForeColor = System.Drawing.Color.Black;
            this.toolTip_RemoveCar.InitialDelay = 500;
            this.toolTip_RemoveCar.ReshowDelay = 100;
            // 
            // UserError_Label
            // 
            this.UserError_Label.AutoSize = true;
            this.UserError_Label.Location = new System.Drawing.Point(973, 493);
            this.UserError_Label.Name = "UserError_Label";
            this.UserError_Label.Size = new System.Drawing.Size(0, 19);
            this.UserError_Label.TabIndex = 17;
            // 
            // button_AccountSettings
            // 
            this.button_AccountSettings.Location = new System.Drawing.Point(977, 228);
            this.button_AccountSettings.Name = "button_AccountSettings";
            this.button_AccountSettings.Size = new System.Drawing.Size(151, 45);
            this.button_AccountSettings.TabIndex = 18;
            this.button_AccountSettings.Text = "Account Settings";
            this.button_AccountSettings.UseVisualStyleBackColor = true;
            this.button_AccountSettings.Click += new System.EventHandler(this.AccountSettings_Button_Click);
            // 
            // button_ClearErrors
            // 
            this.button_ClearErrors.Location = new System.Drawing.Point(1008, 577);
            this.button_ClearErrors.Name = "button_ClearErrors";
            this.button_ClearErrors.Size = new System.Drawing.Size(91, 55);
            this.button_ClearErrors.TabIndex = 19;
            this.button_ClearErrors.Text = "Clear Error List";
            this.button_ClearErrors.UseVisualStyleBackColor = true;
            this.button_ClearErrors.Visible = false;
            this.button_ClearErrors.Click += new System.EventHandler(this.ClearErrors_Button_Click);
            // 
            // toolTip_GetInventory
            // 
            this.toolTip_GetInventory.AutoPopDelay = 20000;
            this.toolTip_GetInventory.InitialDelay = 500;
            this.toolTip_GetInventory.ReshowDelay = 100;
            // 
            // toolTip_AddCar
            // 
            this.toolTip_AddCar.AutoPopDelay = 20000;
            this.toolTip_AddCar.InitialDelay = 500;
            this.toolTip_AddCar.ReshowDelay = 100;
            // 
            // CarInventoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1200, 657);
            this.Controls.Add(this.button_ClearErrors);
            this.Controls.Add(this.button_AccountSettings);
            this.Controls.Add(this.UserError_Label);
            this.Controls.Add(this.label_ActiveUserIdentifier);
            this.Controls.Add(this.label_ActiveUsername);
            this.Controls.Add(this.button_UpdateCar);
            this.Controls.Add(this.button_RemoveCar);
            this.Controls.Add(this.button_AddCar);
            this.Controls.Add(this.label_CarTypeIdentifier);
            this.Controls.Add(this.label_CarColorIdentifier);
            this.Controls.Add(this.textbox_CarType);
            this.Controls.Add(this.textbox_CarColor);
            this.Controls.Add(this.label_CarNameIdentifier);
            this.Controls.Add(this.textbox_CarName);
            this.Controls.Add(this.label_CarBrandIdentifier);
            this.Controls.Add(this.label_AddCarIdentifier);
            this.Controls.Add(this.textbox_CarBrand);
            this.Controls.Add(this.button_GetAllCars);
            this.Controls.Add(this.list_CarResults);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CarInventoryUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_CarResults;
        private System.Windows.Forms.Button button_GetAllCars;
        private System.Windows.Forms.TextBox textbox_CarBrand;
        private System.Windows.Forms.Label label_AddCarIdentifier;
        private System.Windows.Forms.Label label_CarBrandIdentifier;
        private System.Windows.Forms.TextBox textbox_CarName;
        private System.Windows.Forms.Label label_CarNameIdentifier;
        private System.Windows.Forms.TextBox textbox_CarColor;
        private System.Windows.Forms.TextBox textbox_CarType;
        private System.Windows.Forms.Label label_CarColorIdentifier;
        private System.Windows.Forms.Label label_CarTypeIdentifier;
        private System.Windows.Forms.Button button_AddCar;
        private System.Windows.Forms.Button button_RemoveCar;
        private System.Windows.Forms.Button button_UpdateCar;
        private System.Windows.Forms.Label label_ActiveUsername;
        private System.Windows.Forms.Label label_ActiveUserIdentifier;
        private System.Windows.Forms.ToolTip toolTip_updateCar;
        private System.Windows.Forms.ToolTip toolTip_RemoveCar;
        private System.Windows.Forms.Label UserError_Label;
        private System.Windows.Forms.Button button_AccountSettings;
        private System.Windows.Forms.Button button_ClearErrors;
        private System.Windows.Forms.ToolTip toolTip_GetInventory;
        private System.Windows.Forms.ToolTip toolTip_AddCar;
    }
}

