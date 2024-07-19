using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal interface IUserMethods
    {
        Status PostStatus(string i_StatusText, string i_PaceID = null, string i_PictureURL = null, string i_TaggedFriendIDs = null, string i_Link = null, string i_PrivacyParameterValue = null);
        Link PostLink(string i_Url, string i_Message = null, string i_PrivacyParameterValue = null);
        FriendList CreateFriendList(string i_Name);
        Checkin Checkin(Checkin i_Checkin);
        Checkin Checkin(string i_PagePlaceID, string i_LocationCoordinates = null, string i_Message = null, string i_Link = null, string i_PictureURL = null, string i_TaggedFriendIDs = null);
        Album CreateAlbum(string i_Name, string i_Description = null, string i_Privacy = null);
        string ToString();
    }
}
