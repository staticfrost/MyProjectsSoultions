namespace PricePerKG
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtbKG = new System.Windows.Forms.TextBox();
            this.lblHowManyKG = new System.Windows.Forms.Label();
            this.lblPricePerKG = new System.Windows.Forms.Label();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(77, 3);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(116, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Get ya cold meats here";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(206, 115);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(68, 20);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtbKG
            // 
            this.txtbKG.Location = new System.Drawing.Point(115, 50);
            this.txtbKG.Name = "txtbKG";
            this.txtbKG.Size = new System.Drawing.Size(40, 20);
            this.txtbKG.TabIndex = 2;
            // 
            // lblHowManyKG
            // 
            this.lblHowManyKG.AutoSize = true;
            this.lblHowManyKG.Location = new System.Drawing.Point(66, 30);
            this.lblHowManyKG.Name = "lblHowManyKG";
            this.lblHowManyKG.Size = new System.Drawing.Size(147, 13);
            this.lblHowManyKG.TabIndex = 3;
            this.lblHowManyKG.Text = "How many KG of cold meats?";
            // 
            // lblPricePerKG
            // 
            this.lblPricePerKG.AutoSize = true;
            this.lblPricePerKG.Location = new System.Drawing.Point(72, 79);
            this.lblPricePerKG.Name = "lblPricePerKG";
            this.lblPricePerKG.Size = new System.Drawing.Size(133, 13);
            this.lblPricePerKG.TabIndex = 4;
            this.lblPricePerKG.Text = "That will be $16.91 per KG";
            // 
            // txtbTotal
            // 
            this.txtbTotal.Location = new System.Drawing.Point(146, 115);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.Size = new System.Drawing.Size(44, 20);
            this.txtbTotal.TabIndex = 5;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 118);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(119, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "That comes to a total of";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.lblPricePerKG);
            this.Controls.Add(this.lblHowManyKG);
            this.Controls.Add(this.txtbKG);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDesc);
            this.Name = "Form1";
            this.Text = "Price Per KG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtbKG;
        private System.Windows.Forms.Label lblHowManyKG;
        private System.Windows.Forms.Label lblPricePerKG;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.Label lblTotal;
    }
}

