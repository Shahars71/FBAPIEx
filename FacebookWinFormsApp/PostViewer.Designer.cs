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
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.lblPostDate = new System.Windows.Forms.Label();
            this.lblLikes = new System.Windows.Forms.Label();
            this.btnLike = new System.Windows.Forms.Button();
            this.pbPoster = new System.Windows.Forms.PictureBox();
            this.pbPostPic = new System.Windows.Forms.PictureBox();
            this.btnUnlike = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPostPic)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPost
            // 
            this.tbPost.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.tbPost.Location = new System.Drawing.Point(119, 33);
            this.tbPost.Multiline = true;
            this.tbPost.Name = "tbPost";
            this.tbPost.ReadOnly = true;
            this.tbPost.Size = new System.Drawing.Size(466, 64);
            this.tbPost.TabIndex = 0;
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.Location = new System.Drawing.Point(119, 114);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(466, 108);
            this.listBoxComments.TabIndex = 3;
            this.listBoxComments.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblPostDate
            // 
            this.lblPostDate.AutoSize = true;
            this.lblPostDate.Location = new System.Drawing.Point(119, 229);
            this.lblPostDate.Name = "lblPostDate";
            this.lblPostDate.Size = new System.Drawing.Size(60, 13);
            this.lblPostDate.TabIndex = 5;
            this.lblPostDate.Text = "Posted On:";
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLikes.Location = new System.Drawing.Point(464, 234);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(18, 18);
            this.lblLikes.TabIndex = 6;
            this.lblLikes.Text = "0";
            // 
            // btnLike
            // 
            this.btnLike.Image = global::BasicFacebookFeatures.Properties.Resources.like;
            this.btnLike.Location = new System.Drawing.Point(488, 228);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(32, 32);
            this.btnLike.TabIndex = 7;
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // pbPoster
            // 
            this.pbPoster.Location = new System.Drawing.Point(3, 33);
            this.pbPoster.Name = "pbPoster";
            this.pbPoster.Size = new System.Drawing.Size(100, 100);
            this.pbPoster.TabIndex = 4;
            this.pbPoster.TabStop = false;
            // 
            // pbPostPic
            // 
            this.pbPostPic.Location = new System.Drawing.Point(618, 23);
            this.pbPostPic.Name = "pbPostPic";
            this.pbPostPic.Size = new System.Drawing.Size(200, 200);
            this.pbPostPic.TabIndex = 2;
            this.pbPostPic.TabStop = false;
            // 
            // btnUnlike
            // 
            this.btnUnlike.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.unlike;
            this.btnUnlike.Enabled = false;
            this.btnUnlike.Location = new System.Drawing.Point(488, 228);
            this.btnUnlike.Name = "btnUnlike";
            this.btnUnlike.Size = new System.Drawing.Size(32, 32);
            this.btnUnlike.TabIndex = 8;
            this.btnUnlike.UseVisualStyleBackColor = true;
            this.btnUnlike.Visible = false;
            this.btnUnlike.Click += new System.EventHandler(this.btnUnlike_Click);
            // 
            // PostViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnUnlike);
            this.Controls.Add(this.btnLike);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.lblPostDate);
            this.Controls.Add(this.pbPoster);
            this.Controls.Add(this.listBoxComments);
            this.Controls.Add(this.pbPostPic);
            this.Controls.Add(this.tbPost);
            this.Name = "PostViewer";
            this.Size = new System.Drawing.Size(880, 264);
            ((System.ComponentModel.ISupportInitialize)(this.pbPoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPostPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPost;
        private System.Windows.Forms.PictureBox pbPostPic;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.PictureBox pbPoster;
        private System.Windows.Forms.Label lblPostDate;
        private System.Windows.Forms.Label lblLikes;
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnUnlike;
    }
}
