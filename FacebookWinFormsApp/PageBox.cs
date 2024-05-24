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
    public partial class PageBox : UserControl
    {
        private Page m_Page;
        public PageBox()
        {
            InitializeComponent();
        }

        public PageBox(Page page)
        {
            InitializeComponent();
            m_Page = page;
            initPage();
        }

        private void initPage()
        {
            // needs to add relevent controls in desgin
            picBoxPage.LoadAsync(m_Page.PictureNormalURL);

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picBoxPage, m_Page.Name);
        }

        private void picBoxPage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(m_Page.URL);
        }
    }
}
