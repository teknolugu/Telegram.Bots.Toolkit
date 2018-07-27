using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bots.Toolkit.Model;

namespace Telegram.Bots.Toolkit.Services
{
    internal class Pending : TelegramBot
    {
        public WebhookInfo GetWebhookInfo()
        {
            var botClient = new TelegramBotClient(Token);

            var data = botClient.GetWebhookInfoAsync();

            return data.Result;
        }

        public void HapusWebhook()
        {
            var botClient = new TelegramBotClient(Token);

            var data = botClient.DeleteWebhookAsync();
        }

        public void SetWebhook()
        {
            var botClient = new TelegramBotClient(Token);

            var data = botClient.SetWebhookAsync(Uri);
        }

        public void SetWebhookDefault()
        {
            var botClient = new TelegramBotClient(Token);

            var data = botClient.SetWebhookAsync(UriDefault);
        }

        public void GetUpdates()
        {
            var botClient = new TelegramBotClient(Token);

            var data = botClient.GetUpdatesAsync();
        }
    }
}