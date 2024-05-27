using System.Drawing;

namespace BasicFacebookFeatures
{
    public class DataUnit
    {
        private string m_Name;
        private Image m_Image;
        private string m_Link;

        public Image Image { get => m_Image; set => m_Image = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public string Link { get => m_Link; set => m_Link = value; }

        public DataUnit(string name, Image image, string link)
        {
            m_Name = name;
            m_Image = image;
            m_Link = link;
        }
    }
}
