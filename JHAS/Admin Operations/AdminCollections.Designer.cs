
namespace JHAS
{
    partial class AdminCollections
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
            this.lblCollection = new System.Windows.Forms.Label();
            this.dgvCollections = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(149)))), ((int)(((byte)(136)))));
            this.panel3.Controls.Add(this.lblCollection);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(845, 95);
            this.panel3.TabIndex = 10;
            // 
            // lblCollection
            // 
            this.lblCollection.AutoSize = true;
            this.lblCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollection.ForeColor = System.Drawing.Color.White;
            this.lblCollection.Location = new System.Drawing.Point(298, 38);
            this.lblCollection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCollection.Name = "lblCollection";
            this.lblCollection.Size = new System.Drawing.Size(220, 29);
            this.lblCollection.TabIndex = 2;
            this.lblCollection.Text = "Today\'s Collection";
            // 
            // dgvCollections
            // 
            this.dgvCollections.AllowUserToAddRows = false;
            this.dgvCollections.AllowUserToDeleteRows = false;
            this.dgvCollections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCollections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCollections.Location = new System.Drawing.Point(0, 92);
            this.dgvCollections.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCollections.Name = "dgvCollections";
            this.dgvCollections.RowHeadersWidth = 51;
            this.dgvCollections.Size = new System.Drawing.Size(845, 466);
            this.dgvCollections.TabIndex = 11;
            this.dgvCollections.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCollections_CellContentClick);
            // 
            // AdminCollections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCollections);
            this.Controls.Add(this.panel3);
            this.Name = "AdminCollections";
            this.Size = new System.Drawing.Size(845, 558);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCollections)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblCollection;
        private System.Windows.Forms.DataGridView dgvCollections;
    }
}
