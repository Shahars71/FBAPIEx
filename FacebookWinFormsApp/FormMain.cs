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
                        tabPosts.Controls.Add(postViewer);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error getting post: {post.Caption}\n{ex.Message}");
                    }
                }
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
                Label errorLabel = new Label();
                errorLabel.Text = "[Data unavailable]";
                flpPhotos.Controls.Add(errorLabel);
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
                                tabFriends.Controls.Add(friendBox);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Error getting friend: {friend.Name}");

                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error getting friendList: {friendList.Name}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting Data: {ex.Message}");
                Label errLabel = new Label();
                errLabel.Text = "Error getting Friend data!";
                tabFriends.Controls.Add( errLabel );
            }
        }

        private void picBoxProfilePic_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile(m_LoggedInUser);
            formProfile.ShowDialog();
        }
    }
}
