namespace Commission
{
    partial class Form1
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtbSalesAmt = new System.Windows.Forms.TextBox();
            this.txtbCommision = new System.Windows.Forms.TextBox();
            this.lblCommision = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(19, 22);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(120, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Enter your sales amount";
            // 
            // txtbSalesAmt
            // 
            this.txtbSalesAmt.Location = new System.Drawing.Point(42, 47);
            this.txtbSalesAmt.Name = "txtbSalesAmt";
            this.txtbSalesAmt.Size = new System.Drawing.Size(71, 20);
            this.txtbSalesAmt.TabIndex = 1;
            // 
            // txtbCommision
            // 
            this.txtbCommision.Location = new System.Drawing.Point(36, 177);
            this.txtbCommision.Name = "txtbCommision";
            this.txtbCommision.Size = new System.Drawing.Size(77, 20);
            this.txtbCommision.TabIndex = 2;
            // 
            // lblCommision
            // 
            this.lblCommision.AutoSize = true;
            this.lblCommision.Location = new System.Drawing.Point(30, 156);
            this.lblCommision.Name = "lblCommision";
            this.lblCommision.Size = new System.Drawing.Size(157, 13);
            this.lblCommision.TabIndex = 3;
            this.lblCommision.Text = "14% commision on your sales is:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(39, 100);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(73, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblCommision);
            this.Controls.Add(this.txtbCommision);
            this.Controls.Add(this.txtbSalesAmt);
            this.Controls.Add(this.lblDesc);
            this.Name = "Form1";
            this.Text = "Commission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtbSalesAmt;
        private System.Windows.Forms.TextBox txtbCommision;
        private System.Windows.Forms.Label lblCommision;
        private System.Windows.Forms.Button btnCalculate;
    }
}

