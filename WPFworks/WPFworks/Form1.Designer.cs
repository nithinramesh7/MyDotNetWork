
namespace WPFworks
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.principalTextbox = new System.Windows.Forms.TextBox();
            this.RateTextbox = new System.Windows.Forms.TextBox();
            this.periodTextbox = new System.Windows.Forms.TextBox();
            this.interestTextbox = new System.Windows.Forms.TextBox();
            this.AmountTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principal Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rate(p.a)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Period(months)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Interest";
            // 
            // principalTextbox
            // 
            this.principalTextbox.Location = new System.Drawing.Point(235, 81);
            this.principalTextbox.Name = "principalTextbox";
            this.principalTextbox.Size = new System.Drawing.Size(244, 22);
            this.principalTextbox.TabIndex = 4;
            this.principalTextbox.TextChanged += new System.EventHandler(this.principalTextbox_TextChanged);
            // 
            // RateTextbox
            // 
            this.RateTextbox.Location = new System.Drawing.Point(235, 138);
            this.RateTextbox.Name = "RateTextbox";
            this.RateTextbox.Size = new System.Drawing.Size(244, 22);
            this.RateTextbox.TabIndex = 5;
            // 
            // periodTextbox
            // 
            this.periodTextbox.Location = new System.Drawing.Point(235, 203);
            this.periodTextbox.Name = "periodTextbox";
            this.periodTextbox.Size = new System.Drawing.Size(244, 22);
            this.periodTextbox.TabIndex = 6;
            // 
            // interestTextbox
            // 
            this.interestTextbox.Location = new System.Drawing.Point(235, 301);
            this.interestTextbox.Name = "interestTextbox";
            this.interestTextbox.Size = new System.Drawing.Size(244, 22);
            this.interestTextbox.TabIndex = 7;
            // 
            // AmountTextbox
            // 
            this.AmountTextbox.Location = new System.Drawing.Point(235, 357);
            this.AmountTextbox.Name = "AmountTextbox";
            this.AmountTextbox.Size = new System.Drawing.Size(244, 22);
            this.AmountTextbox.TabIndex = 9;
            this.AmountTextbox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(235, 245);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(223, 30);
            this.CalculateBtn.TabIndex = 10;
            this.CalculateBtn.Text = "Calculate Interest";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 430);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.AmountTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.interestTextbox);
            this.Controls.Add(this.periodTextbox);
            this.Controls.Add(this.RateTextbox);
            this.Controls.Add(this.principalTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Interest Calculater";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox principalTextbox;
        private System.Windows.Forms.TextBox RateTextbox;
        private System.Windows.Forms.TextBox periodTextbox;
        private System.Windows.Forms.TextBox interestTextbox;
        private System.Windows.Forms.TextBox AmountTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateBtn;
    }
}

