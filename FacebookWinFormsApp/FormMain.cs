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
using CefSharp.DevTools.DOM;
using System.Collections.ObjectModel;
using System.Threading;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private UserFacade User { get; set; } = null;
        private List<PostViewer> Posts { get; set; }
        private List<PictureBox> Photos { get; set; }
        private List<PictureBox> Friends { get; set; }
        private List<PictureBox> Groups { get; set; }
        private List<PictureBox> Videos { get; set; }
        private List<PictureBox> Pages { get; set; }
        private readonly Color m_HoverColor = Color.FromArgb(255, 8, 102, 255);
        private readonly Color m_ButtonColor = Color.FromArgb(255, 101, 103, 107);

        

        public FormMain()
        {
            InitializeComponent();
        }

        public FormMain(User user)
        {
            object s_lockObj = new object();

            InitializeComponent();

            User = new UserFacade(user);
    

            Shown += FormMain_OnShown;

        }

        private void FormMain_OnShown(object sender, EventArgs e)
        {
            initTabs();

            fetchUserInfo();

            cmbSortOrderLikesVids.SelectedIndex = 0;

        }

        private void initTabs()
        {
            Posts = FBLogic.GetPostViewerListWithData(User);
            Photos = FBLogic.GetPictureBoxListWithData(User.Photos, eDataTypes.photos);
            Friends = FBLogic.GetPictureBoxListWithData(User.Friends, eDataTypes.friends);
            Groups = FBLogic.GetPictureBoxListWithData(User.Groups, eDataTypes.groups);
            Videos = FBLogic.GetPictureBoxListWithData(User.Videos, eDataTypes.videos);
            Pages = FBLogic.GetPictureBoxListWithData(User.LikedPages, eDataTypes.pages);

            fillFLPWithPostViewers();

        }

        //Initial home screen fetch and fill
        private void fetchUserInfo()
        {
            
            picBoxProfilePic.LoadAsync(User.PictureNormalURL);
            labelUserName.Text = User.Name;
        }



        private void btnAlbums_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPhotos;
            flpPhotos.Controls.Clear();
            fillFLPWithPictureBoxes(Photos, flpPhotos);
        }

        private void btnPosts_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab= tabPosts;
            flpPosts.Controls.Clear();
            fillFLPWithPostViewers();

        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabFriends;
            flpFriends.Controls.Clear();
            
            fillFLPWithPictureBoxes(Friends, flpFriends);

        }

        private void picBoxProfilePic_Click(object sender, EventArgs e)
        {
            FormProfile formProfile = new FormProfile(User);
            formProfile.ShowDialog();
        }

        private void btnVideos_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabVideos;
            flpVideos.Controls.Clear();
            fillFLPWithPictureBoxes(Videos, flpVideos);

        }

        private void btnPages_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabPages;
            flpPages.Controls.Clear();
            fillFLPWithPictureBoxes(Pages, flpPages);
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedTab = tabGroups;
            flpGroups.Controls.Clear();
            fillFLPWithPictureBoxes(Groups, flpGroups);
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
        private void picBoxProfilePic_MouseHover(object sender, EventArgs e)
        {
            lblViewProfile.Visible = true;
            pbMasking.Visible = true;
        }
        private void pbMasking_Click(object sender, EventArgs e)
        {
            picBoxProfilePic_Click(sender, e);
        }
        private void picBoxProfilePic_MouseLeave(object sender, EventArgs e)
        {
            lblViewProfile.Visible = false;
            pbMasking.Visible = false;
        }
        private void pbMasking_MouseLeave(object sender, EventArgs e)
        {
            lblViewProfile.Visible = false;
            pbMasking.Visible = false;
        }

        //Functions related to extra feature buttons
        private void btnPostStatus_Click(object sender, EventArgs e)
        {
            FormPostStatus postStatus = new FormPostStatus(User);
            postStatus.ShowDialog();
        }

        private void btnDateFilter_Click(object sender, EventArgs e)
        {
            filterPostsByDateVis();
        }

        private void btnFilterByDatePhotos_Click(object sender, EventArgs e)
        {
            filterPhotosByDateVis();
        }
        private void btnSortByLikes_Click(object sender, EventArgs e)
        {
            switch (cmbSortOrderLikesPages.Text)
            {
                case "Ascending":
                    sortByLikes(User.LikedPages, flpPages, eDataTypes.pages, new FBLikesSorter((num1, num2) => num1 < num2));
                    break;
                case "Descending":
                    sortByLikes(User.LikedPages, flpPages, eDataTypes.pages, new FBLikesSorter((num1, num2) => num1 > num2));
                    break;
            }
        }
        private void btnSortVidsByDate_Click(object sender, EventArgs e)
        {
            switch (cmbSortOrderDateVids.Text)
            {
                case "Ascending":
                    sortByDate(User.Videos, flpVideos, eDataTypes.videos, new FBDatesSorter((dt1, dt2) => dt1 < dt2));
                    break;
                case "Descending":
                    sortByDate(User.Videos, flpVideos, eDataTypes.videos, new FBDatesSorter((dt1, dt2) => dt1 > dt2));
                    break;
            }
        }
        private void btnSortVidsByLikes_Click(object sender, EventArgs e)
        {
            switch (cmbSortOrderLikesVids.Text)
            {
                case "Ascending":
                    sortByLikes(User.Videos, flpVideos, eDataTypes.videos, new FBLikesSorter((num1, num2) => num1 < num2));
                    break;
                case "Descending":
                    sortByLikes(User.Videos, flpVideos, eDataTypes.videos, new FBLikesSorter((num1, num2) => num1 > num2));
                    break;

            }
        }
        private void btnSortPhotosByLikes_Click(object sender, EventArgs e)
        {
            switch (cmbSortOrderLikesPhotos.Text)
            {
                case "Ascending":
                    sortByLikes(User.Photos, flpPhotos, eDataTypes.photos, new FBLikesSorter((num1, num2) => num1 < num2));
                    break;
                case "Descending":
                    sortByLikes(User.Photos, flpPhotos, eDataTypes.photos, new FBLikesSorter((num1, num2) => num1 > num2));
                    break;

            }
        }
        private void btnSortPhotosByDate_Click(object sender, EventArgs e)
        {
            switch (cmbSortOrderDatePhotos.Text)
            {
                case "Ascending":
                    sortByDate(User.Photos, flpPhotos, eDataTypes.photos, new FBDatesSorter((dt1, dt2) => dt1 < dt2));
                    break;
                case "Descending":
                    sortByDate(User.Photos, flpPhotos, eDataTypes.photos, new FBDatesSorter((dt1, dt2) => dt1 > dt2));
                    break;
            }
        }

        private void filterPhotosByDateVis()
        {
            Collection<DataUnit> filteredPhotos = FBLogic.FilterPhotosByDate(User, dtpFromPhotos.Value.Date.Date, dtpToPhotos.Value.Date.Date);

            if (filteredPhotos.Count > 0)
            {
                flpPhotos.Controls.Clear();
                List<PictureBox> pbPhotos = FBLogic.GetPictureBoxListWithData(filteredPhotos, eDataTypes.photos);

                fillFLPWithPictureBoxes(pbPhotos, flpPhotos);

            }
            else
            {
                MessageBox.Show("Error filtering photos!");
            }
        }
        private void filterPostsByDateVis()
        {

            FacebookObjectCollection<Post> filteredPosts = FBLogic.FilterPostsByDate(User, dtpPostDateFrom.Value.Date.Date, dtpPostDateTo.Value.Date.Date);

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

        private void sortByLikes(Collection<DataUnit> i_dataUnits, FlowLayoutPanel i_flp, eDataTypes i_DataType, FBLikesSorter i_Comparison)
        {
            DataUnit[] dataUnitsArr = i_dataUnits.ToArray();

            i_Comparison.SortLikes(dataUnitsArr);

            Collection<DataUnit> units = new Collection<DataUnit>();
            foreach (DataUnit dataunit in dataUnitsArr)
            {
                units.Add(dataunit);
            }

            if (units.Count > 0)
            {
                i_flp.Controls.Clear();
                fillFLPWithPictureBoxes(FBLogic.GetPictureBoxListWithData(units, i_DataType), i_flp);
            }
        }
        private void sortByDate(Collection<DataUnit> i_DataUnits, FlowLayoutPanel i_flp, eDataTypes i_DataType, FBDatesSorter i_Comparison)
        {
            DataUnit[] dataUnitsArr = i_DataUnits.ToArray();

            i_Comparison.SortDate(dataUnitsArr);

            Collection<DataUnit> units = new Collection<DataUnit>();
            foreach (DataUnit dataunit in dataUnitsArr)
            {
                units.Add(dataunit);
            }

            if (units.Count > 0)
            {
                i_flp.Controls.Clear();
                fillFLPWithPictureBoxes(FBLogic.GetPictureBoxListWithData(units, i_DataType), i_flp);
            }
        }

        private void fillFLPWithPictureBoxes(List<PictureBox> i_Controls, FlowLayoutPanel i_flp)
        {
            try
            {
                foreach (PictureBox pb in i_Controls)
                {
                    i_flp.Controls.Add(pb);
                }
            }
            catch (Exception ex)
            {
                i_flp.Controls.Add(FBLogic.ErrorHandle(ex));
            }
        }
        private void fillFLPWithPostViewers()
        {
            try
            {
                foreach (PostViewer post in Posts)
                {
                    flpPosts.Controls.Add(post);
                }
            }
            catch (Exception ex)
            {
                flpPosts.Controls.Add(FBLogic.ErrorHandle(ex));
            }
        }


    }
}
