namespace BasicFacebookFeatures
{
    partial class GroupBox
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
            this.picBoxGroup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxGroup
            // 
            this.picBoxGroup.Location = new System.Drawing.Point(3, 3);
            this.picBoxGroup.Name = "picBoxGroup";
            this.picBoxGroup.Size = new System.Drawing.Size(100, 100);
            this.picBoxGroup.TabIndex = 0;
            this.picBoxGroup.TabStop = false;
            // 
            // GroupBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBoxGroup);
            this.Name = "GroupBox";
            this.Size = new System.Drawing.Size(106, 106);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxGroup;
    }
}
