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
        public static Desktop[] Desktop_List = new Desktop[8];

        public static void Load_Desktop()
        {
            int c = 0;
            foreach (Desktop desktop in Desktop_List)
            {
                Desktop_List[c] = new Desktop("Name", "Location");
                c++;
            }
        }

        public static void Save_Desktops()
        {
            using (StreamWriter file = new StreamWriter(xmlFileLocation))
            {
                
                foreach (Desktop desktop in Desktop_List)
                {
                    XmlSerializer x = new XmlSerializer(desktop.GetType());
                    x.Serialize(file, desktop);
                }
            }
        }
    }
}
