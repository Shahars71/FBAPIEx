using BasicFacebookFeatures.Properties;
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
    public static class DummyData
    {
        static Collection<FakeData> m_Friends;
        static Collection<FakeData> m_Pages;
        static Collection<FakeData> m_Groups;
        static Collection<FakeData> m_Videos;
        static Collection<FakeData> m_Photos;

        
        static DummyData()
        {
            Friends = new Collection<FakeData>();
            Pages = new Collection<FakeData>();
            Groups = new Collection<FakeData>();
            Videos = new Collection<FakeData>();
            Photos = new Collection<FakeData>();


            fillFakeList();
        }

        public static Collection<FakeData> Friends { get => m_Friends; set => m_Friends = value; }
        public static Collection<FakeData> Pages { get => m_Pages; set => m_Pages = value; }
        public static Collection<FakeData> Groups { get => m_Groups; set => m_Groups = value; }
        public static Collection<FakeData> Videos { get => m_Videos; set => m_Videos = value; }
        public static Collection<FakeData> Photos { get => m_Photos; set => m_Photos = value; }

        private static void fillFakeList()
        {
            

            Friends.Add(new FakeData("Orange Orangeman", Resources.orange, ""));
            Friends.Add(new FakeData("Apple Appleman", Resources.apple, ""));
            Friends.Add(new FakeData("Pear Pearman", Resources.pear, ""));
            Friends.Add(new FakeData("Pine Appleman", Resources.pineapple, ""));
            Friends.Add(new FakeData("Straw Berryman", Resources.strawberry, ""));

            Pages.Add(new FakeData("10 cool cleaning tips!",Resources.pageo, ""));
            Pages.Add(new FakeData("10 cool cooking tips!", Resources.pageo, ""));
            Pages.Add(new FakeData("10 cool drawing tips!", Resources.pageo, ""));
            Pages.Add(new FakeData("Water drinking enthusiasts page", Resources.pageo, ""));

            Groups.Add(new FakeData("Circle fans unite!", Resources.groupo, ""));
            Groups.Add(new FakeData("Triangle fans unite!", Resources.groupo, ""));
            Groups.Add(new FakeData("Square fans unite!", Resources.groupo, ""));
            Groups.Add(new FakeData("Trapezoid fans unite!",Resources.groupo, ""));
            Groups.Add(new FakeData("Dodecahedron fans unite!", Resources.groupo, ""));

            Photos.Add(new FakeData("Me on a sunday", Resources.pageo,""));
            Photos.Add(new FakeData("Me on a monday", Resources.pageo,""));
            Photos.Add(new FakeData("Me on a tuesday", Resources.pageo, ""));
            Photos.Add(new FakeData("ME ON A WEDNESDAY!!!!", Resources.pageo, ""));
            Photos.Add(new FakeData("Me on a friday", Resources.pageo, ""));
            Photos.Add(new FakeData("Me on a saturday", Resources.pageo, ""));

            Videos.Add(new FakeData("I found a cute dog!!!", Resources.pageo, ""));
            Videos.Add(new FakeData("I found a cute cat!!!", Resources.pageo, ""));
            Videos.Add(new FakeData("I found a cute bird!!!",Resources.pageo, ""));
            Videos.Add(new FakeData("I found a cute komodo dragon!!!", Resources.pageo, ""));
            Videos.Add(new FakeData("I found a cute vespa mandarinia!!!", Resources.pageo, ""));
        }
    }

    public class FakeData
    {
        private string m_Name;
        private Image m_Image;
        private string m_Link;

        public Image Image { get => m_Image; set => m_Image = value; }
        public string Name { get => m_Name; set => m_Name = value; }
        public string Link { get => m_Link; set => m_Link = value; }

        public FakeData(string name, Image image, string link)
        {
            m_Name = name;
            m_Image = image;
            m_Link = link;
        }
    }
}
