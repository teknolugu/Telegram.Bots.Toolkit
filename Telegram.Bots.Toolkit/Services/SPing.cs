using System.Drawing;
using Telegram.Bots.Toolkit.Model;

namespace Telegram.Bots.Toolkit.Services
{
    internal class SPing : MPing
    {
        public long GetWaktu()
        {
            return PingGanAsync(Url).Result;
        }

        public Color GetWarna()
        {
            var warna = Color.Green;
            long waktu = PingGanAsync(Url).Result;
            if (waktu <= 250)
            {
                warna = Color.Green;
            }
            else if (waktu >= 251 && waktu <= 500)
            {
                warna = Color.Blue;
            }
            else if (waktu >= 501)
            {
                warna = Color.Red;
            }
            return warna;
        }
    }
}
