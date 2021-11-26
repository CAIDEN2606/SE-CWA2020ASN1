
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
            this.rtb_InspectCommsSummary = new System.Windows.Forms.RichTextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_ExitNoSave = new System.Windows.Forms.Button();
            this.lbl_GeneralInspection = new System.Windows.Forms.Label();
            this.cmb_Interventions = new System.Windows.Forms.ComboBox();
            this.lbl_WorkingStandards = new System.Windows.Forms.Label();
            this.rtb_WorkArea = new System.Windows.Forms.RichTextBox();
            this.lbl_Work_Area = new System.Windows.Forms.Label();
            this.lbl_finalSummaryComments = new System.Windows.Forms.Label();
            this.cmb_TypesOfIntervention = new System.Windows.Forms.ComboBox();
            this.lbl_Protection_Of_Individuals = new System.Windows.Forms.Label();
            this.btn_takePic = new System.Windows.Forms.Button();
            this.rtx_actionTaken = new System.Windows.Forms.RichTextBox();
            this.lbl_enterAction = new System.Windows.Forms.Label();
            this.lbl_insertComments = new System.Windows.Forms.Label();
            this.rtx_comments = new System.Windows.Forms.RichTextBox();
            this.btn_saveIntervention = new System.Windows.Forms.Button();
            this.lbl_totalInterventions = new System.Windows.Forms.Label();
            this.rtx_displayTotalInterv = new System.Windows.Forms.TextBox();
            this.lst_pics = new System.Windows.Forms.ListBox();
            this.lst_interventions = new System.Windows.Forms.ListBox();
            this.lbl_listInterventions = new System.Windows.Forms.Label();
            this.lbl_listOfPics = new System.Windows.Forms.Label();
            this.pic_intervPics = new System.Windows.Forms.PictureBox();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_intervPics)).BeginInit();
            this.SuspendLayout();
            // 
            // rtb_InspectCommsSummary
            // 
            this.rtb_InspectCommsSummary.Location = new System.Drawing.Point(14, 656);
            this.rtb_InspectCommsSummary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_InspectCommsSummary.Name = "rtb_InspectCommsSummary";
            this.rtb_InspectCommsSummary.Size = new System.Drawing.Size(425, 60);
            this.rtb_InspectCommsSummary.TabIndex = 39;
            this.rtb_InspectCommsSummary.Text = "";
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(14, 724);
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
            this.btn_ExitNoSave.Location = new System.Drawing.Point(245, 724);
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
            this.lbl_GeneralInspection.Location = new System.Drawing.Point(12, 9);
            this.lbl_GeneralInspection.Name = "lbl_GeneralInspection";
            this.lbl_GeneralInspection.Size = new System.Drawing.Size(249, 29);
            this.lbl_GeneralInspection.TabIndex = 43;
            this.lbl_GeneralInspection.Text = "ADD INTERVENTION";
            // 
            // cmb_Interventions
            // 
            this.cmb_Interventions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Interventions.FormattingEnabled = true;
            this.cmb_Interventions.Location = new System.Drawing.Point(164, 102);
            this.cmb_Interventions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_Interventions.Name = "cmb_Interventions";
            this.cmb_Interventions.Size = new System.Drawing.Size(275, 28);
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
            this.rtb_WorkArea.Location = new System.Drawing.Point(164, 64);
            this.rtb_WorkArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtb_WorkArea.Name = "rtb_WorkArea";
            this.rtb_WorkArea.Size = new System.Drawing.Size(272, 30);
            this.rtb_WorkArea.TabIndex = 63;
            this.rtb_WorkArea.Text = "";
            // 
            // lbl_Work_Area
            // 
            this.lbl_Work_Area.AutoSize = true;
            this.lbl_Work_Area.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Work_Area.Location = new System.Drawing.Point(12, 68);
            this.lbl_Work_Area.Name = "lbl_Work_Area";
            this.lbl_Work_Area.Size = new System.Drawing.Size(113, 25);
            this.lbl_Work_Area.TabIndex = 64;
            this.lbl_Work_Area.Text = "Work Area";
            // 
            // lbl_finalSummaryComments
            // 
            this.lbl_finalSummaryComments.AutoSize = true;
            this.lbl_finalSummaryComments.Location = new System.Drawing.Point(10, 632);
            this.lbl_finalSummaryComments.Name = "lbl_finalSummaryComments";
            this.lbl_finalSummaryComments.Size = new System.Drawing.Size(225, 20);
            this.lbl_finalSummaryComments.TabIndex = 68;
            this.lbl_finalSummaryComments.Text = "Enter final inspection summary";
            // 
            // cmb_TypesOfIntervention
            // 
            this.cmb_TypesOfIntervention.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TypesOfIntervention.FormattingEnabled = true;
            this.cmb_TypesOfIntervention.Items.AddRange(new object[] {
            "Best practice",
            "Positive intervention",
            "SubContractor"});
            this.cmb_TypesOfIntervention.Location = new System.Drawing.Point(164, 139);
            this.cmb_TypesOfIntervention.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmb_TypesOfIntervention.Name = "cmb_TypesOfIntervention";
            this.cmb_TypesOfIntervention.Size = new System.Drawing.Size(275, 28);
            this.cmb_TypesOfIntervention.TabIndex = 53;
            // 
            // lbl_Protection_Of_Individuals
            // 
            this.lbl_Protection_Of_Individuals.AutoSize = true;
            this.lbl_Protection_Of_Individuals.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Protection_Of_Individuals.Location = new System.Drawing.Point(10, 147);
            this.lbl_Protection_Of_Individuals.Name = "lbl_Protection_Of_Individuals";
            this.lbl_Protection_Of_Individuals.Size = new System.Drawing.Size(127, 20);
            this.lbl_Protection_Of_Individuals.TabIndex = 52;
            this.lbl_Protection_Of_Individuals.Text = "Intervention type";
            // 
            // btn_takePic
            // 
            this.btn_takePic.Location = new System.Drawing.Point(41, 317);
            this.btn_takePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_takePic.Name = "btn_takePic";
            this.btn_takePic.Size = new System.Drawing.Size(81, 63);
            this.btn_takePic.TabIndex = 73;
            this.btn_takePic.Text = "Take a picture";
            this.btn_takePic.UseVisualStyleBackColor = true;
            this.btn_takePic.Click += new System.EventHandler(this.btn_takePic_Click);
            // 
            // rtx_actionTaken
            // 
            this.rtx_actionTaken.Location = new System.Drawing.Point(238, 212);
            this.rtx_actionTaken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtx_actionTaken.Name = "rtx_actionTaken";
            this.rtx_actionTaken.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtx_actionTaken.Size = new System.Drawing.Size(184, 76);
            this.rtx_actionTaken.TabIndex = 72;
            this.rtx_actionTaken.Text = "";
            // 
            // lbl_enterAction
            // 
            this.lbl_enterAction.AutoSize = true;
            this.lbl_enterAction.Location = new System.Drawing.Point(234, 190);
            this.lbl_enterAction.Name = "lbl_enterAction";
            this.lbl_enterAction.Size = new System.Drawing.Size(139, 20);
            this.lbl_enterAction.TabIndex = 71;
            this.lbl_enterAction.Text = "Enter action taken";
            // 
            // lbl_insertComments
            // 
            this.lbl_insertComments.AutoSize = true;
            this.lbl_insertComments.Location = new System.Drawing.Point(13, 190);
            this.lbl_insertComments.Name = "lbl_insertComments";
            this.lbl_insertComments.Size = new System.Drawing.Size(173, 20);
            this.lbl_insertComments.TabIndex = 70;
            this.lbl_insertComments.Text = "Insert comments below";
            // 
            // rtx_comments
            // 
            this.rtx_comments.Location = new System.Drawing.Point(17, 212);
            this.rtx_comments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtx_comments.Name = "rtx_comments";
            this.rtx_comments.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtx_comments.Size = new System.Drawing.Size(196, 76);
            this.rtx_comments.TabIndex = 69;
            this.rtx_comments.Text = "";
            // 
            // btn_saveIntervention
            // 
            this.btn_saveIntervention.Location = new System.Drawing.Point(108, 481);
            this.btn_saveIntervention.Name = "btn_saveIntervention";
            this.btn_saveIntervention.Size = new System.Drawing.Size(237, 43);
            this.btn_saveIntervention.TabIndex = 80;
            this.btn_saveIntervention.Text = "Save Intervention";
            this.btn_saveIntervention.UseVisualStyleBackColor = true;
            this.btn_saveIntervention.Click += new System.EventHandler(this.btn_saveIntervention_Click);
            // 
            // lbl_totalInterventions
            // 
            this.lbl_totalInterventions.AutoSize = true;
            this.lbl_totalInterventions.Location = new System.Drawing.Point(267, 26);
            this.lbl_totalInterventions.Name = "lbl_totalInterventions";
            this.lbl_totalInterventions.Size = new System.Drawing.Size(138, 20);
            this.lbl_totalInterventions.TabIndex = 83;
            this.lbl_totalInterventions.Text = "Total interventions";
            // 
            // rtx_displayTotalInterv
            // 
            this.rtx_displayTotalInterv.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtx_displayTotalInterv.Location = new System.Drawing.Point(413, 23);
            this.rtx_displayTotalInterv.Name = "rtx_displayTotalInterv";
            this.rtx_displayTotalInterv.ReadOnly = true;
            this.rtx_displayTotalInterv.Size = new System.Drawing.Size(26, 26);
            this.rtx_displayTotalInterv.TabIndex = 84;
            // 
            // lst_pics
            // 
            this.lst_pics.FormattingEnabled = true;
            this.lst_pics.ItemHeight = 20;
            this.lst_pics.Items.AddRange(new object[] {
            "img1",
            "img2",
            "img3"});
            this.lst_pics.Location = new System.Drawing.Point(145, 353);
            this.lst_pics.Name = "lst_pics";
            this.lst_pics.Size = new System.Drawing.Size(78, 84);
            this.lst_pics.Sorted = true;
            this.lst_pics.TabIndex = 85;
            this.lst_pics.SelectedIndexChanged += new System.EventHandler(this.lst_pics_SelectedIndexChanged);
            // 
            // lst_interventions
            // 
            this.lst_interventions.FormattingEnabled = true;
            this.lst_interventions.ItemHeight = 20;
            this.lst_interventions.Location = new System.Drawing.Point(235, 541);
            this.lst_interventions.Name = "lst_interventions";
            this.lst_interventions.ScrollAlwaysVisible = true;
            this.lst_interventions.Size = new System.Drawing.Size(201, 84);
            this.lst_interventions.TabIndex = 86;
            // 
            // lbl_listInterventions
            // 
            this.lbl_listInterventions.AutoSize = true;
            this.lbl_listInterventions.Location = new System.Drawing.Point(62, 569);
            this.lbl_listInterventions.Name = "lbl_listInterventions";
            this.lbl_listInterventions.Size = new System.Drawing.Size(146, 20);
            this.lbl_listInterventions.TabIndex = 87;
            this.lbl_listInterventions.Text = "List of interventions";
            // 
            // lbl_listOfPics
            // 
            this.lbl_listOfPics.AutoSize = true;
            this.lbl_listOfPics.Location = new System.Drawing.Point(139, 330);
            this.lbl_listOfPics.Name = "lbl_listOfPics";
            this.lbl_listOfPics.Size = new System.Drawing.Size(112, 20);
            this.lbl_listOfPics.TabIndex = 88;
            this.lbl_listOfPics.Text = "List of pictures";
            // 
            // pic_intervPics
            // 
            this.pic_intervPics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_intervPics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_intervPics.Image = global::SE_CWA2020ASN1_Prog.Properties.Resources.musk_logo;
            this.pic_intervPics.Location = new System.Drawing.Point(271, 330);
            this.pic_intervPics.Name = "pic_intervPics";
            this.pic_intervPics.Size = new System.Drawing.Size(168, 135);
            this.pic_intervPics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_intervPics.TabIndex = 89;
            this.pic_intervPics.TabStop = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(41, 402);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 63);
            this.btn_delete.TabIndex = 90;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // InspectionSubmission2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 801);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.pic_intervPics);
            this.Controls.Add(this.lbl_listOfPics);
            this.Controls.Add(this.lbl_listInterventions);
            this.Controls.Add(this.lst_interventions);
            this.Controls.Add(this.lst_pics);
            this.Controls.Add(this.rtx_displayTotalInterv);
            this.Controls.Add(this.lbl_totalInterventions);
            this.Controls.Add(this.btn_saveIntervention);
            this.Controls.Add(this.btn_takePic);
            this.Controls.Add(this.rtx_actionTaken);
            this.Controls.Add(this.lbl_enterAction);
            this.Controls.Add(this.lbl_insertComments);
            this.Controls.Add(this.rtx_comments);
            this.Controls.Add(this.lbl_finalSummaryComments);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InspectionSubmission2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Inspection Main";
            ((System.ComponentModel.ISupportInitialize)(this.pic_intervPics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtb_InspectCommsSummary;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_ExitNoSave;
        private System.Windows.Forms.Label lbl_GeneralInspection;
        private System.Windows.Forms.ComboBox cmb_Interventions;
        private System.Windows.Forms.Label lbl_WorkingStandards;
        private System.Windows.Forms.RichTextBox rtb_WorkArea;
        private System.Windows.Forms.Label lbl_Work_Area;
        private System.Windows.Forms.Label lbl_finalSummaryComments;
        private System.Windows.Forms.ComboBox cmb_TypesOfIntervention;
        private System.Windows.Forms.Label lbl_Protection_Of_Individuals;
        private System.Windows.Forms.Button btn_takePic;
        private System.Windows.Forms.RichTextBox rtx_actionTaken;
        private System.Windows.Forms.Label lbl_enterAction;
        private System.Windows.Forms.Label lbl_insertComments;
        private System.Windows.Forms.RichTextBox rtx_comments;
        private System.Windows.Forms.Button btn_saveIntervention;
        private System.Windows.Forms.Label lbl_totalInterventions;
        private System.Windows.Forms.TextBox rtx_displayTotalInterv;
        private System.Windows.Forms.ListBox lst_pics;
        private System.Windows.Forms.ListBox lst_interventions;
        private System.Windows.Forms.Label lbl_listInterventions;
        private System.Windows.Forms.Label lbl_listOfPics;
        private System.Windows.Forms.PictureBox pic_intervPics;
        private System.Windows.Forms.Button btn_delete;
    }
}