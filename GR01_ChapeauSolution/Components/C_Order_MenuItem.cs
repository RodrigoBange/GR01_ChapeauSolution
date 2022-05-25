using ChapeauModel;
using GR01_ChapeauSolution;
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

        // Form_Chapeau object
        Form_Chapeau chapeauForm;

        // Automatic Property for ItemID
        public int ItemID { get; set; }

        // Constructor
        public C_Order_MenuItem(Form_Chapeau form, string itemName, int itemID)
        {
            InitializeComponent();

            // Set reference to main form
            chapeauForm = form;

            // Set ItemID
            ItemID = itemID;

            // Set and display product information
            lbl_ItemName.Text = itemName;
        }

        // Click event
        private async void AddItem_Click(object sender, EventArgs e)
        {
            // Color changing event with delay to simulate button click
            this.BackColor = ColorTranslator.FromHtml(hexColorDark);
            await Task.Delay(200);
            this.BackColor = ColorTranslator.FromHtml(hexColorBright);

            // Add product
            chapeauForm.AddOrderItem(ItemID);
        }
    }
}
