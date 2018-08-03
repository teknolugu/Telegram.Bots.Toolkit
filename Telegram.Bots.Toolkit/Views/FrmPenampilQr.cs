using System.Text;
using System.Windows.Forms;

namespace Telegram.Bots.Toolkit.Views
{
    public partial class FrmPenampilQr : Form
    {
        public FrmPenampilQr()
        {
            InitializeComponent();
        }

        public void PerbaruiProperti()
        {
            var properti = new StringBuilder();
            properti.AppendLine(PicPenampilQr.Image.Size.ToString());
            properti.AppendLine(PicPenampilQr.Image.PixelFormat.ToString());

            TbxQrProperti.Text = properti.ToString();
        }
    }
}
