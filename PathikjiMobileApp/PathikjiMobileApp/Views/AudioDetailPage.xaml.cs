using PathikjiMobileApp.Model;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PathikjiMobileApp.Views
{
    public partial class AudioDetailPage : ContentPage
    {
        public List<Audio> Audios { get; set; }

        public AudioDetailPage()
        {
            InitializeComponent();

            Audios = new List<Audio>();
            Audios.Add(new Audio("Audio1", "http://pathikji.net/bhajan/Pathik1/Track01.mp3"));
            Audios.Add(new Audio("Audio2", "http://pathikji.net/bhajan/Pathik1/Track02.mp3"));
            Audios.Add(new Audio("Audio3", "http://pathikji.net/bhajan/Pathik1/Track03.mp3"));
            Audios.Add(new Audio("Audio4", "http://pathikji.net/bhajan/Pathik1/Track04.mp3"));
            Audios.Add(new Audio("Audio5", "http://pathikji.net/bhajan/Pathik1/Track05.mp3"));
            Audios.Add(new Audio("Audio6", "http://pathikji.net/bhajan/Pathik1/Track06.mp3"));
            Audios.Add(new Audio("Audio7", "http://pathikji.net/bhajan/Pathik1/Track07.mp3"));
            Audios.Add(new Audio("Audio8", "http://pathikji.net/bhajan/Pathik1/Track08.mp3"));

            AudioListView.ItemsSource = Audios;
        }

        public void OnTapped(object sender, ItemTappedEventArgs e)
        {
            try
            {
                Audio tappedAudio = (Audio)e.Item;
                Uri tappedUri = new Uri(tappedAudio.URL);
                //Device.OpenUri(tappedUri);
            }
            catch (Exception)
            {
                //throw;
            }

        }

    }
    
}
