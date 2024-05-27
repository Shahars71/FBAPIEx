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
        Color m_HoverColor;
        Color m_ButtonColor;

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(User user)
        {
            InitializeComponent();

            m_LoggedInUser = user;

            m_HoverColor = new Color();
            m_HoverColor = Color.FromArgb(255, 8, 102, 255);

            m_ButtonColor = new Color();
            m_ButtonColor = Color.FromArgb(255, 101, 103, 107);

            fetchUserInfo();

        }

        //Initial home screen fetch and fill
        private void fetchUserInfo()
        {
            
            picBoxProfilePic.LoadAsync(m_LoggedInUser.PictureNormalURL);
            labelUserName.Text = m_LoggedInUser.Name;
            fillPostsTab();
        }

        private void btnAlbums_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPhotos;
            flpPhotos.Controls.Clear();
            fillPhotosTab();
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab= tabPosts;

            flpPosts.Controls.Clear();
            fillPostsTab();
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabFriends;
            flpFriends.Controls.Clear();
            fillFriendsTab();
        }

        private void picBoxProfilePic_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile(m_LoggedInUser);
            formProfile.ShowDialog();
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabVideos;
            flpVideos.Controls.Clear();
            fillVideosTab();

        }

        private void btnPages_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPages;
            flpPages.Controls.Clear();
            fillPagesTab();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabGroups;
            flpGroups.Controls.Clear();
            fillGroupsTab();
        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void flpPages_Click(object sender, EventArgs e)
        {

        }

        //Functions to fill each tab with its respective data
        private void fillVideosTab()
        {

            try
            {
                if (m_LoggedInUser.Videos.Count > 0)
                {
                    foreach (Video vid in m_LoggedInUser.Videos)
                    {
                        AssetBox videoBox = new AssetBox(vid.URL, vid.PictureURL, vid.Name);
                        flpVideos.Controls.Add(videoBox);
                    }
                }
                else
                {
                    for (int i = 0; i < DummyData.Videos.Count; i++)
                    {
                        AssetBox videoBox = new AssetBox(DummyData.Videos[i]);
                        flpVideos.Controls.Add(videoBox);
                    }
                }
            }
            catch (Exception ex)
            {
                //errorHandle(flpVideos, ex);

                for (int i = 0; i < DummyData.Videos.Count; i++)
                {
                    AssetBox videoBox = new AssetBox(DummyData.Videos[i]);
                    flpVideos.Controls.Add(videoBox);
                }
            }
        }

        private void fillGroupsTab()
        {
            try
            {
                if (m_LoggedInUser.Groups.Count > 0)
                {
                    foreach (Group group in m_LoggedInUser.Groups)
                    {
                        AssetBox groupBox = new AssetBox(group.Link, group.PictureNormalURL, group.Name);
                        flpGroups.Controls.Add(groupBox);
                    }
                }
                else
                {
                    for (int i = 0; i < DummyData.Groups.Count; i++)
                    {
                        AssetBox groupBox = new AssetBox(DummyData.Groups[i]);
                        flpGroups.Controls.Add(groupBox);
                    }
                }
            }
            catch (Exception ex)
            {
                //errorHandle(flpGroups, ex);
                for (int i = 0; i < DummyData.Groups.Count; i++)
                {
                    AssetBox groupBox = new AssetBox(DummyData.Groups[i]);
                    flpGroups.Controls.Add(groupBox);
                }
            }
        }

        private void fillPagesTab()
        {
            try
            {
                if (m_LoggedInUser.LikedPages.Count > 0)
                {
                    foreach (Page page in m_LoggedInUser.LikedPages)
                    {
                        AssetBox pageBox = new AssetBox(page.URL, page.PictureNormalURL, page.Name);
                        flpPages.Controls.Add(pageBox);
                    }
                }
                else
                {
                    for (int i = 0; i < DummyData.Pages.Count; i++)
                    {
                        AssetBox pageBox = new AssetBox(DummyData.Pages[i]);
                        flpPages.Controls.Add(pageBox);
                    }
                }
            }
            catch (Exception ex)
            {
                //errorHandle(flpPages, ex);

                for (int i = 0; i < DummyData.Pages.Count; i++)
                {
                    AssetBox pageBox = new AssetBox(DummyData.Pages[i]);
                    flpPages.Controls.Add(pageBox);
                }
            }
        }

        private void fillFriendsTab()
        {
            try
            {
                if (m_LoggedInUser.Friends.Count > 0)
                {
                    foreach (User friend in m_LoggedInUser.Friends)
                    {
                        AssetBox friendBox = new AssetBox(friend.Link, friend.PictureNormalURL, friend.Name);
                        flpFriends.Controls.Add(friendBox);
                    }
                }
                else
                {
                    for (int j = 0; j < DummyData.Friends.Count; j++)
                    {
                        AssetBox friendBox = new AssetBox(DummyData.Friends[j]);
                        flpFriends.Controls.Add(friendBox);
                    }
                }
            }
            catch (Exception ex)
            {
                //errorHandle(flpFriends, ex);

                for (int j = 0; j < DummyData.Friends.Count; j++)
                {
                    AssetBox friendBox = new AssetBox(DummyData.Friends[j]);
                    flpFriends.Controls.Add(friendBox);
                }
            }
        }

        private void fillPhotosTab()
        {


            try
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    foreach (Photo pic in album.Photos)
                    {
                        AssetBox photoBox = new AssetBox(pic.Link, pic.PictureThumbURL, pic.Name);

                        flpPhotos.Controls.Add(photoBox);
                    }
                }
            }
            catch 
            {
                for (int j = 0; j < DummyData.Photos.Count; j++)
                {
                    AssetBox photoBox = new AssetBox(DummyData.Photos[j]);
                    flpFriends.Controls.Add(photoBox);
                }
            }
        }

        private void fillPostsTab()
        {

            if (m_LoggedInUser.Posts.Count > 0)
            {
                foreach (Post post in m_LoggedInUser.WallPosts)
                {
                    try
                    {
                        PostViewer postViewer = new PostViewer(post);
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
                errorHandle(flpPosts, null);
            }
        }


        //Custom non-intrusive error handler
        private void errorHandle(FlowLayoutPanel i_flp, Exception ex)
        {
            Label errorLabel = new Label();
            errorLabel.Text = "[Data unavailable]";
            i_flp.Controls.Add(errorLabel);

            if (ex != null)
            {
                Console.WriteLine($"Error getting data to {i_flp.Name}\nError: {ex.Message}");
            }
            else
            {
                Console.WriteLine($"Error getting data to {i_flp.Name}");
            }
        }

        //Mouse hover and leave functions for each menu button
        private void btnPosts_MouseHover(object sender, EventArgs e)
        {
            btnPosts.ForeColor = m_HoverColor;
        }

        private void btnAlbums_MouseHover(object sender, EventArgs e)
        {
            btnAlbums.ForeColor = m_HoverColor;
        }

        private void btnFriends_MouseHover(object sender, EventArgs e)
        {
            btnFriends.ForeColor = m_HoverColor;
        }

        private void btnVideos_MouseHover(object sender, EventArgs e)
        {
            btnVideos.ForeColor = m_HoverColor;
        }

        private void btnPages_MouseHover(object sender, EventArgs e)
        {
            btnPages.ForeColor = m_HoverColor;
        }

        private void btnGroups_MouseHover(object sender, EventArgs e)
        {
            btnGroups.ForeColor = m_HoverColor;
        }

        private void btnGroups_MouseLeave(object sender, EventArgs e)
        {
            btnGroups.ForeColor = m_ButtonColor;
        }

        private void btnPages_MouseLeave(object sender, EventArgs e)
        {
            btnPages.ForeColor= m_ButtonColor;
        }

        private void btnVideos_MouseLeave(object sender, EventArgs e)
        {
            btnVideos.ForeColor= m_ButtonColor;
        }

        private void btnFriends_MouseLeave(object sender, EventArgs e)
        {
            btnFriends.ForeColor= m_ButtonColor;    
        }

        private void btnAlbums_MouseLeave(object sender, EventArgs e)
        {
            btnAlbums.ForeColor= m_ButtonColor;
        }

        private void btnPosts_MouseLeave(object sender, EventArgs e)
        {
            btnPosts.ForeColor= m_ButtonColor;
        }

        //Functions related to extra feature buttons
        private void btnPostStatus_Click(object sender, EventArgs e)
        {
            FormPostStatus postStatus = new FormPostStatus(m_LoggedInUser);
            postStatus.ShowDialog();
        }

        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpPostDateFrom.Value.Date.Date;
            DateTime dateTo = dtpPostDateTo.Value.Date.Date;

            FacebookObjectCollection<Post> filteredPosts = new FacebookObjectCollection<Post>();

            foreach (Post post in m_LoggedInUser.WallPosts)
            {
                DateTime postDate = post.CreatedTime.Value.Date;

                if (postDate >= dateFrom && postDate <= dateTo)
                {
                    filteredPosts.Add(post);
                }
            }
            
            if (filteredPosts.Count > 0)
            {
                flpPosts.Controls.Clear();

                foreach (Post post in filteredPosts)
                {
                    PostViewer postViewer = new PostViewer(post);
                    flpPosts.Controls.Add(postViewer);
                }
            }
            else
            {
                MessageBox.Show("Error filtering posts!");
            }
        }

        private void btnFilterByDatePhotos_Click(object sender, EventArgs e)
        {
            DateTime dateFrom = dtpFromPhotos.Value.Date.Date;
            DateTime dateTo = dtpToPhotos.Value.Date.Date;

            FacebookObjectCollection<Photo> filteredPhotos = new FacebookObjectCollection<Photo>();

            foreach (Album album in m_LoggedInUser.Albums)
            {
                foreach(Photo photo in album.Photos)
                {
                    DateTime photoDate = photo.CreatedTime.Value.Date;

                    if (photoDate >= dateFrom && photoDate <= dateTo)
                    {
                        filteredPhotos.Add(photo);
                    }
                }

            }

            if (filteredPhotos.Count > 0)
            {
                flpPhotos.Controls.Clear();

                foreach (Photo photo in filteredPhotos)
                {
                    AssetBox albumBox = new AssetBox(photo.Link, photo.PictureThumbURL, photo.Name);
                    flpPhotos.Controls.Add(albumBox);
                }
            }
            else
            {
                MessageBox.Show("Error filtering photos!");
            }
        }

        private void btnSortByLikes_Click(object sender, EventArgs e)
        {
            sortPagesByLikes();
        }

        private void sortPagesByLikes()
        {
            List<Page> sortedPages = new List<Page>();

            foreach (Page page in m_LoggedInUser.LikedPages)
            {
                sortedPages.Add(page);
            }
            flpPages.Controls.Clear();

            try
            {
                sortedPages.Sort(compareTwoPageLikeNumbers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sorting pages!{ex.Message}");
            }

            foreach (Page page in sortedPages)
            {
                AssetBox pageBox = new AssetBox(page.URL,page.PictureNormalURL,page.Name);
                flpPages.Controls.Add(pageBox);
            }
        }

        private int compareTwoPageLikeNumbers(Page a, Page b)
        {
            if (a.LikesCount == null || b.LikesCount == null)
            {
                return 0;
            }
            else
            {
                return a.LikesCount.Value.CompareTo(b.LikesCount.Value);
            }
        }
    }
}
