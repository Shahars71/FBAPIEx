using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.ComponentModel;
using System;

namespace BasicFacebookFeatures
{
    public class DataUnit
    {
        public string Name { get; set; }  = string.Empty;
        public string ImageURL { get; set; } = null;
        public string Link { get; set; } = string.Empty;
        public DateTime? CreatedTime { get; set; } = DateTime.Now;
        public int LikesCount { get; set; } = 0;

        public DataUnit(string name, string imageURL, string link, int likesCount) : this(name, imageURL, link)
        {
            LikesCount = likesCount;
        }

        public DataUnit(string i_name, string i_imageURL, string i_link)
        {
            Name = i_name;
            ImageURL = i_imageURL;
            Link = i_link;
        }
        public DataUnit() { }
        public DataUnit(string i_name, string i_imageURL, string i_link, DateTime? i_CreatedTime, int i_LikesCount)
        {
            Name = i_name;
            ImageURL = i_imageURL;
            Link = i_link;
            CreatedTime= i_CreatedTime;
            LikesCount = i_LikesCount;
        }
    }
}
