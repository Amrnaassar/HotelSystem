namespace Hotel
{
    partial class Booking
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Reserve = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.ShowRooms = new System.Windows.Forms.Button();
            this.Roomprice = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reserve
            // 
            this.Reserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Reserve.Location = new System.Drawing.Point(341, 26);
            this.Reserve.Margin = new System.Windows.Forms.Padding(4);
            this.Reserve.Name = "Reserve";
            this.Reserve.Size = new System.Drawing.Size(333, 85);
            this.Reserve.TabIndex = 0;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseVisualStyleBackColor = true;
            this.Reserve.Click += new System.EventHandler(this.Reserve_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(341, 161);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(333, 89);
            this.cancel.TabIndex = 1;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ShowRooms
            // 
            this.ShowRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRooms.Location = new System.Drawing.Point(341, 325);
            this.ShowRooms.Margin = new System.Windows.Forms.Padding(4);
            this.ShowRooms.Name = "ShowRooms";
            this.ShowRooms.Size = new System.Drawing.Size(333, 70);
            this.ShowRooms.TabIndex = 2;
            this.ShowRooms.Text = "Show avalible room";
            this.ShowRooms.UseVisualStyleBackColor = true;
            this.ShowRooms.Click += new System.EventHandler(this.ShowRooms_Click);
            // 
            // Roomprice
            // 
            this.Roomprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roomprice.Location = new System.Drawing.Point(341, 443);
            this.Roomprice.Margin = new System.Windows.Forms.Padding(4);
            this.Roomprice.Name = "Roomprice";
            this.Roomprice.Size = new System.Drawing.Size(333, 76);
            this.Roomprice.TabIndex = 3;
            this.Roomprice.Text = "Price of Room";
            this.Roomprice.UseVisualStyleBackColor = true;
            this.Roomprice.Click += new System.EventHandler(this.Roomprice_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Hotel.Properties.Resources.images__12_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Roomprice);
            this.panel1.Controls.Add(this.ShowRooms);
            this.panel1.Controls.Add(this.Reserve);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 589);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 593);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Booking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Reserve;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button ShowRooms;
        private System.Windows.Forms.Button Roomprice;
        private System.Windows.Forms.Panel panel1;
    }
}