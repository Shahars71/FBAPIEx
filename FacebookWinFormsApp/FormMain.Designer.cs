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
            this.btnPages = new System.Windows.Forms.Button();
            this.btnGroups = new System.Windows.Forms.Button();
            this.tabPages = new System.Windows.Forms.TabPage();
            this.tabGroups = new System.Windows.Forms.TabPage();
            this.flpVideos = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPages = new System.Windows.Forms.FlowLayoutPanel();
            this.flpGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.flpFriends = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBorder)).BeginInit();
            this.flpMainControls.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPosts.SuspendLayout();
            this.tabPhotos.SuspendLayout();
            this.tabFriends.SuspendLayout();
            this.tabVideos.SuspendLayout();
            this.tabPages.SuspendLayout();
            this.tabGroups.SuspendLayout();
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
            this.flpMainControls.Controls.Add(this.btnPages);
            this.flpMainControls.Controls.Add(this.btnGroups);
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
            this.btnVideos.Click += new System.EventHandler(this.btnVideos_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPosts);
            this.tabControlMain.Controls.Add(this.tabPhotos);
            this.tabControlMain.Controls.Add(this.tabFriends);
            this.tabControlMain.Controls.Add(this.tabVideos);
            this.tabControlMain.Controls.Add(this.tabPages);
            this.tabControlMain.Controls.Add(this.tabGroups);
            this.tabControlMain.Location = new System.Drawing.Point(12, 119);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(909, 450);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabPosts
            // 
            this.tabPosts.AutoScroll = true;
            this.tabPosts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(244)))));
            this.tabPosts.Controls.Add(this.flpPosts);
            this.tabPosts.Location = new System.Drawing.Point(4, 22);
            this.tabPosts.Name = "tabPosts";
            this.tabPosts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPosts.Size = new System.Drawing.Size(901, 424);
            this.tabPosts.TabIndex = 0;
            this.tabPosts.Text = "Posts";
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
            this.tabFriends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(244)))));
            this.tabFriends.Controls.Add(this.flpFriends);
            this.tabFriends.Location = new System.Drawing.Point(4, 22);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.Padding = new System.Windows.Forms.Padding(3);
            this.tabFriends.Size = new System.Drawing.Size(901, 424);
            this.tabFriends.TabIndex = 2;
            this.tabFriends.Text = "Friends";
            // 
            // tabVideos
            // 
            this.tabVideos.Controls.Add(this.flpVideos);
            this.tabVideos.Location = new System.Drawing.Point(4, 22);
            this.tabVideos.Name = "tabVideos";
            this.tabVideos.Padding = new System.Windows.Forms.Padding(3);
            this.tabVideos.Size = new System.Drawing.Size(901, 424);
            this.tabVideos.TabIndex = 3;
            this.tabVideos.Text = "Videos";
            this.tabVideos.UseVisualStyleBackColor = true;
            // 
            // btnPages
            // 
            this.btnPages.Location = new System.Drawing.Point(295, 3);
            this.btnPages.Name = "btnPages";
            this.btnPages.Size = new System.Drawing.Size(67, 67);
            this.btnPages.TabIndex = 4;
            this.btnPages.Text = "Pages";
            this.btnPages.UseVisualStyleBackColor = true;
            this.btnPages.Click += new System.EventHandler(this.btnPages_Click);
            // 
            // btnGroups
            // 
            this.btnGroups.Location = new System.Drawing.Point(368, 3);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(67, 67);
            this.btnGroups.TabIndex = 5;
            this.btnGroups.Text = "Groups";
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // tabPages
            // 
            this.tabPages.Controls.Add(this.flpPages);
            this.tabPages.Location = new System.Drawing.Point(4, 22);
            this.tabPages.Name = "tabPages";
            this.tabPages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPages.Size = new System.Drawing.Size(901, 424);
            this.tabPages.TabIndex = 4;
            this.tabPages.Text = "Pages";
            this.tabPages.UseVisualStyleBackColor = true;
            // 
            // tabGroups
            // 
            this.tabGroups.Controls.Add(this.flpGroups);
            this.tabGroups.Location = new System.Drawing.Point(4, 22);
            this.tabGroups.Name = "tabGroups";
            this.tabGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabGroups.Size = new System.Drawing.Size(901, 424);
            this.tabGroups.TabIndex = 5;
            this.tabGroups.Text = "Groups";
            this.tabGroups.UseVisualStyleBackColor = true;
            // 
            // flpVideos
            // 
            this.flpVideos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(244)))));
            this.flpVideos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpVideos.Location = new System.Drawing.Point(3, 3);
            this.flpVideos.Name = "flpVideos";
            this.flpVideos.Size = new System.Drawing.Size(895, 418);
            this.flpVideos.TabIndex = 0;
            // 
            // flpPages
            // 
            this.flpPages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(244)))));
            this.flpPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPages.Location = new System.Drawing.Point(3, 3);
            this.flpPages.Name = "flpPages";
            this.flpPages.Size = new System.Drawing.Size(895, 418);
            this.flpPages.TabIndex = 0;
            // 
            // flpGroups
            // 
            this.flpGroups.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(244)))));
            this.flpGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGroups.Location = new System.Drawing.Point(3, 3);
            this.flpGroups.Name = "flpGroups";
            this.flpGroups.Size = new System.Drawing.Size(895, 418);
            this.flpGroups.TabIndex = 0;
            // 
            // flpPosts
            // 
            this.flpPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPosts.Location = new System.Drawing.Point(3, 3);
            this.flpPosts.Name = "flpPosts";
            this.flpPosts.Size = new System.Drawing.Size(895, 418);
            this.flpPosts.TabIndex = 0;
            // 
            // flpFriends
            // 
            this.flpFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpFriends.Location = new System.Drawing.Point(3, 3);
            this.flpFriends.Name = "flpFriends";
            this.flpFriends.Size = new System.Drawing.Size(895, 418);
            this.flpFriends.TabIndex = 0;
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
            this.tabPosts.ResumeLayout(false);
            this.tabPhotos.ResumeLayout(false);
            this.tabFriends.ResumeLayout(false);
            this.tabVideos.ResumeLayout(false);
            this.tabPages.ResumeLayout(false);
            this.tabGroups.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnPages;
        private System.Windows.Forms.Button btnGroups;
        private System.Windows.Forms.TabPage tabPages;
        private System.Windows.Forms.TabPage tabGroups;
        private System.Windows.Forms.FlowLayoutPanel flpVideos;
        private System.Windows.Forms.FlowLayoutPanel flpPages;
        private System.Windows.Forms.FlowLayoutPanel flpGroups;
        private System.Windows.Forms.FlowLayoutPanel flpPosts;
        private System.Windows.Forms.FlowLayoutPanel flpFriends;
    }
}