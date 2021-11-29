
namespace SE_CWA2020ASN1_Prog
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
            this.lbl_Caiden = new System.Windows.Forms.Label();
            this.btn_actionComments = new System.Windows.Forms.Button();
            this.btn_exitSystem = new System.Windows.Forms.Button();
            this.btn_goSafetyInspection = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.pic_intervPics = new System.Windows.Forms.PictureBox();
            this.lbl_listOfPics = new System.Windows.Forms.Label();
            this.lst_pics = new System.Windows.Forms.ListBox();
            this.btn_takePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_intervPics)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Caiden
            // 
            this.lbl_Caiden.AutoSize = true;
            this.lbl_Caiden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caiden.Location = new System.Drawing.Point(11, 382);
            this.lbl_Caiden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Caiden.Name = "lbl_Caiden";
            this.lbl_Caiden.Size = new System.Drawing.Size(853, 58);
            this.lbl_Caiden.TabIndex = 1;
            this.lbl_Caiden.Text = "We can use this as a message board and navigation page to each form while in\r\n pr" +
    "oduction phase. Then change to a fancy MUSK front page.\r\n";
            // 
            // btn_actionComments
            // 
            this.btn_actionComments.Location = new System.Drawing.Point(0, 0);
            this.btn_actionComments.Name = "btn_actionComments";
            this.btn_actionComments.Size = new System.Drawing.Size(75, 23);
            this.btn_actionComments.TabIndex = 6;
            // 
            // btn_exitSystem
            // 
            this.btn_exitSystem.Location = new System.Drawing.Point(662, 455);
            this.btn_exitSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exitSystem.Name = "btn_exitSystem";
            this.btn_exitSystem.Size = new System.Drawing.Size(177, 71);
            this.btn_exitSystem.TabIndex = 3;
            this.btn_exitSystem.Text = "Exit system";
            this.btn_exitSystem.UseVisualStyleBackColor = true;
            this.btn_exitSystem.Click += new System.EventHandler(this.btn_exitSystem_Click);
            // 
            // btn_goSafetyInspection
            // 
            this.btn_goSafetyInspection.Location = new System.Drawing.Point(51, 456);
            this.btn_goSafetyInspection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_goSafetyInspection.Name = "btn_goSafetyInspection";
            this.btn_goSafetyInspection.Size = new System.Drawing.Size(179, 70);
            this.btn_goSafetyInspection.TabIndex = 4;
            this.btn_goSafetyInspection.Text = "Safety inspection page(1st)";
            this.btn_goSafetyInspection.UseVisualStyleBackColor = true;
            this.btn_goSafetyInspection.Click += new System.EventHandler(this.btn_goSafetyInspection_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(85, 154);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 63);
            this.btn_delete.TabIndex = 96;
            this.btn_delete.Text = "delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // pic_intervPics
            // 
            this.pic_intervPics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_intervPics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_intervPics.Image = global::SE_CWA2020ASN1_Prog.Properties.Resources.musk_logo;
            this.pic_intervPics.Location = new System.Drawing.Point(315, 82);
            this.pic_intervPics.Name = "pic_intervPics";
            this.pic_intervPics.Size = new System.Drawing.Size(168, 135);
            this.pic_intervPics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_intervPics.TabIndex = 95;
            this.pic_intervPics.TabStop = false;
            // 
            // lbl_listOfPics
            // 
            this.lbl_listOfPics.AutoSize = true;
            this.lbl_listOfPics.Location = new System.Drawing.Point(183, 82);
            this.lbl_listOfPics.Name = "lbl_listOfPics";
            this.lbl_listOfPics.Size = new System.Drawing.Size(112, 20);
            this.lbl_listOfPics.TabIndex = 94;
            this.lbl_listOfPics.Text = "List of pictures";
            // 
            // lst_pics
            // 
            this.lst_pics.FormattingEnabled = true;
            this.lst_pics.ItemHeight = 20;
            this.lst_pics.Items.AddRange(new object[] {
            "img1",
            "img2",
            "img3"});
            this.lst_pics.Location = new System.Drawing.Point(189, 105);
            this.lst_pics.Name = "lst_pics";
            this.lst_pics.Size = new System.Drawing.Size(78, 84);
            this.lst_pics.Sorted = true;
            this.lst_pics.TabIndex = 93;
            this.lst_pics.SelectedIndexChanged += new System.EventHandler(this.lst_pics_SelectedIndexChanged);
            // 
            // btn_takePic
            // 
            this.btn_takePic.Location = new System.Drawing.Point(85, 69);
            this.btn_takePic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_takePic.Name = "btn_takePic";
            this.btn_takePic.Size = new System.Drawing.Size(81, 63);
            this.btn_takePic.TabIndex = 91;
            this.btn_takePic.Text = "Take a picture";
            this.btn_takePic.UseVisualStyleBackColor = true;
            this.btn_takePic.Click += new System.EventHandler(this.btn_takePic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 562);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.pic_intervPics);
            this.Controls.Add(this.lbl_listOfPics);
            this.Controls.Add(this.lst_pics);
            this.Controls.Add(this.btn_takePic);
            this.Controls.Add(this.btn_goSafetyInspection);
            this.Controls.Add(this.btn_exitSystem);
            this.Controls.Add(this.btn_actionComments);
            this.Controls.Add(this.lbl_Caiden);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_intervPics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Caiden;
        private System.Windows.Forms.Button btn_actionComments;
        private System.Windows.Forms.Button btn_exitSystem;
        private System.Windows.Forms.Button btn_goSafetyInspection;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.PictureBox pic_intervPics;
        private System.Windows.Forms.Label lbl_listOfPics;
        private System.Windows.Forms.ListBox lst_pics;
        private System.Windows.Forms.Button btn_takePic;
    }
}

