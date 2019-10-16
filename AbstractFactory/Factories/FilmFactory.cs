using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    abstract class FilmFactory
    {
        public static Movie Create(string name, string language) {
            Movie movie;
            switch(name)
            {
                case "Narnia":
                    movie = new ChroniclesOfNarnia();
                    break;
                case "Avengers":
                    movie = new Avengers();
                    break;
                case "LionTheKing":
                    movie = new LionTheKing();
                    break;
                default:
                    throw new NotImplementedException("there is no movie with specified name");
            }
             
            FilmFactory factory;
            switch (language)
            {
                case "english":
                    factory = new EnglishFactory();
                    break;
                case "russian":
                    factory = new RussianFactory();
                    break;
                case "german":
                    factory = new GermanFactory();
                    break;
                case "ukrainian":
                    factory = new UkrainianFactory();
                    break;
                default:
                    throw new NotImplementedException("there is such language");
            }
            factory.SetUp(movie);
            Poster.AddPoster(movie);
            return movie;
        }
        public abstract Movie SetUp(Movie movie);
    }
}