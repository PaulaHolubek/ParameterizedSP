﻿namespace ParameterizedSP
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
            this.CustomerIdTextBox = new System.Windows.Forms.TextBox();
            this.GetTotalSalesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Id:  ";
            // 
            // CustomerIdTextBox
            // 
            this.CustomerIdTextBox.Location = new System.Drawing.Point(145, 20);
            this.CustomerIdTextBox.Name = "CustomerIdTextBox";
            this.CustomerIdTextBox.Size = new System.Drawing.Size(132, 20);
            this.CustomerIdTextBox.TabIndex = 1;
            // 
            // GetTotalSalesButton
            // 
            this.GetTotalSalesButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetTotalSalesButton.Location = new System.Drawing.Point(16, 62);
            this.GetTotalSalesButton.Name = "GetTotalSalesButton";
            this.GetTotalSalesButton.Size = new System.Drawing.Size(140, 44);
            this.GetTotalSalesButton.TabIndex = 2;
            this.GetTotalSalesButton.Text = "Get Total Sales";
            this.GetTotalSalesButton.UseVisualStyleBackColor = true;
            this.GetTotalSalesButton.Click += new System.EventHandler(this.GetTotalSalesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 3;
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesLabel.Location = new System.Drawing.Point(12, 133);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(13, 19);
            this.TotalSalesLabel.TabIndex = 4;
            this.TotalSalesLabel.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TotalSalesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GetTotalSalesButton);
            this.Controls.Add(this.CustomerIdTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerIdTextBox;
        private System.Windows.Forms.Button GetTotalSalesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalSalesLabel;
    }
}

