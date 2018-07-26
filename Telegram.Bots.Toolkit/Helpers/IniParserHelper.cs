using IniParser;
using IniParser.Model;

namespace SIPWB.Helpers
{
    internal static class IniParserHelper
    {
        private static string iniFile = @"Resources\Settings.ini";

        public static void Simpan(string section, string setting, string value)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(iniFile);
            data[section][setting] = value;
            parser.WriteFile(iniFile, data);
        }

        public static string Baca(string section, string setting)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(iniFile);
            return data[section][setting];
        }

        public static void HapusSection(string section)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(iniFile);
            data.Sections.RemoveSection(section);
            parser.WriteFile(iniFile, data);
        }
    }
}