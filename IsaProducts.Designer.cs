namespace BankManagement
{
    partial class IsaProducts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IsaProducts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgIsa = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIsaTranAllow = new System.Windows.Forms.ComboBox();
            this.btnIsaSave = new System.Windows.Forms.Button();
            this.cbIsaStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIsaTfr = new System.Windows.Forms.TextBox();
            this.txtIsaProduct = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIsa)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(45)))), ((int)(((byte)(72)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 712);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(14, 665);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 34);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(18, 715);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 34);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(102, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISA PRODUCTS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dtgIsa);
            this.panel3.Location = new System.Drawing.Point(308, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(982, 502);
            this.panel3.TabIndex = 3;
            // 
            // dtgIsa
            // 
            this.dtgIsa.BackgroundColor = System.Drawing.Color.White;
            this.dtgIsa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIsa.Location = new System.Drawing.Point(0, 9);
            this.dtgIsa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgIsa.MultiSelect = false;
            this.dtgIsa.Name = "dtgIsa";
            this.dtgIsa.ReadOnly = true;
            this.dtgIsa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgIsa.ShowEditingIcon = false;
            this.dtgIsa.Size = new System.Drawing.Size(982, 492);
            this.dtgIsa.TabIndex = 1;
            this.dtgIsa.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgIsa_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIsaTranAllow);
            this.groupBox1.Controls.Add(this.btnIsaSave);
            this.groupBox1.Controls.Add(this.cbIsaStatus);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIsaTfr);
            this.groupBox1.Controls.Add(this.txtIsaProduct);
            this.groupBox1.Location = new System.Drawing.Point(309, 523);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(981, 175);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ISA Product";
            // 
            // cbIsaTranAllow
            // 
            this.cbIsaTranAllow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsaTranAllow.FormattingEnabled = true;
            this.cbIsaTranAllow.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cbIsaTranAllow.Location = new System.Drawing.Point(580, 28);
            this.cbIsaTranAllow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIsaTranAllow.Name = "cbIsaTranAllow";
            this.cbIsaTranAllow.Size = new System.Drawing.Size(180, 28);
            this.cbIsaTranAllow.TabIndex = 10;
            // 
            // btnIsaSave
            // 
            this.btnIsaSave.Location = new System.Drawing.Point(820, 29);
            this.btnIsaSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIsaSave.Name = "btnIsaSave";
            this.btnIsaSave.Size = new System.Drawing.Size(112, 35);
            this.btnIsaSave.TabIndex = 9;
            this.btnIsaSave.Text = "Save";
            this.btnIsaSave.UseVisualStyleBackColor = true;
            this.btnIsaSave.Click += new System.EventHandler(this.btnIsaSave_Click);
            // 
            // cbIsaStatus
            // 
            this.cbIsaStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsaStatus.FormattingEnabled = true;
            this.cbIsaStatus.Items.AddRange(new object[] {
            "Open",
            "Close"});
            this.cbIsaStatus.Location = new System.Drawing.Point(160, 82);
            this.cbIsaStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIsaStatus.Name = "cbIsaStatus";
            this.cbIsaStatus.Size = new System.Drawing.Size(180, 28);
            this.cbIsaStatus.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tax Free Rate %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transfer Allowed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product";
            // 
            // txtIsaTfr
            // 
            this.txtIsaTfr.Location = new System.Drawing.Point(580, 83);
            this.txtIsaTfr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIsaTfr.Name = "txtIsaTfr";
            this.txtIsaTfr.Size = new System.Drawing.Size(180, 26);
            this.txtIsaTfr.TabIndex = 3;
            this.txtIsaTfr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIsaTfr_KeyPress);
            this.txtIsaTfr.Validating += new System.ComponentModel.CancelEventHandler(this.txtIsaTfr_Validating);
            // 
            // txtIsaProduct
            // 
            this.txtIsaProduct.Location = new System.Drawing.Point(160, 29);
            this.txtIsaProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIsaProduct.Name = "txtIsaProduct";
            this.txtIsaProduct.ReadOnly = true;
            this.txtIsaProduct.Size = new System.Drawing.Size(180, 26);
            this.txtIsaProduct.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // IsaProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1302, 712);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IsaProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ISA Products";
            this.Load += new System.EventHandler(this.IsaProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgIsa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgIsa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIsaSave;
        private System.Windows.Forms.ComboBox cbIsaStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIsaTfr;
        private System.Windows.Forms.TextBox txtIsaProduct;
        private System.Windows.Forms.ComboBox cbIsaTranAllow;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}