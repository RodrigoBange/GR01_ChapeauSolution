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
        public KitchenBar_UI()
        {
            InitializeComponent();
            listView_Bar.CheckBoxes = true;
            btn_User.Show();
            lbl_TitleKitchen.Hide();
            label_Time.Show();
            FillBar();

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

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kitchen_BarService barService = new Kitchen_BarService();
            List<KitchenBar> BarList = barService.GetBarItems();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label_Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
