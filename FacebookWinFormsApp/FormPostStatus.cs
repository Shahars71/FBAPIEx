using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    // $G$ SFN-001 (-10) lacking feature
    public partial class FormPostStatus : Form
    {

        UserFacade m_LoggedInUser;
        public FormPostStatus(UserFacade i_user)
        {
            InitializeComponent();
            m_LoggedInUser = i_user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            postStatus();
        }

        private void postStatus()
        {
            try
            {
                Status postedStatus = m_LoggedInUser.PostStatus(tbPost.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
