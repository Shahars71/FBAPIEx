using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

            new Thread(() => initializePost()).Start();
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
                    lblLikes.Location = new Point(lblLikes.Location.X - 116, lblLikes.Location.Y);
                    btnLike.Location = new Point(btnLike.Location.X - 116, btnLike.Location.Y);
                }
            }
            catch { }

            try
            {
                lblLikes.Text = m_Post.LikedBy.Count.ToString();
            }
            catch 
            {

            }

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

        private void btnLike_Click(object sender, EventArgs e)
        {
            likeButton();
        }

        private void btnUnlike_Click(object sender, EventArgs e)
        {
            unlikeButton();
        }

        private void likeButton()
        {
            try
            {
                m_Post.Like();
                btnLike.Enabled = false;
                btnLike.Visible = false;
                btnUnlike.Enabled = true;
                btnUnlike.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
        private void unlikeButton()
        {
            try
            {
                m_Post.Unlike();
                btnUnlike.Enabled = false;
                btnUnlike.Visible = false;
                btnLike.Enabled = true;
                btnLike.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }


}
