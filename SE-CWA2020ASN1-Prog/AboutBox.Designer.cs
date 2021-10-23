
namespace SE_CWA2020ASN1_Prog
{
    partial class AboutBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.lbl_Version = new System.Windows.Forms.Label();
            this.lbl_Copyright = new System.Windows.Forms.Label();
            this.lbl_CompanyName = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lbl_ProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lbl_Version, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lbl_Copyright, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.lbl_CompanyName, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.txt_Description, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(14, 14);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(624, 407);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(4, 5);
            this.logoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(197, 397);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ProductName.Location = new System.Drawing.Point(214, 0);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.lbl_ProductName.MaximumSize = new System.Drawing.Size(0, 26);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(406, 26);
            this.lbl_ProductName.TabIndex = 19;
            this.lbl_ProductName.Text = "Product Name: Inspection Form";
            this.lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Version
            // 
            this.lbl_Version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Version.Location = new System.Drawing.Point(214, 40);
            this.lbl_Version.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.lbl_Version.MaximumSize = new System.Drawing.Size(0, 26);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(406, 26);
            this.lbl_Version.TabIndex = 0;
            this.lbl_Version.Text = "Version: 1.0.1";
            this.lbl_Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Copyright
            // 
            this.lbl_Copyright.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Copyright.Location = new System.Drawing.Point(214, 80);
            this.lbl_Copyright.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.lbl_Copyright.MaximumSize = new System.Drawing.Size(0, 26);
            this.lbl_Copyright.Name = "lbl_Copyright";
            this.lbl_Copyright.Size = new System.Drawing.Size(406, 26);
            this.lbl_Copyright.TabIndex = 21;
            this.lbl_Copyright.Text = "Copyright: ©Edwin James Group 2020";
            this.lbl_Copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CompanyName.Location = new System.Drawing.Point(214, 120);
            this.lbl_CompanyName.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.lbl_CompanyName.MaximumSize = new System.Drawing.Size(0, 26);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(406, 26);
            this.lbl_CompanyName.TabIndex = 22;
            this.lbl_CompanyName.Text = "Company Name: Musk Process Services";
            this.lbl_CompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Description
            // 
            this.txt_Description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Description.Location = new System.Drawing.Point(214, 165);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(9, 5, 4, 5);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Description.Size = new System.Drawing.Size(406, 193);
            this.txt_Description.TabIndex = 23;
            this.txt_Description.TabStop = false;
            this.txt_Description.Text = resources.GetString("txt_Description.Text");
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.okButton.Location = new System.Drawing.Point(508, 368);
            this.okButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(112, 34);
            this.okButton.TabIndex = 24;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // AboutBox
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 435);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.Padding = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.Label lbl_Version;
        private System.Windows.Forms.Label lbl_Copyright;
        private System.Windows.Forms.Label lbl_CompanyName;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Button okButton;
    }
}
