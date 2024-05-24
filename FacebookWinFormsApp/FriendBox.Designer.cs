namespace BasicFacebookFeatures
{
    partial class FriendBox
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
            this.picBoxFriend = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFriend)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxFriend
            // 
            this.picBoxFriend.Location = new System.Drawing.Point(5, 5);
            this.picBoxFriend.Name = "picBoxFriend";
            this.picBoxFriend.Size = new System.Drawing.Size(100, 100);
            this.picBoxFriend.TabIndex = 0;
            this.picBoxFriend.TabStop = false;
            this.picBoxFriend.Click += new System.EventHandler(this.picBoxFriend_Click);
            // 
            // FriendBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.picBoxFriend);
            this.Name = "FriendBox";
            this.Size = new System.Drawing.Size(110, 110);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFriend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxFriend;
    }
}
