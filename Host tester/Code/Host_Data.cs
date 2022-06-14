using System;
using System.IO;
using System.Xml.Serialization;

namespace Host_tester.Code
{
    [XmlRoot(IsNullable = false)]
    public class Host_Data
    {
        public enum HostConnectionStatus
        {
            Disconnected,
            Connected,
            Pinging
        }

        public static int MaxId=0;

        public int Id { get; set; }
        public string Name { set; get; }
        public string Address { set; get; }
        public bool Enabled { set; get; }
        public HostConnectionStatus Status { set; get; }

        //needed for xml serialization
        private Host_Data() { }


        public Host_Data(string name, string address, bool enabled, HostConnectionStatus status)
        {
            MaxId++;
            Id = MaxId;
            Name = name;
            Address = address;
            Enabled = enabled;
            Status = status;
        }

    }
}
