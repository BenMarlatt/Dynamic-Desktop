using System;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Desktop
{
    class Desktop_Manager
    {
        static string xmlFileLocation = @"Desktops.xml";
        private static int SelectedDesktop;
        public static List<Desktop> Desktop_List = new List<Desktop>();

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
                // This would be a good place for error checking and location checking
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
                // This would be a good place for error checking and location checking
                Desktop_List[selectedDesktop].location = value;
            }
        }

        public static void Load_Desktop()
        {
            DesktopXmlizer desktopXmlizer = new DesktopXmlizer();
            Desktop_List = desktopXmlizer.XMLToDesktop(xmlFileLocation);
        }

        public static void Save_Desktops()
        {
            Console.WriteLine("Save_Desktops");
            DesktopXmlizer desktopXmlizer = new DesktopXmlizer();
            desktopXmlizer.DesktopsToXML(Desktop_List, xmlFileLocation);
            
        }
    }
}
