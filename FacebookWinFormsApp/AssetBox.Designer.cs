namespace BasicFacebookFeatures
{
    partial class AssetBox
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
            this.picBoxAsset = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAsset)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxAsset
            // 
            this.picBoxAsset.Location = new System.Drawing.Point(3, 3);
            this.picBoxAsset.Name = "picBoxAsset";
            this.picBoxAsset.Size = new System.Drawing.Size(100, 100);
            this.picBoxAsset.TabIndex = 0;
            this.picBoxAsset.TabStop = false;
            this.picBoxAsset.Click += new System.EventHandler(this.picBoxAsset_Click);
            // 
            // AssetBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBoxAsset);
            this.Name = "AssetBox";
            this.Size = new System.Drawing.Size(106, 106);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAsset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAsset;
    }
}
