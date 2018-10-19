using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KnockKnock
{
    [Serializable()]
    public class Device
    {
        [System.Xml.Serialization.XmlElement("Name")]
        public string Name { get; set; }

        [System.Xml.Serialization.XmlElement("IP")]
        public string IP { get; set; }

        [System.Xml.Serialization.XmlElement("Ports")]
        public List<string> Ports { get; set; }

        [System.Xml.Serialization.XmlElement("AuthenticationPacket")]
        public string AuthenticationPacket { get; set; }
    }


    [Serializable()]
    [System.Xml.Serialization.XmlRoot("DeviceCollection")]
    public class DeviceCollection
    {
        [XmlArray("Devices")]
        [XmlArrayItem("Device", typeof(Device))]
        public List<Device> Devices { get; set; }
    }
}
