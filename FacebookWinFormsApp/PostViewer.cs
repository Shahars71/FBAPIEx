﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BasicFacebookFeatures
{
    public partial class PostViewer : UserControl
    {
        private Post m_Post;
        public PostViewer(Post post)
        {
            InitializeComponent();
            m_Post = post;
            initializePost();
        }

        private void initializePost()
        {
            if (m_Post.Message != null)
            {
                tbPost.Text = m_Post.Message;
            }
            else if (m_Post.Caption != null)
            {
                tbPost.Text = m_Post.Caption;
            }
            else
            {
                tbPost.Text = string.Format("[{0}]", m_Post.Type);
            }

            try
            {
                pbPostPic.LoadAsync(m_Post.PictureURL);
            }
            catch 
            {
            }

            try
            {
                if (m_Post.From != null)
                {
                    pbPoster.LoadAsync(m_Post.From.PictureNormalURL);
                }
                else
                {
                    pbPoster.Visible = false;
                    tbPost.Location = new Point(tbPost.Location.X - 116, tbPost.Location.Y);
                    listBoxComments.Location = new Point(listBoxComments.Location.X - 116, listBoxComments.Location.Y);
                    pbPostPic.Location = new Point(pbPostPic.Location.X - 116, pbPostPic.Location.Y);
                    lblPostDate.Location = new Point(lblPostDate.Location.X - 116, lblPostDate.Location.Y);
                }
            }
            catch { }

            try
            {
                lblPostDate.Text = "Posted on: " + m_Post.CreatedTime.ToString();
            }
            catch { }
            try
            {
                listBoxComments.DisplayMember = "Message";
                listBoxComments.DataSource = m_Post.Comments;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
