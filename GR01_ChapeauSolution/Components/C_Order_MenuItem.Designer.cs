namespace ChapeauUI.Components
{
    partial class C_Order_MenuItem
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ItemName = new System.Windows.Forms.Label();
            this.lbl_Euro = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_Priceholder = new System.Windows.Forms.Panel();
            this.splitter = new System.Windows.Forms.Splitter();
            this.pnl_Main.SuspendLayout();
            this.pnl_Priceholder.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_ItemName
            // 
            this.lbl_ItemName.AutoSize = true;
            this.lbl_ItemName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_ItemName.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ItemName.Location = new System.Drawing.Point(0, 0);
            this.lbl_ItemName.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ItemName.MaximumSize = new System.Drawing.Size(440, 0);
            this.lbl_ItemName.Name = "lbl_ItemName";
            this.lbl_ItemName.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lbl_ItemName.Size = new System.Drawing.Size(425, 120);
            this.lbl_ItemName.TabIndex = 0;
            this.lbl_ItemName.Text = "Fresh madeleines wieth figeeeee compote and creme patissier with Grand Marnier";
            this.lbl_ItemName.UseCompatibleTextRendering = true;
            // 
            // lbl_Euro
            // 
            this.lbl_Euro.AutoSize = true;
            this.lbl_Euro.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Euro.Location = new System.Drawing.Point(0, -2);
            this.lbl_Euro.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Euro.Name = "lbl_Euro";
            this.lbl_Euro.Size = new System.Drawing.Size(37, 44);
            this.lbl_Euro.TabIndex = 1;
            this.lbl_Euro.Text = "€";
            // 
            // lbl_Price
            // 
            this.lbl_Price.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Price.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Price.Location = new System.Drawing.Point(0, 0);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lbl_Price.Size = new System.Drawing.Size(430, 45);
            this.lbl_Price.TabIndex = 2;
            this.lbl_Price.Text = "1.99";
            // 
            // pnl_Main
            // 
            this.pnl_Main.AutoSize = true;
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.pnl_Main.Controls.Add(this.pnl_Priceholder);
            this.pnl_Main.Controls.Add(this.lbl_ItemName);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(430, 165);
            this.pnl_Main.TabIndex = 3;
            // 
            // pnl_Priceholder
            // 
            this.pnl_Priceholder.Controls.Add(this.lbl_Euro);
            this.pnl_Priceholder.Controls.Add(this.lbl_Price);
            this.pnl_Priceholder.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Priceholder.Location = new System.Drawing.Point(0, 120);
            this.pnl_Priceholder.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Priceholder.Name = "pnl_Priceholder";
            this.pnl_Priceholder.Size = new System.Drawing.Size(430, 45);
            this.pnl_Priceholder.TabIndex = 3;
            // 
            // splitter
            // 
            this.splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(119)))));
            this.splitter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter.Location = new System.Drawing.Point(0, 165);
            this.splitter.Margin = new System.Windows.Forms.Padding(0);
            this.splitter.Name = "splitter";
            this.splitter.Size = new System.Drawing.Size(430, 3);
            this.splitter.TabIndex = 4;
            this.splitter.TabStop = false;
            // 
            // C_Order_MenuItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.splitter);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(430, 0);
            this.MinimumSize = new System.Drawing.Size(430, 160);
            this.Name = "C_Order_MenuItem";
            this.Size = new System.Drawing.Size(430, 168);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.pnl_Priceholder.ResumeLayout(false);
            this.pnl_Priceholder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ItemName;
        private System.Windows.Forms.Label lbl_Euro;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Splitter splitter;
        private System.Windows.Forms.Panel pnl_Priceholder;
    }
}
