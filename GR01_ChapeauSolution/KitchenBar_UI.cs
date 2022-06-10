using ChapeauLogic;
using ChapeauModel;
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
                btn_User.Show();
                listView_Bar.CheckBoxes = true;
                label_Time.Show();
                label_Time.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else if (this.employee.EmployeeRole == "Bartender")
            {
                // Display Bar panel
                btn_User.Show();
                FillBar();
                listView_Bar.CheckBoxes = true;
                label_Time.Show();
                label_Time.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            

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
                item1.SubItems.Add(item.Date_Time.ToString("HH:mm:ss"));

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
                item1.SubItems.Add(item.Date_Time.ToString("HH:mm:ss"));

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

        private void btn_Ready_Click(object sender, EventArgs e)
        {

        }

        private void Lunch_Click(object sender, EventArgs e)
        {
            FillLunch();
        }

        private void Dinner_Click(object sender, EventArgs e)
        {
            FillDinner();
        }
    }
}
