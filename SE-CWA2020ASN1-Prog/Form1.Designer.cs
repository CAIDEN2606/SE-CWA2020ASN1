
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
            this.SuspendLayout();
            // 
            // lbl_Test
            // 
            this.lbl_Test.AutoSize = true;
            this.lbl_Test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Test.Location = new System.Drawing.Point(16, 14);
            this.lbl_Test.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Test.Name = "lbl_Test";
            this.lbl_Test.Size = new System.Drawing.Size(1140, 224);
            this.lbl_Test.TabIndex = 0;
            this.lbl_Test.Text = resources.GetString("lbl_Test.Text");
            // 
            // lbl_Caiden
            // 
            this.lbl_Caiden.AutoSize = true;
            this.lbl_Caiden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Caiden.Location = new System.Drawing.Point(22, 615);
            this.lbl_Caiden.Name = "lbl_Caiden";
            this.lbl_Caiden.Size = new System.Drawing.Size(204, 32);
            this.lbl_Caiden.TabIndex = 1;
            this.lbl_Caiden.Text = "Caiden\'s TEST";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 675);
            this.Controls.Add(this.lbl_Caiden);
            this.Controls.Add(this.lbl_Test);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Test;
        private System.Windows.Forms.Label lbl_Caiden;
    }
}

