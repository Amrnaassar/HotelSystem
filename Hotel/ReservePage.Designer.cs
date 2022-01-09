namespace Hotel
{
    partial class ReservePage
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
            this.id = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Roomnum = new System.Windows.Forms.TextBox();
            this.days = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.labelname = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labelphone = new System.Windows.Forms.Label();
            this.labelroom = new System.Windows.Forms.Label();
            this.labelday = new System.Windows.Forms.Label();
            this.DoReserve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(363, 143);
            this.id.Margin = new System.Windows.Forms.Padding(4);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(330, 42);
            this.id.TabIndex = 0;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(363, 210);
            this.Phone.Margin = new System.Windows.Forms.Padding(4);
            this.Phone.Multiline = true;
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(330, 42);
            this.Phone.TabIndex = 1;
            // 
            // Roomnum
            // 
            this.Roomnum.Location = new System.Drawing.Point(363, 272);
            this.Roomnum.Margin = new System.Windows.Forms.Padding(4);
            this.Roomnum.Multiline = true;
            this.Roomnum.Name = "Roomnum";
            this.Roomnum.Size = new System.Drawing.Size(330, 42);
            this.Roomnum.TabIndex = 2;
            // 
            // days
            // 
            this.days.Location = new System.Drawing.Point(363, 343);
            this.days.Margin = new System.Windows.Forms.Padding(4);
            this.days.Multiline = true;
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(330, 42);
            this.days.TabIndex = 3;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(363, 80);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(330, 42);
            this.name.TabIndex = 4;
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelname.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelname.Location = new System.Drawing.Point(160, 95);
            this.labelname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(84, 33);
            this.labelname.TabIndex = 5;
            this.labelname.Text = "Name";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelid.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelid.Location = new System.Drawing.Point(160, 158);
            this.labelid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(43, 33);
            this.labelid.TabIndex = 6;
            this.labelid.Text = "ID";
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelphone.Font = new System.Drawing.Font("Tahoma", 16F);
            this.labelphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelphone.Location = new System.Drawing.Point(160, 225);
            this.labelphone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(189, 33);
            this.labelphone.TabIndex = 7;
            this.labelphone.Text = "Phone number";
            this.labelphone.Click += new System.EventHandler(this.labelphone_Click);
            // 
            // labelroom
            // 
            this.labelroom.AutoSize = true;
            this.labelroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelroom.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelroom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelroom.Location = new System.Drawing.Point(160, 287);
            this.labelroom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelroom.Name = "labelroom";
            this.labelroom.Size = new System.Drawing.Size(163, 29);
            this.labelroom.TabIndex = 8;
            this.labelroom.Text = "Room number";
            // 
            // labelday
            // 
            this.labelday.AutoSize = true;
            this.labelday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelday.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelday.Location = new System.Drawing.Point(160, 358);
            this.labelday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelday.Name = "labelday";
            this.labelday.Size = new System.Drawing.Size(172, 29);
            this.labelday.TabIndex = 9;
            this.labelday.Text = "Number of day";
            // 
            // DoReserve
            // 
            this.DoReserve.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.DoReserve.Location = new System.Drawing.Point(439, 434);
            this.DoReserve.Margin = new System.Windows.Forms.Padding(4);
            this.DoReserve.Name = "DoReserve";
            this.DoReserve.Size = new System.Drawing.Size(186, 46);
            this.DoReserve.TabIndex = 10;
            this.DoReserve.Text = "Submit";
            this.DoReserve.UseVisualStyleBackColor = true;
            this.DoReserve.Click += new System.EventHandler(this.DoReserve_Click);
            // 
            // ReservePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel.Properties.Resources.images__15_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.DoReserve);
            this.Controls.Add(this.labelday);
            this.Controls.Add(this.labelroom);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.days);
            this.Controls.Add(this.Roomnum);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.id);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservePage";
            this.Text = "ReservePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Roomnum;
        private System.Windows.Forms.TextBox days;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.Label labelroom;
        private System.Windows.Forms.Label labelday;
        private System.Windows.Forms.Button DoReserve;
    }
}