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

        // Calculated Property
        private double TotalPrice 
        { 
            get { return Price * Quantity; } 
        }

        // Constructor
        public C_Order_OrderItem(Form_Chapeau form, int itemID, string itemName, double price)
        {
            InitializeComponent();

            // Set reference to main form
            chapeauForm = form;
            
            // Set variables
            ItemID = itemID;
            Price = price;
            Quantity = 1;

            // Set display element text
            lbl_ProductName.Text = itemName;
            UpdateInfo();
        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            // Remove from item
            chapeauForm.RemoveFromOrderQuantity(ItemID);
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            // Add to item
            chapeauForm.AddToOrderQuantity(ItemID);
        }

        private void AddComment(object sender, EventArgs e)
        {
            // If textbox contains text
            if (!string.IsNullOrEmpty(txtBox_Comment.Text))
            {
                // Add comment to item
                chapeauForm.AddOrderComment(ItemID, txtBox_Comment.Text);
            }
        }

        public void UpdateInfo()
        {
            // If there is an item to display...
            if (Quantity != 0)
            {
                // Update display information
                lbl_Count.Text = Quantity.ToString();
                lbl_ProductTotalPrice.Text = $"€ {TotalPrice:N2}";
            }
            else
            {
                // Delete self
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
