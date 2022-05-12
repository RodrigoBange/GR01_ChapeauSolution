using ChapeauUI.Components;
using ChapeauModel;
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

        // Variables 
        private bool functionButtonActivated = false;
        private TableFunctions currentFunction;

        #region General
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
            btn_Return.Visible = true;

            //Set border colors (Due to tab control)
            border_Bottom.BackColor = Color.White;
            border_Left.BackColor = ColorTranslator.FromHtml(hexColorDark);
            border_Right.BackColor = ColorTranslator.FromHtml(hexColorDark);
            border_Top.BackColor = ColorTranslator.FromHtml(hexColorDark);
            border_Bottom.BackColor = ColorTranslator.FromHtml(hexColorDark);
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            tabC_Body.SelectedTab = tab_Tables;
        }
#endregion

        #region Login
        /** LOGIN VIEW METHODS **/
        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Change tab to Table View
            tabC_Body.SelectedTab = tab_Tables;
            lbl_Title.Text = "Overview";

            // Displays UI, might be handy to check what user type logged in, admin or user and send it through
            DisplayUI();

            // Test Reservations
            TestAddReservations();
        }

        private void btn_Login_Forgot_Password_Click(object sender, EventArgs e)
        {
            tabC_Body.SelectedTab = tab_ForgotPassword;
        }
        #endregion

        #region Forgot Password
        /** FORGOT PASSWORD VIEW METHODS **/
        private void btn_Forgot_Password_Login_Click(object sender, EventArgs e)
        {
            tabC_Body.SelectedTab = tab_Login;
        }
        #endregion

        #region Account
        /** ACCOUNT METHODS **/
        private void btn_User_Click(object sender, EventArgs e)
        {
            tabC_Body.SelectedTab = tab_Account;
            DisableAllButtons();
        }
        #endregion

        #region Table View
        /** TABLE VIEW METHODS **/
        private void DisableAllButtons()
        {
            // Disable all function buttons
            currentFunction = TableFunctions.None;

            //Reset all colors
            btn_ActivateReservation.BackColor = ColorTranslator.FromHtml(hexColorDark);
            btn_ActivateOrdering.BackColor = ColorTranslator.FromHtml(hexColorDark);
            btn_ActivateCheckout.BackColor = ColorTranslator.FromHtml(hexColorDark);

            pnl_TableOverview.Panel2.BackColor = ColorTranslator.FromHtml(hexColorBright);

            //Disable all table buttons
            btn_Table_1.Enabled = false;
            btn_Table_2.Enabled = false;
            btn_Table_3.Enabled = false;
            btn_Table_4.Enabled = false;
            btn_Table_5.Enabled = false;
            btn_Table_6.Enabled = false;
            btn_Table_7.Enabled = false;
            btn_Table_8.Enabled = false;
            btn_Table_9.Enabled = false;
            btn_Table_10.Enabled = false;

        }

        private void ActivateAllTables()
        {
            btn_Table_1.Enabled = true;
            btn_Table_2.Enabled = true;
            btn_Table_3.Enabled = true;
            btn_Table_4.Enabled = true;
            btn_Table_5.Enabled = true;
            btn_Table_6.Enabled = true;
            btn_Table_7.Enabled = true;
            btn_Table_8.Enabled = true;
            btn_Table_9.Enabled = true;
            btn_Table_10.Enabled = true;
        }

        private void ActivateFunctionButton(TableFunctions function)
        {
            // If the new function is not the same as old function...
            if (function != currentFunction)
            {
                DisableAllButtons();
                if (function == TableFunctions.Reserve)
                {
                    currentFunction = TableFunctions.Reserve;
                    // Set colors
                    btn_ActivateReservation.BackColor = ColorTranslator.FromHtml(hexColorReserve);
                    pnl_TableOverview.Panel2.BackColor = ColorTranslator.FromHtml(hexColorReserve);
                    ActivateAllTables();
                    tabC_Body.SelectedTab = tab_Tables;
                }
                else if (function == TableFunctions.Order)
                {
                    currentFunction = TableFunctions.Order;
                    // Set colors
                    btn_ActivateOrdering.BackColor = ColorTranslator.FromHtml(hexColorOrder);
                    pnl_TableOverview.Panel2.BackColor = ColorTranslator.FromHtml(hexColorOrder);
                    ActivateAllTables();
                    tabC_Body.SelectedTab = tab_Tables;
                }
                else if (function == TableFunctions.Checkout)
                {
                    currentFunction = TableFunctions.Checkout;
                    // Set colors
                    btn_ActivateCheckout.BackColor = ColorTranslator.FromHtml(hexColorCheckout);
                    pnl_TableOverview.Panel2.BackColor = ColorTranslator.FromHtml(hexColorCheckout);
                    ActivateAllTables();
                    tabC_Body.SelectedTab = tab_Tables;
                }
            }
            else // If function is the same as old function
            {
                functionButtonActivated = !functionButtonActivated;
                DisableAllButtons();
            }
        }

        private void TestAddReservations()
        {
            for (int i = 0; i < 10; i++)
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
            ActivateFunctionButton(TableFunctions.Reserve);
        }

        private void btn_ActivateOrdering_Click(object sender, EventArgs e)
        {
            // Activate Order functionality
            ActivateFunctionButton(TableFunctions.Order);
        }

        private void btn_ActivateCheckout_Click(object sender, EventArgs e)
        {
            // Activate Checkout functionality
            ActivateFunctionButton(TableFunctions.Checkout);
        }

        private void DirectToFunctionPage()
        {
            if (currentFunction == TableFunctions.Reserve)
            {
                
            }
            else if (currentFunction == TableFunctions.Order)
            {
                tabC_Body.SelectedTab = tab_Order;
            }
            else if (currentFunction == TableFunctions.Checkout)
            {
                tabC_Body.SelectedTab = tab_Bill;
            }
        }

        private void btn_Table_1_Click(object sender, EventArgs e)
        {
            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 1";
        }
        private void btn_Table_2_Click(object sender, EventArgs e)
        {
            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 2";
        }
        private void btn_Table_3_Click(object sender, EventArgs e)
        {
            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 3";
        }
        private void btn_Table_4_Click(object sender, EventArgs e)
        {
            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 4";
        }
        private void btn_Table_5_Click(object sender, EventArgs e)
        {
            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 5";
        }
        private void btn_Table_6_Click(object sender, EventArgs e)
        {
            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 6";
        }
        private void btn_Table_7_Click(object sender, EventArgs e)
        {
            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 7";
        }
        private void btn_Table_8_Click(object sender, EventArgs e)
        {
            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 8";
        }
        private void btn_Table_9_Click(object sender, EventArgs e)
        {
            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 9";
        }
        private void btn_Table_10_Click(object sender, EventArgs e)
        {
            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 10";
        }
        #endregion

        #region Order
        /** ORDER VIEW METHODS **/
        private void TestMenuItems()
        {
            for (int i = 0; i < 10; i++)
            {
                C_Order_MenuItem menuItem = new C_Order_MenuItem();

                flow_Order_Menu.Controls.Add(menuItem);
            }
        }
        #endregion

        #region Bill
        /** BILL VIEW METHODS **/
        #endregion

        #region Payment View
        /** PAYMENT VIEW METHODS **/
        #endregion

        #region Payment Processing
        /** PAYMENT PROCESSING METHODS **/
        #endregion

        #region Kitchen
        /** KITCHEN VIEW METHODS **/
        #endregion

        #region Bar
        /** BAR VIEW METHODS **/
        #endregion

        #region Management
        /** MANAGEMENT METHODS **/
        #endregion
    }
}
