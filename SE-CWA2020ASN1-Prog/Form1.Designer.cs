
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
            this.btn_actionComments = new System.Windows.Forms.Button();
            this.btn_exitSystem = new System.Windows.Forms.Button();
            this.btn_goSafetyInspection = new System.Windows.Forms.Button();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_actionComments
            // 
            this.btn_actionComments.Location = new System.Drawing.Point(0, 0);
            this.btn_actionComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_actionComments.Name = "btn_actionComments";
            this.btn_actionComments.Size = new System.Drawing.Size(67, 18);
            this.btn_actionComments.TabIndex = 6;
            // 
            // btn_exitSystem
            // 
            this.btn_exitSystem.Location = new System.Drawing.Point(241, 528);
            this.btn_exitSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exitSystem.Name = "btn_exitSystem";
            this.btn_exitSystem.Size = new System.Drawing.Size(157, 57);
            this.btn_exitSystem.TabIndex = 3;
            this.btn_exitSystem.Text = "Exit system";
            this.btn_exitSystem.UseVisualStyleBackColor = true;
            this.btn_exitSystem.Click += new System.EventHandler(this.btn_exitSystem_Click);
            // 
            // btn_goSafetyInspection
            // 
            this.btn_goSafetyInspection.Location = new System.Drawing.Point(21, 528);
            this.btn_goSafetyInspection.Name = "btn_goSafetyInspection";
            this.btn_goSafetyInspection.Size = new System.Drawing.Size(159, 56);
            this.btn_goSafetyInspection.TabIndex = 4;
            this.btn_goSafetyInspection.Text = "Login";
            this.btn_goSafetyInspection.UseVisualStyleBackColor = true;
            this.btn_goSafetyInspection.Click += new System.EventHandler(this.btn_goSafetyInspection_Click);
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Location = new System.Drawing.Point(38, 310);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(77, 17);
            this.lbl_userName.TabIndex = 97;
            this.lbl_userName.Text = "User name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 98;
            this.label1.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 305);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 99;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(155, 381);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 22);
            this.textBox2.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 101;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 29);
            this.label3.TabIndex = 102;
            this.label3.Text = "Please enter your ligin details!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(436, 641);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.btn_goSafetyInspection);
            this.Controls.Add(this.btn_exitSystem);
            this.Controls.Add(this.btn_actionComments);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_actionComments;
        private System.Windows.Forms.Button btn_exitSystem;
        private System.Windows.Forms.Button btn_goSafetyInspection;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

