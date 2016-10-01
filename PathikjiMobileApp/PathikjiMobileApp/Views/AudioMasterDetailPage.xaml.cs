using Xamarin.Forms;

namespace PathikjiMobileApp.Views
{
    public partial class AudioMasterDetailPage : MasterDetailPage
    {
        public AudioMasterDetailPage()
        {
            InitializeComponent();
            Master = new AudioMasterPage();
            Detail = new AudioDetailPage();
        }
    }
}