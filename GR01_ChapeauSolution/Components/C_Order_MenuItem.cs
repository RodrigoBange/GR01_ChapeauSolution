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

        // MenuItem object
        public MenuItem menuItem; 

        // Constructor
        public C_Order_MenuItem(Form_Chapeau form, MenuItem item)
        {
            InitializeComponent();

            // Set reference to main form
            chapeauForm = form;

            // Set MenuItem
            menuItem = item;

            // Set and display product information
            lbl_ItemName.Text = menuItem.ShortName;
        }

        // Click event
        private async void AddItem_Click(object sender, EventArgs e)
        {
            // Add new item
            chapeauForm.AddNewOrderItem(menuItem);

            // Color changing event with delay to simulate button click
            this.BackColor = ColorTranslator.FromHtml(hexColorDark);
            await Task.Delay(30);
            this.BackColor = ColorTranslator.FromHtml(hexColorBright);

            // Set focus to this control's label
            this.ActiveControl = lbl_ItemName;
        }
    }
}
