
namespace SE_CWA2020ASN1_Prog
{
    partial class TestHarness
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
            this.cmb_sitetName = new System.Windows.Forms.ComboBox();
            this.lbl_siteName1 = new System.Windows.Forms.Label();
            this.dtp_dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.rtb_comments = new System.Windows.Forms.RichTextBox();
            this.lbl_comments = new System.Windows.Forms.Label();
            this.txt_inspectorName = new System.Windows.Forms.TextBox();
            this.lbl_inspectorName = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.cbx_interventionType = new System.Windows.Forms.CheckBox();
            this.rtb_results = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cmb_sitetName
            // 
            this.cmb_sitetName.FormattingEnabled = true;
            this.cmb_sitetName.Items.AddRange(new object[] {
            "Mars",
            "Site1",
            "Site2",
            "Site3",
            "Site4"});
            this.cmb_sitetName.Location = new System.Drawing.Point(180, 39);
            this.cmb_sitetName.Name = "cmb_sitetName";
            this.cmb_sitetName.Size = new System.Drawing.Size(121, 28);
            this.cmb_sitetName.TabIndex = 0;
            // 
            // lbl_siteName1
            // 
            this.lbl_siteName1.AutoSize = true;
            this.lbl_siteName1.Location = new System.Drawing.Point(73, 39);
            this.lbl_siteName1.Name = "lbl_siteName1";
            this.lbl_siteName1.Size = new System.Drawing.Size(81, 20);
            this.lbl_siteName1.TabIndex = 1;
            this.lbl_siteName1.Text = "Site name";
            // 
            // dtp_dateTimePicker1
            // 
            this.dtp_dateTimePicker1.Location = new System.Drawing.Point(180, 100);
            this.dtp_dateTimePicker1.Name = "dtp_dateTimePicker1";
            this.dtp_dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dtp_dateTimePicker1.TabIndex = 2;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(73, 106);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(44, 20);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "Date";
            // 
            // rtb_comments
            // 
            this.rtb_comments.Location = new System.Drawing.Point(180, 159);
            this.rtb_comments.Name = "rtb_comments";
            this.rtb_comments.Size = new System.Drawing.Size(200, 58);
            this.rtb_comments.TabIndex = 4;
            this.rtb_comments.Text = "";
            // 
            // lbl_comments
            // 
            this.lbl_comments.AutoSize = true;
            this.lbl_comments.Location = new System.Drawing.Point(73, 197);
            this.lbl_comments.Name = "lbl_comments";
            this.lbl_comments.Size = new System.Drawing.Size(86, 20);
            this.lbl_comments.TabIndex = 5;
            this.lbl_comments.Text = "Comments";
            // 
            // txt_inspectorName
            // 
            this.txt_inspectorName.Location = new System.Drawing.Point(180, 258);
            this.txt_inspectorName.Name = "txt_inspectorName";
            this.txt_inspectorName.Size = new System.Drawing.Size(209, 26);
            this.txt_inspectorName.TabIndex = 6;
            // 
            // lbl_inspectorName
            // 
            this.lbl_inspectorName.AutoSize = true;
            this.lbl_inspectorName.Location = new System.Drawing.Point(56, 264);
            this.lbl_inspectorName.Name = "lbl_inspectorName";
            this.lbl_inspectorName.Size = new System.Drawing.Size(120, 20);
            this.lbl_inspectorName.TabIndex = 7;
            this.lbl_inspectorName.Text = "Inspector name";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(84, 343);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(92, 46);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cbx_interventionType
            // 
            this.cbx_interventionType.AutoSize = true;
            this.cbx_interventionType.Location = new System.Drawing.Point(182, 223);
            this.cbx_interventionType.Name = "cbx_interventionType";
            this.cbx_interventionType.Size = new System.Drawing.Size(153, 24);
            this.cbx_interventionType.TabIndex = 9;
            this.cbx_interventionType.Text = "InterventionType";
            this.cbx_interventionType.UseVisualStyleBackColor = true;
            // 
            // rtb_results
            // 
            this.rtb_results.Location = new System.Drawing.Point(497, 64);
            this.rtb_results.Name = "rtb_results";
            this.rtb_results.Size = new System.Drawing.Size(195, 220);
            this.rtb_results.TabIndex = 10;
            this.rtb_results.Text = "";
            // 
            // TestHarness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_results);
            this.Controls.Add(this.cbx_interventionType);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_inspectorName);
            this.Controls.Add(this.txt_inspectorName);
            this.Controls.Add(this.lbl_comments);
            this.Controls.Add(this.rtb_comments);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dtp_dateTimePicker1);
            this.Controls.Add(this.lbl_siteName1);
            this.Controls.Add(this.cmb_sitetName);
            this.Name = "TestHarness";
            this.Text = "TestHarness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_sitetName;
        private System.Windows.Forms.Label lbl_siteName1;
        private System.Windows.Forms.DateTimePicker dtp_dateTimePicker1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.RichTextBox rtb_comments;
        private System.Windows.Forms.Label lbl_comments;
        private System.Windows.Forms.TextBox txt_inspectorName;
        private System.Windows.Forms.Label lbl_inspectorName;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.CheckBox cbx_interventionType;
        private System.Windows.Forms.RichTextBox rtb_results;
    }
}