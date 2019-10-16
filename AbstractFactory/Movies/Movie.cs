using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Movie
    {
        public string Name { get; set; }
        public Uri PosterPath { get; set; }
        public string SoundLanguage { get; set; }
        public string SubtitlesLanguage { get; set; }
    }
}
