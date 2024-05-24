namespace BasicFacebookFeatures
{
    partial class FormProfile
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblBday = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblRelationship = new System.Windows.Forms.Label();
            this.lblSignificantOther = new System.Windows.Forms.LinkLabel();
            this.tbBio = new System.Windows.Forms.TextBox();
            this.lblHometown = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxProfilePic
            // 
            this.picBoxProfilePic.Location = new System.Drawing.Point(13, 22);
            this.picBoxProfilePic.Name = "picBoxProfilePic";
            this.picBoxProfilePic.Size = new System.Drawing.Size(100, 100);
            this.picBoxProfilePic.TabIndex = 0;
            this.picBoxProfilePic.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(119, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Full Name";
            // 
            // lblBday
            // 
            this.lblBday.AutoSize = true;
            this.lblBday.Location = new System.Drawing.Point(132, 56);
            this.lblBday.Name = "lblBday";
            this.lblBday.Size = new System.Drawing.Size(45, 13);
            this.lblBday.TabIndex = 2;
            this.lblBday.Text = "Birthday";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(132, 80);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Gender";
            // 
            // lblRelationship
            // 
            this.lblRelationship.AutoSize = true;
            this.lblRelationship.Location = new System.Drawing.Point(293, 44);
            this.lblRelationship.Name = "lblRelationship";
            this.lblRelationship.Size = new System.Drawing.Size(98, 13);
            this.lblRelationship.TabIndex = 4;
            this.lblRelationship.Text = "Relationship Status";
            // 
            // lblSignificantOther
            // 
            this.lblSignificantOther.AutoSize = true;
            this.lblSignificantOther.Location = new System.Drawing.Point(293, 80);
            this.lblSignificantOther.Name = "lblSignificantOther";
            this.lblSignificantOther.Size = new System.Drawing.Size(85, 13);
            this.lblSignificantOther.TabIndex = 5;
            this.lblSignificantOther.TabStop = true;
            this.lblSignificantOther.Text = "Significant Other";
            this.lblSignificantOther.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSignificantOther_LinkClicked);
            // 
            // tbBio
            // 
            this.tbBio.Location = new System.Drawing.Point(13, 145);
            this.tbBio.Multiline = true;
            this.tbBio.Name = "tbBio";
            this.tbBio.ReadOnly = true;
            this.tbBio.Size = new System.Drawing.Size(250, 104);
            this.tbBio.TabIndex = 6;
            this.tbBio.Text = "Bio";
            // 
            // lblHometown
            // 
            this.lblHometown.AutoSize = true;
            this.lblHometown.Location = new System.Drawing.Point(296, 145);
            this.lblHometown.Name = "lblHometown";
            this.lblHometown.Size = new System.Drawing.Size(65, 13);
            this.lblHometown.TabIndex = 7;
            this.lblHometown.Text = "Home Town";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(299, 209);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(85, 13);
            this.lblLocation.TabIndex = 8;
            this.lblLocation.Text = "Current Location";
            // 
            // FormProfile
            // 
            this.ClientSize = new System.Drawing.Size(426, 261);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblHometown);
            this.Controls.Add(this.tbBio);
            this.Controls.Add(this.lblSignificantOther);
            this.Controls.Add(this.lblRelationship);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBday);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picBoxProfilePic);
            this.Name = "FormProfile";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxProfilePic;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBday;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblRelationship;
        private System.Windows.Forms.LinkLabel lblSignificantOther;
        private System.Windows.Forms.TextBox tbBio;
        private System.Windows.Forms.Label lblHometown;
        private System.Windows.Forms.Label lblLocation;
    }
}