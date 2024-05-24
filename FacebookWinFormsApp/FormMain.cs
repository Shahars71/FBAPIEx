using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Windows.Forms.VisualStyles;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        User m_LoggedInUser;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(User user)
        {
            InitializeComponent();
            m_LoggedInUser = user;
            fetchUserInfo();
            //fillPostsTab();
        }

        private void fetchUserInfo()
        {
            
            picBoxProfilePic.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelUserName.Text = m_LoggedInUser.Name;
        }

        private void fillPostsTab()
        {

            if (m_LoggedInUser.Posts.Count > 0)
            {
                foreach(Post post in m_LoggedInUser.Posts)
                {
                    try
                    {
                        Console.WriteLine(post.Caption);

                        PostViewer postViewer = new PostViewer();
                        flpPosts.Controls.Add(postViewer);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error getting post: {post.Caption}\n{ex.Message}");
                    }
                }
            }

            else
            {
                errorHandle(flpPosts);
            }
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPhotos;
            flpPhotos.Controls.Clear();
            fillPhotosTab();
        }

        private void fillPhotosTab()
        {


            try
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    foreach (Photo pc in album.Photos)
                    {
                        PictureBox tabFiller = new PictureBox();
                        tabFiller.Size = new Size(128, 128);
                        tabFiller.LoadAsync(pc.PictureThumbURL);

                        flpPhotos.Controls.Add(tabFiller);
                    }
                }
            }
            catch
            {
                errorHandle(flpPhotos);
            }
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab= tabPosts;
            tabPosts.Controls.Clear();
            fillPostsTab();
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabFriends;
            fillFriendsTab();
        }

        private void fillFriendsTab()
        {
            try
            {
                for (int i = 0; i < m_LoggedInUser.FriendLists.Count; i++)
                {
                    FriendList friendList = m_LoggedInUser.FriendLists[i];
                    try
                    {
                        foreach (User friend in friendList.Members)
                        {
                            try
                            {
                                FriendBox friendBox = new FriendBox(friend);
                                flpFriends.Controls.Add(friendBox);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error getting friend: {friend.Name}");

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        errorHandle(flpFriends);
                    }
                }
            }
            catch (Exception ex)
            {
                errorHandle(flpFriends);
            }
        }

        private void picBoxProfilePic_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile(m_LoggedInUser);
            formProfile.ShowDialog();
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabVideos;
            fillVideosTab();

        }

        private void fillVideosTab()
        {
            
            try
            {
                if (m_LoggedInUser.Videos.Count > 0)
                {
                    foreach (Video vid in m_LoggedInUser.Videos)
                    {
                        VideoBox videoBox = new VideoBox(vid);
                        flpVideos.Controls.Add(videoBox);
                    }
                }
                else
                {
                    errorHandle(flpVideos);
                }
            }
            catch
            {
                errorHandle(flpVideos);
            }
        }

        private void errorHandle(FlowLayoutPanel i_flp)
        {
            Label errorLabel = new Label();
            errorLabel.Text = "[Data unavailable]";
            i_flp.Controls.Add(errorLabel);
        }

        private void btnPages_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPages;
            fillPagesTab();
        }

        private void fillPagesTab()
        {
            try
            {
                if (m_LoggedInUser.LikedPages.Count > 0)
                {
                    foreach (Page page in m_LoggedInUser.LikedPages)
                    {
                        PageBox pageBox = new PageBox(page);
                        flpPages.Controls.Add(pageBox);
                    }
                }
                else
                {
                    errorHandle(flpPages);
                }
            }
            catch
            {
                errorHandle(flpPages);
            }
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabGroups;
            fillGroupsTab();
        }

        private void fillGroupsTab()
        {
            try
            {
                if (m_LoggedInUser.Groups.Count > 0)
                {
                    foreach (Group group in m_LoggedInUser.Groups)
                    {
                        GroupBox groupBox = new GroupBox(group);
                        flpGroups.Controls.Add(groupBox);
                    }
                }
                else
                {
                    errorHandle(flpGroups);
                }
            }
            catch
            {
                errorHandle(flpGroups);
            }
        }

    }
}
