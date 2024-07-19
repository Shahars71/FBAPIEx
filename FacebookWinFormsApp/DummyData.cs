using BasicFacebookFeatures.Properties;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{

    public class DummyData
    {
        #region members

        public Collection<DataUnit> Friends {  get; set; }
        public Collection<DataUnit> Photos {  get; set; }
        public Collection<DataUnit> Groups {  get; set; }
        public Collection<DataUnit> Videos {  get; set; }
        public Collection<DataUnit> Pages {  get; set; }

        #endregion

        private static volatile DummyData s_instance;
        private static object s_locker = new object();

        private DummyData()
        {
            Friends = new Collection<DataUnit>();
            Groups = new Collection<DataUnit>();
            Videos = new Collection<DataUnit>();
            Pages = new Collection<DataUnit>();
            Photos = new Collection<DataUnit>();

            fillFakeList();
        }
        public static DummyData Instance
        {
            get
            {
                if (s_instance == null)
                {
                    lock (s_locker)
                    {
                        if (s_instance == null)
                        {
                            s_instance = new DummyData();
                        }
                    }
                }
                return s_instance;
            }
        }


        private void fillFakeList()
        {
            

            Friends.Add(new DataUnit("Orange Orangeman", "https://static8.depositphotos.com/1020804/884/i/950/depositphotos_8840885-stock-photo-orange-fruits-on-a-white.jpg", ""));
            Friends.Add(new DataUnit("Apple Appleman", "https://as1.ftcdn.net/v2/jpg/01/76/97/96/1000_F_176979696_hqfioFYq7pX13dmiu9ENrpsHZy1yM3Dt.jpg", ""));
            Friends.Add(new DataUnit("Pear Pearman", "https://static9.depositphotos.com/1642482/1148/i/950/depositphotos_11489464-stock-photo-pears.jpg", ""));
            Friends.Add(new DataUnit("Pine Appleman", "https://st.depositphotos.com/1050689/2099/i/950/depositphotos_20990611-stock-photo-pineapple-isolated.jpg", ""));
            Friends.Add(new DataUnit("Straw Berryman", "https://www.shutterstock.com/shutterstock/photos/1750959335/display_1500/stock-photo-strawberry-isolated-strawberries-isolate-whole-half-cut-strawberry-on-white-strawberries-1750959335.jpg", ""));

            Pages.Add(new DataUnit("10 cool cleaning tips!", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Pages.Add(new DataUnit("10 cool cooking tips!", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Pages.Add(new DataUnit("10 cool drawing tips!", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Pages.Add(new DataUnit("Water drinking enthusiasts page", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));

            Groups.Add(new DataUnit("Circle fans unite!", "https://www.iconsdb.com/icons/preview/dim-gray/group-xxl.png", ""));
            Groups.Add(new DataUnit("Triangle fans unite!", "https://www.iconsdb.com/icons/preview/dim-gray/group-xxl.png", ""));
            Groups.Add(new DataUnit("Square fans unite!", "https://www.iconsdb.com/icons/preview/dim-gray/group-xxl.png", ""));
            Groups.Add(new DataUnit("Trapezoid fans unite!", "https://www.iconsdb.com/icons/preview/dim-gray/group-xxl.png", ""));
            Groups.Add(new DataUnit("Dodecahedron fans unite!", "https://www.iconsdb.com/icons/preview/dim-gray/group-xxl.png", ""));

            Photos.Add(new DataUnit("Me on a sunday", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Photos.Add(new DataUnit("Me on a monday", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png",""));
            Photos.Add(new DataUnit("Me on a tuesday", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Photos.Add(new DataUnit("ME ON A WEDNESDAY!!!!", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Photos.Add(new DataUnit("Me on a friday", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Photos.Add(new DataUnit("Me on a saturday", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));

            Videos.Add(new DataUnit("I found a cute dog!!!", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Videos.Add(new DataUnit("I found a cute cat!!!", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Videos.Add(new DataUnit("I found a cute bird!!!","https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Videos.Add(new DataUnit("I found a cute komodo dragon!!!", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
            Videos.Add(new DataUnit("I found a cute vespa mandarinia!!!", "https://cdn.iconscout.com/icon/premium/png-512-thumb/image-missing-1178918.png", ""));
        }

        public Collection<DataUnit> GetDummyDataList (eDataTypes i_dataType)
        {
            switch(i_dataType)
            {
                case eDataTypes.friends:return Friends;
                case eDataTypes.pages: return Pages;
                case eDataTypes.photos: return Photos;
                case eDataTypes.videos: return Videos;
                case eDataTypes.groups: return Groups;
                
                    default: return null;
            }
        }
    }
}
