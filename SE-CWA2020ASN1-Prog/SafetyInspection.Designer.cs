
namespace SE_CWA2020ASN1_Prog
{
    partial class SafetyInspection
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.cmbEnterSite = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_workArea = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_jobDescription = new System.Windows.Forms.TextBox();
            this.cmbEnterType = new System.Windows.Forms.ComboBox();
            this.txt_supervisor = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Safety Inspection Audit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inspection by";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter site";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter work area";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter job description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Enter type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Enter supervisor";
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(298, 379);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(75, 23);
            this.btn_Enter.TabIndex = 8;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(522, 379);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // cmbEnterSite
            // 
            this.cmbEnterSite.FormattingEnabled = true;
            this.cmbEnterSite.Location = new System.Drawing.Point(351, 106);
            this.cmbEnterSite.Name = "cmbEnterSite";
            this.cmbEnterSite.Size = new System.Drawing.Size(198, 24);
            this.cmbEnterSite.TabIndex = 10;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(351, 71);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(198, 22);
            this.txt_name.TabIndex = 11;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_workArea
            // 
            this.txt_workArea.Location = new System.Drawing.Point(351, 153);
            this.txt_workArea.MaxLength = 20;
            this.txt_workArea.Name = "txt_workArea";
            this.txt_workArea.Size = new System.Drawing.Size(198, 22);
            this.txt_workArea.TabIndex = 12;
            this.txt_workArea.TextChanged += new System.EventHandler(this.txt_workArea_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(351, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // txt_jobDescription
            // 
            this.txt_jobDescription.Location = new System.Drawing.Point(351, 239);
            this.txt_jobDescription.MaxLength = 20;
            this.txt_jobDescription.Name = "txt_jobDescription";
            this.txt_jobDescription.Size = new System.Drawing.Size(198, 22);
            this.txt_jobDescription.TabIndex = 14;
            this.txt_jobDescription.TextChanged += new System.EventHandler(this.txt_jobDescription_TextChanged);
            // 
            // cmbEnterType
            // 
            this.cmbEnterType.FormattingEnabled = true;
            this.cmbEnterType.Location = new System.Drawing.Point(351, 281);
            this.cmbEnterType.Name = "cmbEnterType";
            this.cmbEnterType.Size = new System.Drawing.Size(198, 24);
            this.cmbEnterType.TabIndex = 15;
            // 
            // txt_supervisor
            // 
            this.txt_supervisor.Location = new System.Drawing.Point(351, 321);
            this.txt_supervisor.Name = "txt_supervisor";
            this.txt_supervisor.Size = new System.Drawing.Size(198, 22);
            this.txt_supervisor.TabIndex = 16;
            this.txt_supervisor.TextChanged += new System.EventHandler(this.txt_supervisor_TextChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(412, 379);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // SafetyInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_supervisor);
            this.Controls.Add(this.cmbEnterType);
            this.Controls.Add(this.txt_jobDescription);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_workArea);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.cmbEnterSite);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SafetyInspection";
            this.Text = "SafetyInspection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox cmbEnterSite;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_workArea;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_jobDescription;
        private System.Windows.Forms.ComboBox cmbEnterType;
        private System.Windows.Forms.TextBox txt_supervisor;
        private System.Windows.Forms.Button btn_back;
    }
}