﻿using Xamarin.Forms;

namespace PathikjiMobileApp.Views
{
    public partial class VideoMasterDetailpage : MasterDetailPage
    {
        public VideoMasterDetailpage()
        {
            InitializeComponent();
            Master = new VideoMasterPage();
            Detail = new VideoDetailPage();
        }
    }
}