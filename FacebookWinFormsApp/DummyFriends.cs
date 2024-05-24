using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public static class DummyFriends
    {
        static Collection<FakeFriend> m_Friends;

        
        static DummyFriends()
        {
            Friends = new Collection<FakeFriend>();

            fillFriendList();
        }

        public static Collection<FakeFriend> Friends { get => m_Friends; set => m_Friends = value; }

        private static void fillFriendList()
        {
            for (int i = 0; i < 5; i++)
            {
                Friends[i] = new FakeFriend();
            }
        }
    }

    public class FakeFriend
    {
        private string name;
        private Image image;

        public Image Image { get => image; set => image = value; }
        public string Name { get => name; set => name = value; }

        public FakeFriend(string name, Image image)
        {
            this.name = name;
            this.image = image;
        }

        public FakeFriend()
        {
            Name = string.Empty;
            image = null;
        }
    }
}
