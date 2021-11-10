
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
            this.btn_ExitNoSave = new System.Windows.Forms.Button();
            this.lbl_GeneralInspection = new System.Windows.Forms.Label();
            this.cmb_Interventions = new System.Windows.Forms.ComboBox();
            this.lbl_WorkingStandards = new System.Windows.Forms.Label();
            this.rtb_WorkArea = new System.Windows.Forms.RichTextBox();
            this.lbl_Work_Area = new System.Windows.Forms.Label();
            this.rtb_Total = new System.Windows.Forms.RichTextBox();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_finalSummaryComments = new System.Windows.Forms.Label();
            this.cmb_InterventionTypes = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_viewer)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_logo
            // 
            this.pic_logo.ImageLocation = "main.musk-logo.jpg";
            this.pic_logo.Location = new System.Drawing.Point(12, 9);
            this.pic_logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Size = new System.Drawing.Size(163, 66);
            this.pic_logo.TabIndex = 38;
            this.pic_logo.TabStop = false;
            // 
            // rtb_InspectionComments
            // 
            this.rtb_InspectionComments.Location = new System.Drawing.Point(2, 413);
            this.rtb_InspectionComments.Name = "rtb_InspectionComments";
            this.rtb_InspectionComments.Size = new System.Drawing.Size(404, 47);
            this.rtb_InspectionComments.TabIndex = 39;
            this.rtb_InspectionComments.Text = "";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(15, 506);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(172, 42);
            this.btn_Submit.TabIndex = 40;
            this.btn_Submit.Text = "Submit inspection";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_ExitNoSave
            // 
            this.btn_ExitNoSave.Location = new System.Drawing.Point(234, 506);
            this.btn_ExitNoSave.Name = "btn_ExitNoSave";
            this.btn_ExitNoSave.Size = new System.Drawing.Size(172, 42);
            this.btn_ExitNoSave.TabIndex = 42;
            this.btn_ExitNoSave.Text = "Exit Without Save";
            this.btn_ExitNoSave.UseVisualStyleBackColor = true;
            this.btn_ExitNoSave.Click += new System.EventHandler(this.btn_ExitNoSave_Click);
            // 
            // lbl_GeneralInspection
            // 
            this.lbl_GeneralInspection.AutoSize = true;
            this.lbl_GeneralInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GeneralInspection.Location = new System.Drawing.Point(184, 9);
            this.lbl_GeneralInspection.Name = "lbl_GeneralInspection";
            this.lbl_GeneralInspection.Size = new System.Drawing.Size(206, 25);
            this.lbl_GeneralInspection.TabIndex = 43;
            this.lbl_GeneralInspection.Text = "ADD INTERVENTION";
            // 
            // cmb_Interventions
            // 
            this.cmb_Interventions.FormattingEnabled = true;
            this.cmb_Interventions.Location = new System.Drawing.Point(214, 81);
            this.cmb_Interventions.Name = "cmb_Interventions";
            this.cmb_Interventions.Size = new System.Drawing.Size(192, 24);
            this.cmb_Interventions.TabIndex = 44;
            // 
            // lbl_WorkingStandards
            // 
            this.lbl_WorkingStandards.AutoSize = true;
            this.lbl_WorkingStandards.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_WorkingStandards.Location = new System.Drawing.Point(9, 88);
            this.lbl_WorkingStandards.Name = "lbl_WorkingStandards";
            this.lbl_WorkingStandards.Size = new System.Drawing.Size(82, 17);
            this.lbl_WorkingStandards.TabIndex = 45;
            this.lbl_WorkingStandards.Text = "Intervention";
            // 
            // rtb_WorkArea
            // 
            this.rtb_WorkArea.Location = new System.Drawing.Point(275, 50);
            this.rtb_WorkArea.Name = "rtb_WorkArea";
            this.rtb_WorkArea.Size = new System.Drawing.Size(131, 25);
            this.rtb_WorkArea.TabIndex = 63;
            this.rtb_WorkArea.Text = "";
            // 
            // lbl_Work_Area
            // 
            this.lbl_Work_Area.AutoSize = true;
            this.lbl_Work_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Work_Area.Location = new System.Drawing.Point(181, 55);
            this.lbl_Work_Area.Name = "lbl_Work_Area";
            this.lbl_Work_Area.Size = new System.Drawing.Size(88, 20);
            this.lbl_Work_Area.TabIndex = 64;
            this.lbl_Work_Area.Text = "Work Area";
            // 
            // rtb_Total
            // 
            this.rtb_Total.Location = new System.Drawing.Point(484, 845);
            this.rtb_Total.Name = "rtb_Total";
            this.rtb_Total.Size = new System.Drawing.Size(134, 41);
            this.rtb_Total.TabIndex = 65;
            this.rtb_Total.Text = "";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(355, 852);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(123, 25);
            this.lbl_Total.TabIndex = 66;
            this.lbl_Total.Text = "Overall Total";
            // 
            // lbl_finalSummaryComments
            // 
            this.lbl_finalSummaryComments.AutoSize = true;
            this.lbl_finalSummaryComments.Location = new System.Drawing.Point(9, 393);
            this.lbl_finalSummaryComments.Name = "lbl_finalSummaryComments";
            this.lbl_finalSummaryComments.Size = new System.Drawing.Size(201, 17);
            this.lbl_finalSummaryComments.TabIndex = 68;
            this.lbl_finalSummaryComments.Text = "Enter final inspection summary";
            // 
            // cmb_InterventionTypes
            // 
            this.cmb_InterventionTypes.FormattingEnabled = true;
            this.cmb_InterventionTypes.Items.AddRange(new object[] {
            "Best practice",
            "Positive intervention",
            "SubContractor"});
            this.cmb_InterventionTypes.Location = new System.Drawing.Point(214, 115);
            this.cmb_InterventionTypes.Name = "cmb_InterventionTypes";
            this.cmb_InterventionTypes.Size = new System.Drawing.Size(192, 24);
            this.cmb_InterventionTypes.TabIndex = 53;
            // 
            // lbl_Protection_Of_Individuals
            // 
            this.lbl_Protection_Of_Individuals.AutoSize = true;
            this.lbl_Protection_Of_Individuals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Protection_Of_Individuals.Location = new System.Drawing.Point(9, 122);
            this.lbl_Protection_Of_Individuals.Name = "lbl_Protection_Of_Individuals";
            this.lbl_Protection_Of_Individuals.Size = new System.Drawing.Size(113, 17);
            this.lbl_Protection_Of_Individuals.TabIndex = 52;
            this.lbl_Protection_Of_Individuals.Text = "Intervention type";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(256, 342);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 79;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(71, 342);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 78;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // pic_viewer
            // 
            this.pic_viewer.Image = global::SE_CWA2020ASN1_Prog.Properties.Resources.Planet9;
            this.pic_viewer.Location = new System.Drawing.Point(2, 273);
            this.pic_viewer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_viewer.Name = "pic_viewer";
            this.pic_viewer.Size = new System.Drawing.Size(404, 64);
            this.pic_viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_viewer.TabIndex = 77;
            this.pic_viewer.TabStop = false;
            // 
            // vsc_actionTaken
            // 
            this.vsc_actionTaken.Location = new System.Drawing.Point(372, 181);
            this.vsc_actionTaken.Name = "vsc_actionTaken";
            this.vsc_actionTaken.Size = new System.Drawing.Size(26, 33);
            this.vsc_actionTaken.TabIndex = 76;
            this.vsc_actionTaken.Visible = false;
            // 
            // vsc_comments
            // 
            this.vsc_comments.Location = new System.Drawing.Point(149, 181);
            this.vsc_comments.Name = "vsc_comments";
            this.vsc_comments.Size = new System.Drawing.Size(26, 33);
            this.vsc_comments.TabIndex = 75;
            this.vsc_comments.Visible = false;
            // 
            // btn_deletePic
            // 
            this.btn_deletePic.Location = new System.Drawing.Point(256, 227);
            this.btn_deletePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deletePic.Name = "btn_deletePic";
            this.btn_deletePic.Size = new System.Drawing.Size(103, 42);
            this.btn_deletePic.TabIndex = 74;
            this.btn_deletePic.Text = "Delete picture";
            this.btn_deletePic.UseVisualStyleBackColor = true;
            this.btn_deletePic.Click += new System.EventHandler(this.btn_deletePic_Click);
            // 
            // btn_takePic
            // 
            this.btn_takePic.Location = new System.Drawing.Point(33, 227);
            this.btn_takePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_takePic.Name = "btn_takePic";
            this.btn_takePic.Size = new System.Drawing.Size(103, 42);
            this.btn_takePic.TabIndex = 73;
            this.btn_takePic.Text = "Take a picture";
            this.btn_takePic.UseVisualStyleBackColor = true;
            this.btn_takePic.Click += new System.EventHandler(this.btn_takePic_Click);
            // 
            // rtx_actionTaken
            // 
            this.rtx_actionTaken.Location = new System.Drawing.Point(239, 181);
            this.rtx_actionTaken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtx_actionTaken.Name = "rtx_actionTaken";
            this.rtx_actionTaken.Size = new System.Drawing.Size(141, 33);
            this.rtx_actionTaken.TabIndex = 72;
            this.rtx_actionTaken.Text = "";
            // 
            // lbl_enterAction
            // 
            this.lbl_enterAction.AutoSize = true;
            this.lbl_enterAction.Location = new System.Drawing.Point(236, 162);
            this.lbl_enterAction.Name = "lbl_enterAction";
            this.lbl_enterAction.Size = new System.Drawing.Size(123, 17);
            this.lbl_enterAction.TabIndex = 71;
            this.lbl_enterAction.Text = "Enter action taken";
            // 
            // lbl_insertComments
            // 
            this.lbl_insertComments.AutoSize = true;
            this.lbl_insertComments.Location = new System.Drawing.Point(9, 162);
            this.lbl_insertComments.Name = "lbl_insertComments";
            this.lbl_insertComments.Size = new System.Drawing.Size(151, 17);
            this.lbl_insertComments.TabIndex = 70;
            this.lbl_insertComments.Text = "Insert comments below";
            // 
            // rtx_comments
            // 
            this.rtx_comments.Location = new System.Drawing.Point(13, 181);
            this.rtx_comments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtx_comments.Name = "rtx_comments";
            this.rtx_comments.Size = new System.Drawing.Size(150, 33);
            this.rtx_comments.TabIndex = 69;
            this.rtx_comments.Text = "";
            // 
            // InspectionSubmission2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 560);
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
            this.Controls.Add(this.cmb_InterventionTypes);
            this.Controls.Add(this.lbl_Protection_Of_Individuals);
            this.Controls.Add(this.lbl_WorkingStandards);
            this.Controls.Add(this.cmb_Interventions);
            this.Controls.Add(this.lbl_GeneralInspection);
            this.Controls.Add(this.btn_ExitNoSave);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.rtb_InspectionComments);
            this.Controls.Add(this.pic_logo);
            this.Name = "InspectionSubmission2";
            this.Text = "Inspection Main";
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_viewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_logo;
        private System.Windows.Forms.RichTextBox rtb_InspectionComments;
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
        private System.Windows.Forms.ComboBox cmb_InterventionTypes;
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
    }
}