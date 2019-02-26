namespace BankManagement
{
    partial class ShowAccount
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
            this.txtIdShow = new System.Windows.Forms.TextBox();
            this.txtNameShow = new System.Windows.Forms.TextBox();
            this.txtSurnameShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtIdShow
            // 
            this.txtIdShow.Location = new System.Drawing.Point(121, 61);
            this.txtIdShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdShow.Name = "txtIdShow";
            this.txtIdShow.Size = new System.Drawing.Size(68, 20);
            this.txtIdShow.TabIndex = 0;
            this.txtIdShow.TextChanged += new System.EventHandler(this.txtIdShow_TextChanged);
            // 
            // txtNameShow
            // 
            this.txtNameShow.Location = new System.Drawing.Point(121, 93);
            this.txtNameShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNameShow.Name = "txtNameShow";
            this.txtNameShow.Size = new System.Drawing.Size(68, 20);
            this.txtNameShow.TabIndex = 1;
            // 
            // txtSurnameShow
            // 
            this.txtSurnameShow.Location = new System.Drawing.Point(121, 127);
            this.txtSurnameShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSurnameShow.Name = "txtSurnameShow";
            this.txtSurnameShow.Size = new System.Drawing.Size(68, 20);
            this.txtSurnameShow.TabIndex = 2;
            // 
            // ShowAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.txtSurnameShow);
            this.Controls.Add(this.txtNameShow);
            this.Controls.Add(this.txtIdShow);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ShowAccount";
            this.Text = "ShowAccount";
            this.Load += new System.EventHandler(this.ShowAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdShow;
        private System.Windows.Forms.TextBox txtNameShow;
        private System.Windows.Forms.TextBox txtSurnameShow;
    }
}