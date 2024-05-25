namespace BasicFacebookFeatures
{
    partial class FormPostStatus
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
            this.tbPost = new System.Windows.Forms.TextBox();
            this.lblFlavorText = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPost
            // 
            this.tbPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPost.Location = new System.Drawing.Point(5, 55);
            this.tbPost.Multiline = true;
            this.tbPost.Name = "tbPost";
            this.tbPost.Size = new System.Drawing.Size(266, 107);
            this.tbPost.TabIndex = 1;
            // 
            // lblFlavorText
            // 
            this.lblFlavorText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFlavorText.AutoSize = true;
            this.lblFlavorText.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlavorText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFlavorText.Location = new System.Drawing.Point(1, 19);
            this.lblFlavorText.Name = "lblFlavorText";
            this.lblFlavorText.Size = new System.Drawing.Size(265, 24);
            this.lblFlavorText.TabIndex = 0;
            this.lblFlavorText.Text = "What do you want to say?";
            // 
            // btnPost
            // 
            this.btnPost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(244)))));
            this.btnPost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(193)))), ((int)(((byte)(244)))));
            this.btnPost.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPost.Location = new System.Drawing.Point(291, 120);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(92, 42);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post!";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPostStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(399, 170);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblFlavorText);
            this.Controls.Add(this.tbPost);
            this.Name = "FormPostStatus";
            this.Text = "Post Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPost;
        private System.Windows.Forms.Label lblFlavorText;
        private System.Windows.Forms.Button btnPost;
    }
}