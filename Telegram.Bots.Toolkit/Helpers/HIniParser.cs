using System.Collections.Generic;
using IniParser;
using IniParser.Model;
using System.IO;

namespace Telegram.Bots.Toolkit.Helpers
{
    internal class HIniParser
    {
        public static string IniFile { get; set; } = @"Resources\Settings.ini";

        public static void FileCheck()
        {
            if (!Directory.Exists("Resources"))
            {
                Directory.CreateDirectory("Resources");
            }

            if (!File.Exists(IniFile))
            {
                //File.CreateText(IniFile);
                using (var fileWriter = new StreamWriter(IniFile, true))
                {
                    fileWriter.Write("[Settings]\n");
                }
            }
        }

        public static void Simpan(string section, string setting, string value)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(IniFile);
            data[section][setting] = value;
            parser.WriteFile(IniFile, data);
        }

        public static string Baca(string section, string setting)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(IniFile);
            return data[section][setting];
        }

        public static void HapusSection(string section)
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(IniFile);
            data.Sections.RemoveSection(section);
            parser.WriteFile(IniFile, data);
        }

        public static List<string> SemuaSections()
        {
            HIniParser.FileCheck();
            var list = new List<string>();
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile(HIniParser.IniFile);
            foreach (SectionData sect in data.Sections)
            {
                list.Add(sect.SectionName);
            }

            list.Sort();
            return list;
        }
    }
}