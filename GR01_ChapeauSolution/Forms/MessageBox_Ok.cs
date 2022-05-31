using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI.Forms
{
    public partial class MessageBox_Ok : Form
    {
        // Constructor
        public MessageBox_Ok(string title, string message)
        {
            InitializeComponent();

            // Set information
            lbl_Title.Text = title;
            lbl_Message.Text = message;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            // Set Dialog Result to Ok (Closes form)
            DialogResult = DialogResult.OK;
        }
    }
}
