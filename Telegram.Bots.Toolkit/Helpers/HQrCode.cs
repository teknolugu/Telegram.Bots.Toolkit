using QRCoder;
using System.Drawing;

namespace Telegram.Bots.Toolkit.Helpers
{
    internal static class HQrCode
    {
        public static Bitmap CreateQrCode(string value)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            var qRcodeResult = qrCode.GetGraphic(20);

            return qRcodeResult;
        }
    }
}
