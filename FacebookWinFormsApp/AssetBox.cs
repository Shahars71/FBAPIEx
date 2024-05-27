using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class AssetBox : UserControl
    {
        private string m_URL;
        private string m_PicURL;
        private string m_Name;

        public AssetBox(string i_URL, string i_PicURL, string i_Name)
        {
            InitializeComponent();
            m_URL = i_URL;
            m_PicURL = i_PicURL;
            m_Name = i_Name;
            initializeAssetPictureBox();
        }

        public AssetBox(DataUnit fakeData)
        {
            InitializeComponent();
            m_Name = fakeData.Name;
            picBoxAsset.Image = fakeData.Image;
            m_URL = fakeData.Link;
            initializeAssetPictureBox();
        }

        private void initializeAssetPictureBox()
        {
            if (picBoxAsset.Image == null)
            {
                picBoxAsset.LoadAsync(m_PicURL);

            }

            ToolTip toolTipName = new ToolTip();
            toolTipName.SetToolTip(picBoxAsset, m_Name);
        }

        private void picBoxAsset_Click(object sender, EventArgs e)
        {
            if (m_URL != "")
            {
                System.Diagnostics.Process.Start(m_URL);
            }
            
        }
    }
}
