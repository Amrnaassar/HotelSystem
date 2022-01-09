namespace Hotel
{
    partial class PricePage
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
            this.DoPrice = new System.Windows.Forms.Button();
            this.BoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DoPrice
            // 
            this.DoPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoPrice.Location = new System.Drawing.Point(152, 359);
            this.DoPrice.Margin = new System.Windows.Forms.Padding(4);
            this.DoPrice.Name = "DoPrice";
            this.DoPrice.Size = new System.Drawing.Size(201, 47);
            this.DoPrice.TabIndex = 5;
            this.DoPrice.Text = "Show Price";
            this.DoPrice.UseVisualStyleBackColor = true;
            this.DoPrice.Click += new System.EventHandler(this.DoPrice_Click);
            // 
            // BoxPrice
            // 
            this.BoxPrice.Location = new System.Drawing.Point(108, 236);
            this.BoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.BoxPrice.Multiline = true;
            this.BoxPrice.Name = "BoxPrice";
            this.BoxPrice.Size = new System.Drawing.Size(328, 46);
            this.BoxPrice.TabIndex = 4;
            this.BoxPrice.TextChanged += new System.EventHandler(this.BoxPrice_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelPrice.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelPrice.Location = new System.Drawing.Point(113, 109);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(323, 36);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Enter Room Number";
            this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // PricePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hotel.Properties.Resources.images__14_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(531, 508);
            this.Controls.Add(this.DoPrice);
            this.Controls.Add(this.BoxPrice);
            this.Controls.Add(this.labelPrice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PricePage";
            this.Text = "PricePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DoPrice;
        private System.Windows.Forms.TextBox BoxPrice;
        private System.Windows.Forms.Label labelPrice;
    }
}