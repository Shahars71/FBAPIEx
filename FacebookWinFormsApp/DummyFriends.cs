using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public static class DummyFriends
    {
        static FriendList m_Friends;

        public static FriendList Friends { get => m_Friends; set => m_Friends = value; }
        
        static DummyFriends()
        {
            Friends = new FriendList();

            fillFriendList();
        }

        private static void fillFriendList()
        {
            for (int i = 0; i < 11; i++)
            {

            }
        }
    }
}
