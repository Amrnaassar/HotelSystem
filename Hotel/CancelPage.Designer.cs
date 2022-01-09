namespace Hotel
{
    partial class CancelPage
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
            this.labelCancel = new System.Windows.Forms.Label();
            this.BoxCancel = new System.Windows.Forms.TextBox();
            this.DoCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCancel
            // 
            this.labelCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCancel.Font = new System.Drawing.Font("Century Schoolbook", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCancel.Location = new System.Drawing.Point(248, 49);
            this.labelCancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCancel.Name = "labelCancel";
            this.labelCancel.Size = new System.Drawing.Size(304, 52);
            this.labelCancel.TabIndex = 0;
            this.labelCancel.Text = "Enter User \'ID\'";
            this.labelCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCancel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // BoxCancel
            // 
            this.BoxCancel.BackColor = System.Drawing.Color.White;
            this.BoxCancel.Location = new System.Drawing.Point(243, 167);
            this.BoxCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BoxCancel.Multiline = true;
            this.BoxCancel.Name = "BoxCancel";
            this.BoxCancel.Size = new System.Drawing.Size(299, 48);
            this.BoxCancel.TabIndex = 1;
            this.BoxCancel.TextChanged += new System.EventHandler(this.BoxCancel_TextChanged);
            // 
            // DoCancel
            // 
            this.DoCancel.BackColor = System.Drawing.Color.Honeydew;
            this.DoCancel.BackgroundImage = global::Hotel.Properties.Resources.images__13_;
            this.DoCancel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.DoCancel.Location = new System.Drawing.Point(282, 288);
            this.DoCancel.Margin = new System.Windows.Forms.Padding(4);
            this.DoCancel.Name = "DoCancel";
            this.DoCancel.Size = new System.Drawing.Size(201, 47);
            this.DoCancel.TabIndex = 2;
            this.DoCancel.Text = "Cancel";
            this.DoCancel.UseVisualStyleBackColor = false;
            this.DoCancel.Click += new System.EventHandler(this.DoCancel_Click);
            // 
            // CancelPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel.Properties.Resources.images__13_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 473);
            this.Controls.Add(this.DoCancel);
            this.Controls.Add(this.BoxCancel);
            this.Controls.Add(this.labelCancel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CancelPage";
            this.Text = "CancelPage";
            this.Load += new System.EventHandler(this.CancelPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCancel;
        private System.Windows.Forms.TextBox BoxCancel;
        private System.Windows.Forms.Button DoCancel;
    }
}