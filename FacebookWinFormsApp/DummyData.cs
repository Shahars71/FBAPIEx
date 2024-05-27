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
    public static class DummyData
    {
        static Collection<DataUnit> m_Friends;
        static Collection<DataUnit> m_Pages;
        static Collection<DataUnit> m_Groups;
        static Collection<DataUnit> m_Videos;
        static Collection<DataUnit> m_Photos;

        
        static DummyData()
        {
            Friends = new Collection<DataUnit>();
            Pages = new Collection<DataUnit>();
            Groups = new Collection<DataUnit>();
            Videos = new Collection<DataUnit>();
            Photos = new Collection<DataUnit>();


            fillFakeList();
        }

        public static Collection<DataUnit> Friends { get => m_Friends; set => m_Friends = value; }
        public static Collection<DataUnit> Pages { get => m_Pages; set => m_Pages = value; }
        public static Collection<DataUnit> Groups { get => m_Groups; set => m_Groups = value; }
        public static Collection<DataUnit> Videos { get => m_Videos; set => m_Videos = value; }
        public static Collection<DataUnit> Photos { get => m_Photos; set => m_Photos = value; }

        private static void fillFakeList()
        {
            

            Friends.Add(new DataUnit("Orange Orangeman", Resources.orange, ""));
            Friends.Add(new DataUnit("Apple Appleman", Resources.apple, ""));
            Friends.Add(new DataUnit("Pear Pearman", Resources.pear, ""));
            Friends.Add(new DataUnit("Pine Appleman", Resources.pineapple, ""));
            Friends.Add(new DataUnit("Straw Berryman", Resources.strawberry, ""));

            Pages.Add(new DataUnit("10 cool cleaning tips!",Resources.pageo, ""));
            Pages.Add(new DataUnit("10 cool cooking tips!", Resources.pageo, ""));
            Pages.Add(new DataUnit("10 cool drawing tips!", Resources.pageo, ""));
            Pages.Add(new DataUnit("Water drinking enthusiasts page", Resources.pageo, ""));

            Groups.Add(new DataUnit("Circle fans unite!", Resources.groupo, ""));
            Groups.Add(new DataUnit("Triangle fans unite!", Resources.groupo, ""));
            Groups.Add(new DataUnit("Square fans unite!", Resources.groupo, ""));
            Groups.Add(new DataUnit("Trapezoid fans unite!",Resources.groupo, ""));
            Groups.Add(new DataUnit("Dodecahedron fans unite!", Resources.groupo, ""));

            Photos.Add(new DataUnit("Me on a sunday", Resources.pageo,""));
            Photos.Add(new DataUnit("Me on a monday", Resources.pageo,""));
            Photos.Add(new DataUnit("Me on a tuesday", Resources.pageo, ""));
            Photos.Add(new DataUnit("ME ON A WEDNESDAY!!!!", Resources.pageo, ""));
            Photos.Add(new DataUnit("Me on a friday", Resources.pageo, ""));
            Photos.Add(new DataUnit("Me on a saturday", Resources.pageo, ""));

            Videos.Add(new DataUnit("I found a cute dog!!!", Resources.pageo, ""));
            Videos.Add(new DataUnit("I found a cute cat!!!", Resources.pageo, ""));
            Videos.Add(new DataUnit("I found a cute bird!!!",Resources.pageo, ""));
            Videos.Add(new DataUnit("I found a cute komodo dragon!!!", Resources.pageo, ""));
            Videos.Add(new DataUnit("I found a cute vespa mandarinia!!!", Resources.pageo, ""));
        }
    }
}
