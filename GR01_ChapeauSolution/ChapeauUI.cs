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
using System.Security.Cryptography;

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
        EmployeeService employeeService;

        // Constant variables
        const string hexColorBright = "#323145";
        const string hexColorDark = "#1C1B2D";

        // General variables
        private int tableNumber = 0;

        Employee employee;

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
            employeeService = new EmployeeService();
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

        private void SelectedTabChanged(object sender, EventArgs e)
        {
            // When tab is changed...
            switch (tabC_Body.SelectedIndex)
            {
                // Login View
                case 0:
                    {
                        lbl_Title.Text = "Login";

                        txtBox_Login_User.Text = null;
                        txtBox_Login_Password.Text = null;

                        // Hide header and footer elements
                        lbl_OrderCounter.Visible = false;
                        background_OrderCounter.Visible = false;
                        btn_User.Visible = false;
                        btn_Return.Visible = false;

                        // Set colors
                        border_Left.BackColor = ColorTranslator.FromHtml(hexColorBright);
                        border_Right.BackColor = ColorTranslator.FromHtml(hexColorBright);
                        border_Top.BackColor = ColorTranslator.FromHtml(hexColorBright);
                        border_Bottom.BackColor = ColorTranslator.FromHtml(hexColorBright);
                    }
                    break;
                // Account View 
                case 1:
                    {
                        // Set title
                        lbl_Title.Text = "Account";
                    }
                    break;
                // Table View 
                case 2:
                    {
                        // Set title
                        lbl_Title.Text = "Overview";

                        // Test Reservations
                        TestAddReservations();
                    }
                    break;
                // Order View
                case 3:
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

                        // Check if order exists for checkout button
                        CheckOrderStatus();

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
                case 4:
                    {
                        // Set title
                        lbl_Title.Text = $"Bill Table #{tableNumber}";
                    }
                    break;
                // Payment Options View 
                case 5:
                    {
                        // Set title
                        lbl_Title.Text = "Payment Options";
                    }
                    break;
                // Process Payment View 
                case 6:
                    {
                        // Set title
                        lbl_Title.Text = "Processing Payment";
                    }
                    break;
                // Management View 
                case 7:
                    {
                        // Set title
                        lbl_Title.Text = "Management";
                    }
                    break;
                // Bar View 
                case 8:
                    {
                        // Set title
                        lbl_Title.Text = "Bar View";
                    }
                    break;
                // Kitchen View 
                case 9:
                    {
                        // Set title
                        lbl_Title.Text = "Kitchen View";
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
        private void txtBox_Login_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Only allow to enter numbers in the employeeID
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void CreateUser()
        {
            string password = "password1";
            PasswordWithSaltHasher passwordWithSaltHasher = new PasswordWithSaltHasher();
            HashWithSaltResult hashWithSaltResult = passwordWithSaltHasher.HashWithSalt(password, 64, SHA256.Create());
            
            string password2 = "password2";
            PasswordWithSaltHasher passwordWithSaltHasher2 = new PasswordWithSaltHasher();
            HashWithSaltResult hashWithSaltResult2 = passwordWithSaltHasher2.HashWithSalt(password2, 64, SHA256.Create());

            string password3 = "password3";
            PasswordWithSaltHasher passwordWithSaltHasher3 = new PasswordWithSaltHasher();
            HashWithSaltResult hashWithSaltResult3 = passwordWithSaltHasher3.HashWithSalt(password3, 64, SHA256.Create());

            string password4 = "password4";
            PasswordWithSaltHasher passwordWithSaltHasher4 = new PasswordWithSaltHasher();
            HashWithSaltResult hashWithSaltResult4 = passwordWithSaltHasher4.HashWithSalt(password4, 64, SHA256.Create());

            string password5 = "password5";
            PasswordWithSaltHasher passwordWithSaltHasher5 = new PasswordWithSaltHasher();
            HashWithSaltResult hashWithSaltResult5 = passwordWithSaltHasher5.HashWithSalt(password5, 64, SHA256.Create());

            employeeService.CreateEmployee("Alba Placeres", "Waiter", hashWithSaltResult.Salt, hashWithSaltResult.Digest);
            employeeService.CreateEmployee("Johnny Depp", "Waiter", hashWithSaltResult2.Salt, hashWithSaltResult2.Digest);
            employeeService.CreateEmployee("Rafa Nadal", "Waiter", hashWithSaltResult3.Salt, hashWithSaltResult3.Digest);
            employeeService.CreateEmployee("Pepe", "Chef", hashWithSaltResult4.Salt, hashWithSaltResult4.Digest);
            employeeService.CreateEmployee("Ana de Armas", "Bartender", hashWithSaltResult5.Salt, hashWithSaltResult5.Digest);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Get employeeID amd password
            int employeeID = int.Parse(txtBox_Login_User.Text);
            string employeePassword = txtBox_Login_Password.Text;

            employee = employeeService.GetEmployee(employeeID);

            if (employee != null)
            {
                PasswordWithSaltHasher pwHasher = new PasswordWithSaltHasher();
                HashWithSaltResult convertedHash = pwHasher.ConvertedHashWithSalt(employeePassword, employee.Salt);
                string convertedPassword = convertedHash.Digest;

                if (convertedPassword == employee.Hash)
                {
                    // Succesfullly logged in
                    MessageBox_Ok messageBox = new MessageBox_Ok("Login", "Succesfully logged in");
                    messageBox.ShowDialog();

                    // Change tab to Table View
                    OpenView();
                }
                else
                {
                    // Incorrect password
                    MessageBox_Ok messageBox = new MessageBox_Ok("Login", "Incorrect password");
                    messageBox.ShowDialog();
                }
            }
            else
            {
                // Employee doesn't exist
                MessageBox_Ok messageBox = new MessageBox_Ok("Login", "Employee doesn't exist");
                messageBox.ShowDialog();
            }
        }

        private void OpenView()
        {
            btn_User.Visible = true;
            btn_Return.Visible = true;
            if (employee.EmployeeRole == "Waiter")
            {
                tabC_Body.SelectedTab = tab_Tables;
            }
            else if (employee.EmployeeRole == "Chef")
            {
                tabC_Body.SelectedTab = tab_Kitchen;
            }
            else if (employee.EmployeeRole == "Bartender")
            {
                tabC_Body.SelectedTab = tab_Bar;
            }
        }

        #endregion

        #region Account
        /** ACCOUNT METHODS **/
        private void btn_User_Click(object sender, EventArgs e)
        {
            lbl_Account_EmployeeID.Text = $"ID: {employee.EmployeeId.ToString()}";
            lbl_Account_EmployeeName.Text = employee.EmployeeName;
            lbl_Account_Role.Text = employee.EmployeeRole;
            tabC_Body.SelectedTab = tab_Account;
        }

        private void btn_Account_Logout_Click(object sender, EventArgs e)
        {
            tabC_Body.SelectedTab = tab_Login;

            employee = null;
        }

        #endregion

        #region Table View
        /** TABLE VIEW METHODS **/
        private void TestAddReservations()
        {
            for (int i = 0; i < 10; i++)
            {
                // Create new Table order
                C_Table_Order table_order = new C_Table_Order();

                // Add reservation to flow panel
                flow_TableOverview.Controls.Add(table_order);
            }
        }

        private void btn_Table_1_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 1;

            // Open order view
            tabC_Body.SelectedTab = tab_Order;
        }

        private void btn_Table_2_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 2;

            // Open order view
            tabC_Body.SelectedTab = tab_Order;
        }

        private void btn_Table_3_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 3;

            // Open order view
            tabC_Body.SelectedTab = tab_Order;
        }

        private void btn_Table_4_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 4;

            // Open order view
            tabC_Body.SelectedTab = tab_Order;
        }

        private void btn_Table_5_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 5;

            // Open order view
            tabC_Body.SelectedTab = tab_Order;
        }

        private void btn_Table_6_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 6;

            tabC_Body.SelectedIndex = 3;
        }
        private void btn_Table_7_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 7;

            // Open order view
            tabC_Body.SelectedTab = tab_Order;
        }

        private void btn_Table_8_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 8;

            // Open order view
            tabC_Body.SelectedTab = tab_Order;
        }
        private void btn_Table_9_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 9;

            // Open order view
            tabC_Body.SelectedTab = tab_Order;
        }
        private void btn_Table_10_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 10;

            // Open order view
            tabC_Body.SelectedTab = tab_Order;
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
            try
            {
                lunchMenu = menuService.GetMenuItems(MenuCategory.Lunch);
                dinnerMenu = menuService.GetMenuItems(MenuCategory.Dinner);
                drinksMenu = menuService.GetMenuItems(MenuCategory.Drinks);
            }
            catch (Exception ex)
            {
                // Log error and display message
                DisplayError(ex);
            }

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

        private void CheckOrderStatus()
        {
            // If an order exists
            if (orderService.CheckOrderStatus(tableNumber))
            {
                // Activate splitter
                splitter_Checkout.Visible = true;

                // Activate button
                btn_Order_Checkout.Visible = true;
            }
            else
            {
                // Disable splitter
                splitter_Checkout.Visible = false;

                // Disable button
                btn_Order_Checkout.Visible = false;
            }
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

        private void CreateOrder()
        {
            // Create a list of only orders without their components
            List<OrderItem> orders = new List<OrderItem>();

            // Fill the list with all added items of the order
            foreach (Tuple<OrderItem, C_Order_OrderItem> item in orderItems)
            {
                orders.Add(item.Item1);
            }

            try
            {
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
                    using (MessageBox_Ok messageBox_W = new MessageBox_Ok("Confirmation", "Order has been succesfully placed."))
                    {
                        DialogResult dialogResult_W = messageBox_W.ShowDialog();

                        // When accepted
                        if (dialogResult_W == DialogResult.OK)
                        {
                            // Display table overview
                            tabC_Body.SelectedTab = tab_Tables;
                        }
                    }
                }
                else
                {
                    string warningTitle = "Warning - Low Stock";
                    string warningMessage = "The ingredients for the following items are low:" + Environment.NewLine;

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

                    string warningQuestion = "Please check the stock before proceeding." + Environment.NewLine + "Would you still like to place the order?";

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
                                    tabC_Body.SelectedTab = tab_Tables;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log and display error
                DisplayError(ex);
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
            // Create the order
            CreateOrder();
        }

        private void btn_Order_Checkout_Click(object sender, EventArgs e)
        {
            // Open the bill
            tabC_Body.SelectedIndex = 5;
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

        #region Error Management
        private void DisplayError(Exception ex)
        {
            // Log error
            string filePath = logger.LogError(ex);

            string errorMessage = ex.Message + Environment.NewLine + "Apologies, please try again." + " Log location: " + Environment.NewLine + filePath;

            // Display error 
            using (MessageBox_Ok messageBox_W = new MessageBox_Ok("Oops, an error occured!", errorMessage))
            {
                DialogResult dialogResult_W = messageBox_W.ShowDialog();
            }
        }
        #endregion
    }
}
