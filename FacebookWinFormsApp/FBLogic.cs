using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using System.Windows.Forms;
using System.Security.Policy;
using System.Collections.ObjectModel;
using System.Threading;

namespace BasicFacebookFeatures
{
    public static class FBLogic
    {
        //A static class containing the logic used for the app.
        //This is supposed to be called on from each and every part of the app, like a library of logic functions.
        //Making it static felt natural for me, because being able to instantiate something like this felt somewhat weird.
        
        //Interface? Maybe.

        //singleton dummydata -> done
        public static DummyData DummyData {  get; set; }

        static FBLogic()
        {
            DummyData = DummyData.Instance;
        }



        public static bool Login(out LoginResult o_LoginResult, string i_AppID)
        {
            try
            {
                o_LoginResult = FacebookService.Login(
               /// (This is Desig Patter's App ID. replace it with your own)
               i_AppID,
               /// requested permissions:
               "email",
               "public_profile",
               "user_posts",
               "user_hometown",
               "user_birthday",
               "user_age_range",
               "user_gender",
               "user_link",
               "user_friends",
               "user_location",
               "user_likes",
               "public_profile",
               "user_photos",
               "user_videos"
                /// add any relevant permissions
               );

                if (string.IsNullOrEmpty(o_LoginResult.ErrorMessage))
                {
                    if (o_LoginResult.LoggedInUser == null)
                    {
                        return false;
                    }
                }

                return true;
            }
            catch
            {
                o_LoginResult = null;
                return false;
            }
        }
        public static Label ErrorHandle(Exception i_ex)
        {
            Label errorLabel = new Label();
            if (i_ex != null)
            {
                errorLabel.Text = $"[Data unavailable]\nError getting data.\nError: {i_ex.Message}";
            }
            else
            {
                errorLabel.Text = $"[Data unavailable]\nError getting data.";
            }

            return errorLabel;
        }
        public static List<PostViewer> GetPostViewerListWithData(UserFacade i_LoggedInUser)
        {
            List<PostViewer> posts = new List<PostViewer>();

            if (i_LoggedInUser.WallPosts.Count > 0)
            {
                foreach (Post post in i_LoggedInUser.WallPosts)
                {
                    try
                    {
                        posts.Add(new PostViewer(post));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error getting post: {post.Caption}\n{ex.Message}");
                    }
                }
            }

            return posts;
        }
        public static Collection<DataUnit> FilterPhotosByDate(UserFacade i_LoggedInUser, DateTime i_DateFrom, DateTime i_DateTo )
        {

            Collection<DataUnit> filteredPhotos = new Collection<DataUnit>();

            foreach (DataUnit photo in i_LoggedInUser.Photos)
            {
                DateTime photoDate = photo.CreatedTime.Value.Date;
                
                if (photoDate >= i_DateFrom && photoDate <= i_DateTo)
                    {
                        filteredPhotos.Add(photo);
                    }
                }

            return filteredPhotos;
        }
        public static FacebookObjectCollection<Post> FilterPostsByDate(UserFacade i_LoggedInUser, DateTime i_DateFrom, DateTime i_DateTo)
        {

            FacebookObjectCollection<Post> filteredPosts = new FacebookObjectCollection<Post>();

            foreach (Post post in i_LoggedInUser.WallPosts)
            {
                DateTime postDate = post.CreatedTime.Value.Date;

                if (postDate >= i_DateFrom && postDate <= i_DateTo)
                {
                    filteredPosts.Add(post);
                }
            }

            return filteredPosts;


        }
        public static int CompareTwoPageLikeNumbers(Page i_a, Page i_b)
        {
            if (i_a.LikesCount == null || i_b.LikesCount == null)
            {
                return 0;
            }
            else
            {
                return i_a.LikesCount.Value.CompareTo(i_b.LikesCount.Value);
            }
        }
        public static List<PictureBox> GetPictureBoxListWithData(Collection<DataUnit> i_DataUnits, eDataTypes i_DataType)
        {
            Collection<DataUnit> dummyList = DummyData.GetDummyDataList(i_DataType);
            List<PictureBox> o_PictureBoxList = new List<PictureBox>();

            try
            {

                if (i_DataUnits.Count > 0)
                {
                    foreach (DataUnit dataUnit in i_DataUnits)
                    {
                        o_PictureBoxList.Add(buildPictureBox(dataUnit));
                    }
                }
                else
                {
                    for (int i = 0; i < dummyList.Count; i++)
                    {
                        o_PictureBoxList.Add(buildPictureBox(dummyList[i]));
                    }
                }
            }
            catch (Exception ex)
            {
                //errorHandle(flpPages, ex);

                for (int i = 0; i < dummyList.Count; i++)
                {
                    o_PictureBoxList.Add(buildPictureBox(dummyList[i]));
                }
            }

            return o_PictureBoxList;
        }
        private static PictureBox buildPictureBox(DataUnit i_DataUnit)
        {
            PictureBox pb = new PictureBox();

            ToolTip tt = new ToolTip();
            tt.SetToolTip(pb, i_DataUnit.Name);

            try
            {
                pb.LoadAsync(i_DataUnit.ImageURL);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch 
            {
                Console.WriteLine($"Couldn't load {i_DataUnit.ImageURL}");
            }

            Action<object, EventArgs> clickLink = (sender, e) =>
            {
                if (i_DataUnit.Link != "")
                {
                    System.Diagnostics.Process.Start(i_DataUnit.Link);
                }
            };

            pb.MouseClick += new MouseEventHandler(clickLink);

            pb.Size = new Size(100,100);

            return pb;
        }
        public static void SwapDataUnits(ref DataUnit io_du1, ref DataUnit io_du2)
        {
            DataUnit temp = io_du1;
            io_du1 = io_du2;
            io_du2 = temp;
        }
        public static Collection<DataUnit> GetPhotosFromUserAlbums(User i_User)
        {
            Collection<DataUnit> dataUnits = new Collection<DataUnit>();

            try
            {
                if (i_User.Albums.Count == 0)
                {
                    return CreateDataUnitCollectionFromOtherwiseIncompleteData(i_User.Albums);
                }
                else
                {
                    foreach (Album album in i_User.Albums)
                    {
                        foreach (Photo photo in album.Photos)
                        {
                            dataUnits.Add(new DataUnit(photo.Name, photo.PictureAlbumURL, photo.Link, photo.CreatedTime, photo.LikedBy.Count));
                        }
                    }
                }
            }
            catch
            {
                dataUnits = DummyData.GetDummyDataList(eDataTypes.photos);
            }

            return dataUnits;
        }
        public static Collection<DataUnit> CreateDataUnitCollectionFromOtherwiseIncompleteData<T>(FacebookObjectCollection<T> i_items)
        {
            Collection<DataUnit> dataUnits = new Collection<DataUnit>();

            string typeOfItem = typeof(T).Name;

            switch (typeOfItem)
            {
                case "User":
                    typeOfItem = "friend";
                    break;
            }
            typeOfItem = typeOfItem.ToLower() + "s";

            if (i_items.Count == 0)
            {
                try
                {
                    eDataTypes dataType = (eDataTypes)Enum.Parse(typeof(eDataTypes), typeOfItem);
                    dataUnits = DummyData.GetDummyDataList(dataType);
                }
                catch
                {
                    dataUnits = DummyData.GetDummyDataList(eDataTypes.photos);
                }

            }
            else
            {
                foreach (T item in i_items)
                {
                    string name = (string)item.GetType().GetProperty("Name").GetValue(item, null);
                    string link = null;
                    string picURL;
                    int LikesCount = 0;
                    DateTime comparedTime = DateTime.Now;
                    DateTime createdTime = comparedTime;
                    FacebookObjectCollection<User> tempCol;

                    picURL = (string)item.GetType().GetProperty("PictureNormalURL").GetValue(item, null);

                    switch (typeOfItem)
                    {
                        case "photos":
                            link = (string)item.GetType().GetProperty("Link").GetValue(item, null);
                            picURL = (string)item.GetType().GetProperty("PictureThumbURL").GetValue(item, null);
                            createdTime = (DateTime)item?.GetType().GetProperty("CreatedTime").GetValue(item, null);
                            tempCol = (FacebookObjectCollection<User>)item?.GetType().GetProperty("LikedBy").GetValue(item, null);
                            LikesCount = tempCol.Count();
                            break;
                        case "videos":
                            link = (string)item.GetType().GetProperty("Link").GetValue(item, null);
                            picURL = (string)item.GetType().GetProperty("PictureURL").GetValue(item, null);
                            createdTime = (DateTime)item?.GetType().GetProperty("CreatedTime").GetValue(item, null);
                            tempCol = (FacebookObjectCollection<User>)item?.GetType().GetProperty("LikedBy").GetValue(item, null);
                            LikesCount = tempCol.Count();
                            break;
                        case "pages":
                            link = (string)item.GetType().GetProperty("URL").GetValue(item, null);
                            var tempCount = item.GetType().GetProperty("LikesCount").GetValue(item, null);
                            LikesCount = tempCount == null ? 0 : (int)tempCount;
                            break;
                    }
                    if (createdTime != comparedTime)
                    {
                        dataUnits.Add(new DataUnit(name, picURL, link, createdTime, LikesCount));
                    }
                    else
                    {
                        dataUnits.Add(new DataUnit(name, picURL, link));
                    }

                }
            }

            return dataUnits;
        }
    }
}
