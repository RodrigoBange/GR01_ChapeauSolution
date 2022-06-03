using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI.Forms
{
    public partial class MessageBox_OccupiedTakeorder : Form
    {
        // Constructor
        public MessageBox_OccupiedTakeorder(string title)
        {
            InitializeComponent();

            // Set information
            lbl_Title.Text = title;
        }

        private void btn_MarkAsOccupied_Click(object sender, EventArgs e)
        {
            // DialogResult = ;
        }

        private void btn_TakeOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
