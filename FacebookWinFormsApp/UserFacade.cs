using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.ObjectModel;
using System.CodeDom;
using CefSharp.DevTools.Debugger;
using System.Security.Policy;
using System.Threading;

namespace BasicFacebookFeatures
{
    public class UserFacade : IUserMethods
    {
        //A Facade design pattern meant to mask calls for the Facebook user object.
        //This also works as an adapter because of how it takes care of missing data.
        //We implement the client's desired user methods, while taking care of any member incompatibility from within.

        private User User { get; set; }
        private static Thread thread1, thread2, thread3, thread4;

        #region User Members
        public Collection<DataUnit> Photos {  get; set; }
        public Collection<DataUnit> Friends { get; set; }
        public  Collection<DataUnit> Groups { get; set; }
        public  Collection<DataUnit> LikedPages { get; set; }
        public  Collection<DataUnit> Videos { get; set; }
        public Collection<Post> WallPosts { get; set; }
        public  string PictureNormalURL { get; set; }
        public  string Name {  get; set; }
        public  string Gender {  get; set; }
        public  string RelationshipStatus {  get; set; }
        public  UserFacade SignificantOther {  get; set; }
        public  string Hometown {  get; set; }
        public  string Location {  get; set; }
        public  string Birthday {  get; set; }
        public  string About {  get; set; }
        public string Link {  get; set; }
        public string Email { get; set; }

        #endregion

        public UserFacade(User i_user)
        {
            thread4 = new Thread(() =>
            {
                userFacadeMemberInit(i_user);
            });

            thread4.Start();
            thread4.Join();
            thread1.Join();
            thread2.Join();
            thread3.Join();

            SignificantOther = User.SignificantOther == null ? null : new UserFacade(User.SignificantOther, this);
        }

        public UserFacade(User i_user, UserFacade i_SignificantOther)
        {
            userFacadeMemberInit(i_user);
            SignificantOther = i_SignificantOther;
        }

        private void userFacadeMemberInit(User i_user)
        {

            User = i_user;
            thread1 = new Thread(() =>
            {
                Friends =    FBLogic.CreateDataUnitCollectionFromOtherwiseIncompleteData(i_user.Friends);
                LikedPages = FBLogic.CreateDataUnitCollectionFromOtherwiseIncompleteData(i_user.LikedPages);
            });

            thread2 = new Thread(() =>
            {
                Groups = FBLogic.CreateDataUnitCollectionFromOtherwiseIncompleteData(i_user.Groups);
                Videos = FBLogic.CreateDataUnitCollectionFromOtherwiseIncompleteData(i_user.Videos);
                });

            thread3 = new Thread(() =>
            {
                Photos = FBLogic.GetPhotosFromUserAlbums(i_user);
                WallPosts = User.WallPosts;
            });


            thread1.Start();
            thread2.Start();
            thread3.Start();


            PictureNormalURL = User.PictureNormalURL;
            Name = User.Name;
            Hometown = User.Hometown == null ? "Tel Aviv" : User.Hometown.Name;
            Birthday = User.Birthday == null ? "04.02.2004" : User.Birthday;
            About = User.About == null ? "No description" : User.About;
            Link = User.Link;
            RelationshipStatus = User.RelationshipStatus.ToString();
            Gender = User.Gender.ToString();
            Email = User.Email;
        }


        #region User Methods


        public Status PostStatus(string i_StatusText, string i_PaceID = null, string i_PictureURL = null, string i_TaggedFriendIDs = null, string i_Link = null, string i_PrivacyParameterValue = null)
        {
            return User.PostStatus(i_StatusText, i_PaceID, i_PictureURL, i_TaggedFriendIDs, i_Link, i_PrivacyParameterValue);
        }
        public Link PostLink(string i_Url, string i_Message = null, string i_PrivacyParameterValue = null)
        {
            return User.PostLink(i_Url, i_Message, i_PrivacyParameterValue);
        }
        public FriendList CreateFriendList(string i_Name)
        {
            return User.CreateFriendList(i_Name);
        }
        public Checkin Checkin(Checkin i_Checkin)
        {
            return User.Checkin(i_Checkin);
        }
        public Checkin Checkin(string i_PagePlaceID, string i_LocationCoordinates = null, string i_Message = null, string i_Link = null, string i_PictureURL = null, string i_TaggedFriendIDs = null)
        {
            return User.Checkin(i_PagePlaceID, i_LocationCoordinates, i_Message, i_Link, i_PictureURL, i_TaggedFriendIDs);
        }
        public Album CreateAlbum(string i_Name, string i_Description = null, string i_Privacy = null)
        {
            return User.CreateAlbum(i_Name, i_Description, i_Privacy);
        }
        public override string ToString()
        {
            return User.ToString();
        }
        



        #endregion


    }
}
