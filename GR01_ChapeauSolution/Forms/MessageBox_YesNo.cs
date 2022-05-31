using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI.Forms
{
    public partial class MessageBox_YesNo : Form
    {
        // Constructor
        public MessageBox_YesNo(string title, string message, string question)
        {
            InitializeComponent();

            // Set information
            lbl_Title.Text = title;
            lbl_Message.Text = message;
            lbl_Question.Text = question;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            // Set Dialog Result to Yes (Closes form)
            DialogResult = DialogResult.Yes;
        }

        private void btn_Decline_Click(object sender, EventArgs e)
        {
            // Set Dialog Result to No (Closes form)
            DialogResult = DialogResult.No;
        }
    }
}
