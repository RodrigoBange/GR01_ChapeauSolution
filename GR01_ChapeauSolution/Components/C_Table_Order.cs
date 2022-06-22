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
        List<Label> tableOrderLabels = new List<Label>();
        List<Label> tableTimeLabels = new List<Label>();

        public C_Table_Order(List<OrderItem> items)
        {
            InitializeComponent();

            OrderService orderService = new OrderService();
            LoadOrderItems(orderService.GetOrderItems());
            this.items = items;
        }

        private void FillLabelsLists()
        {
            for (int i = 1; i < 11; i++)
            {
                Label labelOrderItems = (Label)this.Controls.OfType<Label>().Where(lbl => lbl.Name == "lbl_OrderItems" + i);
                Label labelTimes = (Label)this.Controls.OfType<Label>().Where(lbl => lbl.Name == "lbl_TableTime" + i);
                tableOrderLabels.Add(labelOrderItems);
                tableTimeLabels.Add(labelTimes);
            }
        }

        // Load items to the running orders view
        private void LoadOrderItems(List<OrderItem> orderItems)
        {
            //FillLabelsLists();

            foreach (OrderItem item in orderItems)
            {
                //foreach (Label label in tableOrderLabels)
                //{
                //    if (item.TableID == tableOrderLabels.IndexOf(label) + 1)
                //        label.Text += item.ItemName + Environment.NewLine;
                //}

                //foreach (Label label in tableTimeLabels)
                //{
                //    if (item.TableID == tableTimeLabels.IndexOf(label) + 1)
                //        label.Text += $"Table {tableTimeLabels.IndexOf(label) + 1} - {item.OrderTime:T}";
                //}


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
            if (lbl_OrderItems2.Text == "\n")
            {
                panel2.Hide();
            }
            if (lbl_OrderItems3.Text == "\n")
            {
                panel3.Hide();
            }
            if (lbl_OrderItems4.Text == "\n")
            {
                panel4.Hide();
            }
            if (lbl_OrderItems5.Text == "\n")
            {
                panel5.Hide();
            }
            if (lbl_OrderItems6.Text == "\n")
            {
                panel6.Hide();
            }
            if (lbl_OrderItems7.Text == "\n")
            {
                panel7.Hide();
            }
            if (lbl_OrderItems8.Text == "\n")
            {
                panel8.Hide();
            }
            if (lbl_OrderItems9.Text == "\n")
            {
                panel9.Hide();
            }
            if (lbl_OrderItems10.Text == "\n")
            {
                panel10.Hide();
            }
        }

        private void btn_OrderServed1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btn_OrderServed2_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btn_OrderServed3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void btn_OrderServed4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void btn_OrderServed5_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void btn_OrderServed6_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void btn_OrderServed7_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void btn_OrderServed8_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void btn_OrderServed9_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }

        private void btn_OrderServed10_Click(object sender, EventArgs e)
        {
            panel10.Visible = false;
        }
    }
}
