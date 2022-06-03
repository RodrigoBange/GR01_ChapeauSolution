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
        BillService billService;
        PaymentService paymentService;

        // Constant variables
        const string hexColorBright = "#323145";
        const string hexColorDark = "#1C1B2D";

        // General variables
        private int tableNumber = 0;

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
            billService = new BillService();
            paymentService = new PaymentService();
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
                        lbl_Title.Text = "Bar Orders";
                    }
                    break;
                // Kitchen View 
                case 9:
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

            // Set colors
            border_Left.BackColor = ColorTranslator.FromHtml(hexColorBright);
            border_Right.BackColor = ColorTranslator.FromHtml(hexColorBright);
            border_Top.BackColor = ColorTranslator.FromHtml(hexColorBright);
            border_Bottom.BackColor = ColorTranslator.FromHtml(hexColorBright);
        }

        #endregion

        #region Table View
        /** TABLE VIEW METHODS **/
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
            tabC_Body.SelectedIndex = 4;
            Bill_LoadBillView(tableNumber);
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
                bill.PriceRemaining = billService.GetRemainingPrice(bill);

                //Call method to load the Bill listview
                Bill_LoadBill(bill);

                //Call method to load the VAT section
                Bill_LoadVATSection(bill);
                
            }
            catch (Exception ex)
            {
                DisplayError(ex);
            }
            
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
                listItem.SubItems.Add("€"+billItem.PriceWithVAT.ToString("0.00"));
                listItem.SubItems.Add("€"+billItem.TotalPrice.ToString("0.00"));
                listItem.Tag = billItem;

                Bill_lv_Bill.Items.Add(listItem);
            }
            Bill_lbl_TotalAmount.Text = $"€{bill.TotalBillPrice.ToString("0.00")}";
            Bill_lbl_RemainingPrice.Text = $"€{bill.PriceRemaining.ToString("0.00")}";
        }

        //Load VAT stats into the VAT section listview
        private void Bill_LoadVATSection(Bill bill)
        {
            //Load listviewItem for Non-Alcoholic VAT
            ListViewItem listItem1 = new ListViewItem($"{Bill.NonAlcholicVATPercentage}%");
            listItem1.SubItems.Add(bill.PriceExclVATNonAlcoholic.ToString("0.00"));
            listItem1.SubItems.Add(bill.VATNonAlcoholic.ToString("0.00"));
            listItem1.SubItems.Add(bill.PriceInclVATNonAlcoholic.ToString("0.00"));
            Bill_lv_VAT.Items.Add(listItem1);

            //Load listviewItem for Alcoholic VAT
            ListViewItem listItem2 = new ListViewItem($"{Bill.AlcholicVATPercentage}%");
            listItem2.SubItems.Add(bill.PriceExclVATAlcoholic.ToString("0.00"));
            listItem2.SubItems.Add(bill.VATAlcoholic.ToString("0.00"));
            listItem2.SubItems.Add(bill.PriceInclVATAlcoholic.ToString("0.00"));
            Bill_lv_VAT.Items.Add(listItem2);
        }
        
        //Code for Pay button 
        private void Bill_btn_Pay_Click(object sender, EventArgs e)
        {
            if (Bill_radbtn_Cash.Checked) //If cash option is checked, open cash payment screen
            {
                payment = new Payment();
                Payment_lbl_Method.Text = "Cash";
                payment.PaymentType = PaymentType.Cash;
                LoadCashPaymentView(bill);
                
                tabC_Body.SelectedIndex = 5;
            }
            else if (Bill_radbtn_Credit.Checked) //If credit option is checked, open credit payment screen
            {
                payment = new Payment();
                Payment_lbl_Method.Text = "Credit Card";
                payment.PaymentType = PaymentType.Credit;
                LoadCardPaymentView(bill);
                tabC_Body.SelectedIndex = 5;
            }
            else if (Bill_radbtn_Debit.Checked) //If debit option is checked, open credit payment screen
            {
                payment = new Payment();
                Payment_lbl_Method.Text = "Debit Card";
                payment.PaymentType = PaymentType.Debit;
                LoadCardPaymentView(bill);
                tabC_Body.SelectedIndex = 5;
            }
            else //No payment method selected, throw messagebox with instructions
            {
                MessageBox_Ok messageBox = new MessageBox_Ok("Select Payment Method", "Select a payment method first.");
                messageBox.ShowDialog();
            }
        }

        //Enable the "Next Screen" button when a Payment method selected
        private void Bill_radbtn_Cash_Checked(object sender, EventArgs e)
        {
            Bill_EnablePayButton();
        }

        private void Bill_radbtn_Debit_Checked(object sender, EventArgs e)
        {
            Bill_EnablePayButton();
        }

        private void Bill_radbtn_Credit_Checked(object sender, EventArgs e)
        {
            Bill_EnablePayButton();
        }

        //Disable Pay button (visually, not functionally)
        private void Bill_DisablePayButton()
        {
            Bill_btn_Pay.ForeColor = Color.LightGray;
            Bill_btn_Pay.BackColor = Color.DarkRed;
        }

        //Enable Pay button (visually, not functionally)
        private void Bill_EnablePayButton()
        {
            Bill_btn_Pay.ForeColor = Color.White;
            Bill_btn_Pay.BackColor = ColorTranslator.FromHtml("254, 60, 60");
        }


        #endregion

        #region Payment View
        /** PAYMENT VIEW METHODS **/
        Payment payment;
        private void LoadPaymentView()
        {
            Payment_num_AmountGivenOrTip.Value = 0;
            Payment_num_ChangeOrTotal.Value = 0;
        }
            
        private void LoadCashPaymentView(Bill bill)
        {
            Payment_lbl_BillTotal.Text = $"€{bill.PriceRemaining.ToString("0.00")}";
            Payment_lbl_AmountGivenOrTip.Text = "Amount Given:";
            Payment_lbl_ChangeOrTotalToPay.Text = "Change";
            Payment_Btn_Pay.Text = "Complete Payment";

            
        }

        private void LoadCardPaymentView(Bill bill)
        {
            Payment_lbl_BillTotal.Text = $"€{bill.PriceRemaining.ToString("0.00")}";
            Payment_lbl_AmountGivenOrTip.Text = "Tip:";
            Payment_lbl_ChangeOrTotalToPay.Text = "Total to Pay:";
            Payment_Btn_Pay.Text = "Process Payment";
        }

        private void Payment_btn_Cancel_Click(object sender, EventArgs e)
        {
            tabC_Body.SelectedIndex = 4;
        }

        private void Payment_num_1_ValueChanged(object sender, EventArgs e)
        {
            if (payment.PaymentType == PaymentType.Cash)
            {
                if (Payment_num_AmountGivenOrTip.Value >= (decimal)bill.PriceRemaining)
                    Payment_num_ChangeOrTotal.Value = (Payment_num_AmountGivenOrTip.Value - (decimal)bill.PriceRemaining);
            }
            else
            {
                Payment_num_ChangeOrTotal.Value = (Payment_num_AmountGivenOrTip.Value + (decimal)bill.PriceRemaining);
            }
        }

        private void Payment_Num_2_ValueChanged(object sender, EventArgs e)
        {
            if (payment.PaymentType == PaymentType.Cash)
            {
                Payment_num_AmountGivenOrTip.Value = ((decimal)bill.PriceRemaining + Payment_num_ChangeOrTotal.Value);
            }
            else
            {
                Payment_num_AmountGivenOrTip.Value = (Payment_num_ChangeOrTotal.Value - (decimal)bill.PriceRemaining);
            }
        }

        private void Payment_Btn_Pay_Click(object sender, EventArgs e)
        {
            if (payment.PaymentType == PaymentType.Cash)
            {
                payment.TotalAmountPaid = (double)Payment_num_AmountGivenOrTip.Value;
                tabC_Body.SelectedIndex = 7;
            }
            else
            {
                payment.TotalAmountPaid = (double)Payment_num_ChangeOrTotal.Value;
                payment.Tip = (double)Payment_num_AmountGivenOrTip.Value;
                tabC_Body.SelectedIndex = 6;

            }
        }
        #endregion

        #region Payment Processing
        /** PAYMENT PROCESSING METHODS **/

        private void LoadPaymentProcessingView()
        {

        }

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
