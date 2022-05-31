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
using ChapeauLogic;

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

        // General variables
        public int tableNumber = 0;
        public List<MenuItem> menuItems;

        // Variables Table Overview
        private bool functionButtonActivated = false;
        private TableFunction currentFunction;

        // Variables Order Overview
        private MenuCategory currentCategory = MenuCategory.Lunch;


        #region General
        // Constructor
        public Form_Chapeau()
        {
            // Initialize
            InitializeComponent();

            // Initialize menuItems 
            menuItems = new List<MenuItem>();
        }

        // On Load
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

        private void SelectedTabChanged(object sender, EventArgs e)
        {
            // When tab is changed...
            switch (tabC_Body.SelectedIndex)
            {
                // Login View
                case 0:
                    {
                        lbl_Title.Text = "Login";
                    }
                    break;
                // Forgot Password View 
                case 1:
                    {
                        // Set title
                        lbl_Title.Text = "Forgot Password";
                    }
                    break;
                // Account View 
                case 2:
                    {
                        // Set title
                        lbl_Title.Text = "Account";
                    }
                    break;
                // Table View 
                case 3:
                    {
                        // Set title
                        lbl_Title.Text = "Overview";

                        // Test Reservations
                        TestAddReservations();
                    }
                    break;
                // Order View
                case 4:
                    {
                        // Set title
                        lbl_Title.Text = $"Order Table #{tableNumber}";

                        //Set border colors (Tab Control)
                        border_Bottom.BackColor = Color.White;
                        border_Left.BackColor = ColorTranslator.FromHtml(hexColorDark);
                        border_Right.BackColor = ColorTranslator.FromHtml(hexColorDark);
                        border_Top.BackColor = ColorTranslator.FromHtml(hexColorBright);
                        border_Bottom.BackColor = ColorTranslator.FromHtml(hexColorDark);

                        // Load default menu on tab open
                        currentCategory = MenuCategory.Lunch;
                        LoadMenu(MenuCategory.Lunch);
                    }
                    break;
                // Bill View 
                case 5:
                    {
                        // Set title
                        lbl_Title.Text = $"Bill Table #{tableNumber}";
                    }
                    break;
                // Payment Options View 
                case 6:
                    {
                        // Set title
                        lbl_Title.Text = "Payment Options";
                    }
                    break;
                // Process Payment View 
                case 7:
                    {
                        // Set title
                        lbl_Title.Text = "Processing Payment";
                    }
                    break;
                // Management View 
                case 8:
                    {
                        // Set title
                        lbl_Title.Text = "Management";
                    }
                    break;
                // Bar View 
                case 9:
                    {
                        // Set title
                        lbl_Title.Text = "Bar Orders";
                    }
                    break;
                // Kitchen View 
                case 10:
                    {
                        // Set title
                        lbl_Title.Text = "Kitchen Orders";
                    }
                    break;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            // Return to table view
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

            DisplayUI();
        }
        #endregion

        #region Account
        /** ACCOUNT METHODS **/
        private void btn_User_Click(object sender, EventArgs e)
        {
            tabC_Body.SelectedTab = tab_Account;
            DisableAllButtons();

            // Set colors
            border_Left.BackColor = ColorTranslator.FromHtml(hexColorBright);
            border_Right.BackColor = ColorTranslator.FromHtml(hexColorBright);
            border_Top.BackColor = ColorTranslator.FromHtml(hexColorBright);
            border_Bottom.BackColor = ColorTranslator.FromHtml(hexColorBright);
        }

        private void btn_Account_Logout_Click(object sender, EventArgs e)
        {
            tabC_Body.SelectedTab = tab_Login;
         
            // Hide header and footer elements
            lbl_OrderCounter.Visible = false;
            background_OrderCounter.Visible = false;
            btn_User.Visible = false;
            btn_Return.Visible = false;
            navMenu.Visible = false;

            // Set colors
            pnl_Footer.BackColor = ColorTranslator.FromHtml(hexColorBright);
            border_Left.BackColor = ColorTranslator.FromHtml(hexColorBright);
            border_Right.BackColor = ColorTranslator.FromHtml(hexColorBright);
            border_Top.BackColor = ColorTranslator.FromHtml(hexColorBright);
            border_Bottom.BackColor = ColorTranslator.FromHtml(hexColorBright);
        }

        #endregion

        #region Table View
        /** TABLE VIEW METHODS **/
        private void DisableAllButtons()
        {
            // Disable all function buttons
            currentFunction = TableFunction.None;

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

        private void ActivateFunctionButton(TableFunction function)
        {
            // If the new function is not the same as old function...
            if (function != currentFunction)
            {
                DisableAllButtons();
                if (function == TableFunction.Reserve)
                {
                    currentFunction = TableFunction.Reserve;
                    // Set colors
                    btn_ActivateReservation.BackColor = ColorTranslator.FromHtml(hexColorReserve);
                    pnl_TableOverview.Panel2.BackColor = ColorTranslator.FromHtml(hexColorReserve);
                    ActivateAllTables();
                    tabC_Body.SelectedTab = tab_Tables;
                }
                else if (function == TableFunction.Order)
                {
                    currentFunction = TableFunction.Order;
                    // Set colors
                    btn_ActivateOrdering.BackColor = ColorTranslator.FromHtml(hexColorOrder);
                    pnl_TableOverview.Panel2.BackColor = ColorTranslator.FromHtml(hexColorOrder);
                    ActivateAllTables();
                    tabC_Body.SelectedTab = tab_Tables;
                }
                else if (function == TableFunction.Checkout)
                {
                    currentFunction = TableFunction.Checkout;
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
            ActivateFunctionButton(TableFunction.Reserve);
        }

        private void btn_ActivateOrdering_Click(object sender, EventArgs e)
        {
            // Activate Order functionality
            ActivateFunctionButton(TableFunction.Order);
        }

        private void btn_ActivateCheckout_Click(object sender, EventArgs e)
        {
            // Activate Checkout functionality
            ActivateFunctionButton(TableFunction.Checkout);
        }

        private void DirectToFunctionPage()
        {
            if (currentFunction == TableFunction.Reserve)
            {
                
            }
            else if (currentFunction == TableFunction.Order)
            {
                tabC_Body.SelectedTab = tab_Order;
            }
            else if (currentFunction == TableFunction.Checkout)
            {
                tabC_Body.SelectedTab = tab_Bill;
            }
        }

        private void btn_Table_1_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 1;

            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 1";
        }
        private void btn_Table_2_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 2;

            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 2";
        }
        private void btn_Table_3_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 3;

            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 3";
        }
        private void btn_Table_4_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 4;

            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 4";
        }
        private void btn_Table_5_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 5;

            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 5";
        }
        private void btn_Table_6_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 6;

            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 6";
        }
        private void btn_Table_7_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 7;

            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 7";
        }
        private void btn_Table_8_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 8;

            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 8";
        }
        private void btn_Table_9_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 9;

            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 9";
        }
        private void btn_Table_10_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 10;

            DirectToFunctionPage();
            lbl_TableOverview_Title.Text = "Table 10";
        }
        #endregion

        #region Order
        /** ORDER VIEW METHODS **/
        private void LoadMenu(MenuCategory category)
        {
            // Call service to fill list with items 
            OrderService orderService = new OrderService();

            // Get the menu items from a certain category
            menuItems = orderService.GetMenuItems(category);

            // Load menu diplay
            DisplayMenu();
        }

        private void DisplayMenu()
        {
            // Clear previous before loading new
            flow_Order_Menu.Controls.Clear();

            // Display menu items and sub category titles
            for (int i = 0; i < menuItems.Count; i++)
            {
                if (i == 0 || (menuItems[i].SubCategory != menuItems[i - 1].SubCategory))
                {
                    // Add sub category title
                    C_Order_MenuItem_Category menuCategory = new C_Order_MenuItem_Category(menuItems[i].SubCategory);
                    flow_Order_Menu.Controls.Add(menuCategory);
                }

                // Add menu item
                C_Order_MenuItem c_MenuItem = new C_Order_MenuItem(menuItems[i]);
                flow_Order_Menu.Controls.Add(c_MenuItem);
            }
        }

        private void btn_Order_LunchMenu_Click(object sender, EventArgs e)
        {
            // Request the lunch menu
            // Check before requesting to avoid uneccessary database requests
            if (currentCategory != MenuCategory.Lunch)
            {
                // Set new current category 
                currentCategory = MenuCategory.Lunch;

                // Load menu
                LoadMenu(MenuCategory.Lunch);
            }
        }

        private void btn_Order_DinnerMenu_Click(object sender, EventArgs e)
        {
            // Request the dinner menu
            // Check before requesting to avoid uneccessary database requests
            if (currentCategory != MenuCategory.Dinner)
            {
                // Set new current category
                currentCategory = MenuCategory.Dinner;

                // Load menu
                LoadMenu(MenuCategory.Dinner);
            }
        }

        private void btn_Order_DrinksMenu_Click(object sender, EventArgs e)
        {
            // Request the drinks menu
            // Check before requesting to avoid uneccessary database requests
            if (currentCategory != MenuCategory.Drinks)
            {
                // Set new current category
                currentCategory = MenuCategory.Drinks;

                // Load menu
                LoadMenu(MenuCategory.Drinks);
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
