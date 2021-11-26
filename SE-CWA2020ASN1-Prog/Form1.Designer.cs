
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Test = new System.Windows.Forms.Label();
            this.lbl_Caiden = new System.Windows.Forms.Label();
            this.btn_exitSystem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Test
            // 
            this.lbl_Test.AutoSize = true;
            this.lbl_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Test.Location = new System.Drawing.Point(14, 12);
            this.lbl_Test.Name = "lbl_Test";
            this.lbl_Test.Size = new System.Drawing.Size(854, 232);
            this.lbl_Test.TabIndex = 0;
            this.lbl_Test.Text = resources.GetString("lbl_Test.Text");
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
            // btn_exitSystem
            // 
            this.btn_exitSystem.Location = new System.Drawing.Point(662, 455);
            this.btn_exitSystem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exitSystem.Name = "btn_exitSystem";
            this.btn_exitSystem.Size = new System.Drawing.Size(177, 71);
            this.btn_exitSystem.TabIndex = 3;
            this.btn_exitSystem.Text = "Exit system";
            this.btn_exitSystem.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 562);
            this.Controls.Add(this.btn_exitSystem);
            this.Controls.Add(this.lbl_Caiden);
            this.Controls.Add(this.lbl_Test);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Test;
        private System.Windows.Forms.Label lbl_Caiden;
        private System.Windows.Forms.Button btn_exitSystem;
    }
}

