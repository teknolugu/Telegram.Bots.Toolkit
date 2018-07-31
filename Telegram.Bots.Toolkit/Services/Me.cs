using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bots.Toolkit.Model;

namespace Telegram.Bots.Toolkit.Services
{
    internal class Me : TelegramBot
    {
        public User GetWebhookInfo()
        {
            var botClient = new TelegramBotClient(Token);

            var data = botClient.GetMeAsync();

            return data.Result;
        }
    }
}
