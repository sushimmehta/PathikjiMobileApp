using PathikjiMobileApp.Model;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PathikjiMobileApp.Views
{
    public partial class VideoDetailPage : ContentPage
    {
        public int tmpVar;
        public List<Video> Videos { get; set; }
        public VideoDetailPage()
        {
            InitializeComponent();

            Videos = new List<Video>();
            Videos.Add(new Video("Video1", "https://www.youtube.com/watch?v=DZJOdIQH1KI"));
            Videos.Add(new Video("Video2", "https://www.youtube.com/watch?v=BDs4papwz0w"));
            Videos.Add(new Video("Video3", "https://www.youtube.com/watch?v=OwXTk1I1LqM"));
            Videos.Add(new Video("Video4", "https://www.youtube.com/watch?v=XD-kPtBRLLE"));
            Videos.Add(new Video("Video5", "https://www.youtube.com/watch?v=R-8x-XnYlM0"));
            Videos.Add(new Video("Video6", "https://www.youtube.com/watch?v=-5h1kKou2vk"));
            Videos.Add(new Video("Video7", "https://www.youtube.com/watch?v=3PA-yj6sByk"));
            Videos.Add(new Video("Video8", "https://www.youtube.com/watch?v=p5PHBbZYjec"));

            NewListView.ItemsSource = Videos;
        }

        public void OnTapped (object sender, ItemTappedEventArgs e)
        {
            try
            {
                Video tappedVideo = (Video)e.Item;
                Uri tappedUri = new Uri(tappedVideo.URL);
                Device.OpenUri(tappedUri);
            }
            catch (Exception)
            {
                //throw;
            }

        }
    }
}
