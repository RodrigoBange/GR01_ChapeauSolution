using ChapeauUI.Components;
using ChapeauModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ChapeauLogic;
using ChapeauUI.Forms;
using ChapeauUI;
using ChapeauUI.Properties;

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
        TableService tableService;
        BillService billService;
        PaymentService paymentService;
        Random rnd;

        // Constant variables
        const string hexColorBright = "#323145";
        const string hexColorDark = "#1C1B2D";

        // General variables
        private int tableNumber = 1;
        private List<Tuple<Button, Table>> tables = new List<Tuple<Button, Table>>();

        Employee employee;

        #region General
        // Constructor
        public Form_Chapeau(Employee employee)
        {
            // Initialize
            InitializeComponent();

            // Get instance
            logger = ErrorLogger.GetInstance();

            // Initialize services
            menuService = new MenuService();
            orderService = new OrderService();
            stockService = new StockService();
            tableService = new TableService();
            billService = new BillService();
            paymentService = new PaymentService();
            rnd = new Random();

            // Set employee
            this.employee = employee;
        }

        // On Load
        private void FormChapeau_Load(object sender, EventArgs e)
        {
            // Hide tab Control tabs for user
            tabC_Body.Appearance = TabAppearance.FlatButtons;
            tabC_Body.ItemSize = new Size(0, 1);
            tabC_Body.SizeMode = TabSizeMode.Fixed;
            btn_User.Visible = true;
            btn_Return.Visible = true;

            // Start tab on load
            tabC_Body.SelectedTab = tab_Tables;

            // Fill table list
            tables.Add(new Tuple<Button, Table>(btn_Table_1, new Table(1, false)));
            tables.Add(new Tuple<Button, Table>(btn_Table_2, new Table(2, false)));
            tables.Add(new Tuple<Button, Table>(btn_Table_3, new Table(3, false)));
            tables.Add(new Tuple<Button, Table>(btn_Table_4, new Table(4, false)));
            tables.Add(new Tuple<Button, Table>(btn_Table_5, new Table(5, false)));
            tables.Add(new Tuple<Button, Table>(btn_Table_6, new Table(6, false)));
            tables.Add(new Tuple<Button, Table>(btn_Table_7, new Table(7, false)));
            tables.Add(new Tuple<Button, Table>(btn_Table_8, new Table(8, false)));
            tables.Add(new Tuple<Button, Table>(btn_Table_9, new Table(9, false)));
            tables.Add(new Tuple<Button, Table>(btn_Table_10, new Table(10, false)));

            // Check for table occupied
            CheckTableStatuses();

            // Load running orders
            List<OrderItem> items = new List<OrderItem>();
            C_Table_Order tab_tableOrder = new C_Table_Order(items);
            flow_TableOverview.Controls.Add(tab_tableOrder);

        }

        private void SelectedTabChanged(object sender, EventArgs e)
        {
            // When tab is changed...
            switch (tabC_Body.SelectedIndex)
            {
                // Account View 
                case 0:
                    {
                        // Set title
                        lbl_Title.Text = "Account";
                        
                        // Set account information
                        lbl_Account_EmployeeID.Text = $"ID: {employee.EmployeeId.ToString()}";
                        lbl_Account_EmployeeName.Text = employee.EmployeeName;
                        lbl_Account_Role.Text = employee.EmployeeRole;
                    }
                    break;
                // Table View 
                case 1:
                    {
                        // Set title
                        lbl_Title.Text = "Overview";

                        // Check for table occupied
                        CheckTableStatuses();
                    }
                    break;
                // Order View
                case 2:
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

                        // Disable Place Order
                        ActivatePlaceOrder();

                        // Set the width to hide the scrollbar for a modern mobile design
                        flow_Order_Menu.Width = pnl_Order_Menu.Width + SystemInformation.VerticalScrollBarWidth;
                        flow_Order_Items.Width = pnl_Order_Orders.Width + SystemInformation.VerticalScrollBarWidth;
                    }
                    break;
                // Bill View 
                case 3:
                    {
                        // Set title
                        lbl_Title.Text = $"Bill Table #{tableNumber}";
                    }
                    break;
                // Cash Payment View
                case 4:
                    {
                        // Set title
                        lbl_Title.Text = $"Payment Table #{tableNumber}";
                    }
                    break;
                // Card Payment View
                case 5:
                    {
                        // Set title
                        lbl_Title.Text = $"Payment Table #{tableNumber}";
                    }
                    break;
                // Process Payment View
                case 6:
                    {
                        lbl_Title.Text = "Process Payment";
                    }
                    break;
                // Payment Failed View
                case 7:
                    {
                        lbl_Title.Text = "Payment Fail";
                    }
                    break;
                // Payment Success View
                case 8:
                    {
                        lbl_Title.Text = "Payment Success";
                    }
                    break;
            }
        }

        private void btn_Return_Click(object sender, EventArgs e)
        {
            // If Orderview is open and there are currently items listed in the order...
            if (tabC_Body.SelectedTab == tab_Order && orderItems.Count > 0)
            {
                // Ask for confirmation before returning
                using (MessageBox_YesNo messageBox = new MessageBox_YesNo("Confirmation", "You are about to return to the table overview and clear all items from the order.", "Are you sure you want to proceed?"))
                {
                    if (messageBox.ShowDialog() == DialogResult.Yes)
                    {
                        // Return to table view
                        tabC_Body.SelectedTab = tab_Tables;
                    }
                }
            }//Or if the payment complete tab is open, the potentially entered comment is transferred (comment will be checked in service layer). 
            else if (tabC_Body.SelectedTab == tab_PaymentComplete) 
            {
                try
                {
                    paymentService.InsertComment(PaymentComplete_txt_Comment.Text);
                }
                catch (Exception ex)
                {
                    DisplayError(ex);
                }
            }
            else
            {
                // Return to table view
                tabC_Body.SelectedTab = tab_Tables;
            }
        }
        #endregion

        #region Account
        /** ACCOUNT METHODS **/
        private void btn_User_Click(object sender, EventArgs e)
        {
            // If Orderview is open and there are currently items listed in the order...
            if (tabC_Body.SelectedTab == tab_Order && orderItems.Count > 0)
            {
                // Ask for confirmation before returning
                using (MessageBox_YesNo messageBox = new MessageBox_YesNo("Confirmation", "You are about to open the account overview and clear all items from the order.", "Are you sure you want to proceed?"))
                {
                    if (messageBox.ShowDialog() == DialogResult.Yes)
                    {
                        // Open account overview
                        tabC_Body.SelectedTab = tab_Account;
                    }
                }
            }//Or if the payment complete tab is open, the potentially entered comment is transferred (comment will be checked in service layer). 
            else if (tabC_Body.SelectedTab == tab_PaymentComplete) 
            {
                try
                {
                    paymentService.InsertComment(PaymentComplete_txt_Comment.Text);
                }
                catch (Exception ex)
                {
                    DisplayError(ex);
                }
            }
            else
            {
                // Open account overview
                tabC_Body.SelectedTab = tab_Account;
            }
        }

        private void btn_Account_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            employee = null;
        }

        #endregion

        #region Table View
        /** TABLE VIEW METHODS **/
        private void CheckTableStatuses()
        {
            for (int i = 1; i < tables.Count + 1; i++)
            {
                if (tableService.TableOccupied(i))
                {
                    tables[i - 1].Item1.BackgroundImage = Resources.tableRed;
                    tables[i - 1].Item2.IsOccupied = true;
                }
                else
                {
                    tables[i - 1].Item1.BackgroundImage = Resources.Table_White;
                    tables[i - 1].Item2.IsOccupied = false;
                }
            }
        }

        private void OccupiedTable()
        {            
            if (tables[tableNumber - 1].Item2.IsOccupied)
            {
                tabC_Body.SelectedTab = tab_Order;
            }
            else
            {
                using (MessageBox_OccupiedTakeorder messageBox = new MessageBox_OccupiedTakeorder("Table " + tableNumber))
                {
                    switch (messageBox.ShowDialog())
                    {
                        case DialogResult.Yes:
                            tableService.SetTableOccupied(tableNumber);
                            tables[tableNumber - 1].Item1.BackgroundImage = Resources.tableRed;
                            tables[tableNumber - 1].Item2.IsOccupied = true;
                            break;
                        case DialogResult.No:
                            tabC_Body.SelectedTab = tab_Order;
                            tableService.SetTableOccupied(tableNumber);
                            tables[tableNumber - 1].Item1.BackgroundImage = Resources.tableRed;
                            tables[tableNumber - 1].Item2.IsOccupied = true;
                            break;
                        case DialogResult.Cancel:
                            messageBox.Hide();
                            break;
                    }
                }
            }
        }

        private void btn_Table_1_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 1;

            // Check if the table is occupied
            OccupiedTable();
        }

        private void btn_Table_2_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 2;

            // Check if the table is occupied
            OccupiedTable();
        }

        private void btn_Table_3_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 3;

            // Check if the table is occupied
            OccupiedTable();
        }

        private void btn_Table_4_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 4;

            // Check if the table is occupied
            OccupiedTable();
        }

        private void btn_Table_5_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 5;

            // Check if the table is occupied
            OccupiedTable();
        }

        private void btn_Table_6_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 6;

            // Check if the table is occupied
            OccupiedTable();
        }
        private void btn_Table_7_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 7;

            // Check if the table is occupied
            OccupiedTable();
        }

        private void btn_Table_8_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 8;

            // Check if the table is occupied
            OccupiedTable();
        }
        private void btn_Table_9_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 9;

            // Check if the table is occupied
            OccupiedTable();
        }
        private void btn_Table_10_Click(object sender, EventArgs e)
        {
            // Set active table number
            tableNumber = 10;

            // Check if the table is occupied
            OccupiedTable();
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
            if (menuCategory == MenuCategory.Lunch) { menuItems = lunchMenu; }
            else if (menuCategory == MenuCategory.Dinner) { menuItems = dinnerMenu; }
            else { menuItems = drinksMenu; }

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

                // Activate Place Order button
                ActivatePlaceOrder();
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
                        ActivatePlaceOrder();

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

                // Check if list is empty
                if (lowStockItems == null)
                {
                    using (MessageBox_YesNo messageBox_YN = new MessageBox_YesNo("Confirmation", "You are about to place an order.", "Are you sure you want to continue?"))
                    {
                        if (messageBox_YN.ShowDialog() == DialogResult.Yes)
                        {
                            // Call orderService to place an order
                            orderService.PlaceOrder(orders, tableNumber, employee.EmployeeId);

                            // Call stockService to remove stock
                            stockService.DepleteStock(orders);

                            // Display confirmation
                            using (MessageBox_Ok messageBox_W = new MessageBox_Ok("Confirmation", "Order has been succesfully placed."))
                            {
                                // When accepted
                                if (messageBox_W.ShowDialog() == DialogResult.OK)
                                {
                                    // Display table overview
                                    tabC_Body.SelectedTab = tab_Tables;
                                }
                            }
                        }
                    }

                }
                else
                {
                    // Confirmation of low stock before placing order
                    LowStockConfirmation(lowStockItems, orders);
                }
            }
            catch (Exception ex)
            {
                // Log and display error
                DisplayError(ex);
            }            
        }

        private void LowStockConfirmation(List<String> lowStockItems, List<OrderItem> orders)
        {
            // Prepare warning message
            string warningMessage = "The ingredients for the following items are low or out of stock:" + Environment.NewLine;

            // Add items to warning message text
            for (int i = 0; i < lowStockItems.Count; i++)
            {
                if (i < lowStockItems.Count - 1) { warningMessage += lowStockItems[i] + ", "; }
                else { warningMessage += lowStockItems[i] + ". "; }
            }

            string warningQuestion = "Please check the stock before proceeding." + Environment.NewLine + "Would you still like to place the order?";

            // Use the custom messageBox
            using (MessageBox_YesNo messageBox = new MessageBox_YesNo("Warning - Low stock", warningMessage, warningQuestion))
            {
                if (messageBox.ShowDialog() == DialogResult.Yes)
                {
                    // Call orderService to place an order
                    orderService.PlaceOrder(orders, tableNumber, employee.EmployeeId);

                    // Call stockService to remove from stock
                    stockService.DepleteStock(orders);

                    // Display confirmation
                    using (MessageBox_Ok messageBox_W = new MessageBox_Ok("Confirmation", "Order has been succesfully placed."))
                    {
                        // When accepted
                        if (messageBox_W.ShowDialog() == DialogResult.OK) 
                        {
                            // Display table overview
                            tabC_Body.SelectedTab = tab_Tables;
                        }
                    }
                }
            }
        }

        private void ActivatePlaceOrder()
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

                // Set Clear order button to visible (As this goes together with order button)
                splitter_ClearOrder.Visible = true;
                btn_Clear_Order.Visible = true;
            }
            else
            {
                btn_Order_Confirm.BackColor = ColorTranslator.FromHtml("#822121");

                // Set Clear order button to invisible (As this goes together with order button)
                splitter_ClearOrder.Visible= false;
                btn_Clear_Order.Visible = false;
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
            Bill_LoadBillView(tableNumber);
        }

        private void btn_Clear_Order_Click(object sender, EventArgs e)
        {
            // Display confirmation message
            using (MessageBox_YesNo messageBox = new MessageBox_YesNo("Confirmation", "You are about to clear all items from the order.", "Are you sure you want to proceed?"))
            {
                if (messageBox.ShowDialog() == DialogResult.Yes)
                {
                    // Clear all orders
                    orderItems.Clear();
                    flow_Order_Items.Controls.Clear();

                    // Set price to 0
                    UpdateTotalPrice(-totalOrderPrice);

                    // Set order button to disabled
                    btn_Order_Confirm.Enabled = false;
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
        private Bill bill;

        //Load Bill View, called when pressing Checkout Button in the Order View
        private void Bill_LoadBillView(int tableNr)
        {
            //Clear listviews
            Bill_lv_Bill.Items.Clear();
            Bill_lv_VAT.Items.Clear();

            //Clear RadButtons
            Bill_radbtn_Cash.Checked = false;
            Bill_radbtn_Debit.Checked = false;
            Bill_radbtn_Credit.Checked = false;

            //Disable Pay button (visually, not functionally)
            Bill_DisablePayButton();

            try
            {
                //Retrieve bill from the database
                bill = billService.GetBill(tableNr);

                //Retrieve the bill's remaining price
                bill.PriceRemaining = paymentService.GetRemainingPrice(bill);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }

            //Load the Bill listview
            Bill_LoadBill(bill);

            //Load the VAT section
            Bill_LoadVATSection(bill);

            //Switch to bill tab
            tabC_Body.SelectedTab = tab_Bill;
        }
        //Load bill listview
        private void Bill_LoadBill(Bill bill)
        {
            //Load BillItems into the bill listview
            foreach (BillItem billItem in bill.BillItems)
            {
                ListViewItem listItem = new ListViewItem(billItem.Count.ToString());

                listItem.SubItems.Add(billItem.Name);
                listItem.SubItems.Add($"{billItem.VATPercentage}%");
                listItem.SubItems.Add("€" + billItem.PriceWithVAT.ToString("0.00"));
                listItem.SubItems.Add("€" + billItem.TotalPrice.ToString("0.00"));
                listItem.Tag = billItem;

                Bill_lv_Bill.Items.Add(listItem);
            }

            //Display additional info
            Bill_lbl_TotalAmount.Text = $"€{bill.TotalBillPrice.ToString("0.00")}";
            Bill_lbl_amountPaid.Text = $"€{(bill.TotalBillPrice - bill.PriceRemaining).ToString("0.00")}";
            Bill_lbl_RemainingPrice.Text = $"€{bill.PriceRemaining.ToString("0.00")}";
        }

        //Load VAT stats into the VAT section listview
        private void Bill_LoadVATSection(Bill bill)
        {
            //Load listviewItem for Non-Alcoholic VAT
            ListViewItem listItem1 = new ListViewItem($"{Bill.NonAlcholicVATPercentage}%");
            listItem1.SubItems.Add($"€{bill.PriceExclVATNonAlcoholic.ToString("0.00")}");
            listItem1.SubItems.Add($"€{bill.VATNonAlcoholic.ToString("0.00")}");
            listItem1.SubItems.Add($"€{bill.PriceInclVATNonAlcoholic.ToString("0.00")}");
            Bill_lv_VAT.Items.Add(listItem1);

            //Load listviewItem for Alcoholic VAT
            ListViewItem listItem2 = new ListViewItem($"{Bill.AlcholicVATPercentage}%");
            listItem2.SubItems.Add($"€{bill.PriceExclVATAlcoholic.ToString("0.00")}");
            listItem2.SubItems.Add($"€{bill.VATAlcoholic.ToString("0.00")}");
            listItem2.SubItems.Add($"€{bill.PriceInclVATAlcoholic.ToString("0.00")}");
            Bill_lv_VAT.Items.Add(listItem2);
        }

        //Enable the "Next Screen" button when a Payment method selected
        private void Bill_radbtn_Cash_CheckedChanged(object sender, EventArgs e)
        {
            Bill_EnablePayButton();
        }

        private void Bill_radbtn_Debit_CheckedChanged(object sender, EventArgs e)
        {
            Bill_EnablePayButton();
        }

        private void Bill_radbtn_Credit_CheckedChanged(object sender, EventArgs e)
        {
            Bill_EnablePayButton();
        }

        //Disable "Next Screen" button (visually, not functionally)
        private void Bill_DisablePayButton()
        {
            Bill_btn_Pay.ForeColor = Color.LightGray;
            Bill_btn_Pay.BackColor = Color.DarkRed;
        }

        //Enable "Next Screen" button (visually, not functionally)
        private void Bill_EnablePayButton()
        {
            Bill_btn_Pay.ForeColor = Color.White;
            Bill_btn_Pay.BackColor = ColorTranslator.FromHtml("254, 60, 60");
        }

        //Code for Pay button 
        Payment payment;
        private void Bill_btn_Pay_Click(object sender, EventArgs e)
        {
            payment = new Payment(bill);

            //If cash option is checked, open cash payment screen
            if (Bill_radbtn_Cash.Checked)
            {
                payment.PaymentMethod = PaymentMethod.Cash;
                LoadCashPaymentView();
            }
            //If credit option is checked, open credit payment screen
            else if (Bill_radbtn_Credit.Checked)
            {
                payment.PaymentMethod = PaymentMethod.Credit;
                LoadCreditPaymentView();
            }
            //If debit option is checked, open credit payment screen
            else if (Bill_radbtn_Debit.Checked)
            {
                payment.PaymentMethod = PaymentMethod.Debit;
                LoadDebitPaymentView();
            }
            else //No payment method selected, display instructions in an error message for the user
            {
                MessageBox_Ok messageBox = new MessageBox_Ok("Select Payment Method", "Select a payment method first.");
                messageBox.ShowDialog();
            }
        }
        #endregion

        #region Cash Payment
        /** CASH PAYMENT METHODS **/
        private void LoadCashPaymentView()
        {
            //Change input types specific to cash payment
            PayCash_lbl_BillTotal.Text = $"€{bill.PriceRemaining.ToString("0.00")}";

            PayCash_num_AmountGiven.Value = (decimal)bill.PriceRemaining;
            PayCash_num_Change.Value = 0;
            tabC_Body.SelectedTab = tab_CashPayment;
        }
        
        private void Cash_btn_Back_Click(object sender, EventArgs e)
        {
            //Back button takes user back to bill screen (with user input still intact)
            tabC_Body.SelectedTab = tab_Bill;
        }

        
        private void PayCash_num_AmountGiven_ValueChanged(object sender, EventArgs e)
        {
            //If entered amount given is more than the bill price, calculate change
            if (PayCash_num_AmountGiven.Value > (decimal)bill.PriceRemaining)
            {
                PayCash_num_Change.Value = (PayCash_num_AmountGiven.Value - (decimal)bill.PriceRemaining);
            }
            else //If given amount is lower, make the change amount 0
            {
                PayCash_num_Change.Value = 0;
            }
        }
        
        private void PayCash_num_Change_ValueChanged(object sender, EventArgs e)
        {
            //If user enters a certain amount of change, system will reverse-calculate the given amount
            PayCash_num_AmountGiven.Value = ((decimal)bill.PriceRemaining + PayCash_num_Change.Value);
        }

        private void Cash_btn_Pay_Click(object sender, EventArgs e)
        {
            //If pay button is pressed, insert payment, go to payment complete view (no process).
            MessageBox_YesNo confirmPay = new MessageBox_YesNo("Confirm Payment", "Are you sure you want to complete this payment?", "");
            confirmPay.ShowDialog();
            if (confirmPay.DialogResult == DialogResult.Yes)
            {
                payment.AmountPaid = (double)PayCash_num_AmountGiven.Value;
                LoadPaymentSuccessfulView();
            }
            
        }
        #endregion

        #region Card Payment
        /** CARD PAYMENT METHODS **/

        //Load debit payment view
        private void LoadDebitPaymentView()
        {
            PayCard_lbl_Method.Text = "Debit Card";
            LoadCardPaymentView();
        }

        //Load credit payment view
        private void LoadCreditPaymentView()
        {
            PayCard_lbl_Method.Text = "Credit Card";
            LoadCardPaymentView();
        }

        private void LoadCardPaymentView()
        {
            PayCard_Num_Tip.Value = 0;
            PayCard_Num_Total.Value = (decimal)bill.PriceRemaining;
            PayCard_lbl_AmountToPay.Text = "€" + bill.PriceRemaining.ToString("0.00");
            tabC_Body.SelectedTab = tab_CardPayment;
        }

        private void PayCard_Num_Total_ValueChanged(object sender, EventArgs e)
        {
            //Automatically calculate tip only if specified amount is more than the bill
            if (PayCard_Num_Total.Value > (decimal)bill.PriceRemaining)
            {
                PayCard_Num_Tip.Value = (PayCard_Num_Total.Value - (decimal)bill.PriceRemaining);
            }
        }

        private void PayCard_Num_Tip_ValueChanged(object sender, EventArgs e)
        {
            //Partial payment, add tip to specified amount
            if (PayCard_Num_Total.Value < (decimal)bill.PriceRemaining)
            {
                PayCard_Num_Total.Value = PayCard_Num_Total.Value + PayCard_Num_Tip.Value;
            }
            else //Full payment, add tip to total price
            {
                PayCard_Num_Total.Value = (decimal)bill.PriceRemaining + PayCard_Num_Tip.Value;
            }
        }
        
        private void PayCard_btn_Back_Click(object sender, EventArgs e)
        {
            //Back button takes user back to bill screen (with user input still intact)
            tabC_Body.SelectedTab = tab_Bill;
        }

        private void PayCard_btn_Pay_Click(object sender, EventArgs e)
        {
            MessageBox_YesNo confirmPay = new MessageBox_YesNo("Confirm Payment", "Are you sure you want to process this payment?", "");
            confirmPay.ShowDialog();
            if (confirmPay.DialogResult == DialogResult.Yes)
            {
                //Take user input
                payment.Tip = (double)PayCard_Num_Tip.Value;
                payment.AmountPaid = (double)PayCard_Num_Total.Value - (double)PayCard_Num_Tip.Value;
                //Load to processing view
                LoadPaymentProcessingView();
            }
        }
        #endregion

        #region Payment Processing
        /** PAYMENT PROCESSING METHODS **/
        int paymentTimeLeft;

        private void LoadPaymentProcessingView()
        {
            tabC_Body.SelectedTab = tab_ProcessPayment;
            PaymentProcess_lbl_FunFact.Text = LoadFunFact();
            paymentTimeLeft = 6;
            PaymentProcessTimer1.Tick += PaymentProcessTimer1_Tick;
            PaymentProcessTimer1.Interval = 1500;
            PaymentProcessTimer1.Start();
        }

        private void PaymentProcessTimer1_Tick(object sender, EventArgs e)
        {
            paymentTimeLeft--;

            switch (paymentTimeLeft)
            {
                case 5:
                    PaymentProcess_lbl_Status.Text = "Crunching numbers...";
                    break;
                case 4:
                    PaymentProcess_lbl_Status.Text = "Robbing bank...";
                    break;
                case 3:
                    PaymentProcess_lbl_Status.Text = "Robbing bank...";
                    break;
                case 2:
                    PaymentProcess_lbl_Status.Text = "Counting change...";
                    break;
                case 1:
                    PaymentProcess_lbl_Status.Text = "Finalising payment...";
                    break;
                case 0:
                    PaymentProcess_lbl_Status.Text = "Finalising payment...";
                    PaymentProcessTimer1.Stop();

                    if (paymentService.SuccessfulPayment())
                        LoadPaymentSuccessfulView();
                    else
                        tabC_Body.SelectedTab = tab_PaymentFailed;
                    break;
                default:
                    break;
            }
        }

        //Load a fun fact to display while processing the payment
        private string LoadFunFact()
        {
            List<string> funFacts = paymentService.CreateFunFactsList();
            string funfact = funFacts[rnd.Next(0, funFacts.Count)];

            return funfact;
        }
        #endregion

        #region PaymentSuccessful
        /** PAYMENT SUCCESS VIEW METHODS **/
        private void LoadPaymentSuccessfulView()
        {
            //Reset comment textbox to the instruction              
            ResetCommentTextbox();

            try
            {
                //Insert the payment into the database
                paymentService.InsertPayment(payment);
                //Insert 
                if (paymentService.IsBillPaid(bill))
                {
                    PaymentComplete_btn_BackToTableView.Text = "Back to Table View";
                    bill.IsPaid = true;
                    tableService.SetTableUnoccupied(tableNumber);
                }
                else
                {
                    PaymentComplete_btn_BackToTableView.Text = "Issue Another Payment";
                }
            }
            catch (Exception ex)
            {
                DisplayError(ex);
                tabC_Body.SelectedTab = tab_PaymentFailed;
            }

            tabC_Body.SelectedTab = tab_PaymentComplete;
        }

        private void PaymentComplete_txt_Comment_Click(object sender, EventArgs e)
        {
            //Clear instruction when user clicks the textbox.
            if (PaymentComplete_txt_Comment.Text == "Ask the guest for a review of their experience and enter here.")
            {
                PaymentComplete_txt_Comment.Text = "";
                PaymentComplete_txt_Comment.Font = new Font(PaymentComplete_txt_Comment.Font, FontStyle.Regular);
            }
        }

        private void PaymentComplete_btn_BackToTableView_Click(object sender, EventArgs e)
        {
            try
            {
                //Insert comment to the database (comment will be checked in service layer)
                paymentService.InsertComment(PaymentComplete_txt_Comment.Text);
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }

            //If the bill is paid, return to the table view, if there are still payments remaining, return to bill view
            if (bill.IsPaid)
            {
                tabC_Body.SelectedTab = tab_Tables;
                payment = null;
                bill = null;
            }
            else
                Bill_LoadBillView(tableNumber);

        }

        //Method to reset comment textbox
        private void ResetCommentTextbox()
        {
            PaymentComplete_txt_Comment.Font = new Font(PaymentComplete_txt_Comment.Font, FontStyle.Italic);
            PaymentComplete_txt_Comment.Text = "Ask the guest for a review of their experience and enter here.";
        }
        #endregion

        #region PaymentFailed
        /** PAYMENT FAILED METHODS **/
        private void PaymentFailure_btn_ChangeMethod_Click(object sender, EventArgs e)
        {
            Bill_LoadBillView(tableNumber);
        }

        private void PaymentFailure_btn_TryAgain_Click(object sender, EventArgs e)
        {
            LoadPaymentProcessingView();
        }
        #endregion

        #region Kitchen
        /** KITCHEN VIEW METHODS **/
        #endregion

        #region Bar
        /** BAR VIEW METHODS **/
        #endregion

        #region Error Management
        private void DisplayError(Exception ex)
        {
            // Log error
            string filePath = logger.LogError(ex);

            string errorMessage = ex.Message + Environment.NewLine + "Apologies, if this keeps happening please refer the log to your IT specialist." + " Log location: " + Environment.NewLine + filePath;

            // Display error 
            using (MessageBox_Ok messageBox_W = new MessageBox_Ok("Oops, something went wrong!", errorMessage))
            {
                DialogResult dialogResult_W = messageBox_W.ShowDialog();
            }
        }

        #endregion

        
    }
}
