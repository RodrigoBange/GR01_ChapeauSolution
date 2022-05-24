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
        private Form_Chapeau chapeauForm;
        MenuItem item;
        OrderItem orderItem;

        // Constructor
        public C_Order_OrderItem(Form_Chapeau form, MenuItem item)
        {
            InitializeComponent();

            // Set reference to main form
            chapeauForm = form;

            // Set OrderID
            orderItem = new OrderItem(item.ItemID);
            // Get MenuItem object
            this.item = item;

            lbl_ProductName.Text = item.FullName;
        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            if (orderItem.Quantity == 0)
            {
                // Remove ordered item and component from list...
            }
            else
            {
                // Maybe do this in the chapeauform??
                // Remove one from quantity
                orderItem.Quantity--;

                // Update display
                lbl_Count.Text = orderItem.Quantity.ToString();
            }
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            // Maybe do this in the chapeauform??
            // This needs to be somehow done in the form due to also being able to add via menu item....
            // Add one to quantity
            //chapeauForm.AddProduct(item);
            orderItem.Quantity++;

            // Update display
            lbl_Count.Text = orderItem.Quantity.ToString();
        }
    }
}
