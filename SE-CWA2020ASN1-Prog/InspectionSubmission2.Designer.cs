﻿
namespace SE_CWA2020ASN1_Prog
{
    partial class InspectionSubmission2
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
            this.pic_logo = new System.Windows.Forms.PictureBox();
            this.rtb_InspectionComments = new System.Windows.Forms.RichTextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_ExitNoSave = new System.Windows.Forms.Button();
            this.lbl_GeneralInspection = new System.Windows.Forms.Label();
            this.cmb_WorkingStandards = new System.Windows.Forms.ComboBox();
            this.lbl_WorkingStandards = new System.Windows.Forms.Label();
            this.lbl_Quality = new System.Windows.Forms.Label();
            this.cmb_Quality = new System.Windows.Forms.ComboBox();
            this.lbl_Site_Rules = new System.Windows.Forms.Label();
            this.cmb_Site_Rules = new System.Windows.Forms.ComboBox();
            this.lbl_Environmental = new System.Windows.Forms.Label();
            this.cmb_Environmental = new System.Windows.Forms.ComboBox();
            this.lbl_Protection_Of_Individuals = new System.Windows.Forms.Label();
            this.cmb_Protection_Of_Individuals = new System.Windows.Forms.ComboBox();
            this.lbl_Tools_Cables_And_Other = new System.Windows.Forms.Label();
            this.cmb_Tools_Cables_And_Other = new System.Windows.Forms.ComboBox();
            this.lbl_Miscellaneous = new System.Windows.Forms.Label();
            this.cmb_Miscellaneous = new System.Windows.Forms.ComboBox();
            this.lbl_High_Risk = new System.Windows.Forms.Label();
            this.cmb_High_Risk = new System.Windows.Forms.ComboBox();
            this.chk_Best_Practice = new System.Windows.Forms.CheckBox();
            this.chk_Intervention = new System.Windows.Forms.CheckBox();
            this.chk_Subcontractor = new System.Windows.Forms.CheckBox();
            this.rtb_WorkArea = new System.Windows.Forms.RichTextBox();
            this.lbl_Work_Area = new System.Windows.Forms.Label();
            this.rtb_Total = new System.Windows.Forms.RichTextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.btn_enterComments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo
            // 
            this.pic_logo.ImageLocation = "main.musk-logo.jpg";
            this.pic_logo.Location = new System.Drawing.Point(14, 11);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(183, 82);
            this.pic_logo.TabIndex = 38;
            this.pic_logo.TabStop = false;
            // 
            // rtb_InspectionComments
            // 
            this.rtb_InspectionComments.Location = new System.Drawing.Point(12, 394);
            this.rtb_InspectionComments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_InspectionComments.Name = "rtb_InspectionComments";
            this.rtb_InspectionComments.Size = new System.Drawing.Size(237, 238);
            this.rtb_InspectionComments.TabIndex = 39;
            this.rtb_InspectionComments.Text = "";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(271, 580);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(193, 52);
            this.btn_Submit.TabIndex = 40;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(485, 471);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(193, 52);
            this.btn_Edit.TabIndex = 41;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_ExitNoSave
            // 
            this.btn_ExitNoSave.Location = new System.Drawing.Point(485, 580);
            this.btn_ExitNoSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ExitNoSave.Name = "btn_ExitNoSave";
            this.btn_ExitNoSave.Size = new System.Drawing.Size(193, 52);
            this.btn_ExitNoSave.TabIndex = 42;
            this.btn_ExitNoSave.Text = "Exit Without Save";
            this.btn_ExitNoSave.UseVisualStyleBackColor = true;
            this.btn_ExitNoSave.Click += new System.EventHandler(this.btn_ExitNoSave_Click);
            // 
            // lbl_GeneralInspection
            // 
            this.lbl_GeneralInspection.AutoSize = true;
            this.lbl_GeneralInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GeneralInspection.Location = new System.Drawing.Point(235, 11);
            this.lbl_GeneralInspection.Name = "lbl_GeneralInspection";
            this.lbl_GeneralInspection.Size = new System.Drawing.Size(215, 29);
            this.lbl_GeneralInspection.TabIndex = 43;
            this.lbl_GeneralInspection.Text = "General Inspection";
            // 
            // cmb_WorkingStandards
            // 
            this.cmb_WorkingStandards.FormattingEnabled = true;
            this.cmb_WorkingStandards.Items.AddRange(new object[] {
            "1. Work At Height",
            "2. Lifting Operations",
            "3. Certification",
            "4. Confined Space Work",
            "5. Electrical Work"});
            this.cmb_WorkingStandards.Location = new System.Drawing.Point(444, 103);
            this.cmb_WorkingStandards.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_WorkingStandards.Name = "cmb_WorkingStandards";
            this.cmb_WorkingStandards.Size = new System.Drawing.Size(255, 28);
            this.cmb_WorkingStandards.TabIndex = 44;
            // 
            // lbl_WorkingStandards
            // 
            this.lbl_WorkingStandards.AutoSize = true;
            this.lbl_WorkingStandards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorkingStandards.Location = new System.Drawing.Point(243, 106);
            this.lbl_WorkingStandards.Name = "lbl_WorkingStandards";
            this.lbl_WorkingStandards.Size = new System.Drawing.Size(195, 25);
            this.lbl_WorkingStandards.TabIndex = 45;
            this.lbl_WorkingStandards.Text = "Working Standards";
            // 
            // lbl_Quality
            // 
            this.lbl_Quality.AutoSize = true;
            this.lbl_Quality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quality.Location = new System.Drawing.Point(359, 148);
            this.lbl_Quality.Name = "lbl_Quality";
            this.lbl_Quality.Size = new System.Drawing.Size(79, 25);
            this.lbl_Quality.TabIndex = 46;
            this.lbl_Quality.Text = "Quality";
            // 
            // cmb_Quality
            // 
            this.cmb_Quality.FormattingEnabled = true;
            this.cmb_Quality.Items.AddRange(new object[] {
            "6. Site Set-Up & Appearance, Signage",
            "7. Paperwork",
            "8. Certification"});
            this.cmb_Quality.Location = new System.Drawing.Point(444, 148);
            this.cmb_Quality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Quality.Name = "cmb_Quality";
            this.cmb_Quality.Size = new System.Drawing.Size(255, 28);
            this.cmb_Quality.TabIndex = 47;
            // 
            // lbl_Site_Rules
            // 
            this.lbl_Site_Rules.AutoSize = true;
            this.lbl_Site_Rules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Site_Rules.Location = new System.Drawing.Point(328, 190);
            this.lbl_Site_Rules.Name = "lbl_Site_Rules";
            this.lbl_Site_Rules.Size = new System.Drawing.Size(110, 25);
            this.lbl_Site_Rules.TabIndex = 48;
            this.lbl_Site_Rules.Text = "Site Rules";
            // 
            // cmb_Site_Rules
            // 
            this.cmb_Site_Rules.FormattingEnabled = true;
            this.cmb_Site_Rules.Items.AddRange(new object[] {
            "9. Hot Work",
            "10. Isolation and Lock Offs",
            "11. Fire Exits and Escape Routes",
            "12. Awareness"});
            this.cmb_Site_Rules.Location = new System.Drawing.Point(444, 190);
            this.cmb_Site_Rules.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Site_Rules.Name = "cmb_Site_Rules";
            this.cmb_Site_Rules.Size = new System.Drawing.Size(255, 28);
            this.cmb_Site_Rules.TabIndex = 49;
            // 
            // lbl_Environmental
            // 
            this.lbl_Environmental.AutoSize = true;
            this.lbl_Environmental.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Environmental.Location = new System.Drawing.Point(289, 233);
            this.lbl_Environmental.Name = "lbl_Environmental";
            this.lbl_Environmental.Size = new System.Drawing.Size(149, 25);
            this.lbl_Environmental.TabIndex = 50;
            this.lbl_Environmental.Text = "Environmental";
            // 
            // cmb_Environmental
            // 
            this.cmb_Environmental.FormattingEnabled = true;
            this.cmb_Environmental.Items.AddRange(new object[] {
            "13. Waste Management",
            "14. Product Contamination",
            "15. COSHH & Asbestos"});
            this.cmb_Environmental.Location = new System.Drawing.Point(444, 234);
            this.cmb_Environmental.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Environmental.Name = "cmb_Environmental";
            this.cmb_Environmental.Size = new System.Drawing.Size(255, 28);
            this.cmb_Environmental.TabIndex = 51;
            // 
            // lbl_Protection_Of_Individuals
            // 
            this.lbl_Protection_Of_Individuals.AutoSize = true;
            this.lbl_Protection_Of_Individuals.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Protection_Of_Individuals.Location = new System.Drawing.Point(193, 277);
            this.lbl_Protection_Of_Individuals.Name = "lbl_Protection_Of_Individuals";
            this.lbl_Protection_Of_Individuals.Size = new System.Drawing.Size(245, 25);
            this.lbl_Protection_Of_Individuals.TabIndex = 52;
            this.lbl_Protection_Of_Individuals.Text = "Protection Of Individuals";
            // 
            // cmb_Protection_Of_Individuals
            // 
            this.cmb_Protection_Of_Individuals.FormattingEnabled = true;
            this.cmb_Protection_Of_Individuals.Items.AddRange(new object[] {
            "16. PPE",
            "17. Manual Handling",
            "18. Other Contractors"});
            this.cmb_Protection_Of_Individuals.Location = new System.Drawing.Point(444, 278);
            this.cmb_Protection_Of_Individuals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Protection_Of_Individuals.Name = "cmb_Protection_Of_Individuals";
            this.cmb_Protection_Of_Individuals.Size = new System.Drawing.Size(255, 28);
            this.cmb_Protection_Of_Individuals.TabIndex = 53;
            // 
            // lbl_Tools_Cables_And_Other
            // 
            this.lbl_Tools_Cables_And_Other.AutoSize = true;
            this.lbl_Tools_Cables_And_Other.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tools_Cables_And_Other.Location = new System.Drawing.Point(83, 322);
            this.lbl_Tools_Cables_And_Other.Name = "lbl_Tools_Cables_And_Other";
            this.lbl_Tools_Cables_And_Other.Size = new System.Drawing.Size(355, 25);
            this.lbl_Tools_Cables_And_Other.TabIndex = 54;
            this.lbl_Tools_Cables_And_Other.Text = "Tools, Cables And Other Equipment";
            // 
            // cmb_Tools_Cables_And_Other
            // 
            this.cmb_Tools_Cables_And_Other.FormattingEnabled = true;
            this.cmb_Tools_Cables_And_Other.Items.AddRange(new object[] {
            "19. Power Tools, Cables & Other Equipment",
            "20. Voltage Detector Checked",
            "21. Tools Used Fit For Purpose"});
            this.cmb_Tools_Cables_And_Other.Location = new System.Drawing.Point(444, 323);
            this.cmb_Tools_Cables_And_Other.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Tools_Cables_And_Other.Name = "cmb_Tools_Cables_And_Other";
            this.cmb_Tools_Cables_And_Other.Size = new System.Drawing.Size(255, 28);
            this.cmb_Tools_Cables_And_Other.TabIndex = 55;
            // 
            // lbl_Miscellaneous
            // 
            this.lbl_Miscellaneous.AutoSize = true;
            this.lbl_Miscellaneous.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Miscellaneous.Location = new System.Drawing.Point(288, 367);
            this.lbl_Miscellaneous.Name = "lbl_Miscellaneous";
            this.lbl_Miscellaneous.Size = new System.Drawing.Size(150, 25);
            this.lbl_Miscellaneous.TabIndex = 56;
            this.lbl_Miscellaneous.Text = "Miscellaneous";
            // 
            // cmb_Miscellaneous
            // 
            this.cmb_Miscellaneous.FormattingEnabled = true;
            this.cmb_Miscellaneous.Items.AddRange(new object[] {
            "22. Company Vehicles",
            "23. Fire Precautions",
            "24. Workshop Conditions"});
            this.cmb_Miscellaneous.Location = new System.Drawing.Point(444, 367);
            this.cmb_Miscellaneous.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Miscellaneous.Name = "cmb_Miscellaneous";
            this.cmb_Miscellaneous.Size = new System.Drawing.Size(255, 28);
            this.cmb_Miscellaneous.TabIndex = 57;
            // 
            // lbl_High_Risk
            // 
            this.lbl_High_Risk.AutoSize = true;
            this.lbl_High_Risk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_High_Risk.Location = new System.Drawing.Point(334, 412);
            this.lbl_High_Risk.Name = "lbl_High_Risk";
            this.lbl_High_Risk.Size = new System.Drawing.Size(104, 25);
            this.lbl_High_Risk.TabIndex = 58;
            this.lbl_High_Risk.Text = "High Risk";
            // 
            // cmb_High_Risk
            // 
            this.cmb_High_Risk.FormattingEnabled = true;
            this.cmb_High_Risk.Items.AddRange(new object[] {
            "Need to figure out what counts as high risk"});
            this.cmb_High_Risk.Location = new System.Drawing.Point(444, 409);
            this.cmb_High_Risk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_High_Risk.Name = "cmb_High_Risk";
            this.cmb_High_Risk.Size = new System.Drawing.Size(255, 28);
            this.cmb_High_Risk.TabIndex = 59;
            // 
            // chk_Best_Practice
            // 
            this.chk_Best_Practice.AutoSize = true;
            this.chk_Best_Practice.Location = new System.Drawing.Point(37, 142);
            this.chk_Best_Practice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_Best_Practice.Name = "chk_Best_Practice";
            this.chk_Best_Practice.Size = new System.Drawing.Size(129, 24);
            this.chk_Best_Practice.TabIndex = 60;
            this.chk_Best_Practice.Text = "Best Practice";
            this.chk_Best_Practice.UseVisualStyleBackColor = true;
            // 
            // chk_Intervention
            // 
            this.chk_Intervention.AutoSize = true;
            this.chk_Intervention.Location = new System.Drawing.Point(37, 206);
            this.chk_Intervention.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_Intervention.Name = "chk_Intervention";
            this.chk_Intervention.Size = new System.Drawing.Size(119, 24);
            this.chk_Intervention.TabIndex = 61;
            this.chk_Intervention.Text = "Intervention";
            this.chk_Intervention.UseVisualStyleBackColor = true;
            // 
            // chk_Subcontractor
            // 
            this.chk_Subcontractor.AutoSize = true;
            this.chk_Subcontractor.Location = new System.Drawing.Point(37, 174);
            this.chk_Subcontractor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chk_Subcontractor.Name = "chk_Subcontractor";
            this.chk_Subcontractor.Size = new System.Drawing.Size(144, 24);
            this.chk_Subcontractor.TabIndex = 62;
            this.chk_Subcontractor.Text = "Sub-Contractor";
            this.chk_Subcontractor.UseVisualStyleBackColor = true;
            // 
            // rtb_WorkArea
            // 
            this.rtb_WorkArea.Location = new System.Drawing.Point(351, 55);
            this.rtb_WorkArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_WorkArea.Name = "rtb_WorkArea";
            this.rtb_WorkArea.Size = new System.Drawing.Size(348, 38);
            this.rtb_WorkArea.TabIndex = 63;
            this.rtb_WorkArea.Text = "";
            // 
            // lbl_Work_Area
            // 
            this.lbl_Work_Area.AutoSize = true;
            this.lbl_Work_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Work_Area.Location = new System.Drawing.Point(221, 55);
            this.lbl_Work_Area.Name = "lbl_Work_Area";
            this.lbl_Work_Area.Size = new System.Drawing.Size(113, 25);
            this.lbl_Work_Area.TabIndex = 64;
            this.lbl_Work_Area.Text = "Work Area";
            // 
            // rtb_Total
            // 
            this.rtb_Total.Location = new System.Drawing.Point(544, 1056);
            this.rtb_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_Total.Name = "rtb_Total";
            this.rtb_Total.Size = new System.Drawing.Size(150, 50);
            this.rtb_Total.TabIndex = 65;
            this.rtb_Total.Text = "";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(399, 1065);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(151, 29);
            this.lbl_Total.TabIndex = 66;
            this.lbl_Total.Text = "Overall Total";
            // 
            // btn_enterComments
            // 
            this.btn_enterComments.Location = new System.Drawing.Point(276, 471);
            this.btn_enterComments.Name = "btn_enterComments";
            this.btn_enterComments.Size = new System.Drawing.Size(188, 91);
            this.btn_enterComments.TabIndex = 67;
            this.btn_enterComments.Text = "Enter comments and take picture";
            this.btn_enterComments.UseVisualStyleBackColor = true;
            this.btn_enterComments.Click += new System.EventHandler(this.btn_enterComments_Click);
            // 
            // InspectionSubmission2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 647);
            this.Controls.Add(this.btn_enterComments);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.rtb_Total);
            this.Controls.Add(this.lbl_Work_Area);
            this.Controls.Add(this.rtb_WorkArea);
            this.Controls.Add(this.chk_Subcontractor);
            this.Controls.Add(this.chk_Intervention);
            this.Controls.Add(this.chk_Best_Practice);
            this.Controls.Add(this.cmb_High_Risk);
            this.Controls.Add(this.lbl_High_Risk);
            this.Controls.Add(this.cmb_Miscellaneous);
            this.Controls.Add(this.lbl_Miscellaneous);
            this.Controls.Add(this.cmb_Tools_Cables_And_Other);
            this.Controls.Add(this.lbl_Tools_Cables_And_Other);
            this.Controls.Add(this.cmb_Protection_Of_Individuals);
            this.Controls.Add(this.lbl_Protection_Of_Individuals);
            this.Controls.Add(this.cmb_Environmental);
            this.Controls.Add(this.lbl_Environmental);
            this.Controls.Add(this.cmb_Site_Rules);
            this.Controls.Add(this.lbl_Site_Rules);
            this.Controls.Add(this.cmb_Quality);
            this.Controls.Add(this.lbl_Quality);
            this.Controls.Add(this.lbl_WorkingStandards);
            this.Controls.Add(this.cmb_WorkingStandards);
            this.Controls.Add(this.lbl_GeneralInspection);
            this.Controls.Add(this.btn_ExitNoSave);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.rtb_InspectionComments);
            this.Controls.Add(this.pic_logo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InspectionSubmission2";
            this.Text = "Inspection Main";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.RichTextBox rtb_InspectionComments;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_ExitNoSave;
        private System.Windows.Forms.Label lbl_GeneralInspection;
        private System.Windows.Forms.ComboBox cmb_WorkingStandards;
        private System.Windows.Forms.Label lbl_WorkingStandards;
        private System.Windows.Forms.Label lbl_Quality;
        private System.Windows.Forms.ComboBox cmb_Quality;
        private System.Windows.Forms.Label lbl_Site_Rules;
        private System.Windows.Forms.ComboBox cmb_Site_Rules;
        private System.Windows.Forms.Label lbl_Environmental;
        private System.Windows.Forms.ComboBox cmb_Environmental;
        private System.Windows.Forms.Label lbl_Protection_Of_Individuals;
        private System.Windows.Forms.ComboBox cmb_Protection_Of_Individuals;
        private System.Windows.Forms.Label lbl_Tools_Cables_And_Other;
        private System.Windows.Forms.ComboBox cmb_Tools_Cables_And_Other;
        private System.Windows.Forms.Label lbl_Miscellaneous;
        private System.Windows.Forms.ComboBox cmb_Miscellaneous;
        private System.Windows.Forms.Label lbl_High_Risk;
        private System.Windows.Forms.ComboBox cmb_High_Risk;
        private System.Windows.Forms.CheckBox chk_Best_Practice;
        private System.Windows.Forms.CheckBox chk_Intervention;
        private System.Windows.Forms.CheckBox chk_Subcontractor;
        private System.Windows.Forms.RichTextBox rtb_WorkArea;
        private System.Windows.Forms.Label lbl_Work_Area;
        private System.Windows.Forms.RichTextBox rtb_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Button btn_enterComments;
    }
}