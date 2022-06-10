using ChapeauModel;
using ChapeauLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChapeauUI.Components
{
    public partial class C_Table_Order : UserControl
    {
        List<OrderItem> items = new List<OrderItem>();

        public C_Table_Order(List<OrderItem> items)
        {
            InitializeComponent();

            OrderService orderService = new OrderService();
            loadOrderItems(orderService.GetOrderItems());
            this.items = items;

        }

        // Load items to the running orders view
        private void loadOrderItems(List<OrderItem> orderItems)
        {
            
            foreach (OrderItem item in orderItems)
            {
                if (item.TableID == 1)
                {
                    lbl_OrderItems1.Text += item.ItemName + Environment.NewLine;
                }
                else if (item.TableID == 2)
                {
                    lbl_OrderItems2.Text += item.ItemName + Environment.NewLine;
                }
                else if (item.TableID == 3)
                {
                    lbl_OrderItems3.Text += item.ItemName + Environment.NewLine;
                }
                else if (item.TableID == 4)
                {
                    lbl_OrderItems4.Text += item.ItemName + Environment.NewLine;
                }
                else if (item.TableID == 5)
                {
                    lbl_OrderItems5.Text += item.ItemName + Environment.NewLine;
                }
                else if (item.TableID == 6)
                {
                    lbl_OrderItems6.Text += item.ItemName + Environment.NewLine;
                }
                else if (item.TableID == 7)
                {
                    lbl_OrderItems7.Text += item.ItemName + Environment.NewLine;
                }
                else if (item.TableID == 8)
                {
                    lbl_OrderItems8.Text += item.ItemName + Environment.NewLine;
                }
                else if (item.TableID == 9)
                {
                    lbl_OrderItems9.Text += item.ItemName + Environment.NewLine;
                }
                else
                {
                    lbl_OrderItems10.Text += item.ItemName + Environment.NewLine;
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
