using QRCoder;
using System.Drawing;

namespace Telegram.Bots.Toolkit.Helpers
{
    internal class HQrCode
    {
        public static Bitmap CreateQRCode(string value)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(value, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap QRcodeResult = qrCode.GetGraphic(20);

            return QRcodeResult;
        }
    }
}
