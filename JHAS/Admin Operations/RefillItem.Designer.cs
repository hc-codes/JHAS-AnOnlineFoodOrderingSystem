
namespace JHAS
{
    partial class RefillItem
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblViewOrders = new System.Windows.Forms.Label();
            this.btnRefill = new System.Windows.Forms.Button();
            this.lblItemQuantity = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.panel3.Controls.Add(this.lblViewOrders);
            this.panel3.Location = new System.Drawing.Point(-2, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 95);
            this.panel3.TabIndex = 7;
            // 
            // lblViewOrders
            // 
            this.lblViewOrders.AutoSize = true;
            this.lblViewOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewOrders.ForeColor = System.Drawing.Color.White;
            this.lblViewOrders.Location = new System.Drawing.Point(347, 37);
            this.lblViewOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewOrders.Name = "lblViewOrders";
            this.lblViewOrders.Size = new System.Drawing.Size(180, 29);
            this.lblViewOrders.TabIndex = 2;
            this.lblViewOrders.Text = "REFILL ITEMS";
            // 
            // btnRefill
            // 
            this.btnRefill.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefill.Location = new System.Drawing.Point(428, 321);
            this.btnRefill.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(100, 28);
            this.btnRefill.TabIndex = 21;
            this.btnRefill.Text = "Refill";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // lblItemQuantity
            // 
            this.lblItemQuantity.AutoSize = true;
            this.lblItemQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemQuantity.Location = new System.Drawing.Point(236, 229);
            this.lblItemQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemQuantity.Name = "lblItemQuantity";
            this.lblItemQuantity.Size = new System.Drawing.Size(76, 22);
            this.lblItemQuantity.TabIndex = 19;
            this.lblItemQuantity.Text = "Quantity";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(236, 168);
            this.lblItemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(96, 22);
            this.lblItemName.TabIndex = 17;
            this.lblItemName.Text = "Item Name";
            // 
            // cbItems
            // 
            this.cbItems.FormattingEnabled = true;
            this.cbItems.Location = new System.Drawing.Point(371, 166);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(192, 24);
            this.cbItems.TabIndex = 22;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged);
            // 
            // nudQuantity
            // 
            this.nudQuantity.Location = new System.Drawing.Point(371, 228);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(192, 22);
            this.nudQuantity.TabIndex = 23;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RefillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.cbItems);
            this.Controls.Add(this.btnRefill);
            this.Controls.Add(this.lblItemQuantity);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.panel3);
            this.Name = "RefillItem";
            this.Size = new System.Drawing.Size(845, 558);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblViewOrders;
        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Label lblItemQuantity;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.ComboBox cbItems;
        private System.Windows.Forms.NumericUpDown nudQuantity;
    }
}
