using Xamarin.Forms;

namespace PathikjiMobileApp.Views
{
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            InitializeComponent();

            Children.Add(new AboutPage());
            Children.Add(new VideoMasterDetailpage());
            Children.Add(new AudioMasterDetailPage());
        }
    }
}
