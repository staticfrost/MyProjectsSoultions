namespace RefloorCost
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtbLength = new System.Windows.Forms.TextBox();
            this.txtbWidth = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.lblPricePerMeter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(36, 9);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(201, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Cost $12per Sq Meter to refloor in carpet ";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(31, 48);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(82, 13);
            this.lblLength.TabIndex = 1;
            this.lblLength.Text = "Enter the length";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(159, 48);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(78, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Enter the width";
            // 
            // txtbLength
            // 
            this.txtbLength.Location = new System.Drawing.Point(54, 76);
            this.txtbLength.Name = "txtbLength";
            this.txtbLength.Size = new System.Drawing.Size(41, 20);
            this.txtbLength.TabIndex = 3;
            // 
            // txtbWidth
            // 
            this.txtbWidth.Location = new System.Drawing.Point(179, 76);
            this.txtbWidth.Name = "txtbWidth";
            this.txtbWidth.Size = new System.Drawing.Size(42, 20);
            this.txtbWidth.TabIndex = 4;
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(114, 187);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(48, 20);
            this.txtbPrice.TabIndex = 5;
            // 
            // lblPricePerMeter
            // 
            this.lblPricePerMeter.AutoSize = true;
            this.lblPricePerMeter.Location = new System.Drawing.Point(79, 160);
            this.lblPricePerMeter.Name = "lblPricePerMeter";
            this.lblPricePerMeter.Size = new System.Drawing.Size(136, 13);
            this.lblPricePerMeter.TabIndex = 6;
            this.lblPricePerMeter.Text = "Price for the refloor will cost";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(63, 107);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(143, 40);
            this.btnCalculate.TabIndex = 7;
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
            this.Controls.Add(this.lblPricePerMeter);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.txtbWidth);
            this.Controls.Add(this.txtbLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblDesc);
            this.Name = "Form1";
            this.Text = "Refloor Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtbLength;
        private System.Windows.Forms.TextBox txtbWidth;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.Label lblPricePerMeter;
        private System.Windows.Forms.Button btnCalculate;
    }
}

