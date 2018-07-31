using System.Drawing;
using Telegram.Bots.Toolkit.Helpers;
using Telegram.Bots.Toolkit.Model;

namespace Telegram.Bots.Toolkit.Services
{
    internal class SQrCode : MQrData
    {
        public Bitmap BuatQr()
        {
            return HQrCode.CreateQrCode(QrTeks);
        }
    }
}
