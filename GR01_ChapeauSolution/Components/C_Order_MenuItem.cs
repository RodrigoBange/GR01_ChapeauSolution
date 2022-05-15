using ChapeauModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI.Components
{
    public partial class C_Order_MenuItem : UserControl
    {
        // Color variables
        const string hexColorBright = "#3C3C4E";
        const string hexColorDark = "#2D2D3A";

        // Variables
        MenuItem menuItem; 
        public string productName = "Test product";
        public double productPrice = 10.59;

        public C_Order_MenuItem(MenuItem item)
        {
            InitializeComponent();

            // Set and display product information
            menuItem = item;
            lbl_ItemName.Text = item.Name;
            lbl_Price.Text = item.Price.ToString("0.00");
        }

        // Click event
        private async void AddItem_Click(object sender, EventArgs e)
        {
            // Color changing event with delay to simulate button click
            this.BackColor = ColorTranslator.FromHtml(hexColorDark);
            await Task.Delay(200);
            this.BackColor = ColorTranslator.FromHtml(hexColorBright);

            // Display message (Test)
            MessageBox.Show("Added item.");
        }
    }
}
