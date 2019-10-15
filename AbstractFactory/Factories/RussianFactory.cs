using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class RussianFactory : FilmFactory
    {
        public override Movie SetUp(Movie movie)
        {
            string language = "Russian";
            movie.SoundLanguage = language;
            movie.SubtitlesLanguage = language;
            return movie;
        }
    }
}
