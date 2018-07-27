using System.Collections.Generic;
using Telegram.Bots.Toolkit.Helpers;
using Telegram.Bots.Toolkit.Model;

namespace Telegram.Bots.Toolkit.Services
{
    internal class SBots
    {
        public static List<string> GetSemuaBot()
        {
            return HIniParser.SemuaSections();
        }

        public static void TambahBot(string sect, List<TelegramBot> data)
        {
            HIniParser.Simpan(sect, "token", data[0].Token);
            HIniParser.Simpan(sect, "uri", data[0].Uri);
            HIniParser.Simpan(sect, "uriDefault", data[0].UriDefault);
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
                    Token = HIniParser.Baca(sect,"token"),
                    Uri = HIniParser.Baca(sect,"uri"),
                    UriDefault = HIniParser.Baca(sect,"uriDefault")
                }
            };

            return data;
        }
    }
}