using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI.Components
{
    public partial class C_Order_MenuItem_Category : UserControl
    {
        // Constructor
        public C_Order_MenuItem_Category(string category)
        {
            InitializeComponent();

            // Set title
            lbl_Category.Text = category;
        }
    }
}
