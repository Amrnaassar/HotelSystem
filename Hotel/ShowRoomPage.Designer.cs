namespace Hotel
{
    partial class ShowRoomPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelAllRoom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowRooms = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SeaShell;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 94);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(893, 462);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelAllRoom
            // 
            this.labelAllRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAllRoom.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelAllRoom.Location = new System.Drawing.Point(13, 8);
            this.labelAllRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAllRoom.Name = "labelAllRoom";
            this.labelAllRoom.Size = new System.Drawing.Size(289, 44);
            this.labelAllRoom.TabIndex = 1;
            this.labelAllRoom.Text = "All Avaliable Room";
            this.labelAllRoom.Click += new System.EventHandler(this.LabelAllRoom_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.ShowRooms);
            this.panel1.Controls.Add(this.labelAllRoom);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(893, 96);
            this.panel1.TabIndex = 2;
            // 
            // ShowRooms
            // 
            this.ShowRooms.Location = new System.Drawing.Point(340, 23);
            this.ShowRooms.Name = "ShowRooms";
            this.ShowRooms.Size = new System.Drawing.Size(206, 49);
            this.ShowRooms.TabIndex = 2;
            this.ShowRooms.Text = "Show Rooms";
            this.ShowRooms.UseVisualStyleBackColor = true;
            this.ShowRooms.Click += new System.EventHandler(this.ShowRooms_Click);
            // 
            // ShowRoomPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowRoomPage";
            this.Text = "ShowRoomPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelAllRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ShowRooms;
    }
}