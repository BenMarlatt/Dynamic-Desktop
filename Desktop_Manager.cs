using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Desktop
{
    public class Desktop_Manager
    {
        static string xmlFileLocation = @"Desktops.xml";
        DesktopXmlizer desktopXmlizer = new DesktopXmlizer();
        private static int SelectedDesktop = 0;
        public static List<Desktop> Desktop_List = new List<Desktop>();

        public void createDefaultDesktop_List()
        {
            Desktop_List.Clear();
            // Default data for when Desktop.xml is not for or user resets the data
            var DefaultData = new List<Tuple<string, string>>
            {
                Tuple.Create("Desktop", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop"),
                Tuple.Create("Downloads", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads"),
                Tuple.Create("Documents", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Documents"),
                Tuple.Create("Pictures", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Pictures"),
                Tuple.Create("Videos", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Videos"),
                Tuple.Create("Music", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Music")
            };

            for (int x = 0; x < DefaultData.Count; x += 1)
            {
                string name = DefaultData[x].Item1;
                string path = DefaultData[x].Item2;
                int id = x;
                Desktop_List.Add(new Desktop(name, path, id));
            }
        }

        public void Load_Desktop()
        {
            
            Desktop_List = desktopXmlizer.XMLToDesktop(xmlFileLocation);
        }

        public void Save_Desktops()
        {
            desktopXmlizer.DesktopsToXML(Desktop_List, xmlFileLocation);
            
        }

        /*
         *
         * Getters/Setters
         * 
        */

        public List<Desktop> desktop_List
        {
            get
            {
                return Desktop_List;
            }
        }

        public int selectedDesktop
        {
            get
            {
                return SelectedDesktop;
            }
            set
            {
                SelectedDesktop = value;
            }
        }

        public string name
        {
            get
            {
                return Desktop_List[selectedDesktop].name;
            }
            set
            {
                Desktop_List[selectedDesktop].name = value;
            }
        }
        public string location
        {
            get
            {
                return Desktop_List[selectedDesktop].location;
            }

            set
            {
                Desktop_List[selectedDesktop].location = value;
            }
        }
    }
}
