namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.picBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.picBoxBorder = new System.Windows.Forms.PictureBox();
            this.flpMainControls = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPosts = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.btnVideos = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPosts = new System.Windows.Forms.TabPage();
            this.tabPhotos = new System.Windows.Forms.TabPage();
            this.flpPhotos = new System.Windows.Forms.FlowLayoutPanel();
            this.tabFriends = new System.Windows.Forms.TabPage();
            this.tabVideos = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBorder)).BeginInit();
            this.flpMainControls.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPhotos.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBoxProfilePic
            // 
            this.picBoxProfilePic.Location = new System.Drawing.Point(13, 13);
            this.picBoxProfilePic.Name = "picBoxProfilePic";
            this.picBoxProfilePic.Size = new System.Drawing.Size(100, 100);
            this.picBoxProfilePic.TabIndex = 0;
            this.picBoxProfilePic.TabStop = false;
            this.picBoxProfilePic.Click += new System.EventHandler(this.picBoxProfilePic_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.labelUserName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.ForeColor = System.Drawing.Color.White;
            this.labelUserName.Location = new System.Drawing.Point(119, 43);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(171, 37);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Full Name";
            // 
            // picBoxBorder
            // 
            this.picBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.picBoxBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxBorder.Location = new System.Drawing.Point(0, 0);
            this.picBoxBorder.Name = "picBoxBorder";
            this.picBoxBorder.Size = new System.Drawing.Size(933, 581);
            this.picBoxBorder.TabIndex = 3;
            this.picBoxBorder.TabStop = false;
            // 
            // flpMainControls
            // 
            this.flpMainControls.Controls.Add(this.btnPosts);
            this.flpMainControls.Controls.Add(this.btnAlbums);
            this.flpMainControls.Controls.Add(this.btnFriends);
            this.flpMainControls.Controls.Add(this.btnVideos);
            this.flpMainControls.Location = new System.Drawing.Point(356, 32);
            this.flpMainControls.Name = "flpMainControls";
            this.flpMainControls.Size = new System.Drawing.Size(540, 72);
            this.flpMainControls.TabIndex = 4;
            // 
            // btnPosts
            // 
            this.btnPosts.Location = new System.Drawing.Point(3, 3);
            this.btnPosts.Name = "btnPosts";
            this.btnPosts.Size = new System.Drawing.Size(67, 67);
            this.btnPosts.TabIndex = 0;
            this.btnPosts.Text = "Posts";
            this.btnPosts.UseVisualStyleBackColor = true;
            this.btnPosts.Click += new System.EventHandler(this.btnPosts_Click);
            // 
            // btnAlbums
            // 
            this.btnAlbums.Location = new System.Drawing.Point(76, 3);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(67, 67);
            this.btnAlbums.TabIndex = 1;
            this.btnAlbums.Text = "Photos";
            this.btnAlbums.UseVisualStyleBackColor = true;
            this.btnAlbums.Click += new System.EventHandler(this.btnAlbums_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.Location = new System.Drawing.Point(149, 3);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(67, 67);
            this.btnFriends.TabIndex = 2;
            this.btnFriends.Text = "Friends";
            this.btnFriends.UseVisualStyleBackColor = true;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // btnVideos
            // 
            this.btnVideos.Location = new System.Drawing.Point(222, 3);
            this.btnVideos.Name = "btnVideos";
            this.btnVideos.Size = new System.Drawing.Size(67, 67);
            this.btnVideos.TabIndex = 3;
            this.btnVideos.Text = "Videos";
            this.btnVideos.UseVisualStyleBackColor = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPosts);
            this.tabControlMain.Controls.Add(this.tabPhotos);
            this.tabControlMain.Controls.Add(this.tabFriends);
            this.tabControlMain.Controls.Add(this.tabVideos);
            this.tabControlMain.Location = new System.Drawing.Point(12, 119);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(909, 450);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabPosts
            // 
            this.tabPosts.AutoScroll = true;
            this.tabPosts.Location = new System.Drawing.Point(4, 22);
            this.tabPosts.Name = "tabPosts";
            this.tabPosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPosts.Size = new System.Drawing.Size(901, 424);
            this.tabPosts.TabIndex = 0;
            this.tabPosts.Text = "Posts";
            this.tabPosts.UseVisualStyleBackColor = true;
            // 
            // tabPhotos
            // 
            this.tabPhotos.Controls.Add(this.flpPhotos);
            this.tabPhotos.Location = new System.Drawing.Point(4, 22);
            this.tabPhotos.Name = "tabPhotos";
            this.tabPhotos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPhotos.Size = new System.Drawing.Size(901, 424);
            this.tabPhotos.TabIndex = 1;
            this.tabPhotos.Text = "Photos";
            this.tabPhotos.UseVisualStyleBackColor = true;
            // 
            // flpPhotos
            // 
            this.flpPhotos.AutoScroll = true;
            this.flpPhotos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(244)))));
            this.flpPhotos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPhotos.Location = new System.Drawing.Point(3, 3);
            this.flpPhotos.Name = "flpPhotos";
            this.flpPhotos.Size = new System.Drawing.Size(895, 418);
            this.flpPhotos.TabIndex = 0;
            // 
            // tabFriends
            // 
            this.tabFriends.Location = new System.Drawing.Point(4, 22);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.Padding = new System.Windows.Forms.Padding(3);
            this.tabFriends.Size = new System.Drawing.Size(901, 424);
            this.tabFriends.TabIndex = 2;
            this.tabFriends.Text = "Friends";
            this.tabFriends.UseVisualStyleBackColor = true;
            // 
            // tabVideos
            // 
            this.tabVideos.Location = new System.Drawing.Point(4, 22);
            this.tabVideos.Name = "tabVideos";
            this.tabVideos.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideos.Size = new System.Drawing.Size(901, 424);
            this.tabVideos.TabIndex = 3;
            this.tabVideos.Text = "Videos";
            this.tabVideos.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 581);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.flpMainControls);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.picBoxProfilePic);
            this.Controls.Add(this.picBoxBorder);
            this.Name = "FormMain";
            this.Text = "Home Page";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBorder)).EndInit();
            this.flpMainControls.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPhotos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxProfilePic;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox picBoxBorder;
        private System.Windows.Forms.FlowLayoutPanel flpMainControls;
        private System.Windows.Forms.Button btnPosts;
        private System.Windows.Forms.TabPage tabPosts;
        private System.Windows.Forms.TabPage tabPhotos;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnFriends;
        private System.Windows.Forms.Button btnVideos;
        private System.Windows.Forms.FlowLayoutPanel flpPhotos;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabFriends;
        private System.Windows.Forms.TabPage tabVideos;
    }
}