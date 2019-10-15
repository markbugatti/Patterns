using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class EnglishFactory : FilmFactory
    {
        public override Movie SetUp(Movie movie)
        {
            string language = "English";
            movie.SoundLanguage = language;
            movie.SubtitlesLanguage = language;
            return movie;
        }
    }
}
