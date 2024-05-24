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
    public partial class GroupBox : UserControl
    {
        private Group m_Group;
        public GroupBox()
        {
            InitializeComponent();
        }

        public GroupBox(Group group)
        {
            InitializeComponent();
            m_Group = group;
            initGroup();
        }

        private void initGroup()
        {
            picBoxGroup.LoadAsync(m_Group.PictureNormalURL);
            ToolTip toolTip = new ToolTip();

            toolTip.SetToolTip(picBoxGroup, m_Group.Name);
        }
    }
}
