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
        public static int selectedDesktop = 0;
        public static List<Desktop> Desktop_List = new List<Desktop>();

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
