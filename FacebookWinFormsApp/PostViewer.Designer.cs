namespace BasicFacebookFeatures
{
    partial class PostViewer
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
            this.tbPost = new System.Windows.Forms.TextBox();
            this.pbPostPic = new System.Windows.Forms.PictureBox();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPostPic)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPost
            // 
            this.tbPost.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPost.Location = new System.Drawing.Point(3, 15);
            this.tbPost.Name = "tbPost";
            this.tbPost.Size = new System.Drawing.Size(622, 48);
            this.tbPost.TabIndex = 0;
            // 
            // pbPostPic
            // 
            this.pbPostPic.Location = new System.Drawing.Point(651, 15);
            this.pbPostPic.Name = "pbPostPic";
            this.pbPostPic.Size = new System.Drawing.Size(100, 97);
            this.pbPostPic.TabIndex = 2;
            this.pbPostPic.TabStop = false;
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.Location = new System.Drawing.Point(3, 69);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(622, 95);
            this.listBoxComments.TabIndex = 3;
            this.listBoxComments.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // PostViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.pbPostPic);
            this.Controls.Add(this.tbPost);
            this.Name = "PostViewer";
            this.Size = new System.Drawing.Size(769, 179);
            ((System.ComponentModel.ISupportInitialize)(this.pbPostPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPost;
        private System.Windows.Forms.PictureBox pbPostPic;
        private System.Windows.Forms.ListBox listBoxComments;
    }
}
