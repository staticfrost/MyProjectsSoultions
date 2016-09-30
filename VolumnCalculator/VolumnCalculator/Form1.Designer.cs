namespace VolumnCalculator
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
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.TxtBLength = new System.Windows.Forms.TextBox();
            this.LblLength = new System.Windows.Forms.Label();
            this.LblWidth = new System.Windows.Forms.Label();
            this.TxtBWidth = new System.Windows.Forms.TextBox();
            this.LblHeight = new System.Windows.Forms.Label();
            this.TxtBHeight = new System.Windows.Forms.TextBox();
            this.LblVolume = new System.Windows.Forms.Label();
            this.TxtBAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(65, 85);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(130, 36);
            this.BtnCalculate.TabIndex = 0;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // TxtBLength
            // 
            this.TxtBLength.Location = new System.Drawing.Point(31, 35);
            this.TxtBLength.Name = "TxtBLength";
            this.TxtBLength.Size = new System.Drawing.Size(37, 20);
            this.TxtBLength.TabIndex = 1;
            this.TxtBLength.TextChanged += new System.EventHandler(this.TxtBLength_TextChanged);
            // 
            // LblLength
            // 
            this.LblLength.AutoSize = true;
            this.LblLength.Location = new System.Drawing.Point(28, 19);
            this.LblLength.Name = "LblLength";
            this.LblLength.Size = new System.Drawing.Size(40, 13);
            this.LblLength.TabIndex = 2;
            this.LblLength.Text = "Length";
            // 
            // LblWidth
            // 
            this.LblWidth.AutoSize = true;
            this.LblWidth.Location = new System.Drawing.Point(109, 19);
            this.LblWidth.Name = "LblWidth";
            this.LblWidth.Size = new System.Drawing.Size(35, 13);
            this.LblWidth.TabIndex = 4;
            this.LblWidth.Text = "Width";
            // 
            // TxtBWidth
            // 
            this.TxtBWidth.Location = new System.Drawing.Point(112, 35);
            this.TxtBWidth.Name = "TxtBWidth";
            this.TxtBWidth.Size = new System.Drawing.Size(37, 20);
            this.TxtBWidth.TabIndex = 3;
            this.TxtBWidth.TextChanged += new System.EventHandler(this.TxtBWidth_TextChanged);
            // 
            // LblHeight
            // 
            this.LblHeight.AutoSize = true;
            this.LblHeight.Location = new System.Drawing.Point(197, 19);
            this.LblHeight.Name = "LblHeight";
            this.LblHeight.Size = new System.Drawing.Size(38, 13);
            this.LblHeight.TabIndex = 6;
            this.LblHeight.Text = "Height";
            // 
            // TxtBHeight
            // 
            this.TxtBHeight.Location = new System.Drawing.Point(200, 35);
            this.TxtBHeight.Name = "TxtBHeight";
            this.TxtBHeight.Size = new System.Drawing.Size(37, 20);
            this.TxtBHeight.TabIndex = 5;
            this.TxtBHeight.TextChanged += new System.EventHandler(this.TxtBHeight_TextChanged);
            // 
            // LblVolume
            // 
            this.LblVolume.AutoSize = true;
            this.LblVolume.Location = new System.Drawing.Point(109, 154);
            this.LblVolume.Name = "LblVolume";
            this.LblVolume.Size = new System.Drawing.Size(42, 13);
            this.LblVolume.TabIndex = 7;
            this.LblVolume.Text = "Volume";
            this.LblVolume.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtBAnswer
            // 
            this.TxtBAnswer.Location = new System.Drawing.Point(65, 170);
            this.TxtBAnswer.Name = "TxtBAnswer";
            this.TxtBAnswer.Size = new System.Drawing.Size(130, 20);
            this.TxtBAnswer.TabIndex = 8;
            this.TxtBAnswer.TextChanged += new System.EventHandler(this.TxtBAnswer_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtBAnswer);
            this.Controls.Add(this.LblVolume);
            this.Controls.Add(this.LblHeight);
            this.Controls.Add(this.TxtBHeight);
            this.Controls.Add(this.LblWidth);
            this.Controls.Add(this.TxtBWidth);
            this.Controls.Add(this.LblLength);
            this.Controls.Add(this.TxtBLength);
            this.Controls.Add(this.BtnCalculate);
            this.Name = "Form1";
            this.Text = "Calculate Rectangle Prism Volume";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox TxtBLength;
        private System.Windows.Forms.Label LblLength;
        private System.Windows.Forms.Label LblWidth;
        private System.Windows.Forms.TextBox TxtBWidth;
        private System.Windows.Forms.Label LblHeight;
        private System.Windows.Forms.TextBox TxtBHeight;
        private System.Windows.Forms.Label LblVolume;
        private System.Windows.Forms.TextBox TxtBAnswer;
    }
}

