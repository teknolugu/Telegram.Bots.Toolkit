using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bots.Toolkit.Model;

namespace Telegram.Bots.Toolkit.Helpers
{
    internal class Pending : TelegramBot
    {
        public WebhookInfo GetWebhookInfo()
        {
            var BotClient = new TelegramBotClient(Token);

            var data = BotClient.GetWebhookInfoAsync();

            return data.Result;
        }

        public void HapusWebhook()
        {
            var BotClient = new TelegramBotClient(Token);

            var data = BotClient.DeleteWebhookAsync();
        }

        public void SetWebhook()
        {
            var BotClient = new TelegramBotClient(Token);

            var data = BotClient.SetWebhookAsync(Uri);
        }

        public void SetWebhookDefault()
        {
            var BotClient = new TelegramBotClient(Token);

            var data = BotClient.SetWebhookAsync(UriDefault);
        }

        public void GetUpdates()
        {
            var BotClient = new TelegramBotClient(Token);

            var data = BotClient.GetUpdatesAsync();
        }
    }
}