namespace HowMuchMarkUp
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
            this.lblItemCost = new System.Windows.Forms.Label();
            this.lblItemSell = new System.Windows.Forms.Label();
            this.txtbItemCost = new System.Windows.Forms.TextBox();
            this.txtbItemSell = new System.Windows.Forms.TextBox();
            this.txtbPercent = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblBeenCharged = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(33, 16);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(214, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "How much mark up are you being charged?";
            // 
            // lblItemCost
            // 
            this.lblItemCost.AutoSize = true;
            this.lblItemCost.Location = new System.Drawing.Point(40, 61);
            this.lblItemCost.Name = "lblItemCost";
            this.lblItemCost.Size = new System.Drawing.Size(51, 13);
            this.lblItemCost.TabIndex = 1;
            this.lblItemCost.Text = "Item Cost";
            // 
            // lblItemSell
            // 
            this.lblItemSell.AutoSize = true;
            this.lblItemSell.Location = new System.Drawing.Point(168, 61);
            this.lblItemSell.Name = "lblItemSell";
            this.lblItemSell.Size = new System.Drawing.Size(47, 13);
            this.lblItemSell.TabIndex = 2;
            this.lblItemSell.Text = "Item Sell";
            this.lblItemSell.Click += new System.EventHandler(this.lblItemSell_Click);
            // 
            // txtbItemCost
            // 
            this.txtbItemCost.Location = new System.Drawing.Point(43, 89);
            this.txtbItemCost.Name = "txtbItemCost";
            this.txtbItemCost.Size = new System.Drawing.Size(47, 20);
            this.txtbItemCost.TabIndex = 3;
            // 
            // txtbItemSell
            // 
            this.txtbItemSell.Location = new System.Drawing.Point(166, 88);
            this.txtbItemSell.Name = "txtbItemSell";
            this.txtbItemSell.Size = new System.Drawing.Size(48, 20);
            this.txtbItemSell.TabIndex = 4;
            // 
            // txtbPercent
            // 
            this.txtbPercent.Location = new System.Drawing.Point(97, 178);
            this.txtbPercent.Name = "txtbPercent";
            this.txtbPercent.Size = new System.Drawing.Size(62, 20);
            this.txtbPercent.TabIndex = 5;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(97, 121);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(62, 27);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblBeenCharged
            // 
            this.lblBeenCharged.AutoSize = true;
            this.lblBeenCharged.Location = new System.Drawing.Point(33, 162);
            this.lblBeenCharged.Name = "lblBeenCharged";
            this.lblBeenCharged.Size = new System.Drawing.Size(194, 13);
            this.lblBeenCharged.TabIndex = 7;
            this.lblBeenCharged.Text = "You\'ve been charged the mark up % of:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblBeenCharged);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtbPercent);
            this.Controls.Add(this.txtbItemSell);
            this.Controls.Add(this.txtbItemCost);
            this.Controls.Add(this.lblItemSell);
            this.Controls.Add(this.lblItemCost);
            this.Controls.Add(this.lblDesc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblItemCost;
        private System.Windows.Forms.Label lblItemSell;
        private System.Windows.Forms.TextBox txtbItemCost;
        private System.Windows.Forms.TextBox txtbItemSell;
        private System.Windows.Forms.TextBox txtbPercent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblBeenCharged;
    }
}

