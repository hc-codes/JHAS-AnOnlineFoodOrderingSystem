
namespace JHAS
{
    partial class PaymentForm
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
            this.components = new System.ComponentModel.Container();
            this.rbPay = new System.Windows.Forms.RadioButton();
            this.rbCOD = new System.Windows.Forms.RadioButton();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWalletBalance = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelShow = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbPay
            // 
            this.rbPay.AutoSize = true;
            this.rbPay.Location = new System.Drawing.Point(12, 98);
            this.rbPay.Name = "rbPay";
            this.rbPay.Size = new System.Drawing.Size(84, 21);
            this.rbPay.TabIndex = 32;
            this.rbPay.TabStop = true;
            this.rbPay.Text = "Pay Now";
            this.rbPay.UseVisualStyleBackColor = true;
            // 
            // rbCOD
            // 
            this.rbCOD.AutoSize = true;
            this.rbCOD.Location = new System.Drawing.Point(12, 58);
            this.rbCOD.Name = "rbCOD";
            this.rbCOD.Size = new System.Drawing.Size(59, 21);
            this.rbCOD.TabIndex = 31;
            this.rbCOD.TabStop = true;
            this.rbCOD.Text = "COD";
            this.rbCOD.UseVisualStyleBackColor = true;
            this.rbCOD.CheckedChanged += new System.EventHandler(this.rbCOD_CheckedChanged);
            // 
            // btnContinue
            // 
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnContinue.Location = new System.Drawing.Point(183, 309);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(117, 40);
            this.btnContinue.TabIndex = 33;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 314);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 25);
            this.lblTotal.TabIndex = 34;
            this.lblTotal.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Wallet Balance:";
            // 
            // lblWalletBalance
            // 
            this.lblWalletBalance.AutoSize = true;
            this.lblWalletBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWalletBalance.Location = new System.Drawing.Point(158, 12);
            this.lblWalletBalance.Name = "lblWalletBalance";
            this.lblWalletBalance.Size = new System.Drawing.Size(0, 20);
            this.lblWalletBalance.TabIndex = 38;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.lblPassword);
            this.panelShow.Controls.Add(this.txtPassword);
            this.panelShow.Location = new System.Drawing.Point(1, 144);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(310, 100);
            this.panelShow.TabIndex = 39;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(11, 21);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(0, 18);
            this.lblPassword.TabIndex = 38;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(11, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(283, 26);
            this.txtPassword.TabIndex = 37;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 358);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.lblWalletBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.rbPay);
            this.Controls.Add(this.rbCOD);
            this.Name = "PaymentForm";
            this.Text = "Payment Portal";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPay;
        private System.Windows.Forms.RadioButton rbCOD;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWalletBalance;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}