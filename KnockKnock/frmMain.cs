using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Net;
using System.Net.Sockets;

namespace KnockKnock
{
    public partial class frmMain : Form
    {
        DeviceCollection _dc;

        public frmMain()
        {
            InitializeComponent();

            // Load in the XML
            string contents = File.ReadAllText(@"Devices.xml");
            StringReader stringReader = new StringReader(contents);
            XmlSerializer serializer = new XmlSerializer(typeof(DeviceCollection));
            _dc = (DeviceCollection)serializer.Deserialize(stringReader);

            // Sort the List By Device Name
            _dc.Devices = _dc.Devices.OrderBy(x => x.Name).ToList();

            // Populate the Device Names in the List View
            foreach(var Device in _dc.Devices)
            {
                lstSavedDevices.Items.Add(Device.Name);
            }
        }

        private void btnKnock_Click(object sender, EventArgs e)
        {
            var _result = _dc.Devices.Single(s => s.Name == lstSavedDevices.SelectedItem.ToString());

            byte[] packetData = Encoding.ASCII.GetBytes(_result.AuthenticationPacket);

            IPAddress address = null;
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            IPAddress.TryParse(_result.IP, out address);
            foreach (var _port in _result.Ports)
            {
                int port = 0;
                if (int.TryParse(_port, out port))
                {
                    Console.WriteLine($"Sending UDP packet to {address}:{port}");
                    socket.SendTo(packetData, new IPEndPoint(address, port));
                }
                System.Threading.Thread.Sleep(500);
            }
        }
    }
}
