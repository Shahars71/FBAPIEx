﻿namespace BasicFacebookFeatures
{
    partial class PageBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picBoxPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxPage
            // 
            this.picBoxPage.Location = new System.Drawing.Point(3, 3);
            this.picBoxPage.Name = "picBoxPage";
            this.picBoxPage.Size = new System.Drawing.Size(100, 100);
            this.picBoxPage.TabIndex = 0;
            this.picBoxPage.TabStop = false;
            // 
            // PageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBoxPage);
            this.Name = "PageBox";
            this.Size = new System.Drawing.Size(106, 106);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxPage;
    }
}