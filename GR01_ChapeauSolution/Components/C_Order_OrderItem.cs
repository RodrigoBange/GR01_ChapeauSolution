using ChapeauModel;
using GR01_ChapeauSolution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI.Components
{
    public partial class C_Order_OrderItem : UserControl
    {
        // Form_Chapeau object
        private Form_Chapeau chapeauForm;

        // Automatic Properties
        public int ItemID { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        // Constructor
        public C_Order_OrderItem(Form_Chapeau form, int itemID, string itemName, double price, int quantity)
        {
            InitializeComponent();

            // Set reference to main form
            chapeauForm = form;
            
            // Set variables
            ItemID = itemID;
            Price = price;
            Quantity = quantity;

            // Set display element text
            lbl_ProductName.Text = itemName;
            UpdateInfo();
        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            // Remove from item
            chapeauForm.RemoveOrderItem(ItemID);
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            // Add to item
            chapeauForm.AddOrderItem(ItemID);
        }

        public void UpdateInfo()
        {
            // If there is an item to display...
            if (Quantity != 0)
            {
                // Update display information
                lbl_Count.Text = Quantity.ToString();
                lbl_ProductTotalPrice.Text = $"€ {Price * Quantity:N2}";
            }
            else
            {
                // Delete self
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
