namespace Wages
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblHoursWorked = new System.Windows.Forms.Label();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbHourlyRate = new System.Windows.Forms.TextBox();
            this.txtbHoursWorked = new System.Windows.Forms.TextBox();
            this.btnCalulate = new System.Windows.Forms.Button();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.txtbGrossPay = new System.Windows.Forms.TextBox();
            this.txtbTaxes = new System.Windows.Forms.TextBox();
            this.txtbNetPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(7, 7);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(125, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Please enter your details:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(11, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Location = new System.Drawing.Point(12, 58);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(66, 13);
            this.lblHourlyRate.TabIndex = 2;
            this.lblHourlyRate.Text = "Hourly Rate:";
            // 
            // lblHoursWorked
            // 
            this.lblHoursWorked.AutoSize = true;
            this.lblHoursWorked.Location = new System.Drawing.Point(13, 83);
            this.lblHoursWorked.Name = "lblHoursWorked";
            this.lblHoursWorked.Size = new System.Drawing.Size(79, 13);
            this.lblHoursWorked.TabIndex = 3;
            this.lblHoursWorked.Text = "Hours Worked:";
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(79, 33);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(135, 20);
            this.txtbName.TabIndex = 4;
            // 
            // txtbHourlyRate
            // 
            this.txtbHourlyRate.Location = new System.Drawing.Point(154, 58);
            this.txtbHourlyRate.Name = "txtbHourlyRate";
            this.txtbHourlyRate.Size = new System.Drawing.Size(59, 20);
            this.txtbHourlyRate.TabIndex = 5;
            // 
            // txtbHoursWorked
            // 
            this.txtbHoursWorked.Location = new System.Drawing.Point(154, 85);
            this.txtbHoursWorked.Name = "txtbHoursWorked";
            this.txtbHoursWorked.Size = new System.Drawing.Size(59, 20);
            this.txtbHoursWorked.TabIndex = 6;
            // 
            // btnCalulate
            // 
            this.btnCalulate.Location = new System.Drawing.Point(27, 124);
            this.btnCalulate.Name = "btnCalulate";
            this.btnCalulate.Size = new System.Drawing.Size(238, 32);
            this.btnCalulate.TabIndex = 7;
            this.btnCalulate.Text = "Calculate";
            this.btnCalulate.UseVisualStyleBackColor = true;
            this.btnCalulate.Click += new System.EventHandler(this.btnCalulate_Click);
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Location = new System.Drawing.Point(25, 186);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(58, 13);
            this.lblGrossPay.TabIndex = 8;
            this.lblGrossPay.Text = "Gross Pay:";
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(24, 209);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(78, 13);
            this.lblTaxes.TabIndex = 9;
            this.lblTaxes.Text = "How much tax:";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(26, 231);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(48, 13);
            this.lblNetPay.TabIndex = 10;
            this.lblNetPay.Text = "Net Pay:";
            // 
            // txtbGrossPay
            // 
            this.txtbGrossPay.Location = new System.Drawing.Point(122, 179);
            this.txtbGrossPay.Name = "txtbGrossPay";
            this.txtbGrossPay.Size = new System.Drawing.Size(92, 20);
            this.txtbGrossPay.TabIndex = 11;
            // 
            // txtbTaxes
            // 
            this.txtbTaxes.Location = new System.Drawing.Point(122, 204);
            this.txtbTaxes.Name = "txtbTaxes";
            this.txtbTaxes.Size = new System.Drawing.Size(92, 20);
            this.txtbTaxes.TabIndex = 12;
            // 
            // txtbNetPay
            // 
            this.txtbNetPay.Location = new System.Drawing.Point(122, 228);
            this.txtbNetPay.Name = "txtbNetPay";
            this.txtbNetPay.Size = new System.Drawing.Size(92, 20);
            this.txtbNetPay.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 278);
            this.Controls.Add(this.txtbNetPay);
            this.Controls.Add(this.txtbTaxes);
            this.Controls.Add(this.txtbGrossPay);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.lblTaxes);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.btnCalulate);
            this.Controls.Add(this.txtbHoursWorked);
            this.Controls.Add(this.txtbHourlyRate);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.lblHoursWorked);
            this.Controls.Add(this.lblHourlyRate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDesc);
            this.Name = "Form1";
            this.Text = "Wage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblHoursWorked;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbHourlyRate;
        private System.Windows.Forms.TextBox txtbHoursWorked;
        private System.Windows.Forms.Button btnCalulate;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.TextBox txtbGrossPay;
        private System.Windows.Forms.TextBox txtbTaxes;
        private System.Windows.Forms.TextBox txtbNetPay;
    }
}

