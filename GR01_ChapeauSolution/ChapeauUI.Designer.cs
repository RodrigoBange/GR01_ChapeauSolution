namespace GR01_ChapeauSolution
{
    partial class Form_Chapeau
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabC_Body = new System.Windows.Forms.TabControl();
            this.tab_Login = new System.Windows.Forms.TabPage();
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.txtBox_Login_Password = new System.Windows.Forms.TextBox();
            this.lbl_Login_Password = new System.Windows.Forms.Label();
            this.lbl_Login_EmployeeID = new System.Windows.Forms.Label();
            this.txtBox_Login_User = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.imgLogin_Logo = new System.Windows.Forms.PictureBox();
            this.tab_Account = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Account_Logout = new System.Windows.Forms.Button();
            this.lbl_Account_Role = new System.Windows.Forms.Label();
            this.lbl_Account_Email = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tab_Tables = new System.Windows.Forms.TabPage();
            this.pnl_TableOverview = new System.Windows.Forms.SplitContainer();
            this.flow_TableOverview = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.flow_TableOverview_Title = new System.Windows.Forms.FlowLayoutPanel();
            this.img_TableOverview_Title_Table = new System.Windows.Forms.PictureBox();
            this.lbl_TableOverview_Title = new System.Windows.Forms.Label();
            this.flow_Tables = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Table_1 = new System.Windows.Forms.Button();
            this.btn_Table_2 = new System.Windows.Forms.Button();
            this.btn_Table_3 = new System.Windows.Forms.Button();
            this.btn_Table_4 = new System.Windows.Forms.Button();
            this.btn_Table_5 = new System.Windows.Forms.Button();
            this.btn_Table_6 = new System.Windows.Forms.Button();
            this.btn_Table_7 = new System.Windows.Forms.Button();
            this.btn_Table_8 = new System.Windows.Forms.Button();
            this.btn_Table_9 = new System.Windows.Forms.Button();
            this.btn_Table_10 = new System.Windows.Forms.Button();
            this.splitter_TableOverview = new System.Windows.Forms.Splitter();
            this.pnl_TableInfo = new System.Windows.Forms.SplitContainer();
            this.splitter_Table_Top = new System.Windows.Forms.Splitter();
            this.flow_ServeOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_TableInfo_Panel1_Title = new System.Windows.Forms.Label();
            this.flow_Reservations = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_TableInfo_Panel2_Title = new System.Windows.Forms.Label();
            this.tab_Order = new System.Windows.Forms.TabPage();
            this.pnl_Order_Menu = new System.Windows.Forms.Panel();
            this.flow_Order_Menu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Order_Orders = new System.Windows.Forms.Panel();
            this.flow_Order_Items = new System.Windows.Forms.FlowLayoutPanel();
            this.splitter_Orders_Price = new System.Windows.Forms.Splitter();
            this.lbl_Order_TotalPrice = new System.Windows.Forms.Label();
            this.btn_Order_Confirm = new System.Windows.Forms.Button();
            this.splitter_Checkout = new System.Windows.Forms.Splitter();
            this.btn_Order_Checkout = new System.Windows.Forms.Button();
            this.splitter_OrderMenu = new System.Windows.Forms.Splitter();
            this.pnl_Order_Categories = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Order_LunchMenu = new System.Windows.Forms.Button();
            this.btn_Order_DinnerMenu = new System.Windows.Forms.Button();
            this.btn_Order_DrinksMenu = new System.Windows.Forms.Button();
            this.tab_Bill = new System.Windows.Forms.TabPage();
            this.pnl_Bill = new System.Windows.Forms.Panel();
            this.Bill_lbl_RemainingPrice = new System.Windows.Forms.Label();
            this.Bill_lbl_StillToPayTitle = new System.Windows.Forms.Label();
            this.Bill_lbl_TotalAmount = new System.Windows.Forms.Label();
            this.Bill_lbl_TotalTitle = new System.Windows.Forms.Label();
            this.Bill_lv_VAT = new System.Windows.Forms.ListView();
            this.VAT_ColVAT = new System.Windows.Forms.ColumnHeader();
            this.VAT_ColBasePrice = new System.Windows.Forms.ColumnHeader();
            this.VAT_ColVATAmount = new System.Windows.Forms.ColumnHeader();
            this.VAT_ColTotalSum = new System.Windows.Forms.ColumnHeader();
            this.Bill_btn_Pay = new System.Windows.Forms.Button();
            this.Bill_lbl_Bill = new System.Windows.Forms.Label();
            this.Bill_grpbox_PaymentMethod = new System.Windows.Forms.GroupBox();
            this.Bill_radbtn_Credit = new System.Windows.Forms.RadioButton();
            this.Bill_radbtn_Cash = new System.Windows.Forms.RadioButton();
            this.Bill_radbtn_Debit = new System.Windows.Forms.RadioButton();
            this.Bill_lv_Bill = new System.Windows.Forms.ListView();
            this.Bill_ColQuantity = new System.Windows.Forms.ColumnHeader();
            this.Bill_ColName = new System.Windows.Forms.ColumnHeader();
            this.Bill_ColVAT = new System.Windows.Forms.ColumnHeader();
            this.Bill_ColPrice = new System.Windows.Forms.ColumnHeader();
            this.Bill_ColPriceTotal = new System.Windows.Forms.ColumnHeader();
            this.tab_CashPayment = new System.Windows.Forms.TabPage();
            this.pnl_Cash = new System.Windows.Forms.Panel();
            this.Payment_Btn_Pay = new System.Windows.Forms.Button();
            this.Payment_lbl_AmountGivenOrTip = new System.Windows.Forms.Label();
            this.Payment_lbl_BillTotal = new System.Windows.Forms.Label();
            this.Payment_lbl_ChangeOrTotalToPay = new System.Windows.Forms.Label();
            this.Payment_lbl_BillTotalTitle = new System.Windows.Forms.Label();
            this.Payment_btn_Cancel = new System.Windows.Forms.Button();
            this.Payment_lbl_Method = new System.Windows.Forms.Label();
            this.Payment_num_ChangeOrTotal = new System.Windows.Forms.NumericUpDown();
            this.Payment_num_AmountGivenOrTip = new System.Windows.Forms.NumericUpDown();
            this.Payment_lbl_MethodTitle = new System.Windows.Forms.Label();
            this.tab_ProcessPayment = new System.Windows.Forms.TabPage();
            this.pnl_ProcessPayment = new System.Windows.Forms.Panel();
            this.PaymentProcess_lbl_FunFactTitle = new System.Windows.Forms.Label();
            this.ProcessPayment_ProcessingIcon = new System.Windows.Forms.PictureBox();
            this.lbl_ProcessPayment_Status = new System.Windows.Forms.Label();
            this.tab_PaymentComplete = new System.Windows.Forms.TabPage();
            this.pnl_PaymentComplete = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tab_Bar = new System.Windows.Forms.TabPage();
            this.flow_Bar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Bar_Categories = new System.Windows.Forms.Panel();
            this.lbl_Bar_Type = new System.Windows.Forms.Label();
            this.lbl_Bar_Drink = new System.Windows.Forms.Label();
            this.lbl_Bar_Order_Number = new System.Windows.Forms.Label();
            this.tab_Kitchen = new System.Windows.Forms.TabPage();
            this.flow_Kitchen = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Kitchen_Categories = new System.Windows.Forms.Panel();
            this.lbl_Kitchen_Type = new System.Windows.Forms.Label();
            this.lbl_Kitchen_Food = new System.Windows.Forms.Label();
            this.lbl_Kitchen_Order_Number = new System.Windows.Forms.Label();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Return_Admin = new System.Windows.Forms.Button();
            this.lbl_OrderCounter = new System.Windows.Forms.Label();
            this.background_OrderCounter = new System.Windows.Forms.PictureBox();
            this.btn_User = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Body = new System.Windows.Forms.Panel();
            this.border_Left = new System.Windows.Forms.PictureBox();
            this.border_Right = new System.Windows.Forms.PictureBox();
            this.border_Bottom = new System.Windows.Forms.PictureBox();
            this.border_Top = new System.Windows.Forms.PictureBox();
            this.PaymentProcessTimer1 = new System.Windows.Forms.Timer(this.components);
            this.PaymentProcess_lbl_FunFact = new System.Windows.Forms.Label();
            this.tabC_Body.SuspendLayout();
            this.tab_Login.SuspendLayout();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin_Logo)).BeginInit();
            this.tab_Account.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tab_Tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TableOverview)).BeginInit();
            this.pnl_TableOverview.Panel1.SuspendLayout();
            this.pnl_TableOverview.Panel2.SuspendLayout();
            this.pnl_TableOverview.SuspendLayout();
            this.flow_TableOverview_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_TableOverview_Title_Table)).BeginInit();
            this.flow_Tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TableInfo)).BeginInit();
            this.pnl_TableInfo.Panel1.SuspendLayout();
            this.pnl_TableInfo.Panel2.SuspendLayout();
            this.pnl_TableInfo.SuspendLayout();
            this.tab_Order.SuspendLayout();
            this.pnl_Order_Menu.SuspendLayout();
            this.pnl_Order_Orders.SuspendLayout();
            this.pnl_Order_Categories.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tab_Bill.SuspendLayout();
            this.pnl_Bill.SuspendLayout();
            this.Bill_grpbox_PaymentMethod.SuspendLayout();
            this.tab_CashPayment.SuspendLayout();
            this.pnl_Cash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_num_ChangeOrTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_num_AmountGivenOrTip)).BeginInit();
            this.tab_ProcessPayment.SuspendLayout();
            this.pnl_ProcessPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProcessPayment_ProcessingIcon)).BeginInit();
            this.tab_PaymentComplete.SuspendLayout();
            this.pnl_PaymentComplete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_Bar.SuspendLayout();
            this.pnl_Bar_Categories.SuspendLayout();
            this.tab_Kitchen.SuspendLayout();
            this.pnl_Kitchen_Categories.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background_OrderCounter)).BeginInit();
            this.pnl_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.border_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_Right)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_Bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_Top)).BeginInit();
            this.SuspendLayout();
            // 
            // tabC_Body
            // 
            this.tabC_Body.Controls.Add(this.tab_Login);
            this.tabC_Body.Controls.Add(this.tab_Account);
            this.tabC_Body.Controls.Add(this.tab_Tables);
            this.tabC_Body.Controls.Add(this.tab_Order);
            this.tabC_Body.Controls.Add(this.tab_Bill);
            this.tabC_Body.Controls.Add(this.tab_CashPayment);
            this.tabC_Body.Controls.Add(this.tab_ProcessPayment);
            this.tabC_Body.Controls.Add(this.tab_PaymentComplete);
            this.tabC_Body.Controls.Add(this.tab_Bar);
            this.tabC_Body.Controls.Add(this.tab_Kitchen);
            this.tabC_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabC_Body.Location = new System.Drawing.Point(0, 0);
            this.tabC_Body.Margin = new System.Windows.Forms.Padding(0);
            this.tabC_Body.Name = "tabC_Body";
            this.tabC_Body.Padding = new System.Drawing.Point(0, 0);
            this.tabC_Body.SelectedIndex = 0;
            this.tabC_Body.Size = new System.Drawing.Size(529, 650);
            this.tabC_Body.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabC_Body.TabIndex = 0;
            this.tabC_Body.SelectedIndexChanged += new System.EventHandler(this.SelectedTabChanged);
            // 
            // tab_Login
            // 
            this.tab_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tab_Login.Controls.Add(this.pnl_Login);
            this.tab_Login.Controls.Add(this.imgLogin_Logo);
            this.tab_Login.Location = new System.Drawing.Point(4, 24);
            this.tab_Login.Margin = new System.Windows.Forms.Padding(0);
            this.tab_Login.Name = "tab_Login";
            this.tab_Login.Size = new System.Drawing.Size(521, 622);
            this.tab_Login.TabIndex = 0;
            this.tab_Login.Text = "Login";
            // 
            // pnl_Login
            // 
            this.pnl_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_Login.Controls.Add(this.txtBox_Login_Password);
            this.pnl_Login.Controls.Add(this.lbl_Login_Password);
            this.pnl_Login.Controls.Add(this.lbl_Login_EmployeeID);
            this.pnl_Login.Controls.Add(this.txtBox_Login_User);
            this.pnl_Login.Controls.Add(this.btn_Login);
            this.pnl_Login.Location = new System.Drawing.Point(51, 214);
            this.pnl_Login.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(431, 351);
            this.pnl_Login.TabIndex = 2;
            // 
            // txtBox_Login_Password
            // 
            this.txtBox_Login_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.txtBox_Login_Password.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Login_Password.ForeColor = System.Drawing.Color.White;
            this.txtBox_Login_Password.Location = new System.Drawing.Point(147, 101);
            this.txtBox_Login_Password.Margin = new System.Windows.Forms.Padding(1);
            this.txtBox_Login_Password.Name = "txtBox_Login_Password";
            this.txtBox_Login_Password.PasswordChar = '●';
            this.txtBox_Login_Password.PlaceholderText = "Enter your password";
            this.txtBox_Login_Password.Size = new System.Drawing.Size(263, 34);
            this.txtBox_Login_Password.TabIndex = 4;
            // 
            // lbl_Login_Password
            // 
            this.lbl_Login_Password.AutoSize = true;
            this.lbl_Login_Password.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_Password.Location = new System.Drawing.Point(11, 103);
            this.lbl_Login_Password.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Login_Password.Name = "lbl_Login_Password";
            this.lbl_Login_Password.Size = new System.Drawing.Size(116, 27);
            this.lbl_Login_Password.TabIndex = 3;
            this.lbl_Login_Password.Text = "Password : ";
            // 
            // lbl_Login_EmployeeID
            // 
            this.lbl_Login_EmployeeID.AutoSize = true;
            this.lbl_Login_EmployeeID.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Login_EmployeeID.Location = new System.Drawing.Point(11, 57);
            this.lbl_Login_EmployeeID.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Login_EmployeeID.Name = "lbl_Login_EmployeeID";
            this.lbl_Login_EmployeeID.Size = new System.Drawing.Size(143, 27);
            this.lbl_Login_EmployeeID.TabIndex = 2;
            this.lbl_Login_EmployeeID.Text = "Employee ID : ";
            // 
            // txtBox_Login_User
            // 
            this.txtBox_Login_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.txtBox_Login_User.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBox_Login_User.ForeColor = System.Drawing.Color.White;
            this.txtBox_Login_User.Location = new System.Drawing.Point(147, 53);
            this.txtBox_Login_User.Margin = new System.Windows.Forms.Padding(1);
            this.txtBox_Login_User.Name = "txtBox_Login_User";
            this.txtBox_Login_User.PlaceholderText = "Enter your employee ID";
            this.txtBox_Login_User.Size = new System.Drawing.Size(263, 34);
            this.txtBox_Login_User.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Login.Location = new System.Drawing.Point(149, 161);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(133, 43);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // imgLogin_Logo
            // 
            this.imgLogin_Logo.BackgroundImage = global::ChapeauUI.Properties.Resources.Logo;
            this.imgLogin_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgLogin_Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.imgLogin_Logo.Location = new System.Drawing.Point(0, 0);
            this.imgLogin_Logo.Margin = new System.Windows.Forms.Padding(1);
            this.imgLogin_Logo.Name = "imgLogin_Logo";
            this.imgLogin_Logo.Size = new System.Drawing.Size(521, 183);
            this.imgLogin_Logo.TabIndex = 1;
            this.imgLogin_Logo.TabStop = false;
            // 
            // tab_Account
            // 
            this.tab_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tab_Account.Controls.Add(this.panel1);
            this.tab_Account.Location = new System.Drawing.Point(4, 24);
            this.tab_Account.Margin = new System.Windows.Forms.Padding(1);
            this.tab_Account.Name = "tab_Account";
            this.tab_Account.Padding = new System.Windows.Forms.Padding(1);
            this.tab_Account.Size = new System.Drawing.Size(521, 622);
            this.tab_Account.TabIndex = 10;
            this.tab_Account.Text = "Account";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 620);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.btn_Account_Logout);
            this.panel2.Controls.Add(this.lbl_Account_Role);
            this.panel2.Controls.Add(this.lbl_Account_Email);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(68, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 525);
            this.panel2.TabIndex = 0;
            // 
            // btn_Account_Logout
            // 
            this.btn_Account_Logout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Account_Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(122)))), ((int)(((byte)(161)))));
            this.btn_Account_Logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Account_Logout.FlatAppearance.BorderSize = 0;
            this.btn_Account_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Account_Logout.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Account_Logout.Location = new System.Drawing.Point(129, 409);
            this.btn_Account_Logout.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Account_Logout.Name = "btn_Account_Logout";
            this.btn_Account_Logout.Size = new System.Drawing.Size(133, 43);
            this.btn_Account_Logout.TabIndex = 5;
            this.btn_Account_Logout.Text = "Logout";
            this.btn_Account_Logout.UseVisualStyleBackColor = false;
            this.btn_Account_Logout.Click += new System.EventHandler(this.btn_Account_Logout_Click);
            // 
            // lbl_Account_Role
            // 
            this.lbl_Account_Role.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Account_Role.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Account_Role.ForeColor = System.Drawing.Color.Gray;
            this.lbl_Account_Role.Location = new System.Drawing.Point(3, 300);
            this.lbl_Account_Role.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Account_Role.Name = "lbl_Account_Role";
            this.lbl_Account_Role.Size = new System.Drawing.Size(383, 23);
            this.lbl_Account_Role.TabIndex = 4;
            this.lbl_Account_Role.Text = "fdsa";
            this.lbl_Account_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Account_Email
            // 
            this.lbl_Account_Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Account_Email.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Account_Email.Location = new System.Drawing.Point(3, 251);
            this.lbl_Account_Email.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Account_Email.Name = "lbl_Account_Email";
            this.lbl_Account_Email.Size = new System.Drawing.Size(383, 23);
            this.lbl_Account_Email.TabIndex = 3;
            this.lbl_Account_Email.Text = "fdsagdfs@fdsag";
            this.lbl_Account_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::ChapeauUI.Properties.Resources.User_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(115, 57);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 153);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // tab_Tables
            // 
            this.tab_Tables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tab_Tables.Controls.Add(this.pnl_TableOverview);
            this.tab_Tables.Controls.Add(this.splitter_TableOverview);
            this.tab_Tables.Controls.Add(this.pnl_TableInfo);
            this.tab_Tables.Location = new System.Drawing.Point(4, 24);
            this.tab_Tables.Margin = new System.Windows.Forms.Padding(1);
            this.tab_Tables.Name = "tab_Tables";
            this.tab_Tables.Size = new System.Drawing.Size(521, 622);
            this.tab_Tables.TabIndex = 2;
            this.tab_Tables.Text = "Tables";
            // 
            // pnl_TableOverview
            // 
            this.pnl_TableOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_TableOverview.IsSplitterFixed = true;
            this.pnl_TableOverview.Location = new System.Drawing.Point(0, 168);
            this.pnl_TableOverview.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_TableOverview.Name = "pnl_TableOverview";
            // 
            // pnl_TableOverview.Panel1
            // 
            this.pnl_TableOverview.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.pnl_TableOverview.Panel1.Controls.Add(this.flow_TableOverview);
            this.pnl_TableOverview.Panel1.Controls.Add(this.splitter1);
            this.pnl_TableOverview.Panel1.Controls.Add(this.flow_TableOverview_Title);
            this.pnl_TableOverview.Panel1MinSize = 0;
            // 
            // pnl_TableOverview.Panel2
            // 
            this.pnl_TableOverview.Panel2.Controls.Add(this.flow_Tables);
            this.pnl_TableOverview.Panel2MinSize = 200;
            this.pnl_TableOverview.Size = new System.Drawing.Size(521, 454);
            this.pnl_TableOverview.SplitterDistance = 234;
            this.pnl_TableOverview.SplitterWidth = 1;
            this.pnl_TableOverview.TabIndex = 0;
            // 
            // flow_TableOverview
            // 
            this.flow_TableOverview.AutoScroll = true;
            this.flow_TableOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_TableOverview.Location = new System.Drawing.Point(0, 44);
            this.flow_TableOverview.Margin = new System.Windows.Forms.Padding(0);
            this.flow_TableOverview.Name = "flow_TableOverview";
            this.flow_TableOverview.Size = new System.Drawing.Size(234, 410);
            this.flow_TableOverview.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(136)))), ((int)(((byte)(155)))));
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 43);
            this.splitter1.Margin = new System.Windows.Forms.Padding(1);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(234, 1);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // flow_TableOverview_Title
            // 
            this.flow_TableOverview_Title.AutoSize = true;
            this.flow_TableOverview_Title.Controls.Add(this.img_TableOverview_Title_Table);
            this.flow_TableOverview_Title.Controls.Add(this.lbl_TableOverview_Title);
            this.flow_TableOverview_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.flow_TableOverview_Title.Location = new System.Drawing.Point(0, 0);
            this.flow_TableOverview_Title.Margin = new System.Windows.Forms.Padding(1);
            this.flow_TableOverview_Title.Name = "flow_TableOverview_Title";
            this.flow_TableOverview_Title.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.flow_TableOverview_Title.Size = new System.Drawing.Size(234, 43);
            this.flow_TableOverview_Title.TabIndex = 0;
            // 
            // img_TableOverview_Title_Table
            // 
            this.img_TableOverview_Title_Table.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.img_TableOverview_Title_Table.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_Icon;
            this.img_TableOverview_Title_Table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.img_TableOverview_Title_Table.Location = new System.Drawing.Point(7, 3);
            this.img_TableOverview_Title_Table.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.img_TableOverview_Title_Table.Name = "img_TableOverview_Title_Table";
            this.img_TableOverview_Title_Table.Size = new System.Drawing.Size(37, 37);
            this.img_TableOverview_Title_Table.TabIndex = 0;
            this.img_TableOverview_Title_Table.TabStop = false;
            // 
            // lbl_TableOverview_Title
            // 
            this.lbl_TableOverview_Title.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_TableOverview_Title.Location = new System.Drawing.Point(45, 0);
            this.lbl_TableOverview_Title.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_TableOverview_Title.Name = "lbl_TableOverview_Title";
            this.lbl_TableOverview_Title.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_TableOverview_Title.Size = new System.Drawing.Size(176, 43);
            this.lbl_TableOverview_Title.TabIndex = 1;
            this.lbl_TableOverview_Title.Text = "Table #";
            this.lbl_TableOverview_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_TableOverview_Title.UseCompatibleTextRendering = true;
            // 
            // flow_Tables
            // 
            this.flow_Tables.AutoSize = true;
            this.flow_Tables.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flow_Tables.Controls.Add(this.btn_Table_1);
            this.flow_Tables.Controls.Add(this.btn_Table_2);
            this.flow_Tables.Controls.Add(this.btn_Table_3);
            this.flow_Tables.Controls.Add(this.btn_Table_4);
            this.flow_Tables.Controls.Add(this.btn_Table_5);
            this.flow_Tables.Controls.Add(this.btn_Table_6);
            this.flow_Tables.Controls.Add(this.btn_Table_7);
            this.flow_Tables.Controls.Add(this.btn_Table_8);
            this.flow_Tables.Controls.Add(this.btn_Table_9);
            this.flow_Tables.Controls.Add(this.btn_Table_10);
            this.flow_Tables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_Tables.Location = new System.Drawing.Point(0, 0);
            this.flow_Tables.Margin = new System.Windows.Forms.Padding(0);
            this.flow_Tables.MaximumSize = new System.Drawing.Size(280, 0);
            this.flow_Tables.Name = "flow_Tables";
            this.flow_Tables.Padding = new System.Windows.Forms.Padding(60, 13, 0, 0);
            this.flow_Tables.Size = new System.Drawing.Size(280, 454);
            this.flow_Tables.TabIndex = 0;
            // 
            // btn_Table_1
            // 
            this.btn_Table_1.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_White;
            this.btn_Table_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Table_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table_1.FlatAppearance.BorderSize = 0;
            this.btn_Table_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_1.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Table_1.Location = new System.Drawing.Point(61, 14);
            this.btn_Table_1.Margin = new System.Windows.Forms.Padding(1, 1, 40, 13);
            this.btn_Table_1.Name = "btn_Table_1";
            this.btn_Table_1.Size = new System.Drawing.Size(60, 60);
            this.btn_Table_1.TabIndex = 0;
            this.btn_Table_1.Text = "1";
            this.btn_Table_1.UseCompatibleTextRendering = true;
            this.btn_Table_1.UseVisualStyleBackColor = true;
            this.btn_Table_1.Click += new System.EventHandler(this.btn_Table_1_Click);
            // 
            // btn_Table_2
            // 
            this.btn_Table_2.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_White;
            this.btn_Table_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Table_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table_2.FlatAppearance.BorderSize = 0;
            this.btn_Table_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_2.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Table_2.Location = new System.Drawing.Point(162, 14);
            this.btn_Table_2.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Table_2.Name = "btn_Table_2";
            this.btn_Table_2.Size = new System.Drawing.Size(60, 60);
            this.btn_Table_2.TabIndex = 1;
            this.btn_Table_2.Text = "2";
            this.btn_Table_2.UseCompatibleTextRendering = true;
            this.btn_Table_2.UseVisualStyleBackColor = true;
            this.btn_Table_2.Click += new System.EventHandler(this.btn_Table_2_Click);
            // 
            // btn_Table_3
            // 
            this.btn_Table_3.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_White;
            this.btn_Table_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Table_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table_3.FlatAppearance.BorderSize = 0;
            this.btn_Table_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_3.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Table_3.Location = new System.Drawing.Point(61, 88);
            this.btn_Table_3.Margin = new System.Windows.Forms.Padding(1, 1, 40, 13);
            this.btn_Table_3.Name = "btn_Table_3";
            this.btn_Table_3.Size = new System.Drawing.Size(60, 60);
            this.btn_Table_3.TabIndex = 2;
            this.btn_Table_3.Text = "3";
            this.btn_Table_3.UseCompatibleTextRendering = true;
            this.btn_Table_3.UseVisualStyleBackColor = true;
            this.btn_Table_3.Click += new System.EventHandler(this.btn_Table_3_Click);
            // 
            // btn_Table_4
            // 
            this.btn_Table_4.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_White;
            this.btn_Table_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Table_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table_4.FlatAppearance.BorderSize = 0;
            this.btn_Table_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_4.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Table_4.Location = new System.Drawing.Point(162, 88);
            this.btn_Table_4.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Table_4.Name = "btn_Table_4";
            this.btn_Table_4.Size = new System.Drawing.Size(60, 60);
            this.btn_Table_4.TabIndex = 3;
            this.btn_Table_4.Text = "4";
            this.btn_Table_4.UseCompatibleTextRendering = true;
            this.btn_Table_4.UseVisualStyleBackColor = true;
            this.btn_Table_4.Click += new System.EventHandler(this.btn_Table_4_Click);
            // 
            // btn_Table_5
            // 
            this.btn_Table_5.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_White;
            this.btn_Table_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Table_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table_5.FlatAppearance.BorderSize = 0;
            this.btn_Table_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_5.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Table_5.Location = new System.Drawing.Point(61, 162);
            this.btn_Table_5.Margin = new System.Windows.Forms.Padding(1, 1, 40, 13);
            this.btn_Table_5.Name = "btn_Table_5";
            this.btn_Table_5.Size = new System.Drawing.Size(60, 60);
            this.btn_Table_5.TabIndex = 4;
            this.btn_Table_5.Text = "5";
            this.btn_Table_5.UseCompatibleTextRendering = true;
            this.btn_Table_5.UseVisualStyleBackColor = true;
            this.btn_Table_5.Click += new System.EventHandler(this.btn_Table_5_Click);
            // 
            // btn_Table_6
            // 
            this.btn_Table_6.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_White;
            this.btn_Table_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Table_6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table_6.FlatAppearance.BorderSize = 0;
            this.btn_Table_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_6.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Table_6.Location = new System.Drawing.Point(162, 162);
            this.btn_Table_6.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Table_6.Name = "btn_Table_6";
            this.btn_Table_6.Size = new System.Drawing.Size(60, 60);
            this.btn_Table_6.TabIndex = 5;
            this.btn_Table_6.Text = "6";
            this.btn_Table_6.UseCompatibleTextRendering = true;
            this.btn_Table_6.UseVisualStyleBackColor = true;
            this.btn_Table_6.Click += new System.EventHandler(this.btn_Table_6_Click);
            // 
            // btn_Table_7
            // 
            this.btn_Table_7.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_White;
            this.btn_Table_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Table_7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table_7.FlatAppearance.BorderSize = 0;
            this.btn_Table_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_7.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Table_7.Location = new System.Drawing.Point(61, 236);
            this.btn_Table_7.Margin = new System.Windows.Forms.Padding(1, 1, 40, 13);
            this.btn_Table_7.Name = "btn_Table_7";
            this.btn_Table_7.Size = new System.Drawing.Size(60, 60);
            this.btn_Table_7.TabIndex = 6;
            this.btn_Table_7.Text = "7";
            this.btn_Table_7.UseCompatibleTextRendering = true;
            this.btn_Table_7.UseVisualStyleBackColor = true;
            this.btn_Table_7.Click += new System.EventHandler(this.btn_Table_7_Click);
            // 
            // btn_Table_8
            // 
            this.btn_Table_8.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_White;
            this.btn_Table_8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Table_8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table_8.FlatAppearance.BorderSize = 0;
            this.btn_Table_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_8.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Table_8.Location = new System.Drawing.Point(162, 236);
            this.btn_Table_8.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Table_8.Name = "btn_Table_8";
            this.btn_Table_8.Size = new System.Drawing.Size(60, 60);
            this.btn_Table_8.TabIndex = 7;
            this.btn_Table_8.Text = "8";
            this.btn_Table_8.UseCompatibleTextRendering = true;
            this.btn_Table_8.UseVisualStyleBackColor = true;
            this.btn_Table_8.Click += new System.EventHandler(this.btn_Table_8_Click);
            // 
            // btn_Table_9
            // 
            this.btn_Table_9.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_White;
            this.btn_Table_9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Table_9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table_9.FlatAppearance.BorderSize = 0;
            this.btn_Table_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_9.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Table_9.Location = new System.Drawing.Point(61, 310);
            this.btn_Table_9.Margin = new System.Windows.Forms.Padding(1, 1, 40, 1);
            this.btn_Table_9.Name = "btn_Table_9";
            this.btn_Table_9.Size = new System.Drawing.Size(60, 60);
            this.btn_Table_9.TabIndex = 8;
            this.btn_Table_9.Text = "9";
            this.btn_Table_9.UseCompatibleTextRendering = true;
            this.btn_Table_9.UseVisualStyleBackColor = true;
            this.btn_Table_9.Click += new System.EventHandler(this.btn_Table_9_Click);
            // 
            // btn_Table_10
            // 
            this.btn_Table_10.BackgroundImage = global::ChapeauUI.Properties.Resources.Table_White;
            this.btn_Table_10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Table_10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Table_10.FlatAppearance.BorderSize = 0;
            this.btn_Table_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Table_10.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Table_10.Location = new System.Drawing.Point(162, 310);
            this.btn_Table_10.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Table_10.Name = "btn_Table_10";
            this.btn_Table_10.Size = new System.Drawing.Size(60, 60);
            this.btn_Table_10.TabIndex = 9;
            this.btn_Table_10.Text = "10";
            this.btn_Table_10.UseCompatibleTextRendering = true;
            this.btn_Table_10.UseVisualStyleBackColor = true;
            this.btn_Table_10.Click += new System.EventHandler(this.btn_Table_10_Click);
            // 
            // splitter_TableOverview
            // 
            this.splitter_TableOverview.BackColor = System.Drawing.Color.White;
            this.splitter_TableOverview.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter_TableOverview.Location = new System.Drawing.Point(0, 167);
            this.splitter_TableOverview.Margin = new System.Windows.Forms.Padding(0);
            this.splitter_TableOverview.Name = "splitter_TableOverview";
            this.splitter_TableOverview.Size = new System.Drawing.Size(521, 1);
            this.splitter_TableOverview.TabIndex = 0;
            this.splitter_TableOverview.TabStop = false;
            // 
            // pnl_TableInfo
            // 
            this.pnl_TableInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.pnl_TableInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TableInfo.IsSplitterFixed = true;
            this.pnl_TableInfo.Location = new System.Drawing.Point(0, 0);
            this.pnl_TableInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_TableInfo.Name = "pnl_TableInfo";
            // 
            // pnl_TableInfo.Panel1
            // 
            this.pnl_TableInfo.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.pnl_TableInfo.Panel1.Controls.Add(this.splitter_Table_Top);
            this.pnl_TableInfo.Panel1.Controls.Add(this.flow_ServeOrders);
            this.pnl_TableInfo.Panel1.Controls.Add(this.lbl_TableInfo_Panel1_Title);
            // 
            // pnl_TableInfo.Panel2
            // 
            this.pnl_TableInfo.Panel2.Controls.Add(this.flow_Reservations);
            this.pnl_TableInfo.Panel2.Controls.Add(this.lbl_TableInfo_Panel2_Title);
            this.pnl_TableInfo.Size = new System.Drawing.Size(521, 167);
            this.pnl_TableInfo.SplitterDistance = 257;
            this.pnl_TableInfo.SplitterWidth = 3;
            this.pnl_TableInfo.TabIndex = 1;
            // 
            // splitter_Table_Top
            // 
            this.splitter_Table_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            this.splitter_Table_Top.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter_Table_Top.Enabled = false;
            this.splitter_Table_Top.Location = new System.Drawing.Point(254, 25);
            this.splitter_Table_Top.Margin = new System.Windows.Forms.Padding(1);
            this.splitter_Table_Top.MaximumSize = new System.Drawing.Size(0, 127);
            this.splitter_Table_Top.Name = "splitter_Table_Top";
            this.splitter_Table_Top.Size = new System.Drawing.Size(3, 127);
            this.splitter_Table_Top.TabIndex = 0;
            this.splitter_Table_Top.TabStop = false;
            // 
            // flow_ServeOrders
            // 
            this.flow_ServeOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_ServeOrders.Location = new System.Drawing.Point(0, 25);
            this.flow_ServeOrders.Margin = new System.Windows.Forms.Padding(1);
            this.flow_ServeOrders.Name = "flow_ServeOrders";
            this.flow_ServeOrders.Size = new System.Drawing.Size(257, 142);
            this.flow_ServeOrders.TabIndex = 0;
            // 
            // lbl_TableInfo_Panel1_Title
            // 
            this.lbl_TableInfo_Panel1_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TableInfo_Panel1_Title.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TableInfo_Panel1_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_TableInfo_Panel1_Title.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_TableInfo_Panel1_Title.Name = "lbl_TableInfo_Panel1_Title";
            this.lbl_TableInfo_Panel1_Title.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_TableInfo_Panel1_Title.Size = new System.Drawing.Size(257, 25);
            this.lbl_TableInfo_Panel1_Title.TabIndex = 0;
            this.lbl_TableInfo_Panel1_Title.Text = "Reservations";
            this.lbl_TableInfo_Panel1_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flow_Reservations
            // 
            this.flow_Reservations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_Reservations.Location = new System.Drawing.Point(0, 25);
            this.flow_Reservations.Margin = new System.Windows.Forms.Padding(1);
            this.flow_Reservations.Name = "flow_Reservations";
            this.flow_Reservations.Size = new System.Drawing.Size(261, 142);
            this.flow_Reservations.TabIndex = 0;
            // 
            // lbl_TableInfo_Panel2_Title
            // 
            this.lbl_TableInfo_Panel2_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_TableInfo_Panel2_Title.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_TableInfo_Panel2_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_TableInfo_Panel2_Title.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_TableInfo_Panel2_Title.Name = "lbl_TableInfo_Panel2_Title";
            this.lbl_TableInfo_Panel2_Title.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lbl_TableInfo_Panel2_Title.Size = new System.Drawing.Size(261, 25);
            this.lbl_TableInfo_Panel2_Title.TabIndex = 1;
            this.lbl_TableInfo_Panel2_Title.Text = "Orders";
            this.lbl_TableInfo_Panel2_Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_Order
            // 
            this.tab_Order.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tab_Order.Controls.Add(this.pnl_Order_Menu);
            this.tab_Order.Controls.Add(this.pnl_Order_Orders);
            this.tab_Order.Controls.Add(this.pnl_Order_Categories);
            this.tab_Order.Location = new System.Drawing.Point(4, 24);
            this.tab_Order.Margin = new System.Windows.Forms.Padding(1);
            this.tab_Order.Name = "tab_Order";
            this.tab_Order.Size = new System.Drawing.Size(521, 622);
            this.tab_Order.TabIndex = 3;
            this.tab_Order.Text = "Order";
            // 
            // pnl_Order_Menu
            // 
            this.pnl_Order_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.pnl_Order_Menu.Controls.Add(this.flow_Order_Menu);
            this.pnl_Order_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Order_Menu.Location = new System.Drawing.Point(0, 40);
            this.pnl_Order_Menu.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Order_Menu.Name = "pnl_Order_Menu";
            this.pnl_Order_Menu.Size = new System.Drawing.Size(267, 582);
            this.pnl_Order_Menu.TabIndex = 0;
            // 
            // flow_Order_Menu
            // 
            this.flow_Order_Menu.AutoScroll = true;
            this.flow_Order_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.flow_Order_Menu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_Order_Menu.Location = new System.Drawing.Point(0, 0);
            this.flow_Order_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.flow_Order_Menu.Name = "flow_Order_Menu";
            this.flow_Order_Menu.Size = new System.Drawing.Size(267, 582);
            this.flow_Order_Menu.TabIndex = 0;
            this.flow_Order_Menu.WrapContents = false;
            // 
            // pnl_Order_Orders
            // 
            this.pnl_Order_Orders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.pnl_Order_Orders.Controls.Add(this.flow_Order_Items);
            this.pnl_Order_Orders.Controls.Add(this.splitter_Orders_Price);
            this.pnl_Order_Orders.Controls.Add(this.lbl_Order_TotalPrice);
            this.pnl_Order_Orders.Controls.Add(this.btn_Order_Confirm);
            this.pnl_Order_Orders.Controls.Add(this.splitter_Checkout);
            this.pnl_Order_Orders.Controls.Add(this.btn_Order_Checkout);
            this.pnl_Order_Orders.Controls.Add(this.splitter_OrderMenu);
            this.pnl_Order_Orders.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Order_Orders.Location = new System.Drawing.Point(268, 40);
            this.pnl_Order_Orders.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Order_Orders.Name = "pnl_Order_Orders";
            this.pnl_Order_Orders.Size = new System.Drawing.Size(253, 582);
            this.pnl_Order_Orders.TabIndex = 0;
            // 
            // flow_Order_Items
            // 
            this.flow_Order_Items.AutoScroll = true;
            this.flow_Order_Items.Dock = System.Windows.Forms.DockStyle.Left;
            this.flow_Order_Items.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flow_Order_Items.Location = new System.Drawing.Point(1, 0);
            this.flow_Order_Items.Margin = new System.Windows.Forms.Padding(0);
            this.flow_Order_Items.Name = "flow_Order_Items";
            this.flow_Order_Items.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flow_Order_Items.Size = new System.Drawing.Size(253, 466);
            this.flow_Order_Items.TabIndex = 0;
            this.flow_Order_Items.WrapContents = false;
            // 
            // splitter_Orders_Price
            // 
            this.splitter_Orders_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(119)))));
            this.splitter_Orders_Price.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter_Orders_Price.Enabled = false;
            this.splitter_Orders_Price.Location = new System.Drawing.Point(1, 466);
            this.splitter_Orders_Price.Margin = new System.Windows.Forms.Padding(0);
            this.splitter_Orders_Price.Name = "splitter_Orders_Price";
            this.splitter_Orders_Price.Size = new System.Drawing.Size(252, 1);
            this.splitter_Orders_Price.TabIndex = 0;
            this.splitter_Orders_Price.TabStop = false;
            // 
            // lbl_Order_TotalPrice
            // 
            this.lbl_Order_TotalPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_Order_TotalPrice.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Order_TotalPrice.Location = new System.Drawing.Point(1, 467);
            this.lbl_Order_TotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Order_TotalPrice.Name = "lbl_Order_TotalPrice";
            this.lbl_Order_TotalPrice.Size = new System.Drawing.Size(252, 33);
            this.lbl_Order_TotalPrice.TabIndex = 0;
            this.lbl_Order_TotalPrice.Text = "Total : € 0,00";
            this.lbl_Order_TotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Order_Confirm
            // 
            this.btn_Order_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btn_Order_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order_Confirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Order_Confirm.Enabled = false;
            this.btn_Order_Confirm.FlatAppearance.BorderSize = 0;
            this.btn_Order_Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order_Confirm.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Order_Confirm.ForeColor = System.Drawing.Color.White;
            this.btn_Order_Confirm.Location = new System.Drawing.Point(1, 500);
            this.btn_Order_Confirm.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Order_Confirm.Name = "btn_Order_Confirm";
            this.btn_Order_Confirm.Size = new System.Drawing.Size(252, 40);
            this.btn_Order_Confirm.TabIndex = 0;
            this.btn_Order_Confirm.Text = "Confirm order";
            this.btn_Order_Confirm.UseVisualStyleBackColor = false;
            this.btn_Order_Confirm.EnabledChanged += new System.EventHandler(this.btn_Order_Confirm_Enable_Changed);
            this.btn_Order_Confirm.Click += new System.EventHandler(this.btn_Order_Confirm_Click);
            // 
            // splitter_Checkout
            // 
            this.splitter_Checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.splitter_Checkout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter_Checkout.Enabled = false;
            this.splitter_Checkout.Location = new System.Drawing.Point(1, 540);
            this.splitter_Checkout.Margin = new System.Windows.Forms.Padding(2);
            this.splitter_Checkout.Name = "splitter_Checkout";
            this.splitter_Checkout.Size = new System.Drawing.Size(252, 2);
            this.splitter_Checkout.TabIndex = 2;
            this.splitter_Checkout.TabStop = false;
            // 
            // btn_Order_Checkout
            // 
            this.btn_Order_Checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Order_Checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order_Checkout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Order_Checkout.FlatAppearance.BorderSize = 0;
            this.btn_Order_Checkout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order_Checkout.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Order_Checkout.ForeColor = System.Drawing.Color.White;
            this.btn_Order_Checkout.Location = new System.Drawing.Point(1, 542);
            this.btn_Order_Checkout.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Order_Checkout.Name = "btn_Order_Checkout";
            this.btn_Order_Checkout.Size = new System.Drawing.Size(252, 40);
            this.btn_Order_Checkout.TabIndex = 1;
            this.btn_Order_Checkout.Text = "Checkout ";
            this.btn_Order_Checkout.UseVisualStyleBackColor = false;
            this.btn_Order_Checkout.Visible = false;
            this.btn_Order_Checkout.Click += new System.EventHandler(this.btn_Order_Checkout_Click);
            // 
            // splitter_OrderMenu
            // 
            this.splitter_OrderMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            this.splitter_OrderMenu.Enabled = false;
            this.splitter_OrderMenu.Location = new System.Drawing.Point(0, 0);
            this.splitter_OrderMenu.Margin = new System.Windows.Forms.Padding(2);
            this.splitter_OrderMenu.Name = "splitter_OrderMenu";
            this.splitter_OrderMenu.Size = new System.Drawing.Size(1, 582);
            this.splitter_OrderMenu.TabIndex = 0;
            this.splitter_OrderMenu.TabStop = false;
            this.splitter_OrderMenu.Visible = false;
            // 
            // pnl_Order_Categories
            // 
            this.pnl_Order_Categories.Controls.Add(this.flowLayoutPanel1);
            this.pnl_Order_Categories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Order_Categories.Location = new System.Drawing.Point(0, 0);
            this.pnl_Order_Categories.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_Order_Categories.Name = "pnl_Order_Categories";
            this.pnl_Order_Categories.Size = new System.Drawing.Size(521, 40);
            this.pnl_Order_Categories.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.btn_Order_LunchMenu);
            this.flowLayoutPanel1.Controls.Add(this.btn_Order_DinnerMenu);
            this.flowLayoutPanel1.Controls.Add(this.btn_Order_DrinksMenu);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(40, 3, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(517, 39);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btn_Order_LunchMenu
            // 
            this.btn_Order_LunchMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.btn_Order_LunchMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order_LunchMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order_LunchMenu.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Order_LunchMenu.Location = new System.Drawing.Point(40, 3);
            this.btn_Order_LunchMenu.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_Order_LunchMenu.Name = "btn_Order_LunchMenu";
            this.btn_Order_LunchMenu.Size = new System.Drawing.Size(133, 33);
            this.btn_Order_LunchMenu.TabIndex = 0;
            this.btn_Order_LunchMenu.Text = "Lunch";
            this.btn_Order_LunchMenu.UseCompatibleTextRendering = true;
            this.btn_Order_LunchMenu.UseVisualStyleBackColor = false;
            this.btn_Order_LunchMenu.Click += new System.EventHandler(this.btn_Order_LunchMenu_Click);
            // 
            // btn_Order_DinnerMenu
            // 
            this.btn_Order_DinnerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.btn_Order_DinnerMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order_DinnerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order_DinnerMenu.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Order_DinnerMenu.Location = new System.Drawing.Point(193, 3);
            this.btn_Order_DinnerMenu.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btn_Order_DinnerMenu.Name = "btn_Order_DinnerMenu";
            this.btn_Order_DinnerMenu.Size = new System.Drawing.Size(133, 33);
            this.btn_Order_DinnerMenu.TabIndex = 1;
            this.btn_Order_DinnerMenu.Text = "Dinner";
            this.btn_Order_DinnerMenu.UseCompatibleTextRendering = true;
            this.btn_Order_DinnerMenu.UseVisualStyleBackColor = false;
            this.btn_Order_DinnerMenu.Click += new System.EventHandler(this.btn_Order_DinnerMenu_Click);
            // 
            // btn_Order_DrinksMenu
            // 
            this.btn_Order_DrinksMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.btn_Order_DrinksMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Order_DrinksMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Order_DrinksMenu.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Order_DrinksMenu.Location = new System.Drawing.Point(346, 3);
            this.btn_Order_DrinksMenu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Order_DrinksMenu.Name = "btn_Order_DrinksMenu";
            this.btn_Order_DrinksMenu.Size = new System.Drawing.Size(133, 33);
            this.btn_Order_DrinksMenu.TabIndex = 2;
            this.btn_Order_DrinksMenu.Text = "Drinks";
            this.btn_Order_DrinksMenu.UseCompatibleTextRendering = true;
            this.btn_Order_DrinksMenu.UseVisualStyleBackColor = false;
            this.btn_Order_DrinksMenu.Click += new System.EventHandler(this.btn_Order_DrinksMenu_Click);
            // 
            // tab_Bill
            // 
            this.tab_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tab_Bill.Controls.Add(this.pnl_Bill);
            this.tab_Bill.Location = new System.Drawing.Point(4, 24);
            this.tab_Bill.Margin = new System.Windows.Forms.Padding(1);
            this.tab_Bill.Name = "tab_Bill";
            this.tab_Bill.Size = new System.Drawing.Size(521, 622);
            this.tab_Bill.TabIndex = 4;
            this.tab_Bill.Text = "Bill";
            // 
            // pnl_Bill
            // 
            this.pnl_Bill.Controls.Add(this.Bill_lbl_RemainingPrice);
            this.pnl_Bill.Controls.Add(this.Bill_lbl_StillToPayTitle);
            this.pnl_Bill.Controls.Add(this.Bill_lbl_TotalAmount);
            this.pnl_Bill.Controls.Add(this.Bill_lbl_TotalTitle);
            this.pnl_Bill.Controls.Add(this.Bill_lv_VAT);
            this.pnl_Bill.Controls.Add(this.Bill_btn_Pay);
            this.pnl_Bill.Controls.Add(this.Bill_lbl_Bill);
            this.pnl_Bill.Controls.Add(this.Bill_grpbox_PaymentMethod);
            this.pnl_Bill.Controls.Add(this.Bill_lv_Bill);
            this.pnl_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Bill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnl_Bill.Location = new System.Drawing.Point(0, 0);
            this.pnl_Bill.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Bill.Name = "pnl_Bill";
            this.pnl_Bill.Padding = new System.Windows.Forms.Padding(73, 0, 73, 0);
            this.pnl_Bill.Size = new System.Drawing.Size(521, 622);
            this.pnl_Bill.TabIndex = 1;
            // 
            // Bill_lbl_RemainingPrice
            // 
            this.Bill_lbl_RemainingPrice.Location = new System.Drawing.Point(391, 388);
            this.Bill_lbl_RemainingPrice.Name = "Bill_lbl_RemainingPrice";
            this.Bill_lbl_RemainingPrice.Size = new System.Drawing.Size(89, 21);
            this.Bill_lbl_RemainingPrice.TabIndex = 18;
            this.Bill_lbl_RemainingPrice.Text = "RemainingPrice";
            // 
            // Bill_lbl_StillToPayTitle
            // 
            this.Bill_lbl_StillToPayTitle.AutoSize = true;
            this.Bill_lbl_StillToPayTitle.Location = new System.Drawing.Point(299, 388);
            this.Bill_lbl_StillToPayTitle.Name = "Bill_lbl_StillToPayTitle";
            this.Bill_lbl_StillToPayTitle.Size = new System.Drawing.Size(82, 19);
            this.Bill_lbl_StillToPayTitle.TabIndex = 17;
            this.Bill_lbl_StillToPayTitle.Text = "Left to Pay:";
            // 
            // Bill_lbl_TotalAmount
            // 
            this.Bill_lbl_TotalAmount.Location = new System.Drawing.Point(391, 369);
            this.Bill_lbl_TotalAmount.Name = "Bill_lbl_TotalAmount";
            this.Bill_lbl_TotalAmount.Size = new System.Drawing.Size(89, 21);
            this.Bill_lbl_TotalAmount.TabIndex = 16;
            this.Bill_lbl_TotalAmount.Text = "TotalAmount";
            // 
            // Bill_lbl_TotalTitle
            // 
            this.Bill_lbl_TotalTitle.AutoSize = true;
            this.Bill_lbl_TotalTitle.Location = new System.Drawing.Point(335, 369);
            this.Bill_lbl_TotalTitle.Name = "Bill_lbl_TotalTitle";
            this.Bill_lbl_TotalTitle.Size = new System.Drawing.Size(45, 19);
            this.Bill_lbl_TotalTitle.TabIndex = 15;
            this.Bill_lbl_TotalTitle.Text = "Total:";
            // 
            // Bill_lv_VAT
            // 
            this.Bill_lv_VAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.Bill_lv_VAT.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.VAT_ColVAT,
            this.VAT_ColBasePrice,
            this.VAT_ColVATAmount,
            this.VAT_ColTotalSum});
            this.Bill_lv_VAT.ForeColor = System.Drawing.Color.White;
            this.Bill_lv_VAT.HideSelection = false;
            this.Bill_lv_VAT.Location = new System.Drawing.Point(48, 410);
            this.Bill_lv_VAT.Name = "Bill_lv_VAT";
            this.Bill_lv_VAT.Size = new System.Drawing.Size(332, 74);
            this.Bill_lv_VAT.TabIndex = 12;
            this.Bill_lv_VAT.UseCompatibleStateImageBehavior = false;
            this.Bill_lv_VAT.View = System.Windows.Forms.View.Details;
            // 
            // VAT_ColVAT
            // 
            this.VAT_ColVAT.Text = "VAT";
            this.VAT_ColVAT.Width = 50;
            // 
            // VAT_ColBasePrice
            // 
            this.VAT_ColBasePrice.Text = "Base Price";
            this.VAT_ColBasePrice.Width = 80;
            // 
            // VAT_ColVATAmount
            // 
            this.VAT_ColVATAmount.Text = "VAT Amount";
            this.VAT_ColVATAmount.Width = 90;
            // 
            // VAT_ColTotalSum
            // 
            this.VAT_ColTotalSum.Text = "Total";
            this.VAT_ColTotalSum.Width = 90;
            // 
            // Bill_btn_Pay
            // 
            this.Bill_btn_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bill_btn_Pay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bill_btn_Pay.Location = new System.Drawing.Point(363, 529);
            this.Bill_btn_Pay.Name = "Bill_btn_Pay";
            this.Bill_btn_Pay.Size = new System.Drawing.Size(127, 50);
            this.Bill_btn_Pay.TabIndex = 11;
            this.Bill_btn_Pay.Text = "Next Screen";
            this.Bill_btn_Pay.UseVisualStyleBackColor = false;
            this.Bill_btn_Pay.Click += new System.EventHandler(this.Bill_btn_Pay_Click);
            // 
            // Bill_lbl_Bill
            // 
            this.Bill_lbl_Bill.AutoSize = true;
            this.Bill_lbl_Bill.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bill_lbl_Bill.Location = new System.Drawing.Point(245, 10);
            this.Bill_lbl_Bill.Name = "Bill_lbl_Bill";
            this.Bill_lbl_Bill.Size = new System.Drawing.Size(32, 22);
            this.Bill_lbl_Bill.TabIndex = 9;
            this.Bill_lbl_Bill.Text = "Bill";
            // 
            // Bill_grpbox_PaymentMethod
            // 
            this.Bill_grpbox_PaymentMethod.Controls.Add(this.Bill_radbtn_Credit);
            this.Bill_grpbox_PaymentMethod.Controls.Add(this.Bill_radbtn_Cash);
            this.Bill_grpbox_PaymentMethod.Controls.Add(this.Bill_radbtn_Debit);
            this.Bill_grpbox_PaymentMethod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bill_grpbox_PaymentMethod.ForeColor = System.Drawing.Color.White;
            this.Bill_grpbox_PaymentMethod.Location = new System.Drawing.Point(48, 490);
            this.Bill_grpbox_PaymentMethod.Name = "Bill_grpbox_PaymentMethod";
            this.Bill_grpbox_PaymentMethod.Size = new System.Drawing.Size(208, 124);
            this.Bill_grpbox_PaymentMethod.TabIndex = 7;
            this.Bill_grpbox_PaymentMethod.TabStop = false;
            this.Bill_grpbox_PaymentMethod.Text = "Payment Method";
            // 
            // Bill_radbtn_Credit
            // 
            this.Bill_radbtn_Credit.AutoSize = true;
            this.Bill_radbtn_Credit.Location = new System.Drawing.Point(18, 80);
            this.Bill_radbtn_Credit.Name = "Bill_radbtn_Credit";
            this.Bill_radbtn_Credit.Size = new System.Drawing.Size(183, 23);
            this.Bill_radbtn_Credit.TabIndex = 9;
            this.Bill_radbtn_Credit.TabStop = true;
            this.Bill_radbtn_Credit.Text = "Credit Card (Visa/Amex)";
            this.Bill_radbtn_Credit.UseVisualStyleBackColor = true;
            this.Bill_radbtn_Credit.CheckedChanged += new System.EventHandler(this.Bill_radbtn_Credit_Checked);
            // 
            // Bill_radbtn_Cash
            // 
            this.Bill_radbtn_Cash.AutoSize = true;
            this.Bill_radbtn_Cash.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bill_radbtn_Cash.Location = new System.Drawing.Point(18, 26);
            this.Bill_radbtn_Cash.Name = "Bill_radbtn_Cash";
            this.Bill_radbtn_Cash.Size = new System.Drawing.Size(59, 23);
            this.Bill_radbtn_Cash.TabIndex = 8;
            this.Bill_radbtn_Cash.TabStop = true;
            this.Bill_radbtn_Cash.Text = "Cash";
            this.Bill_radbtn_Cash.UseVisualStyleBackColor = true;
            this.Bill_radbtn_Cash.CheckedChanged += new System.EventHandler(this.Bill_radbtn_Cash_Checked);
            // 
            // Bill_radbtn_Debit
            // 
            this.Bill_radbtn_Debit.AutoSize = true;
            this.Bill_radbtn_Debit.Location = new System.Drawing.Point(18, 53);
            this.Bill_radbtn_Debit.Name = "Bill_radbtn_Debit";
            this.Bill_radbtn_Debit.Size = new System.Drawing.Size(96, 23);
            this.Bill_radbtn_Debit.TabIndex = 9;
            this.Bill_radbtn_Debit.TabStop = true;
            this.Bill_radbtn_Debit.Text = "Debit Card";
            this.Bill_radbtn_Debit.UseVisualStyleBackColor = true;
            this.Bill_radbtn_Debit.CheckedChanged += new System.EventHandler(this.Bill_radbtn_Debit_Checked);
            // 
            // Bill_lv_Bill
            // 
            this.Bill_lv_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.Bill_lv_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bill_ColQuantity,
            this.Bill_ColName,
            this.Bill_ColVAT,
            this.Bill_ColPrice,
            this.Bill_ColPriceTotal});
            this.Bill_lv_Bill.ForeColor = System.Drawing.Color.White;
            this.Bill_lv_Bill.HideSelection = false;
            this.Bill_lv_Bill.Location = new System.Drawing.Point(48, 35);
            this.Bill_lv_Bill.Name = "Bill_lv_Bill";
            this.Bill_lv_Bill.Size = new System.Drawing.Size(442, 331);
            this.Bill_lv_Bill.TabIndex = 1;
            this.Bill_lv_Bill.UseCompatibleStateImageBehavior = false;
            this.Bill_lv_Bill.View = System.Windows.Forms.View.Details;
            // 
            // Bill_ColQuantity
            // 
            this.Bill_ColQuantity.Text = "Quantity";
            this.Bill_ColQuantity.Width = 70;
            // 
            // Bill_ColName
            // 
            this.Bill_ColName.Text = "Name";
            this.Bill_ColName.Width = 140;
            // 
            // Bill_ColVAT
            // 
            this.Bill_ColVAT.Text = "VAT";
            this.Bill_ColVAT.Width = 50;
            // 
            // Bill_ColPrice
            // 
            this.Bill_ColPrice.Text = "Price";
            this.Bill_ColPrice.Width = 70;
            // 
            // Bill_ColPriceTotal
            // 
            this.Bill_ColPriceTotal.Text = "Price Total";
            this.Bill_ColPriceTotal.Width = 90;
            // 
            // tab_CashPayment
            // 
            this.tab_CashPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tab_CashPayment.Controls.Add(this.pnl_Cash);
            this.tab_CashPayment.Location = new System.Drawing.Point(4, 24);
            this.tab_CashPayment.Margin = new System.Windows.Forms.Padding(1);
            this.tab_CashPayment.Name = "tab_CashPayment";
            this.tab_CashPayment.Size = new System.Drawing.Size(521, 622);
            this.tab_CashPayment.TabIndex = 7;
            this.tab_CashPayment.Text = "Payment";
            // 
            // pnl_Cash
            // 
            this.pnl_Cash.Controls.Add(this.Payment_Btn_Pay);
            this.pnl_Cash.Controls.Add(this.Payment_lbl_AmountGivenOrTip);
            this.pnl_Cash.Controls.Add(this.Payment_lbl_BillTotal);
            this.pnl_Cash.Controls.Add(this.Payment_lbl_ChangeOrTotalToPay);
            this.pnl_Cash.Controls.Add(this.Payment_lbl_BillTotalTitle);
            this.pnl_Cash.Controls.Add(this.Payment_btn_Cancel);
            this.pnl_Cash.Controls.Add(this.Payment_lbl_Method);
            this.pnl_Cash.Controls.Add(this.Payment_num_ChangeOrTotal);
            this.pnl_Cash.Controls.Add(this.Payment_num_AmountGivenOrTip);
            this.pnl_Cash.Controls.Add(this.Payment_lbl_MethodTitle);
            this.pnl_Cash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Cash.Location = new System.Drawing.Point(0, 0);
            this.pnl_Cash.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_Cash.Name = "pnl_Cash";
            this.pnl_Cash.Size = new System.Drawing.Size(521, 622);
            this.pnl_Cash.TabIndex = 0;
            // 
            // Payment_Btn_Pay
            // 
            this.Payment_Btn_Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Payment_Btn_Pay.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_Btn_Pay.Location = new System.Drawing.Point(193, 508);
            this.Payment_Btn_Pay.Name = "Payment_Btn_Pay";
            this.Payment_Btn_Pay.Size = new System.Drawing.Size(126, 40);
            this.Payment_Btn_Pay.TabIndex = 9;
            this.Payment_Btn_Pay.Text = "button1";
            this.Payment_Btn_Pay.UseVisualStyleBackColor = false;
            this.Payment_Btn_Pay.Click += new System.EventHandler(this.Payment_Btn_Pay_Click);
            // 
            // Payment_lbl_AmountGivenOrTip
            // 
            this.Payment_lbl_AmountGivenOrTip.AutoSize = true;
            this.Payment_lbl_AmountGivenOrTip.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_lbl_AmountGivenOrTip.Location = new System.Drawing.Point(193, 253);
            this.Payment_lbl_AmountGivenOrTip.Name = "Payment_lbl_AmountGivenOrTip";
            this.Payment_lbl_AmountGivenOrTip.Size = new System.Drawing.Size(146, 23);
            this.Payment_lbl_AmountGivenOrTip.TabIndex = 8;
            this.Payment_lbl_AmountGivenOrTip.Text = "AmountGiven/Tip";
            // 
            // Payment_lbl_BillTotal
            // 
            this.Payment_lbl_BillTotal.AutoSize = true;
            this.Payment_lbl_BillTotal.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_lbl_BillTotal.Location = new System.Drawing.Point(301, 195);
            this.Payment_lbl_BillTotal.Name = "Payment_lbl_BillTotal";
            this.Payment_lbl_BillTotal.Size = new System.Drawing.Size(59, 23);
            this.Payment_lbl_BillTotal.TabIndex = 7;
            this.Payment_lbl_BillTotal.Text = "€ 0.00";
            // 
            // Payment_lbl_ChangeOrTotalToPay
            // 
            this.Payment_lbl_ChangeOrTotalToPay.AutoSize = true;
            this.Payment_lbl_ChangeOrTotalToPay.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_lbl_ChangeOrTotalToPay.Location = new System.Drawing.Point(193, 329);
            this.Payment_lbl_ChangeOrTotalToPay.Name = "Payment_lbl_ChangeOrTotalToPay";
            this.Payment_lbl_ChangeOrTotalToPay.Size = new System.Drawing.Size(155, 23);
            this.Payment_lbl_ChangeOrTotalToPay.TabIndex = 6;
            this.Payment_lbl_ChangeOrTotalToPay.Text = "Change/TotalToPay";
            // 
            // Payment_lbl_BillTotalTitle
            // 
            this.Payment_lbl_BillTotalTitle.AutoSize = true;
            this.Payment_lbl_BillTotalTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_lbl_BillTotalTitle.Location = new System.Drawing.Point(166, 195);
            this.Payment_lbl_BillTotalTitle.Name = "Payment_lbl_BillTotalTitle";
            this.Payment_lbl_BillTotalTitle.Size = new System.Drawing.Size(129, 23);
            this.Payment_lbl_BillTotalTitle.TabIndex = 5;
            this.Payment_lbl_BillTotalTitle.Text = "Amount to Pay:";
            // 
            // Payment_btn_Cancel
            // 
            this.Payment_btn_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.Payment_btn_Cancel.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_btn_Cancel.Location = new System.Drawing.Point(154, 105);
            this.Payment_btn_Cancel.Name = "Payment_btn_Cancel";
            this.Payment_btn_Cancel.Size = new System.Drawing.Size(75, 29);
            this.Payment_btn_Cancel.TabIndex = 4;
            this.Payment_btn_Cancel.Text = "Back";
            this.Payment_btn_Cancel.UseVisualStyleBackColor = false;
            this.Payment_btn_Cancel.Click += new System.EventHandler(this.Payment_btn_Cancel_Click);
            // 
            // Payment_lbl_Method
            // 
            this.Payment_lbl_Method.AutoSize = true;
            this.Payment_lbl_Method.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_lbl_Method.Location = new System.Drawing.Point(301, 70);
            this.Payment_lbl_Method.Name = "Payment_lbl_Method";
            this.Payment_lbl_Method.Size = new System.Drawing.Size(130, 23);
            this.Payment_lbl_Method.TabIndex = 3;
            this.Payment_lbl_Method.Text = "CurrentMethod";
            // 
            // Payment_num_ChangeOrTotal
            // 
            this.Payment_num_ChangeOrTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.Payment_num_ChangeOrTotal.DecimalPlaces = 2;
            this.Payment_num_ChangeOrTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_num_ChangeOrTotal.ForeColor = System.Drawing.Color.White;
            this.Payment_num_ChangeOrTotal.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Payment_num_ChangeOrTotal.Location = new System.Drawing.Point(193, 355);
            this.Payment_num_ChangeOrTotal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Payment_num_ChangeOrTotal.Name = "Payment_num_ChangeOrTotal";
            this.Payment_num_ChangeOrTotal.Size = new System.Drawing.Size(120, 27);
            this.Payment_num_ChangeOrTotal.TabIndex = 2;
            this.Payment_num_ChangeOrTotal.ValueChanged += new System.EventHandler(this.Payment_Num_2_ValueChanged);
            // 
            // Payment_num_AmountGivenOrTip
            // 
            this.Payment_num_AmountGivenOrTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(78)))));
            this.Payment_num_AmountGivenOrTip.DecimalPlaces = 2;
            this.Payment_num_AmountGivenOrTip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_num_AmountGivenOrTip.ForeColor = System.Drawing.Color.White;
            this.Payment_num_AmountGivenOrTip.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.Payment_num_AmountGivenOrTip.Location = new System.Drawing.Point(193, 279);
            this.Payment_num_AmountGivenOrTip.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Payment_num_AmountGivenOrTip.Name = "Payment_num_AmountGivenOrTip";
            this.Payment_num_AmountGivenOrTip.Size = new System.Drawing.Size(120, 27);
            this.Payment_num_AmountGivenOrTip.TabIndex = 1;
            this.Payment_num_AmountGivenOrTip.ValueChanged += new System.EventHandler(this.Payment_num_1_ValueChanged);
            // 
            // Payment_lbl_MethodTitle
            // 
            this.Payment_lbl_MethodTitle.AutoSize = true;
            this.Payment_lbl_MethodTitle.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Payment_lbl_MethodTitle.Location = new System.Drawing.Point(154, 70);
            this.Payment_lbl_MethodTitle.Name = "Payment_lbl_MethodTitle";
            this.Payment_lbl_MethodTitle.Size = new System.Drawing.Size(148, 23);
            this.Payment_lbl_MethodTitle.TabIndex = 0;
            this.Payment_lbl_MethodTitle.Text = "Payment Method:";
            // 
            // tab_ProcessPayment
            // 
            this.tab_ProcessPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tab_ProcessPayment.Controls.Add(this.pnl_ProcessPayment);
            this.tab_ProcessPayment.Location = new System.Drawing.Point(4, 24);
            this.tab_ProcessPayment.Margin = new System.Windows.Forms.Padding(1);
            this.tab_ProcessPayment.Name = "tab_ProcessPayment";
            this.tab_ProcessPayment.Size = new System.Drawing.Size(521, 622);
            this.tab_ProcessPayment.TabIndex = 6;
            this.tab_ProcessPayment.Text = "Process Payment";
            // 
            // pnl_ProcessPayment
            // 
            this.pnl_ProcessPayment.Controls.Add(this.PaymentProcess_lbl_FunFact);
            this.pnl_ProcessPayment.Controls.Add(this.PaymentProcess_lbl_FunFactTitle);
            this.pnl_ProcessPayment.Controls.Add(this.ProcessPayment_ProcessingIcon);
            this.pnl_ProcessPayment.Controls.Add(this.lbl_ProcessPayment_Status);
            this.pnl_ProcessPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ProcessPayment.Location = new System.Drawing.Point(0, 0);
            this.pnl_ProcessPayment.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_ProcessPayment.Name = "pnl_ProcessPayment";
            this.pnl_ProcessPayment.Padding = new System.Windows.Forms.Padding(73, 0, 73, 0);
            this.pnl_ProcessPayment.Size = new System.Drawing.Size(521, 622);
            this.pnl_ProcessPayment.TabIndex = 3;
            // 
            // PaymentProcess_lbl_FunFactTitle
            // 
            this.PaymentProcess_lbl_FunFactTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaymentProcess_lbl_FunFactTitle.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaymentProcess_lbl_FunFactTitle.Location = new System.Drawing.Point(74, 437);
            this.PaymentProcess_lbl_FunFactTitle.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PaymentProcess_lbl_FunFactTitle.Name = "PaymentProcess_lbl_FunFactTitle";
            this.PaymentProcess_lbl_FunFactTitle.Size = new System.Drawing.Size(88, 49);
            this.PaymentProcess_lbl_FunFactTitle.TabIndex = 3;
            this.PaymentProcess_lbl_FunFactTitle.Text = "Fun fact:";
            this.PaymentProcess_lbl_FunFactTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessPayment_ProcessingIcon
            // 
            this.ProcessPayment_ProcessingIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ProcessPayment_ProcessingIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ProcessPayment_ProcessingIcon.Image = global::ChapeauUI.Properties.Resources.CautiousImpassionedBoubou_size_restricted;
            this.ProcessPayment_ProcessingIcon.Location = new System.Drawing.Point(136, 76);
            this.ProcessPayment_ProcessingIcon.Margin = new System.Windows.Forms.Padding(1);
            this.ProcessPayment_ProcessingIcon.Name = "ProcessPayment_ProcessingIcon";
            this.ProcessPayment_ProcessingIcon.Size = new System.Drawing.Size(251, 181);
            this.ProcessPayment_ProcessingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProcessPayment_ProcessingIcon.TabIndex = 2;
            this.ProcessPayment_ProcessingIcon.TabStop = false;
            // 
            // lbl_ProcessPayment_Status
            // 
            this.lbl_ProcessPayment_Status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ProcessPayment_Status.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ProcessPayment_Status.Location = new System.Drawing.Point(84, 335);
            this.lbl_ProcessPayment_Status.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_ProcessPayment_Status.Name = "lbl_ProcessPayment_Status";
            this.lbl_ProcessPayment_Status.Size = new System.Drawing.Size(371, 49);
            this.lbl_ProcessPayment_Status.TabIndex = 0;
            this.lbl_ProcessPayment_Status.Text = "Processing Payment...";
            this.lbl_ProcessPayment_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tab_PaymentComplete
            // 
            this.tab_PaymentComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tab_PaymentComplete.Controls.Add(this.pnl_PaymentComplete);
            this.tab_PaymentComplete.Location = new System.Drawing.Point(4, 24);
            this.tab_PaymentComplete.Margin = new System.Windows.Forms.Padding(1);
            this.tab_PaymentComplete.Name = "tab_PaymentComplete";
            this.tab_PaymentComplete.Size = new System.Drawing.Size(521, 622);
            this.tab_PaymentComplete.TabIndex = 5;
            this.tab_PaymentComplete.Text = "Payment Complete";
            // 
            // pnl_PaymentComplete
            // 
            this.pnl_PaymentComplete.Controls.Add(this.pictureBox1);
            this.pnl_PaymentComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PaymentComplete.Location = new System.Drawing.Point(0, 0);
            this.pnl_PaymentComplete.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_PaymentComplete.Name = "pnl_PaymentComplete";
            this.pnl_PaymentComplete.Padding = new System.Windows.Forms.Padding(73, 0, 73, 0);
            this.pnl_PaymentComplete.Size = new System.Drawing.Size(521, 622);
            this.pnl_PaymentComplete.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(192, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 133);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tab_Bar
            // 
            this.tab_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tab_Bar.Controls.Add(this.flow_Bar);
            this.tab_Bar.Controls.Add(this.pnl_Bar_Categories);
            this.tab_Bar.Location = new System.Drawing.Point(4, 24);
            this.tab_Bar.Margin = new System.Windows.Forms.Padding(1);
            this.tab_Bar.Name = "tab_Bar";
            this.tab_Bar.Size = new System.Drawing.Size(521, 622);
            this.tab_Bar.TabIndex = 8;
            this.tab_Bar.Text = "Bar";
            // 
            // flow_Bar
            // 
            this.flow_Bar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_Bar.Location = new System.Drawing.Point(0, 67);
            this.flow_Bar.Margin = new System.Windows.Forms.Padding(1);
            this.flow_Bar.Name = "flow_Bar";
            this.flow_Bar.Size = new System.Drawing.Size(521, 555);
            this.flow_Bar.TabIndex = 0;
            // 
            // pnl_Bar_Categories
            // 
            this.pnl_Bar_Categories.Controls.Add(this.lbl_Bar_Type);
            this.pnl_Bar_Categories.Controls.Add(this.lbl_Bar_Drink);
            this.pnl_Bar_Categories.Controls.Add(this.lbl_Bar_Order_Number);
            this.pnl_Bar_Categories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Bar_Categories.Location = new System.Drawing.Point(0, 0);
            this.pnl_Bar_Categories.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_Bar_Categories.Name = "pnl_Bar_Categories";
            this.pnl_Bar_Categories.Size = new System.Drawing.Size(521, 67);
            this.pnl_Bar_Categories.TabIndex = 0;
            // 
            // lbl_Bar_Type
            // 
            this.lbl_Bar_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Bar_Type.AutoSize = true;
            this.lbl_Bar_Type.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bar_Type.Location = new System.Drawing.Point(342, 20);
            this.lbl_Bar_Type.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Bar_Type.Name = "lbl_Bar_Type";
            this.lbl_Bar_Type.Size = new System.Drawing.Size(60, 29);
            this.lbl_Bar_Type.TabIndex = 1;
            this.lbl_Bar_Type.Text = "Type";
            // 
            // lbl_Bar_Drink
            // 
            this.lbl_Bar_Drink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Bar_Drink.AutoSize = true;
            this.lbl_Bar_Drink.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bar_Drink.Location = new System.Drawing.Point(198, 20);
            this.lbl_Bar_Drink.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Bar_Drink.Name = "lbl_Bar_Drink";
            this.lbl_Bar_Drink.Size = new System.Drawing.Size(66, 29);
            this.lbl_Bar_Drink.TabIndex = 2;
            this.lbl_Bar_Drink.Text = "Drink";
            // 
            // lbl_Bar_Order_Number
            // 
            this.lbl_Bar_Order_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Bar_Order_Number.AutoSize = true;
            this.lbl_Bar_Order_Number.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Bar_Order_Number.Location = new System.Drawing.Point(16, 20);
            this.lbl_Bar_Order_Number.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Bar_Order_Number.Name = "lbl_Bar_Order_Number";
            this.lbl_Bar_Order_Number.Size = new System.Drawing.Size(153, 29);
            this.lbl_Bar_Order_Number.TabIndex = 0;
            this.lbl_Bar_Order_Number.Text = "Order number";
            // 
            // tab_Kitchen
            // 
            this.tab_Kitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.tab_Kitchen.Controls.Add(this.flow_Kitchen);
            this.tab_Kitchen.Controls.Add(this.pnl_Kitchen_Categories);
            this.tab_Kitchen.Location = new System.Drawing.Point(4, 24);
            this.tab_Kitchen.Margin = new System.Windows.Forms.Padding(1);
            this.tab_Kitchen.Name = "tab_Kitchen";
            this.tab_Kitchen.Size = new System.Drawing.Size(521, 622);
            this.tab_Kitchen.TabIndex = 9;
            this.tab_Kitchen.Text = "Kitchen";
            // 
            // flow_Kitchen
            // 
            this.flow_Kitchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_Kitchen.Location = new System.Drawing.Point(0, 67);
            this.flow_Kitchen.Margin = new System.Windows.Forms.Padding(1);
            this.flow_Kitchen.Name = "flow_Kitchen";
            this.flow_Kitchen.Size = new System.Drawing.Size(521, 555);
            this.flow_Kitchen.TabIndex = 1;
            // 
            // pnl_Kitchen_Categories
            // 
            this.pnl_Kitchen_Categories.Controls.Add(this.lbl_Kitchen_Type);
            this.pnl_Kitchen_Categories.Controls.Add(this.lbl_Kitchen_Food);
            this.pnl_Kitchen_Categories.Controls.Add(this.lbl_Kitchen_Order_Number);
            this.pnl_Kitchen_Categories.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Kitchen_Categories.Location = new System.Drawing.Point(0, 0);
            this.pnl_Kitchen_Categories.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_Kitchen_Categories.Name = "pnl_Kitchen_Categories";
            this.pnl_Kitchen_Categories.Size = new System.Drawing.Size(521, 67);
            this.pnl_Kitchen_Categories.TabIndex = 2;
            // 
            // lbl_Kitchen_Type
            // 
            this.lbl_Kitchen_Type.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Kitchen_Type.AutoSize = true;
            this.lbl_Kitchen_Type.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Kitchen_Type.Location = new System.Drawing.Point(342, 20);
            this.lbl_Kitchen_Type.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Kitchen_Type.Name = "lbl_Kitchen_Type";
            this.lbl_Kitchen_Type.Size = new System.Drawing.Size(60, 29);
            this.lbl_Kitchen_Type.TabIndex = 1;
            this.lbl_Kitchen_Type.Text = "Type";
            // 
            // lbl_Kitchen_Food
            // 
            this.lbl_Kitchen_Food.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Kitchen_Food.AutoSize = true;
            this.lbl_Kitchen_Food.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Kitchen_Food.Location = new System.Drawing.Point(198, 20);
            this.lbl_Kitchen_Food.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Kitchen_Food.Name = "lbl_Kitchen_Food";
            this.lbl_Kitchen_Food.Size = new System.Drawing.Size(63, 29);
            this.lbl_Kitchen_Food.TabIndex = 2;
            this.lbl_Kitchen_Food.Text = "Food";
            // 
            // lbl_Kitchen_Order_Number
            // 
            this.lbl_Kitchen_Order_Number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Kitchen_Order_Number.AutoSize = true;
            this.lbl_Kitchen_Order_Number.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Kitchen_Order_Number.Location = new System.Drawing.Point(16, 20);
            this.lbl_Kitchen_Order_Number.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Kitchen_Order_Number.Name = "lbl_Kitchen_Order_Number";
            this.lbl_Kitchen_Order_Number.Size = new System.Drawing.Size(153, 29);
            this.lbl_Kitchen_Order_Number.TabIndex = 0;
            this.lbl_Kitchen_Order_Number.Text = "Order number";
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.pnl_Header.Controls.Add(this.btn_Return);
            this.pnl_Header.Controls.Add(this.btn_Return_Admin);
            this.pnl_Header.Controls.Add(this.lbl_OrderCounter);
            this.pnl_Header.Controls.Add(this.background_OrderCounter);
            this.pnl_Header.Controls.Add(this.btn_User);
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(1);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(529, 53);
            this.pnl_Header.TabIndex = 0;
            // 
            // btn_Return
            // 
            this.btn_Return.BackgroundImage = global::ChapeauUI.Properties.Resources.Home_Icon;
            this.btn_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return.FlatAppearance.BorderSize = 0;
            this.btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Return.Location = new System.Drawing.Point(1, 0);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(73, 53);
            this.btn_Return.TabIndex = 4;
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Visible = false;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Return_Admin
            // 
            this.btn_Return_Admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Return_Admin.FlatAppearance.BorderSize = 0;
            this.btn_Return_Admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Return_Admin.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Return_Admin.Location = new System.Drawing.Point(103, 8);
            this.btn_Return_Admin.Margin = new System.Windows.Forms.Padding(1);
            this.btn_Return_Admin.Name = "btn_Return_Admin";
            this.btn_Return_Admin.Size = new System.Drawing.Size(83, 40);
            this.btn_Return_Admin.TabIndex = 5;
            this.btn_Return_Admin.Text = "Admin";
            this.btn_Return_Admin.UseVisualStyleBackColor = true;
            this.btn_Return_Admin.Visible = false;
            // 
            // lbl_OrderCounter
            // 
            this.lbl_OrderCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_OrderCounter.AutoSize = true;
            this.lbl_OrderCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.lbl_OrderCounter.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_OrderCounter.Location = new System.Drawing.Point(395, 15);
            this.lbl_OrderCounter.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_OrderCounter.Name = "lbl_OrderCounter";
            this.lbl_OrderCounter.Size = new System.Drawing.Size(64, 27);
            this.lbl_OrderCounter.TabIndex = 3;
            this.lbl_OrderCounter.Text = "0 / 10";
            this.lbl_OrderCounter.Visible = false;
            // 
            // background_OrderCounter
            // 
            this.background_OrderCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.background_OrderCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.background_OrderCounter.Location = new System.Drawing.Point(385, 8);
            this.background_OrderCounter.Margin = new System.Windows.Forms.Padding(1);
            this.background_OrderCounter.Name = "background_OrderCounter";
            this.background_OrderCounter.Size = new System.Drawing.Size(80, 40);
            this.background_OrderCounter.TabIndex = 2;
            this.background_OrderCounter.TabStop = false;
            this.background_OrderCounter.Visible = false;
            // 
            // btn_User
            // 
            this.btn_User.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(67)))));
            this.btn_User.BackgroundImage = global::ChapeauUI.Properties.Resources.User_Icon;
            this.btn_User.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_User.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_User.FlatAppearance.BorderSize = 0;
            this.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_User.Location = new System.Drawing.Point(481, 8);
            this.btn_User.Margin = new System.Windows.Forms.Padding(1);
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(40, 40);
            this.btn_User.TabIndex = 0;
            this.btn_User.UseVisualStyleBackColor = false;
            this.btn_User.Visible = false;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(151)))), ((int)(((byte)(169)))));
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(529, 53);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Login";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Body
            // 
            this.pnl_Body.Controls.Add(this.tabC_Body);
            this.pnl_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Body.Location = new System.Drawing.Point(0, 53);
            this.pnl_Body.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Body.Name = "pnl_Body";
            this.pnl_Body.Size = new System.Drawing.Size(529, 650);
            this.pnl_Body.TabIndex = 0;
            // 
            // border_Left
            // 
            this.border_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.border_Left.Location = new System.Drawing.Point(0, 57);
            this.border_Left.Margin = new System.Windows.Forms.Padding(0);
            this.border_Left.Name = "border_Left";
            this.border_Left.Size = new System.Drawing.Size(3, 643);
            this.border_Left.TabIndex = 2;
            this.border_Left.TabStop = false;
            // 
            // border_Right
            // 
            this.border_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.border_Right.Location = new System.Drawing.Point(526, 57);
            this.border_Right.Margin = new System.Windows.Forms.Padding(0);
            this.border_Right.Name = "border_Right";
            this.border_Right.Size = new System.Drawing.Size(3, 643);
            this.border_Right.TabIndex = 1;
            this.border_Right.TabStop = false;
            // 
            // border_Bottom
            // 
            this.border_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.border_Bottom.Location = new System.Drawing.Point(0, 700);
            this.border_Bottom.Margin = new System.Windows.Forms.Padding(0);
            this.border_Bottom.Name = "border_Bottom";
            this.border_Bottom.Size = new System.Drawing.Size(529, 3);
            this.border_Bottom.TabIndex = 3;
            this.border_Bottom.TabStop = false;
            // 
            // border_Top
            // 
            this.border_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.border_Top.Location = new System.Drawing.Point(0, 53);
            this.border_Top.Margin = new System.Windows.Forms.Padding(0);
            this.border_Top.Name = "border_Top";
            this.border_Top.Size = new System.Drawing.Size(529, 4);
            this.border_Top.TabIndex = 4;
            this.border_Top.TabStop = false;
            // 
            // PaymentProcessTimer1
            // 
            this.PaymentProcessTimer1.Interval = 1000;
            // 
            // PaymentProcess_lbl_FunFact
            // 
            this.PaymentProcess_lbl_FunFact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PaymentProcess_lbl_FunFact.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PaymentProcess_lbl_FunFact.Location = new System.Drawing.Point(74, 475);
            this.PaymentProcess_lbl_FunFact.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.PaymentProcess_lbl_FunFact.Name = "PaymentProcess_lbl_FunFact";
            this.PaymentProcess_lbl_FunFact.Size = new System.Drawing.Size(371, 49);
            this.PaymentProcess_lbl_FunFact.TabIndex = 4;
            this.PaymentProcess_lbl_FunFact.Text = "Fun fact:";
            this.PaymentProcess_lbl_FunFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Chapeau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(529, 703);
            this.Controls.Add(this.border_Right);
            this.Controls.Add(this.border_Left);
            this.Controls.Add(this.border_Top);
            this.Controls.Add(this.border_Bottom);
            this.Controls.Add(this.pnl_Body);
            this.Controls.Add(this.pnl_Header);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(545, 754);
            this.MinimumSize = new System.Drawing.Size(545, 705);
            this.Name = "Form_Chapeau";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Restaurant Chapeau Ordering System";
            this.Load += new System.EventHandler(this.FormChapeau_Load);
            this.tabC_Body.ResumeLayout(false);
            this.tab_Login.ResumeLayout(false);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin_Logo)).EndInit();
            this.tab_Account.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tab_Tables.ResumeLayout(false);
            this.pnl_TableOverview.Panel1.ResumeLayout(false);
            this.pnl_TableOverview.Panel1.PerformLayout();
            this.pnl_TableOverview.Panel2.ResumeLayout(false);
            this.pnl_TableOverview.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TableOverview)).EndInit();
            this.pnl_TableOverview.ResumeLayout(false);
            this.flow_TableOverview_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_TableOverview_Title_Table)).EndInit();
            this.flow_Tables.ResumeLayout(false);
            this.pnl_TableInfo.Panel1.ResumeLayout(false);
            this.pnl_TableInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_TableInfo)).EndInit();
            this.pnl_TableInfo.ResumeLayout(false);
            this.tab_Order.ResumeLayout(false);
            this.pnl_Order_Menu.ResumeLayout(false);
            this.pnl_Order_Orders.ResumeLayout(false);
            this.pnl_Order_Categories.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tab_Bill.ResumeLayout(false);
            this.pnl_Bill.ResumeLayout(false);
            this.pnl_Bill.PerformLayout();
            this.Bill_grpbox_PaymentMethod.ResumeLayout(false);
            this.Bill_grpbox_PaymentMethod.PerformLayout();
            this.tab_CashPayment.ResumeLayout(false);
            this.pnl_Cash.ResumeLayout(false);
            this.pnl_Cash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_num_ChangeOrTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Payment_num_AmountGivenOrTip)).EndInit();
            this.tab_ProcessPayment.ResumeLayout(false);
            this.pnl_ProcessPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProcessPayment_ProcessingIcon)).EndInit();
            this.tab_PaymentComplete.ResumeLayout(false);
            this.pnl_PaymentComplete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_Bar.ResumeLayout(false);
            this.pnl_Bar_Categories.ResumeLayout(false);
            this.pnl_Bar_Categories.PerformLayout();
            this.tab_Kitchen.ResumeLayout(false);
            this.pnl_Kitchen_Categories.ResumeLayout(false);
            this.pnl_Kitchen_Categories.PerformLayout();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.background_OrderCounter)).EndInit();
            this.pnl_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.border_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_Right)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_Bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.border_Top)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabC_Body;
        private System.Windows.Forms.TabPage tab_Login;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Body;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.PictureBox border_Left;
        private System.Windows.Forms.PictureBox border_Right;
        private System.Windows.Forms.PictureBox border_Bottom;
        private System.Windows.Forms.PictureBox border_Top;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.PictureBox background_OrderCounter;
        private System.Windows.Forms.Label lbl_OrderCounter;
        private System.Windows.Forms.TabPage tab_Tables;
        private System.Windows.Forms.TabPage tab_Order;
        private System.Windows.Forms.TabPage tab_Bill;
        private System.Windows.Forms.TabPage tab_PaymentComplete;
        private System.Windows.Forms.TabPage tab_ProcessPayment;
        private System.Windows.Forms.TabPage tab_CashPayment;
        private System.Windows.Forms.PictureBox imgLogin_Logo;
        private System.Windows.Forms.SplitContainer pnl_TableOverview;
        private System.Windows.Forms.SplitContainer pnl_TableInfo;
        private System.Windows.Forms.FlowLayoutPanel flow_TableOverview;
        private System.Windows.Forms.FlowLayoutPanel flow_ServeOrders;
        private System.Windows.Forms.FlowLayoutPanel flow_Reservations;
        private System.Windows.Forms.Panel pnl_Order_Categories;
        private System.Windows.Forms.TabPage tab_Bar;
        private System.Windows.Forms.TabPage tab_Kitchen;
        private System.Windows.Forms.FlowLayoutPanel flow_Order_Menu;
        private System.Windows.Forms.FlowLayoutPanel flow_Order_Items;
        private System.Windows.Forms.Button btn_Order_Confirm;
        private System.Windows.Forms.Panel pnl_Bill;
        private System.Windows.Forms.Panel pnl_PaymentComplete;
        private System.Windows.Forms.Panel pnl_ProcessPayment;
        private System.Windows.Forms.PictureBox ProcessPayment_ProcessingIcon;
        private System.Windows.Forms.Label lbl_ProcessPayment_Status;
        private System.Windows.Forms.Panel pnl_Cash;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Return_Admin;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.TextBox txtBox_Login_User;
        private System.Windows.Forms.FlowLayoutPanel flow_Bar;
        private System.Windows.Forms.Panel pnl_Bar_Categories;
        private System.Windows.Forms.Label lbl_Bar_Type;
        private System.Windows.Forms.Label lbl_Bar_Drink;
        private System.Windows.Forms.Label lbl_Bar_Order_Number;
        private System.Windows.Forms.FlowLayoutPanel flow_Kitchen;
        private System.Windows.Forms.Panel pnl_Kitchen_Categories;
        private System.Windows.Forms.Label lbl_Kitchen_Type;
        private System.Windows.Forms.Label lbl_Kitchen_Food;
        private System.Windows.Forms.Label lbl_Kitchen_Order_Number;
        private System.Windows.Forms.TextBox txtBox_Login_Password;
        private System.Windows.Forms.Label lbl_Login_Password;
        private System.Windows.Forms.Label lbl_Login_EmployeeID;
        private System.Windows.Forms.FlowLayoutPanel flow_Tables;
        private System.Windows.Forms.Button btn_Table_1;
        private System.Windows.Forms.Button btn_Table_2;
        private System.Windows.Forms.Button btn_Table_3;
        private System.Windows.Forms.Button btn_Table_4;
        private System.Windows.Forms.Button btn_Table_5;
        private System.Windows.Forms.Button btn_Table_6;
        private System.Windows.Forms.Button btn_Table_7;
        private System.Windows.Forms.Button btn_Table_8;
        private System.Windows.Forms.Button btn_Table_9;
        private System.Windows.Forms.Button btn_Table_10;
        private System.Windows.Forms.Splitter splitter_TableOverview;
        private System.Windows.Forms.Splitter splitter_Table_Top;
        private System.Windows.Forms.Label lbl_TableInfo_Panel1_Title;
        private System.Windows.Forms.Label lbl_TableInfo_Panel2_Title;
        private System.Windows.Forms.FlowLayoutPanel flow_TableOverview_Title;
        private System.Windows.Forms.PictureBox img_TableOverview_Title_Table;
        private System.Windows.Forms.Label lbl_TableOverview_Title;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_Order_LunchMenu;
        private System.Windows.Forms.Button btn_Order_DinnerMenu;
        private System.Windows.Forms.Button btn_Order_DrinksMenu;
        private System.Windows.Forms.TabPage tab_Account;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_Account_Logout;
        private System.Windows.Forms.Label lbl_Account_Role;
        private System.Windows.Forms.Label lbl_Account_Email;
        private System.Windows.Forms.Label lbl_Order_TotalPrice;
        private System.Windows.Forms.Splitter splitter_Orders_Price;
        private System.Windows.Forms.Panel pnl_Order_Menu;
        private System.Windows.Forms.Panel pnl_Order_Orders;
        private System.Windows.Forms.Splitter splitter_OrderMenu;
        private System.Windows.Forms.Button btn_Order_Checkout;
        private System.Windows.Forms.Splitter splitter_Checkout;
        private System.Windows.Forms.ListView Bill_lv_Bill;
        private System.Windows.Forms.Button Bill_btn_Pay;
        private System.Windows.Forms.Label Bill_lbl_Bill;
        private System.Windows.Forms.RadioButton Bill_radbtn_Cash;
        private System.Windows.Forms.GroupBox Bill_grpbox_PaymentMethod;
        private System.Windows.Forms.RadioButton Bill_radbtn_Credit;
        private System.Windows.Forms.RadioButton Bill_radbtn_Debit;
        private System.Windows.Forms.ListView Bill_lv_VAT;
        private System.Windows.Forms.Label Bill_lbl_TotalAmount;
        private System.Windows.Forms.Label Bill_lbl_TotalTitle;
        private System.Windows.Forms.ColumnHeader Bill_ColQuantity;
        private System.Windows.Forms.ColumnHeader Bill_ColName;
        private System.Windows.Forms.ColumnHeader Bill_ColVAT;
        private System.Windows.Forms.ColumnHeader Bill_ColPrice;
        private System.Windows.Forms.ColumnHeader Bill_ColPriceTotal;
        private System.Windows.Forms.ColumnHeader VAT_ColVAT;
        private System.Windows.Forms.ColumnHeader VAT_ColBasePrice;
        private System.Windows.Forms.ColumnHeader VAT_ColVATAmount;
        private System.Windows.Forms.ColumnHeader VAT_ColTotalSum;
        private System.Windows.Forms.Label Payment_lbl_Method;
        private System.Windows.Forms.NumericUpDown Payment_num_ChangeOrTotal;
        private System.Windows.Forms.NumericUpDown Payment_num_AmountGivenOrTip;
        private System.Windows.Forms.Label Payment_lbl_MethodTitle;
        private System.Windows.Forms.Button Payment_btn_Cancel;
        private System.Windows.Forms.Label Payment_lbl_BillTotal;
        private System.Windows.Forms.Label Payment_lbl_ChangeOrTotalToPay;
        private System.Windows.Forms.Label Payment_lbl_BillTotalTitle;
        private System.Windows.Forms.Label Payment_lbl_AmountGivenOrTip;
        private System.Windows.Forms.Button Payment_Btn_Pay;
        private System.Windows.Forms.Label Bill_lbl_StillToPayTitle;
        private System.Windows.Forms.Label Bill_lbl_RemainingPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer PaymentProcessTimer1;
        private System.Windows.Forms.Label PaymentProcess_lbl_FunFactTitle;
        private System.Windows.Forms.Label PaymentProcess_lbl_FunFact;
    }
}
