using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PathikjiMobileApp.ViewModels
{
    public class AboutPageViewModel : BindableBase
    {
        public string AboutHeading { get; private set; }

        public string AboutText { get; private set; }

        public AboutPageViewModel()
        {
            AboutHeading =
                "Sadhu vesh mein PATHIK";

            AboutText =
                "Sant Pathikji Maharaj was born in a kanyakubj-brahmin family. " +
                "He spent his childhood with his maternal grand parents. " +
                "There he acquired primary education. " +
                "From the beginning, he had faith and reverence for local gods and godesses.";
        }
    }
}
