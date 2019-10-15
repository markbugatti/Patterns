using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class GermanFactory : FilmFactory
    {
        public override Movie SetUp(Movie movie)
        {
            string language = "German";
            movie.SoundLanguage = language;
            movie.SubtitlesLanguage = language;
            return movie;
        }
    }
}
