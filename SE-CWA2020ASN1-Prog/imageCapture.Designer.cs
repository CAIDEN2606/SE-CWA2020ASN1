
namespace SE_CWA2020ASN1_Prog
{
    partial class ImageCapture
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
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pic_captureImage = new System.Windows.Forms.PictureBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_captureImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(48, 444);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(173, 53);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(371, 444);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(161, 53);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pic_captureImage
            // 
            this.pic_captureImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic_captureImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_captureImage.Location = new System.Drawing.Point(0, 0);
            this.pic_captureImage.Name = "pic_captureImage";
            this.pic_captureImage.Size = new System.Drawing.Size(987, 426);
            this.pic_captureImage.TabIndex = 0;
            this.pic_captureImage.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(698, 444);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(131, 53);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ImageCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(987, 526);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pic_captureImage);
            this.Name = "ImageCapture";
            this.Text = "imageCapture";
            ((System.ComponentModel.ISupportInitialize)(this.pic_captureImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_captureImage;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}