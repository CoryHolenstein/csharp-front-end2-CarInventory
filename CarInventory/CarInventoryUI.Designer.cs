
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
            this.label1 = new System.Windows.Forms.Label();
            this.List_CarResults = new System.Windows.Forms.ListBox();
            this.Button_GetAllCars = new System.Windows.Forms.Button();
            this.TextBox_CarBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_CarName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_CarColor = new System.Windows.Forms.TextBox();
            this.TextBox_CarType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Button_AddCar = new System.Windows.Forms.Button();
            this.Button_RemoveCar = new System.Windows.Forms.Button();
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
            // List_CarResults
            // 
            this.List_CarResults.BackColor = System.Drawing.Color.Silver;
            this.List_CarResults.FormattingEnabled = true;
            this.List_CarResults.ItemHeight = 19;
            this.List_CarResults.Location = new System.Drawing.Point(239, 52);
            this.List_CarResults.Name = "List_CarResults";
            this.List_CarResults.Size = new System.Drawing.Size(661, 308);
            this.List_CarResults.TabIndex = 1;
            this.List_CarResults.SelectedIndexChanged += new System.EventHandler(this.List_CarResults_SelectedIndexChanged);
            // 
            // Button_GetAllCars
            // 
            this.Button_GetAllCars.Location = new System.Drawing.Point(239, 366);
            this.Button_GetAllCars.Name = "Button_GetAllCars";
            this.Button_GetAllCars.Size = new System.Drawing.Size(105, 56);
            this.Button_GetAllCars.TabIndex = 2;
            this.Button_GetAllCars.Text = "Get Inventory";
            this.Button_GetAllCars.UseVisualStyleBackColor = true;
            this.Button_GetAllCars.Click += new System.EventHandler(this.Button_GetAllCars_Click);
            // 
            // TextBox_CarBrand
            // 
            this.TextBox_CarBrand.Location = new System.Drawing.Point(239, 515);
            this.TextBox_CarBrand.Name = "TextBox_CarBrand";
            this.TextBox_CarBrand.Size = new System.Drawing.Size(118, 26);
            this.TextBox_CarBrand.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Add New Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Car Brand";
            // 
            // TextBox_CarName
            // 
            this.TextBox_CarName.Location = new System.Drawing.Point(432, 515);
            this.TextBox_CarName.Name = "TextBox_CarName";
            this.TextBox_CarName.Size = new System.Drawing.Size(112, 26);
            this.TextBox_CarName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 493);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Car Name";
            // 
            // TextBox_CarColor
            // 
            this.TextBox_CarColor.Location = new System.Drawing.Point(623, 515);
            this.TextBox_CarColor.Name = "TextBox_CarColor";
            this.TextBox_CarColor.Size = new System.Drawing.Size(122, 26);
            this.TextBox_CarColor.TabIndex = 8;
            // 
            // TextBox_CarType
            // 
            this.TextBox_CarType.Location = new System.Drawing.Point(787, 515);
            this.TextBox_CarType.Name = "TextBox_CarType";
            this.TextBox_CarType.Size = new System.Drawing.Size(113, 26);
            this.TextBox_CarType.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Car Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(802, 493);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Car Type";
            // 
            // Button_AddCar
            // 
            this.Button_AddCar.Location = new System.Drawing.Point(517, 581);
            this.Button_AddCar.Name = "Button_AddCar";
            this.Button_AddCar.Size = new System.Drawing.Size(142, 42);
            this.Button_AddCar.TabIndex = 12;
            this.Button_AddCar.Text = "Add Car";
            this.Button_AddCar.UseVisualStyleBackColor = true;
            this.Button_AddCar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Button_RemoveCar
            // 
            this.Button_RemoveCar.Location = new System.Drawing.Point(412, 366);
            this.Button_RemoveCar.Name = "Button_RemoveCar";
            this.Button_RemoveCar.Size = new System.Drawing.Size(109, 55);
            this.Button_RemoveCar.TabIndex = 13;
            this.Button_RemoveCar.Text = "Remove Car";
            this.Button_RemoveCar.UseVisualStyleBackColor = true;
            this.Button_RemoveCar.Click += new System.EventHandler(this.Button_RemoveCar_Click);
            // 
            // CarInventoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1200, 657);
            this.Controls.Add(this.Button_RemoveCar);
            this.Controls.Add(this.Button_AddCar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBox_CarType);
            this.Controls.Add(this.TextBox_CarColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextBox_CarName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBox_CarBrand);
            this.Controls.Add(this.Button_GetAllCars);
            this.Controls.Add(this.List_CarResults);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "CarInventoryUI";
            this.Text = "Car Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox List_CarResults;
        private System.Windows.Forms.Button Button_GetAllCars;
        private System.Windows.Forms.TextBox TextBox_CarBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBox_CarName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBox_CarColor;
        private System.Windows.Forms.TextBox TextBox_CarType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Button_AddCar;
        private System.Windows.Forms.Button Button_RemoveCar;
    }
}

