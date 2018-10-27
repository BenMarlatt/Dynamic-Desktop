using System;
using System.Collections.Generic;
using System.Xml;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Desktop
{
    class DesktopXmlizer
    {
        public void DesktopsToXML(List<Desktop> desktops, string path)
        {
            using (FileStream stream = File.Create(path))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(desktops.GetType());
                x.Serialize(stream, desktops);
            }
            
            
        }

        public List<Desktop> XMLToDesktop(string path)
        {

            List<Desktop> desktops = new List<Desktop>();
            using (FileStream stream = File.Open(path, FileMode.Open))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(desktops.GetType());
                desktops = (List<Desktop>)x.Deserialize(stream);
            }
            return desktops;
        }
    }
}
