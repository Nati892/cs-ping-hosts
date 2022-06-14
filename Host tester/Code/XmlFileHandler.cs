using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Host_tester.Code
{
    internal class XmlFileHandler
    {
        private const string FILE_PATH = "Hosts.xml";
        public static List<Host_Data> LoadFromXml()
        {
            List<Host_Data> remoteHosts = new List<Host_Data>();

            if (!File.Exists(FILE_PATH))
            {
                //create file and put empty xml data
                SaveToXml(remoteHosts);
            }
            else
            {

                XmlSerializer serializer = new XmlSerializer(typeof(List<Host_Data>));
                FileStream fs = new FileStream(FILE_PATH, FileMode.Open);
                remoteHosts = (List<Host_Data>)serializer.Deserialize(fs);
                fs.Close();
            }

            if (remoteHosts != null)//syncronize with the max Id counter
            {
                foreach (Host_Data h in remoteHosts)
                {
                    if (h.Id > Host_Data.MaxId)
                        Host_Data.MaxId = h.Id;
                }
            }
            return remoteHosts;
        }

        public static void SaveToXml(List<Host_Data> remoteHosts)
        {

            if (!File.Exists(FILE_PATH))
            {
                var x = File.Open(FILE_PATH, FileMode.CreateNew);
                x.Close();
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Host_Data>));
            TextWriter writer = new StreamWriter(FILE_PATH);
            serializer.Serialize(writer, remoteHosts);
            writer.Close();
        }


    }
}
