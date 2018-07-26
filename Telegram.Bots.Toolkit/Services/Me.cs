using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bots.Toolkit.Model;

namespace Telegram.Bots.Toolkit.Services
{
    internal class Me : TelegramBot
    {
        public User GetWebhookInfo()
        {
            var BotClient = new TelegramBotClient(Token);

            var data = BotClient.GetMeAsync();

            return data.Result;
        }
    }
}