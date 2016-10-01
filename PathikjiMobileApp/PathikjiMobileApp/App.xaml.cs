using Prism.Unity;
using PathikjiMobileApp.Views;

namespace PathikjiMobileApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainTabbedPage");
            
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainTabbedPage>();
            Container.RegisterTypeForNavigation<AboutPage>();
            Container.RegisterTypeForNavigation<AudioMasterDetailPage>();
            Container.RegisterTypeForNavigation<AudioMasterPage>();
            Container.RegisterTypeForNavigation<AudioDetailPage>();
            Container.RegisterTypeForNavigation<VideoMasterDetailpage>();
            Container.RegisterTypeForNavigation<VideoMasterPage>();
            Container.RegisterTypeForNavigation<VideoDetailPage>();
        }
    }
}
