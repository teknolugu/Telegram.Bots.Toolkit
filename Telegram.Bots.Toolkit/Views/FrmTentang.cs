using System.Windows.Forms;

namespace Telegram.Bots.Toolkit.Views
{
    public partial class FrmTentang : Form
    {
        public FrmTentang()
        {
            InitializeComponent();
            LblProduk.Text = Application.ProductName;
            LblVersi.Text = "Versi :" + Application.ProductVersion;
        }
    }
}