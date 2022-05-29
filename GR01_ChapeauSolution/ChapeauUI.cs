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
using ChapeauUI.Forms;
using ChapeauUI;

namespace GR01_ChapeauSolution
{
    public partial class Form_Chapeau : Form
    {
        // Error Logger 
        ErrorLogger logger; 

        // Services
        MenuService menuService;
        OrderService orderService;
        StockService stockService;

        // Constant variables
        const string hexColorBright = "#323145";
        const string hexColorDark = "#1C1B2D";
        const string hexColorReserve = "#db7a67";
        const string hexColorOrder = "#5fadac";
        const string hexColorCheckout = "#8486f0";

        // General variables
        private int tableNumber = 0;

        // Variables Table Overview
        private bool functionButtonActivated = false;
        private TableFunction currentFunction;

        #region General
        // Constructor
        public Form_Chapeau()
        {
            // Initialize
            InitializeComponent();

            // Get instance
            logger = ErrorLogger.GetInstance();

            // Initialize services
            menuService = new MenuService();
            orderService = new OrderService();
            stockService = new StockService();
        }

        // On Load
        private void FormChapeau_Load(object sender, EventArgs e)
        {
            // Hide tab Control tabs for user
            tabC_Body.Appearance = TabAppearance.FlatButtons;
            tabC_Body.ItemSize = new Size(0, 1);
            tabC_Body.SizeMode = TabSizeMode.Fixed;

            // Start tab on load
            tabC_Body.SelectedTab = tab_Login;
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
                        border_Left.BackColor = ColorTranslator.FromHtml(hexColorDark);
                        border_Right.BackColor = ColorTranslator.FromHtml(hexColorDark);
                        border_Top.BackColor = ColorTranslator.FromHtml(hexColorBright);
                        border_Bottom.BackColor = ColorTranslator.FromHtml(hexColorDark);

                        // Fill menus when tab opens (In case products have been updated)
                        currentCategory = MenuCategory.Lunch;
                        LoadMenu();

                        // Reset all to default
                        orderItems.Clear();
                        flow_Order_Items.Controls.Clear();
                        totalOrderPrice = 0.00;
                        lbl_Order_TotalPrice.Text = $"Total : € {totalOrderPrice:N2}";

                        // Set the width to hide the scrollbar for a modern mobile design
                        flow_Order_Menu.Width = pnl_Order_Menu.Width + SystemInformation.VerticalScrollBarWidth;
                        flow_Order_Items.Width = pnl_Order_Orders.Width + SystemInformation.VerticalScrollBarWidth;
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

            // Displays UI, might be handy to check what user type logged in, admin or user and send it through
            DisplayUI();
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
        // Variables Order Overview
        private MenuCategory currentCategory = MenuCategory.Lunch;
        private double totalOrderPrice = 0.00;

        // Menus
        public List<MenuItem> lunchMenu;
        public List<MenuItem> dinnerMenu;
        public List<MenuItem> drinksMenu;

        // Order items and display component
        public List<Tuple<OrderItem, C_Order_OrderItem>> orderItems ;

        /** ORDER VIEW METHODS **/
        private void LoadMenu()
        {
            // Initialize orderItems
            orderItems = new List<Tuple<OrderItem, C_Order_OrderItem>>();

            // Reload when opening order view in case of management changing product information
            // Fill menus with items
            lunchMenu = menuService.GetMenuItems(MenuCategory.Lunch);
            dinnerMenu = menuService.GetMenuItems(MenuCategory.Dinner);
            drinksMenu = menuService.GetMenuItems(MenuCategory.Drinks);

            // Load menu diplay
            DisplayMenu(MenuCategory.Lunch);
        }

        private void DisplayMenu(MenuCategory menuCategory)
        {
            // Clear previous menu before loading new menu
            flow_Order_Menu.Controls.Clear();

            // Suspend layout
            pnl_Order_Menu.SuspendLayout();

            // Create new list of menuItems to display
            List<MenuItem> menuItems;

            // Fill list with items
            if (menuCategory == MenuCategory.Lunch) // If Lunch
            {
                menuItems = lunchMenu;
            }
            else if (menuCategory == MenuCategory.Dinner) // If Dinner
            {
                menuItems = dinnerMenu;
            }
            else // If drinks
            {
                menuItems = drinksMenu;
            }

            // Display menu items and sub category titles
            for (int i = 0; i < menuItems.Count; i++)
            {
                if (i == 0 || (menuItems[i].SubCategory != menuItems[i - 1].SubCategory))
                {
                    // Add sub category title
                    C_Order_MenuItem_Category categoryTitle = new C_Order_MenuItem_Category(menuItems[i].SubCategory);
                    flow_Order_Menu.Controls.Add(categoryTitle);
                }

                // Add menu item
                C_Order_MenuItem c_MenuItem = new C_Order_MenuItem(this, menuItems[i]);
                flow_Order_Menu.Controls.Add(c_MenuItem);
            }

            // Resume layout
            pnl_Order_Menu.ResumeLayout();
        }

        public void AddNewOrderItem(MenuItem menuItem)
        {
            bool itemExists = false;

            // Check if item already exists in order list
            foreach (Tuple<OrderItem, C_Order_OrderItem> item in orderItems)
            {
                // If the item has already been added...
                if (item.Item1.ItemID == menuItem.ItemID)
                {
                    itemExists = true;
                    break;
                }
            }

            // If item doesn't exist, create a new orderItem
            if (!itemExists)
            {
                // Create new orderItem object with the ID
                OrderItem orderItem = new OrderItem(menuItem.ItemID, menuItem.Price);

                // Create new OrderItem component 
                // Requires first to get the MenuItem object with the ID 
                C_Order_OrderItem orderDisplayItem = new C_Order_OrderItem(this, menuItem.ItemID, menuItem.FullName, menuItem.Price);

                // Add new Tuple with OrderItem object and C_Order_OrderItem component to list
                orderItems.Add(new Tuple<OrderItem, C_Order_OrderItem>(orderItem, orderDisplayItem));

                // Add component to order list
                flow_Order_Items.Controls.Add(orderDisplayItem);

                // Add to total price
                UpdateTotalPrice(orderItem.Price);

                // Activate Checkout button
                ActivateCheckout();
            }
            else { AddToOrderQuantity(menuItem.ItemID); }
        }

        public void AddToOrderQuantity(int itemID)
        {
            // Check if item already exists in order list
            foreach (Tuple<OrderItem, C_Order_OrderItem> item in orderItems)
            {
                // If the item has already been added...
                if (item.Item1.ItemID == itemID)
                {
                    // Add to quantity
                    item.Item1.Quantity++;
                    item.Item2.Quantity++;

                    // Update display
                    item.Item2.UpdateInfo();

                    // Add to total price
                    UpdateTotalPrice(item.Item1.Price);

                    // Return
                    return;
                }
            }
        }

        public void RemoveFromOrderQuantity(int itemID)
        {
            // Check what item has the ID
            for (int i = orderItems.Count -1; i >= 0; i--)
            {
                if (orderItems[i].Item1.ItemID == itemID)
                {
                    // Remove one from the quantity
                    orderItems[i].Item1.Quantity--;
                    orderItems[i].Item2.Quantity--;

                    // Update the display information
                    orderItems[i].Item2.UpdateInfo();

                    // Remove from the total price
                    UpdateTotalPrice(-orderItems[i].Item1.Price);

                    // If the quantity is 0
                    if (orderItems[i].Item1.Quantity == 0)
                    {
                        // Remove from orderItems
                        orderItems.RemoveAt(i);

                        // Check for checkout functionality
                        ActivateCheckout();

                        // Return
                        return;
                    }
                }
            }
        }

        private void UpdateTotalPrice(double price)
        {
            // Adjust total price
            totalOrderPrice += price;

            // Update display
            lbl_Order_TotalPrice.Text = $"Total : € {totalOrderPrice:N2}";
        }

        public void AddOrderComment(int itemID, string comment)
        {
            // Check for item location...
            foreach (Tuple<OrderItem, C_Order_OrderItem> item in orderItems)
            {
                // If the item has already been added...
                if (item.Item1.ItemID == itemID)
                {
                    // Add comment to item
                    item.Item1.Comment = comment;

                    // Return
                    return;
                }
            }
        }

        private void ActivateCheckout()
        {
            // If there are items added, enable checkout option
            if (orderItems.Count > 0)
            {
                btn_Order_Confirm.Enabled = true;
            }
            else
            {
                btn_Order_Confirm.Enabled = false;
            }
        }

        private void btn_Order_Confirm_Enable_Changed(object sender, EventArgs e)
        {
            // Change color on enable event
            if (btn_Order_Confirm.Enabled)
            {
                btn_Order_Confirm.BackColor = ColorTranslator.FromHtml("#FE4040");
            }
            else
            {
                btn_Order_Confirm.BackColor = ColorTranslator.FromHtml("#822121");
            }
        }

        private void btn_Order_Confirm_Click(object sender, EventArgs e)
        {
            // Create a list of only orders without their components
            List<OrderItem> orders = new List<OrderItem>();

            // Fill the list with all added items of the order
            foreach (Tuple<OrderItem, C_Order_OrderItem> item in orderItems)
            {
                orders.Add(item.Item1);
            }

            // Check storage status
            List<string> lowStockItems = stockService.CheckStorageStatus(orders);

            // Check storage before continuing
            if (lowStockItems == null)
            {
                // Call orderService to place an order
                orderService.PlaceOrder(orders, tableNumber, 1);

                // Call stockService to remove stock
                stockService.DepleteStock(orders);

                // Display confirmation
                MessageBox.Show("Order has been placed.");
                tabC_Body.SelectedIndex = 3;
            }
            else
            {
                string warningTitle = "Warning - Low Stock";
                string warningMessage = "The following items are low in stock: " + Environment.NewLine;
                for (int i = 0; i < lowStockItems.Count; i++)
                {
                    if (i < lowStockItems.Count - 1)
                    {
                        warningMessage += lowStockItems[i] + ", ";
                    }
                    else
                    {
                        warningMessage += lowStockItems[i] + ". ";
                    }
                }

                string warningQuestion = "Please check the storage before proceeding." + Environment.NewLine + "Would you still like to place the order?";

                // Use the custom messageBox
                using (MessageBox_YesNo messageBox = new MessageBox_YesNo(warningTitle, warningMessage, warningQuestion))
                {
                    // Show the dialog
                    DialogResult dialogResult = messageBox.ShowDialog();

                    if (dialogResult == DialogResult.Yes)
                    {
                        // Call orderService to place an order
                        orderService.PlaceOrder(orders, tableNumber, 1);

                        // Call stockService to remove from stock
                        stockService.DepleteStock(orders);

                        // Display confirmation
                        using (MessageBox_Ok messageBox_W = new MessageBox_Ok("Confirmation", "Order has been succesfully placed."))
                        {
                            DialogResult dialogResult_W = messageBox_W.ShowDialog();

                            // When accepted
                            if (dialogResult_W == DialogResult.OK)
                            {
                                // Display table overview
                                tabC_Body.SelectedIndex = 3;
                            }
                        }
                    }
                }
            }
        }

        private void btn_Order_LunchMenu_Click(object sender, EventArgs e)
        {
            // Request the lunch menu
            // Check before requesting to avoid uneccessary loading
            if (currentCategory != MenuCategory.Lunch)
            {
                // Set new current category 
                currentCategory = MenuCategory.Lunch;

                // Display menu
                DisplayMenu(MenuCategory.Lunch);
            }
        }

        private void btn_Order_DinnerMenu_Click(object sender, EventArgs e)
        {
            // Request the dinner menu
            // Check before requesting to avoid uneccessary loading
            if (currentCategory != MenuCategory.Dinner)
            {
                // Set new current category
                currentCategory = MenuCategory.Dinner;

                // Display menu
                DisplayMenu(MenuCategory.Dinner);
            }
        }

        private void btn_Order_DrinksMenu_Click(object sender, EventArgs e)
        {
            // Request the drinks menu
            // Check before requesting to avoid uneccessary loading
            if (currentCategory != MenuCategory.Drinks)
            {
                // Set new current category
                currentCategory = MenuCategory.Drinks;

                // Display menu
                DisplayMenu(MenuCategory.Drinks);
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
