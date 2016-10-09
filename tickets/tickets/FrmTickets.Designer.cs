namespace tickets
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
            this.BtnTickets = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnTickets
            // 
            this.BtnTickets.Location = new System.Drawing.Point(73, 144);
            this.BtnTickets.Name = "BtnTickets";
            this.BtnTickets.Size = new System.Drawing.Size(148, 30);
            this.BtnTickets.TabIndex = 0;
            this.BtnTickets.Text = "Determine Ticket Price";
            this.BtnTickets.UseVisualStyleBackColor = true;
            this.BtnTickets.Click += new System.EventHandler(this.BtnTickets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ticket Price";
            // 
            // TxtBoxAge
            // 
            this.TxtBoxAge.Location = new System.Drawing.Point(135, 50);
            this.TxtBoxAge.Name = "TxtBoxAge";
            this.TxtBoxAge.Size = new System.Drawing.Size(39, 20);
            this.TxtBoxAge.TabIndex = 3;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(169, 76);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(70, 20);
            this.txtBoxPrice.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.TxtBoxAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnTickets);
            this.Name = "Form1";
            this.Text = "Tickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxAge;
        private System.Windows.Forms.TextBox txtBoxPrice;
    }
}

