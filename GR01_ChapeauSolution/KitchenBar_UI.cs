using ChapeauLogic;
using ChapeauModel;
using GR01_ChapeauSolution;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class KitchenBar_UI : Form
    {
        Employee employee;

        public KitchenBar_UI(Employee employee)
        {
            InitializeComponent();

            this.employee = employee;

            if (this.employee.EmployeeRole == "Chef")
            {
                // Display Kitchen panel
                pnl_Food.Show();
                pnl_Kitchen.Show();
                pnl_Bar.Hide();
                listView_Bar.CheckBoxes = true;

                kitchen_Clock.Text = DateTime.Now.ToString("HH:mm");
                
                Clock();
                MyTimer(10);
                FillLunch();
            }
            else if (this.employee.EmployeeRole == "Bartender")
            {
                // Display Bar panel
                pnl_Bar.Show();
                pnl_Food.Hide();
                pnl_Kitchen.Hide();
                listView_Bar.CheckBoxes = true;

                bar_Clock.Text = DateTime.Now.ToString("HH:mm");

                Clock();
                MyTimer(10);
                FillBar();
            }
            

        }

        private void MyTimer(int seconds)
        {
            Timer timer = new Timer();
            timer.Interval = (seconds * 1000);
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            for (int i = 0; i < listView_Food.Items.Count; i++)
            {
                if (listView_Food.Items[i].Checked == true)
                {
                    listView_Food.Items[i].Remove();
                }
            }

            for (int i = 0; i < listView_Bar.Items.Count; i++)
            {
                if (listView_Bar.Items[i].Checked == true)
                {
                    listView_Bar.Items[i].Remove();
                }
            }

        }

        private void Clock()
        {
            Timer timer = new Timer();
            timer.Interval = (30 * 1000);
            timer.Tick += new EventHandler(Clock_Tick);
            timer.Start();
        }
        private void Clock_Tick(object sender, System.EventArgs e)
        {
            bar_Clock.Text = DateTime.Now.ToString("HH:mm");
            kitchen_Clock.Text = DateTime.Now.ToString("HH:mm");
        }

        public void FillBar()
        {
            Kitchen_BarService barService = new Kitchen_BarService();
            List<KitchenBar> BarList = barService.GetBarItems();

            foreach (KitchenBar item in BarList)
            {
                ListViewItem item1 = new ListViewItem(" ");
                item1.SubItems.Add(item.OrderID.ToString());
                item1.SubItems.Add(item.Item_Type.ToString());
                item1.SubItems.Add(item.ShortName.ToString());
                item1.SubItems.Add(item.Quantity.ToString());
                item1.SubItems.Add(item.Comment.ToString());
                item1.SubItems.Add(item.Date_Time.ToString("HH:mm"));

                listView_Bar.Items.Add(item1);
            }
        }

        public void FillLunch()
        {
            Kitchen_BarService LunchService = new Kitchen_BarService();
            List<KitchenBar> LunchList = LunchService.GetLunchItems();

            foreach (KitchenBar item in LunchList)
            {
                ListViewItem item1 = new ListViewItem(" ");
                item1.SubItems.Add(item.OrderID.ToString());
                item1.SubItems.Add(item.Item_Type.ToString());
                item1.SubItems.Add(item.ShortName.ToString());
                item1.SubItems.Add(item.Quantity.ToString());
                item1.SubItems.Add(item.Comment.ToString());
                item1.SubItems.Add(item.Date_Time.ToString("HH:mm"));

                listView_Food.Items.Add(item1);
            }
        }

        public void FillDinner()
        {
            Kitchen_BarService DinnerService = new Kitchen_BarService();
            List<KitchenBar> DinnerList = DinnerService.GetDinnerItems();

            foreach (KitchenBar item in DinnerList)
            {
                ListViewItem item1 = new ListViewItem(" ");
                item1.SubItems.Add(item.OrderID.ToString());
                item1.SubItems.Add(item.Item_Type.ToString());
                item1.SubItems.Add(item.ShortName.ToString());
                item1.SubItems.Add(item.Quantity.ToString());
                item1.SubItems.Add(item.Comment.ToString());
                item1.SubItems.Add(item.Date_Time.ToString("HH:mm:ss"));

                listView_Food.Items.Add(item1);
            }
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kitchen_BarService barService = new Kitchen_BarService();
            List<KitchenBar> BarList = barService.GetBarItems();
        }

        private void Lunch_Click(object sender, EventArgs e)
        {
            listView_Food.Items.Clear();
            FillLunch();
        }

        private void Dinner_Click(object sender, EventArgs e)
        {
            listView_Food.Items.Clear();
            FillDinner();
        }

        private void btn_Account_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            employee = null;
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            // Open account overview
            pnl_AccountBarKitchen.Show();
            pnl_Bar.Hide();
            pnl_Kitchen.Hide();
            pnl_Food.Hide();
            
            //Show employee information
            lbl_Account_EmployeeID.Text = $"ID: {employee.EmployeeId.ToString()}";
            lbl_Account_EmployeeName.Text = employee.EmployeeName;
            lbl_Account_Role.Text = employee.EmployeeRole;
        }

        private void btn_ReturnBarKitchenView_Click(object sender, EventArgs e)
        {
            // Close account overview
            pnl_AccountBarKitchen.Hide();
            if (employee.EmployeeRole == "Chef")
            {
                pnl_Food.Show();
                pnl_Kitchen.Show();
            }
            else if (employee.EmployeeRole == "Bartender")
            {
                pnl_Bar.Show();
            }
        }
    }
}
