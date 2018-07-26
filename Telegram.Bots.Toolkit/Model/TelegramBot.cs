namespace Telegram.Bots.Toolkit.Model
{
    internal class TelegramBot
    {
        public string Token { get; set; }

        public string Method { get; set; }

        public string Uri { get; set; }

        public string UriDefault { get; set; }

        public int PendingCount { get; set; }
    }
}