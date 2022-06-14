using System.Net.NetworkInformation;

namespace Host_tester.Code
{
    internal class PingHost
    {
        public static int TIMEOUT = 2000;//mS
        public string hostAddress { set; get; }
        public Host_Data.HostConnectionStatus StartPing()
        {
            PingReply x=null;
            try
            {
                Ping pingSender = new Ping();

                 x = pingSender.Send(hostAddress, TIMEOUT);
            }
            catch
            {
                return Host_Data.HostConnectionStatus.Disconnected;
            }

            if (x!=null && x.Status == IPStatus.Success)
                return Host_Data.HostConnectionStatus.Connected;

            return Host_Data.HostConnectionStatus.Disconnected;

        }
    }
}
