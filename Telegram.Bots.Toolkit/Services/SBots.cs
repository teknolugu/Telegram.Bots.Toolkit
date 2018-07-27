using System.Collections.Generic;
using Telegram.Bots.Toolkit.Helpers;
using Telegram.Bots.Toolkit.Model;

namespace Telegram.Bots.Toolkit.Services
{
    internal class SBots
    {
        public static List<string> GetSemuaBot()
        {
            string[] bukans = new[] { "Settings" };
            var bots = HIniParser.SemuaSections();
            foreach (var bukan in bukans)
            {
                bots.Remove(bukan);
            }

            return bots;
        }

        public static void TambahBot(string sect, List<TelegramBot> data)
        {
            HIniParser.Simpan(sect, "Token", data[0].Token);
            HIniParser.Simpan(sect, "UriClean", data[0].UriClean);
            HIniParser.Simpan(sect, "UriCurrent", data[0].UriCurrent);
        }

        public static void HapusBot(string sect)
        {
            HIniParser.HapusSection(sect);
        }

        public static List<TelegramBot> GetBots(string sect)
        {
            var data = new List<TelegramBot>
            {
                new TelegramBot
                {
                    Token = HIniParser.Baca(sect,"Token"),
                    UriClean = HIniParser.Baca(sect,"UriClean"),
                    UriCurrent = HIniParser.Baca(sect,"UriCurrent")
                }
            };

            return data;
        }
    }
}