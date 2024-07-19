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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label aboutLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label hometownLabel;
            System.Windows.Forms.Label locationLabel2;
            System.Windows.Forms.Label relationshipStatusLabel;
            this.picBoxProfilePic = new System.Windows.Forms.PictureBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.userFacadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birthdayLabel1 = new System.Windows.Forms.Label();
            this.genderLabel1 = new System.Windows.Forms.Label();
            this.hometownLabel1 = new System.Windows.Forms.Label();
            this.locationLabel1 = new System.Windows.Forms.Label();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.relationshipStatusLabel1 = new System.Windows.Forms.Label();
            this.linkLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelFBProfile = new System.Windows.Forms.LinkLabel();
            this.lblEmail = new System.Windows.Forms.Label();
            aboutLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            hometownLabel = new System.Windows.Forms.Label();
            locationLabel2 = new System.Windows.Forms.Label();
            relationshipStatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFacadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            aboutLabel.AutoSize = true;
            aboutLabel.Location = new System.Drawing.Point(10, 200);
            aboutLabel.Name = "aboutLabel";
            aboutLabel.Size = new System.Drawing.Size(38, 13);
            aboutLabel.TabIndex = 10;
            aboutLabel.Text = "About:";
            aboutLabel.Click += new System.EventHandler(this.aboutLabel_Click);
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.Location = new System.Drawing.Point(276, 76);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(66, 15);
            birthdayLabel.TabIndex = 12;
            birthdayLabel.Text = "Birthday:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(201, 238);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(48, 15);
            emailLabel.TabIndex = 14;
            emailLabel.Text = "Email:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(118, 72);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(68, 17);
            genderLabel.TabIndex = 16;
            genderLabel.Text = "Gender:";
            // 
            // hometownLabel
            // 
            hometownLabel.AutoSize = true;
            hometownLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hometownLabel.Location = new System.Drawing.Point(275, 116);
            hometownLabel.Name = "hometownLabel";
            hometownLabel.Size = new System.Drawing.Size(81, 15);
            hometownLabel.TabIndex = 18;
            hometownLabel.Text = "Hometown:";
            // 
            // locationLabel2
            // 
            locationLabel2.AutoSize = true;
            locationLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locationLabel2.Location = new System.Drawing.Point(275, 152);
            locationLabel2.Name = "locationLabel2";
            locationLabel2.Size = new System.Drawing.Size(68, 15);
            locationLabel2.TabIndex = 22;
            locationLabel2.Text = "Location:";
            // 
            // relationshipStatusLabel
            // 
            relationshipStatusLabel.AutoSize = true;
            relationshipStatusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            relationshipStatusLabel.Location = new System.Drawing.Point(12, 125);
            relationshipStatusLabel.Name = "relationshipStatusLabel";
            relationshipStatusLabel.Size = new System.Drawing.Size(153, 17);
            relationshipStatusLabel.TabIndex = 26;
            relationshipStatusLabel.Text = "Relationship Status:";
            relationshipStatusLabel.Click += new System.EventHandler(this.relationshipStatusLabel_Click);
            // 
            // picBoxProfilePic
            // 
            this.picBoxProfilePic.Location = new System.Drawing.Point(13, 22);
            this.picBoxProfilePic.Name = "picBoxProfilePic";
            this.picBoxProfilePic.Size = new System.Drawing.Size(100, 100);
            this.picBoxProfilePic.TabIndex = 0;
            this.picBoxProfilePic.TabStop = false;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "About", true));
            this.aboutTextBox.Location = new System.Drawing.Point(12, 216);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(183, 71);
            this.aboutTextBox.TabIndex = 11;
            this.aboutTextBox.TextChanged += new System.EventHandler(this.aboutTextBox_TextChanged);
            // 
            // userFacadeBindingSource
            // 
            this.userFacadeBindingSource.DataSource = typeof(BasicFacebookFeatures.UserFacade);
            this.userFacadeBindingSource.CurrentChanged += new System.EventHandler(this.userFacadeBindingSource_CurrentChanged);
            // 
            // birthdayLabel1
            // 
            this.birthdayLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Birthday", true));
            this.birthdayLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayLabel1.Location = new System.Drawing.Point(276, 92);
            this.birthdayLabel1.Name = "birthdayLabel1";
            this.birthdayLabel1.Size = new System.Drawing.Size(100, 23);
            this.birthdayLabel1.TabIndex = 13;
            this.birthdayLabel1.Text = "label1";
            // 
            // genderLabel1
            // 
            this.genderLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Gender", true));
            this.genderLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel1.Location = new System.Drawing.Point(188, 74);
            this.genderLabel1.Name = "genderLabel1";
            this.genderLabel1.Size = new System.Drawing.Size(100, 23);
            this.genderLabel1.TabIndex = 17;
            this.genderLabel1.Text = "label1";
            this.genderLabel1.Click += new System.EventHandler(this.genderLabel1_Click);
            // 
            // hometownLabel1
            // 
            this.hometownLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Hometown", true));
            this.hometownLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hometownLabel1.Location = new System.Drawing.Point(275, 129);
            this.hometownLabel1.Name = "hometownLabel1";
            this.hometownLabel1.Size = new System.Drawing.Size(100, 23);
            this.hometownLabel1.TabIndex = 19;
            this.hometownLabel1.Text = "label1";
            // 
            // locationLabel1
            // 
            this.locationLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Location", true));
            this.locationLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel1.Location = new System.Drawing.Point(275, 165);
            this.locationLabel1.Name = "locationLabel1";
            this.locationLabel1.Size = new System.Drawing.Size(100, 23);
            this.locationLabel1.TabIndex = 23;
            this.locationLabel1.Text = "label1";
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.nameLabel1.Location = new System.Drawing.Point(119, 28);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(150, 38);
            this.nameLabel1.TabIndex = 25;
            this.nameLabel1.Text = "Full Name";
            // 
            // relationshipStatusLabel1
            // 
            this.relationshipStatusLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "RelationshipStatus", true));
            this.relationshipStatusLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationshipStatusLabel1.Location = new System.Drawing.Point(169, 129);
            this.relationshipStatusLabel1.Name = "relationshipStatusLabel1";
            this.relationshipStatusLabel1.Size = new System.Drawing.Size(100, 23);
            this.relationshipStatusLabel1.TabIndex = 27;
            this.relationshipStatusLabel1.Text = "label1";
            // 
            // linkLinkLabel1
            // 
            this.linkLinkLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userFacadeBindingSource, "SignificantOther.Link", true));
            this.linkLinkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.linkLinkLabel1.Location = new System.Drawing.Point(13, 151);
            this.linkLinkLabel1.Name = "linkLinkLabel1";
            this.linkLinkLabel1.Size = new System.Drawing.Size(150, 23);
            this.linkLinkLabel1.TabIndex = 39;
            this.linkLinkLabel1.TabStop = true;
            this.linkLinkLabel1.Text = "Significant Other";
            // 
            // linkLabelFBProfile
            // 
            this.linkLabelFBProfile.AutoSize = true;
            this.linkLabelFBProfile.Location = new System.Drawing.Point(202, 273);
            this.linkLabelFBProfile.Name = "linkLabelFBProfile";
            this.linkLabelFBProfile.Size = new System.Drawing.Size(99, 13);
            this.linkLabelFBProfile.TabIndex = 40;
            this.linkLabelFBProfile.TabStop = true;
            this.linkLabelFBProfile.Text = "View on Facebook!";
            this.linkLabelFBProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFBProfile_LinkClicked);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(249, 238);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 15);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "label1";
            this.lblEmail.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormProfile
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(428, 303);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.linkLabelFBProfile);
            this.Controls.Add(this.linkLinkLabel1);
            this.Controls.Add(aboutLabel);
            this.Controls.Add(this.aboutTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayLabel1);
            this.Controls.Add(emailLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.genderLabel1);
            this.Controls.Add(hometownLabel);
            this.Controls.Add(this.hometownLabel1);
            this.Controls.Add(locationLabel2);
            this.Controls.Add(this.locationLabel1);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(relationshipStatusLabel);
            this.Controls.Add(this.relationshipStatusLabel1);
            this.Controls.Add(this.picBoxProfilePic);
            this.Name = "FormProfile";
            this.Load += new System.EventHandler(this.FormProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userFacadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxProfilePic;
        private System.Windows.Forms.BindingSource userFacadeBindingSource;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.Label birthdayLabel1;
        private System.Windows.Forms.Label genderLabel1;
        private System.Windows.Forms.Label hometownLabel1;
        private System.Windows.Forms.Label locationLabel1;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label relationshipStatusLabel1;
        private System.Windows.Forms.LinkLabel linkLinkLabel1;
        private System.Windows.Forms.LinkLabel linkLabelFBProfile;
        private System.Windows.Forms.Label lblEmail;
    }
}