using System;
using System.Windows.Forms;
using TelegramBots.Toolkit.Views;

namespace TelegramBots.Toolkit
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmAwal());
        }
    }
}