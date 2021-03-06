using ChapeauModel;
using ChapeauLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace ChapeauUI.Components
{
    public partial class C_Table_Order : UserControl
    {
        List<OrderItem> items = new List<OrderItem>();
        OrderService orderService = new OrderService();

        public C_Table_Order()
        {
            InitializeComponent();
            this.items = orderService.GetOrderItems();
            LoadOrderItems(this.items);

            Clock();
        }

        private void Clock()
        {
            Timer timer = new Timer();
            timer.Interval = (10 * 1000);
            timer.Tick += new EventHandler(Clock_Tick);
            timer.Start();
        }
        private void Clock_Tick(object sender, System.EventArgs e)
        {
            ClearLabels();
            this.items = orderService.GetOrderItems();
            LoadOrderItems(this.items);
        }

        private void ClearLabels()
        {
            lbl_OrderItems1.Text = "";
            lbl_TableTime1.Text = "";
            lbl_OrderItems2.Text = "";
            lbl_TableTime2.Text = "";
            lbl_OrderItems3.Text = "";
            lbl_TableTime3.Text = "";
            lbl_OrderItems4.Text = "";
            lbl_TableTime4.Text = "";
            lbl_OrderItems5.Text = "";
            lbl_TableTime5.Text = "";
            lbl_OrderItems6.Text = "";
            lbl_TableTime6.Text = "";
            lbl_OrderItems7.Text = "";
            lbl_TableTime7.Text = "";
            lbl_OrderItems8.Text = "";
            lbl_TableTime8.Text = "";
            lbl_OrderItems9.Text = "";
            lbl_TableTime9.Text = "";
            lbl_OrderItems10.Text = "";
            lbl_TableTime10.Text = "";
        }


        // Load items to the running orders view
        private void LoadOrderItems(List<OrderItem> orderItems)
        {
            //FillLabelsLists();

            foreach (OrderItem item in orderItems)
            {
                if (item.TableID == 1)
                {
                    lbl_OrderItems1.Text += item.ItemName + Environment.NewLine;
                    lbl_TableTime1.Text = $"Table 1 - {item.OrderTime:T}";
                }
                else if (item.TableID == 2)
                {
                    lbl_OrderItems2.Text += item.ItemName + Environment.NewLine;
                    lbl_TableTime2.Text = $"Table 2 - {item.OrderTime:T}";
                }
                else if (item.TableID == 3)
                {
                    lbl_OrderItems3.Text += item.ItemName + Environment.NewLine;
                    lbl_TableTime3.Text = $"Table 3 - {item.OrderTime:T}";
                }
                else if (item.TableID == 4)
                {
                    lbl_OrderItems4.Text += item.ItemName + Environment.NewLine;
                    lbl_TableTime4.Text = $"Table 4 - {item.OrderTime:T}";
                }
                else if (item.TableID == 5)
                {
                    lbl_OrderItems5.Text += item.ItemName + Environment.NewLine;
                    lbl_TableTime5.Text = $"Table 5 - {item.OrderTime:T}";
                }
                else if (item.TableID == 6)
                {
                    lbl_OrderItems6.Text += item.ItemName + Environment.NewLine;
                    lbl_TableTime6.Text = $"Table 6 - {item.OrderTime:T}";
                }
                else if (item.TableID == 7)
                {
                    lbl_OrderItems7.Text += item.ItemName + Environment.NewLine;
                    lbl_TableTime7.Text = $"Table 7 - {item.OrderTime:T}";
                }
                else if (item.TableID == 8)
                {
                    lbl_OrderItems8.Text += item.ItemName + Environment.NewLine;
                    lbl_TableTime8.Text = $"Table 8 - {item.OrderTime:T}";
                }
                else if (item.TableID == 9)
                {
                    lbl_OrderItems9.Text += item.ItemName + Environment.NewLine;
                    lbl_TableTime9.Text = $"Table 9 - {item.OrderTime:T}";
                }
                else
                {
                    lbl_OrderItems10.Text += item.ItemName + Environment.NewLine;
                    lbl_TableTime10.Text = $"Table 10 - {item.OrderTime:T}";
                }
            }
            lbl_OrderItems1.Text += "\n";
            lbl_OrderItems2.Text += "\n";
            lbl_OrderItems3.Text += "\n";
            lbl_OrderItems4.Text += "\n";
            lbl_OrderItems5.Text += "\n";
            lbl_OrderItems6.Text += "\n";
            lbl_OrderItems7.Text += "\n";
            lbl_OrderItems8.Text += "\n";
            lbl_OrderItems9.Text += "\n";
            lbl_OrderItems10.Text += "\n";

            if (lbl_OrderItems1.Text == "\n")
            {
                panel1.Hide();
            }
            else
                panel1.Show();
            if (lbl_OrderItems2.Text == "\n")
            {
                panel2.Hide();
            }
            else
                panel2.Show();
            if (lbl_OrderItems3.Text == "\n")
            {
                panel3.Hide();
            }
            else
                panel3.Show();
            if (lbl_OrderItems4.Text == "\n")
            {
                panel4.Hide();
            }
            else
                panel4.Show();
            if (lbl_OrderItems5.Text == "\n")
            {
                panel5.Hide();
            }
            else
                panel5.Show();
            if (lbl_OrderItems6.Text == "\n")
            {
                panel6.Hide();
            }
            else
                panel6.Show();
            if (lbl_OrderItems7.Text == "\n")
            {
                panel7.Hide();
            }
            else
                panel7.Show();
            if (lbl_OrderItems8.Text == "\n")
            {
                panel8.Hide();
            }
            else
                panel8.Show();
            if (lbl_OrderItems9.Text == "\n")
            {
                panel9.Hide();
            }
            else
                panel9.Show();
            if (lbl_OrderItems10.Text == "\n")
            {
                panel10.Hide();
            }
            else
                panel10.Show();
        }

        private void ServeOrder(int tableID)
        {
            foreach (OrderItem item in items)
            {
                if (item.TableID == tableID)
                {
                    orderService.SetOrderServed(item.OrderItemID);
                }
            }
        }

        private void btn_OrderServed1_Click(object sender, EventArgs e)
        {
            ServeOrder(1);
            panel1.Visible = false;
        }

        private void btn_OrderServed2_Click(object sender, EventArgs e)
        {
            ServeOrder(2);
            panel2.Visible = false;
        }

        private void btn_OrderServed3_Click(object sender, EventArgs e)
        {
            ServeOrder(3);
            panel3.Visible = false;
        }

        private void btn_OrderServed4_Click(object sender, EventArgs e)
        {
            ServeOrder(4);
            panel4.Visible = false;
        }

        private void btn_OrderServed5_Click(object sender, EventArgs e)
        {
            ServeOrder(5);
            panel5.Visible = false;
        }

        private void btn_OrderServed6_Click(object sender, EventArgs e)
        {
            ServeOrder(6);
            panel6.Visible = false;
        }

        private void btn_OrderServed7_Click(object sender, EventArgs e)
        {
            ServeOrder(7);
            panel7.Visible = false;
        }

        private void btn_OrderServed8_Click(object sender, EventArgs e)
        {
            ServeOrder(8);
            panel8.Visible = false;
        }

        private void btn_OrderServed9_Click(object sender, EventArgs e)
        {
            ServeOrder(9);
            panel9.Visible = false;
        }

        private void btn_OrderServed10_Click(object sender, EventArgs e)
        {
            ServeOrder(10);
            panel10.Visible = false;
        }
    }
}
