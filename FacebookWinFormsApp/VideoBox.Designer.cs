namespace BasicFacebookFeatures
{
    partial class VideoBox
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
            this.picBoxThumb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThumb)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxThumb
            // 
            this.picBoxThumb.Location = new System.Drawing.Point(3, 3);
            this.picBoxThumb.Name = "picBoxThumb";
            this.picBoxThumb.Size = new System.Drawing.Size(100, 100);
            this.picBoxThumb.TabIndex = 0;
            this.picBoxThumb.TabStop = false;
            this.picBoxThumb.Click += new System.EventHandler(this.picBoxThumb_Click);
            // 
            // VideoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBoxThumb);
            this.Name = "VideoBox";
            this.Size = new System.Drawing.Size(106, 106);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxThumb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxThumb;
    }
}
