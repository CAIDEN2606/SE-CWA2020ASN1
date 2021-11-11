
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
            this.rtb_InspectCommsSummary = new System.Windows.Forms.RichTextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_ExitNoSave = new System.Windows.Forms.Button();
            this.lbl_GeneralInspection = new System.Windows.Forms.Label();
            this.cmb_Interventions = new System.Windows.Forms.ComboBox();
            this.lbl_WorkingStandards = new System.Windows.Forms.Label();
            this.rtb_WorkArea = new System.Windows.Forms.RichTextBox();
            this.lbl_Work_Area = new System.Windows.Forms.Label();
            this.rtb_Total = new System.Windows.Forms.RichTextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_finalSummaryComments = new System.Windows.Forms.Label();
            this.cmb_TypesOfIntervention = new System.Windows.Forms.ComboBox();
            this.lbl_Protection_Of_Individuals = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.pic_viewer = new System.Windows.Forms.PictureBox();
            this.vsc_actionTaken = new System.Windows.Forms.VScrollBar();
            this.vsc_comments = new System.Windows.Forms.VScrollBar();
            this.btn_deletePic = new System.Windows.Forms.Button();
            this.btn_takePic = new System.Windows.Forms.Button();
            this.rtx_actionTaken = new System.Windows.Forms.RichTextBox();
            this.lbl_enterAction = new System.Windows.Forms.Label();
            this.lbl_insertComments = new System.Windows.Forms.Label();
            this.rtx_comments = new System.Windows.Forms.RichTextBox();
            this.btn_saveIntervention = new System.Windows.Forms.Button();
            this.lbl_error1 = new System.Windows.Forms.Label();
            this.lbl_error2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_viewer)).BeginInit();
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
            // rtb_InspectCommsSummary
            // 
            this.rtb_InspectCommsSummary.Location = new System.Drawing.Point(17, 576);
            this.rtb_InspectCommsSummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_InspectCommsSummary.Name = "rtb_InspectCommsSummary";
            this.rtb_InspectCommsSummary.Size = new System.Drawing.Size(453, 60);
            this.rtb_InspectCommsSummary.TabIndex = 39;
            this.rtb_InspectCommsSummary.Text = "";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(17, 644);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(194, 52);
            this.btn_Submit.TabIndex = 40;
            this.btn_Submit.Text = "Submit inspection";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_ExitNoSave
            // 
            this.btn_ExitNoSave.Location = new System.Drawing.Point(277, 644);
            this.btn_ExitNoSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ExitNoSave.Name = "btn_ExitNoSave";
            this.btn_ExitNoSave.Size = new System.Drawing.Size(194, 52);
            this.btn_ExitNoSave.TabIndex = 42;
            this.btn_ExitNoSave.Text = "Exit Without Save";
            this.btn_ExitNoSave.UseVisualStyleBackColor = true;
            this.btn_ExitNoSave.Click += new System.EventHandler(this.btn_ExitNoSave_Click);
            // 
            // lbl_GeneralInspection
            // 
            this.lbl_GeneralInspection.AutoSize = true;
            this.lbl_GeneralInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GeneralInspection.Location = new System.Drawing.Point(207, 11);
            this.lbl_GeneralInspection.Name = "lbl_GeneralInspection";
            this.lbl_GeneralInspection.Size = new System.Drawing.Size(249, 29);
            this.lbl_GeneralInspection.TabIndex = 43;
            this.lbl_GeneralInspection.Text = "ADD INTERVENTION";
            // 
            // cmb_Interventions
            // 
            this.cmb_Interventions.FormattingEnabled = true;
            this.cmb_Interventions.Items.AddRange(new object[] {
            "work at height",
            "wroking some"});
            this.cmb_Interventions.Location = new System.Drawing.Point(178, 101);
            this.cmb_Interventions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Interventions.Name = "cmb_Interventions";
            this.cmb_Interventions.Size = new System.Drawing.Size(292, 28);
            this.cmb_Interventions.TabIndex = 44;
            // 
            // lbl_WorkingStandards
            // 
            this.lbl_WorkingStandards.AutoSize = true;
            this.lbl_WorkingStandards.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorkingStandards.Location = new System.Drawing.Point(10, 110);
            this.lbl_WorkingStandards.Name = "lbl_WorkingStandards";
            this.lbl_WorkingStandards.Size = new System.Drawing.Size(93, 20);
            this.lbl_WorkingStandards.TabIndex = 45;
            this.lbl_WorkingStandards.Text = "Intervention";
            // 
            // rtb_WorkArea
            // 
            this.rtb_WorkArea.Location = new System.Drawing.Point(323, 63);
            this.rtb_WorkArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_WorkArea.Name = "rtb_WorkArea";
            this.rtb_WorkArea.Size = new System.Drawing.Size(147, 30);
            this.rtb_WorkArea.TabIndex = 63;
            this.rtb_WorkArea.Text = "";
            // 
            // lbl_Work_Area
            // 
            this.lbl_Work_Area.AutoSize = true;
            this.lbl_Work_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Work_Area.Location = new System.Drawing.Point(204, 69);
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
            // lbl_finalSummaryComments
            // 
            this.lbl_finalSummaryComments.AutoSize = true;
            this.lbl_finalSummaryComments.Location = new System.Drawing.Point(13, 552);
            this.lbl_finalSummaryComments.Name = "lbl_finalSummaryComments";
            this.lbl_finalSummaryComments.Size = new System.Drawing.Size(225, 20);
            this.lbl_finalSummaryComments.TabIndex = 68;
            this.lbl_finalSummaryComments.Text = "Enter final inspection summary";
            // 
            // cmb_TypesOfIntervention
            // 
            this.cmb_TypesOfIntervention.FormattingEnabled = true;
            this.cmb_TypesOfIntervention.Items.AddRange(new object[] {
            "Best practice",
            "Positive intervention",
            "SubContractor"});
            this.cmb_TypesOfIntervention.Location = new System.Drawing.Point(178, 144);
            this.cmb_TypesOfIntervention.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_TypesOfIntervention.Name = "cmb_TypesOfIntervention";
            this.cmb_TypesOfIntervention.Size = new System.Drawing.Size(292, 28);
            this.cmb_TypesOfIntervention.TabIndex = 53;
            // 
            // lbl_Protection_Of_Individuals
            // 
            this.lbl_Protection_Of_Individuals.AutoSize = true;
            this.lbl_Protection_Of_Individuals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Protection_Of_Individuals.Location = new System.Drawing.Point(10, 152);
            this.lbl_Protection_Of_Individuals.Name = "lbl_Protection_Of_Individuals";
            this.lbl_Protection_Of_Individuals.Size = new System.Drawing.Size(127, 20);
            this.lbl_Protection_Of_Individuals.TabIndex = 52;
            this.lbl_Protection_Of_Individuals.Text = "Intervention type";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(303, 449);
            this.btn_next.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(84, 29);
            this.btn_next.TabIndex = 79;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(95, 449);
            this.btn_prev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(84, 29);
            this.btn_prev.TabIndex = 78;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // pic_viewer
            // 
            this.pic_viewer.Image = global::SE_CWA2020ASN1_Prog.Properties.Resources.Planet9;
            this.pic_viewer.Location = new System.Drawing.Point(17, 362);
            this.pic_viewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_viewer.Name = "pic_viewer";
            this.pic_viewer.Size = new System.Drawing.Size(454, 80);
            this.pic_viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_viewer.TabIndex = 77;
            this.pic_viewer.TabStop = false;
            // 
            // vsc_actionTaken
            // 
            this.vsc_actionTaken.Location = new System.Drawing.Point(430, 212);
            this.vsc_actionTaken.Name = "vsc_actionTaken";
            this.vsc_actionTaken.Size = new System.Drawing.Size(26, 76);
            this.vsc_actionTaken.TabIndex = 76;
            // 
            // vsc_comments
            // 
            this.vsc_comments.Location = new System.Drawing.Point(171, 212);
            this.vsc_comments.Name = "vsc_comments";
            this.vsc_comments.Size = new System.Drawing.Size(26, 76);
            this.vsc_comments.TabIndex = 75;
            // 
            // btn_deletePic
            // 
            this.btn_deletePic.Location = new System.Drawing.Point(323, 305);
            this.btn_deletePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deletePic.Name = "btn_deletePic";
            this.btn_deletePic.Size = new System.Drawing.Size(116, 52);
            this.btn_deletePic.TabIndex = 74;
            this.btn_deletePic.Text = "Delete picture";
            this.btn_deletePic.UseVisualStyleBackColor = true;
            this.btn_deletePic.Click += new System.EventHandler(this.btn_deletePic_Click);
            // 
            // btn_takePic
            // 
            this.btn_takePic.Location = new System.Drawing.Point(63, 305);
            this.btn_takePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_takePic.Name = "btn_takePic";
            this.btn_takePic.Size = new System.Drawing.Size(116, 52);
            this.btn_takePic.TabIndex = 73;
            this.btn_takePic.Text = "Take a picture";
            this.btn_takePic.UseVisualStyleBackColor = true;
            this.btn_takePic.Click += new System.EventHandler(this.btn_takePic_Click);
            // 
            // rtx_actionTaken
            // 
            this.rtx_actionTaken.Location = new System.Drawing.Point(269, 212);
            this.rtx_actionTaken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtx_actionTaken.Name = "rtx_actionTaken";
            this.rtx_actionTaken.Size = new System.Drawing.Size(201, 76);
            this.rtx_actionTaken.TabIndex = 72;
            this.rtx_actionTaken.Text = "";
            // 
            // lbl_enterAction
            // 
            this.lbl_enterAction.AutoSize = true;
            this.lbl_enterAction.Location = new System.Drawing.Point(265, 190);
            this.lbl_enterAction.Name = "lbl_enterAction";
            this.lbl_enterAction.Size = new System.Drawing.Size(139, 20);
            this.lbl_enterAction.TabIndex = 71;
            this.lbl_enterAction.Text = "Enter action taken";
            // 
            // lbl_insertComments
            // 
            this.lbl_insertComments.AutoSize = true;
            this.lbl_insertComments.Location = new System.Drawing.Point(28, 190);
            this.lbl_insertComments.Name = "lbl_insertComments";
            this.lbl_insertComments.Size = new System.Drawing.Size(173, 20);
            this.lbl_insertComments.TabIndex = 70;
            this.lbl_insertComments.Text = "Insert comments below";
            // 
            // rtx_comments
            // 
            this.rtx_comments.Location = new System.Drawing.Point(32, 212);
            this.rtx_comments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtx_comments.Name = "rtx_comments";
            this.rtx_comments.Size = new System.Drawing.Size(196, 76);
            this.rtx_comments.TabIndex = 69;
            this.rtx_comments.Text = "";
            // 
            // btn_saveIntervention
            // 
            this.btn_saveIntervention.Location = new System.Drawing.Point(122, 493);
            this.btn_saveIntervention.Name = "btn_saveIntervention";
            this.btn_saveIntervention.Size = new System.Drawing.Size(237, 43);
            this.btn_saveIntervention.TabIndex = 80;
            this.btn_saveIntervention.Text = "Save Intervention";
            this.btn_saveIntervention.UseVisualStyleBackColor = true;
            this.btn_saveIntervention.Click += new System.EventHandler(this.btn_saveIntervention_Click);
            // 
            // lbl_error1
            // 
            this.lbl_error1.AutoSize = true;
            this.lbl_error1.ForeColor = System.Drawing.Color.Red;
            this.lbl_error1.Location = new System.Drawing.Point(157, 104);
            this.lbl_error1.Name = "lbl_error1";
            this.lbl_error1.Size = new System.Drawing.Size(15, 20);
            this.lbl_error1.TabIndex = 81;
            this.lbl_error1.Text = "*";
            this.lbl_error1.Visible = false;
            // 
            // lbl_error2
            // 
            this.lbl_error2.AutoSize = true;
            this.lbl_error2.ForeColor = System.Drawing.Color.Red;
            this.lbl_error2.Location = new System.Drawing.Point(157, 147);
            this.lbl_error2.Name = "lbl_error2";
            this.lbl_error2.Size = new System.Drawing.Size(15, 20);
            this.lbl_error2.TabIndex = 82;
            this.lbl_error2.Text = "*";
            this.lbl_error2.Visible = false;
            // 
            // InspectionSubmission2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 700);
            this.Controls.Add(this.lbl_error2);
            this.Controls.Add(this.lbl_error1);
            this.Controls.Add(this.btn_saveIntervention);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.pic_viewer);
            this.Controls.Add(this.vsc_actionTaken);
            this.Controls.Add(this.vsc_comments);
            this.Controls.Add(this.btn_deletePic);
            this.Controls.Add(this.btn_takePic);
            this.Controls.Add(this.rtx_actionTaken);
            this.Controls.Add(this.lbl_enterAction);
            this.Controls.Add(this.lbl_insertComments);
            this.Controls.Add(this.rtx_comments);
            this.Controls.Add(this.lbl_finalSummaryComments);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.rtb_Total);
            this.Controls.Add(this.lbl_Work_Area);
            this.Controls.Add(this.rtb_WorkArea);
            this.Controls.Add(this.cmb_TypesOfIntervention);
            this.Controls.Add(this.lbl_Protection_Of_Individuals);
            this.Controls.Add(this.lbl_WorkingStandards);
            this.Controls.Add(this.cmb_Interventions);
            this.Controls.Add(this.lbl_GeneralInspection);
            this.Controls.Add(this.btn_ExitNoSave);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.rtb_InspectCommsSummary);
            this.Controls.Add(this.pic_logo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InspectionSubmission2";
            this.Text = "Inspection Main";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.RichTextBox rtb_InspectCommsSummary;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_ExitNoSave;
        private System.Windows.Forms.Label lbl_GeneralInspection;
        private System.Windows.Forms.ComboBox cmb_Interventions;
        private System.Windows.Forms.Label lbl_WorkingStandards;
        private System.Windows.Forms.RichTextBox rtb_WorkArea;
        private System.Windows.Forms.Label lbl_Work_Area;
        private System.Windows.Forms.RichTextBox rtb_Total;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_finalSummaryComments;
        private System.Windows.Forms.ComboBox cmb_TypesOfIntervention;
        private System.Windows.Forms.Label lbl_Protection_Of_Individuals;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.PictureBox pic_viewer;
        private System.Windows.Forms.VScrollBar vsc_actionTaken;
        private System.Windows.Forms.VScrollBar vsc_comments;
        private System.Windows.Forms.Button btn_deletePic;
        private System.Windows.Forms.Button btn_takePic;
        private System.Windows.Forms.RichTextBox rtx_actionTaken;
        private System.Windows.Forms.Label lbl_enterAction;
        private System.Windows.Forms.Label lbl_insertComments;
        private System.Windows.Forms.RichTextBox rtx_comments;
        private System.Windows.Forms.Button btn_saveIntervention;
        private System.Windows.Forms.Label lbl_error1;
        private System.Windows.Forms.Label lbl_error2;
    }
}