namespace ChapeauUI.Components
{
    partial class C_Available_Reservation
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
            this.btn_PlaceReservation = new System.Windows.Forms.Button();
            this.img_Clock = new System.Windows.Forms.PictureBox();
            this.lbl_AvailableTime = new System.Windows.Forms.Label();
            this.img_Splitter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_Clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Splitter)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_PlaceReservation
            // 
            this.btn_PlaceReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PlaceReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_PlaceReservation.FlatAppearance.BorderSize = 0;
            this.btn_PlaceReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlaceReservation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_PlaceReservation.ForeColor = System.Drawing.Color.White;
            this.btn_PlaceReservation.Location = new System.Drawing.Point(143, 64);
            this.btn_PlaceReservation.Name = "btn_PlaceReservation";
            this.btn_PlaceReservation.Size = new System.Drawing.Size(162, 39);
            this.btn_PlaceReservation.TabIndex = 0;
            this.btn_PlaceReservation.Text = "Reserve";
            this.btn_PlaceReservation.UseVisualStyleBackColor = false;
            this.btn_PlaceReservation.Click += new System.EventHandler(this.btn_PlaceReservation_Click);
            // 
            // img_Clock
            // 
            this.img_Clock.BackColor = System.Drawing.Color.White;
            this.img_Clock.Location = new System.Drawing.Point(37, 12);
            this.img_Clock.Name = "img_Clock";
            this.img_Clock.Size = new System.Drawing.Size(40, 40);
            this.img_Clock.TabIndex = 1;
            this.img_Clock.TabStop = false;
            // 
            // lbl_AvailableTime
            // 
            this.lbl_AvailableTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_AvailableTime.AutoSize = true;
            this.lbl_AvailableTime.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_AvailableTime.ForeColor = System.Drawing.Color.White;
            this.lbl_AvailableTime.Location = new System.Drawing.Point(95, 12);
            this.lbl_AvailableTime.Name = "lbl_AvailableTime";
            this.lbl_AvailableTime.Size = new System.Drawing.Size(210, 44);
            this.lbl_AvailableTime.TabIndex = 2;
            this.lbl_AvailableTime.Text = "00:00 - 01:00";
            // 
            // img_Splitter
            // 
            this.img_Splitter.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.img_Splitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(100)))), ((int)(((byte)(119)))));
            this.img_Splitter.Location = new System.Drawing.Point(10, 118);
            this.img_Splitter.Margin = new System.Windows.Forms.Padding(0);
            this.img_Splitter.Name = "img_Splitter";
            this.img_Splitter.Size = new System.Drawing.Size(300, 2);
            this.img_Splitter.TabIndex = 3;
            this.img_Splitter.TabStop = false;
            // 
            // C_Available_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.lbl_AvailableTime);
            this.Controls.Add(this.img_Clock);
            this.Controls.Add(this.btn_PlaceReservation);
            this.Controls.Add(this.img_Splitter);
            this.Name = "C_Available_Reservation";
            this.Size = new System.Drawing.Size(320, 120);
            ((System.ComponentModel.ISupportInitialize)(this.img_Clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Splitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PlaceReservation;
        private System.Windows.Forms.PictureBox img_Clock;
        private System.Windows.Forms.Label lbl_AvailableTime;
        private System.Windows.Forms.PictureBox img_Splitter;
    }
}
