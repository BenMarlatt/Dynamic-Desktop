using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Desktop
{
    class DesktopXmlizer
    {


        public void DesktopsToXML(List<Desktop> desktops)
        {

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(desktops.GetType());
            FileStream file = File.Create("Desktops.xml");
            x.Serialize(file, desktops);

        }

        public void XMLToDesktop(string path)
        {
            List<Desktop> desktops = new List<Desktop>();
            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(desktops.GetType());

            using (FileStream stream = File.Open(path, FileMode.Open))
            {
                desktops = (List<Desktop>)x.Deserialize(stream);
            }
        }


    }
}
