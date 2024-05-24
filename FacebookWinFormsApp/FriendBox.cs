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

namespace BasicFacebookFeatures
{
    public partial class FriendBox : UserControl
    {
        public FriendBox()
        {
            InitializeComponent();
            m_friend = null;
        }

        private User m_friend;

        public FriendBox(User friend)
        {
            InitializeComponent();
            m_friend = friend;
            initFriendBox();
        }

        private void initFriendBox()
        {
            picBoxFriend.Image = m_friend.ImageNormal;

            ToolTip friendName = new ToolTip();
            friendName.SetToolTip(picBoxFriend, m_friend.Name);
        }

        private void picBoxFriend_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(m_friend.Link);
            }
            catch
            {
                MessageBox.Show("Error opening profile page!");
            }
            
        }
    }
}
