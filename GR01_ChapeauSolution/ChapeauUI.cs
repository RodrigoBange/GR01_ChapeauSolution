using ChapeauUI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR01_ChapeauSolution
{
    public partial class Form_Chapeau : Form
    {
        // Constant variables
        const string hexColorBright = "#323145";
        const string hexColorDark = "#1C1B2D";
        const string hexColorReserve = "#db7a67";
        const string hexColorOrder = "#5fadac";
        const string hexColorCheckout = "#8486f0";

        public Form_Chapeau()
        {
            // Initialize
            InitializeComponent();
        }

        private void FormChapeau_Load(object sender, EventArgs e)
        {
            // Hide tab Control tabs for user
            tabC_Body.Appearance = TabAppearance.FlatButtons;
            tabC_Body.ItemSize = new Size(0, 1);
            tabC_Body.SizeMode = TabSizeMode.Fixed;

            /* FOR TESTING PURPOSES ON DEBUG, change this to your current work tab */
            /*For employee*/
            tabC_Body.SelectedTab = tab_Login;

            /*For manager*/
            //tabC_Body.SelectedTab = tab_Management;
            //pnl_Footer.BackColor = ColorTranslator.FromHtml(hexColorDark);
            //navMenuManager.Visible = true;
        }

        private void DisplayUI()
        {
            // Display appropiate UI elements upon login

            // If user...
            // Display footer elements (table menu buttons)
            pnl_Footer.BackColor = ColorTranslator.FromHtml(hexColorDark);
            navMenu.Visible = true;

            // Display header elements !!Order matters for toggling visibility
            lbl_OrderCounter.Visible = true;
            background_OrderCounter.Visible = true;
            btn_User.Visible = true;

            //Set border colors (Due to tab control)
            border_Bottom.BackColor = Color.White;
            border_Left.BackColor = ColorTranslator.FromHtml(hexColorDark);
            border_Right.BackColor = ColorTranslator.FromHtml(hexColorDark);
            border_Top.BackColor = ColorTranslator.FromHtml(hexColorDark);
            border_Bottom.BackColor = ColorTranslator.FromHtml(hexColorDark);
        }


        /** LOGIN VIEW METHODS **/
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Change tab to Table View
            tabC_Body.SelectedTab = tab_Tables;
            lbl_Title.Text = "Table Overview";

            // Displays UI, might be handy to check what user type logged in, admin or user and send it through
            DisplayUI();

            // Test Reservations
            TestAddReservations();
        }


        /** FORGOT PASSWORD VIEW METHODS **/


        /** TABLE VIEW METHODS **/
        private void ActivateFunctionButton(string functionType)
        {
            // Reset all colors first
            btn_ActivateReservation.BackColor = ColorTranslator.FromHtml(hexColorDark);
            btn_ActivateOrdering.BackColor = ColorTranslator.FromHtml(hexColorDark);
            btn_ActivateCheckout.BackColor = ColorTranslator.FromHtml(hexColorDark);

            pnl_TableOverview.Panel2.BackColor = ColorTranslator.FromHtml(hexColorBright);

            // Activate functionality
            if (functionType == "Reserve")
            {
                // Set colors
                btn_ActivateReservation.BackColor = ColorTranslator.FromHtml(hexColorReserve);
                pnl_TableOverview.Panel2.BackColor = ColorTranslator.FromHtml(hexColorReserve);
            }
            else if (functionType == "Order")
            {
                // Set colors
                btn_ActivateOrdering.BackColor = ColorTranslator.FromHtml(hexColorOrder);
                pnl_TableOverview.Panel2.BackColor = ColorTranslator.FromHtml(hexColorOrder);
            }
            else if (functionType == "Checkout")
            {
                // Set colors
                btn_ActivateCheckout.BackColor = ColorTranslator.FromHtml(hexColorCheckout);
                pnl_TableOverview.Panel2.BackColor = ColorTranslator.FromHtml(hexColorCheckout);
            }
        }
        private void TestAddReservations()
        {
            for (int i = 0; i < 50; i++)
            {
                // Generate dates
                DateTime startDate = DateTime.Now.AddHours(i);
                DateTime endDate = DateTime.Now.AddHours(i + 1);

                // Create new Reservation
                C_Available_Reservation available_Reservation1 = new C_Available_Reservation(startDate, endDate);

                // Add reservation to flow panel
                flow_TableOverview.Controls.Add(available_Reservation1);
            }
        }

        private void btn_ActivateReservation_Click(object sender, EventArgs e)
        {
            // Activate Reserve functionality
            ActivateFunctionButton("Reserve");
        }

        private void btn_ActivateOrdering_Click(object sender, EventArgs e)
        {
            // Activate Order functionality
            ActivateFunctionButton("Order");
        }

        private void btn_ActivateCheckout_Click(object sender, EventArgs e)
        {
            // Activate Checkout functionality
            ActivateFunctionButton("Checkout");
        }


        /** ORDER VIEW METHODS **/


        /** BILL VIEW METHODS **/


        /** PAYMENT VIEW METHODS **/


        /** PAYMENT PROCESSING METHODS **/


        /** KITCHEN VIEW METHODS **/


        /** BAR VIEW METHODS **/


        /** MANAGEMENT METHODS **/


    }
}
