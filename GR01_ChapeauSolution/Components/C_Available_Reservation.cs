using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI.Components
{
    public partial class C_Available_Reservation : UserControl
    {
        // Property to display time
        public string AvailableTime { 
            get { return lbl_AvailableTime.Text; }
            set { lbl_AvailableTime.Text = value; }
        }

        // Automatic properties
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Constructor
        public C_Available_Reservation(DateTime startDate, DateTime endDate)
        {
            // Initalize component
            InitializeComponent();

            // Set variables to properties
            StartDate = startDate;
            EndDate = endDate;

            // Set time to text
            lbl_AvailableTime.Text = $"{StartDate:HH:mm} - {EndDate:HH:mm}";
        }

        private void btn_PlaceReservation_Click(object sender, EventArgs e)
        {
            // Code for button to add reservation in case necessary
        }
    }
}
