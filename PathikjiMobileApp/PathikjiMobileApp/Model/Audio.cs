using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathikjiMobileApp.Model
{
    public class Audio
    {
        public string Name { get; set; }
        public string URL { get; set; }

        public Audio(string name, string url)
        {
            this.Name = name;
            this.URL = url;
        }
    }
}
