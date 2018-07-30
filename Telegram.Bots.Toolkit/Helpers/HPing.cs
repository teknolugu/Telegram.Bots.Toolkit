using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Telegram.Bots.Toolkit.Helpers
{
    internal class HPing
    {
        public static async Task<long> PingGanAsync(string url)
        {
            var ping = new Ping();
            var uri = new Uri(url);
            long time = 0;
            var reply = await ping.SendPingAsync(uri.Host, 3000);

            if (reply.Status == IPStatus.Success)
            {
                time = reply.RoundtripTime;
            }
            else
            {
                time = -1;
            }
            return time;
        }
    }
}
