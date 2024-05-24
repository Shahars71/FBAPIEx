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
    public partial class VideoBox : UserControl
    {
        private Video m_Video;
        public VideoBox()
        {
            InitializeComponent();
        }

        public VideoBox(Video video)
        {
            InitializeComponent();
            Video = video;
            initVideo();
        }

        private void initVideo()
        {
            picBoxThumb.LoadAsync(Video.PictureURL);
        }

        public Video Video { get => m_Video; set => m_Video = value; }

        private void picBoxThumb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Video.URL);
        }
    }
}
