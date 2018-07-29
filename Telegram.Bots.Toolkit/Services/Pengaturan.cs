using Telegram.Bots.Toolkit.Helpers;

namespace Telegram.Bots.Toolkit.Services
{
    internal class Pengaturan
    {
        private static string sect = "Settings";

        public static object Baca(string setting)
        {
            return HIniParser.Baca(sect, setting);
        }

        public static void Tulis(string setting, string nilai)
        {
            HIniParser.Simpan(sect, setting, nilai);
        }
    }
}