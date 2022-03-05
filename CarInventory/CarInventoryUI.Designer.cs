
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
            this.List_CarResults.Location = new System.Drawing.Point(211, 242);
            this.List_CarResults.Name = "List_CarResults";
            this.List_CarResults.Size = new System.Drawing.Size(977, 403);
            this.List_CarResults.TabIndex = 1;
            this.List_CarResults.SelectedIndexChanged += new System.EventHandler(this.List_CarResults_SelectedIndexChanged);
            // 
            // Button_GetAllCars
            // 
            this.Button_GetAllCars.Location = new System.Drawing.Point(53, 294);
            this.Button_GetAllCars.Name = "Button_GetAllCars";
            this.Button_GetAllCars.Size = new System.Drawing.Size(105, 56);
            this.Button_GetAllCars.TabIndex = 2;
            this.Button_GetAllCars.Text = "Get Inventory";
            this.Button_GetAllCars.UseVisualStyleBackColor = true;
            this.Button_GetAllCars.Click += new System.EventHandler(this.Button_GetAllCars_Click);
            // 
            // CarInventoryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1200, 657);
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
    }
}

