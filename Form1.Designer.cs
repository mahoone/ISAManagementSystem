﻿namespace BankManagement
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
            this.txtShowCustomers = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtShowCustomers
            // 
            this.txtShowCustomers.Location = new System.Drawing.Point(249, 60);
            this.txtShowCustomers.Name = "txtShowCustomers";
            this.txtShowCustomers.Size = new System.Drawing.Size(286, 71);
            this.txtShowCustomers.TabIndex = 0;
            this.txtShowCustomers.Text = "Show all customers";
            this.txtShowCustomers.UseVisualStyleBackColor = true;
            this.txtShowCustomers.Click += new System.EventHandler(this.txtShowCustomers_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show all customers";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(286, 71);
            this.button3.TabIndex = 2;
            this.button3.Text = "Show all customers";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtShowCustomers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtShowCustomers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
