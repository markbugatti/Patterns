using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Avengers : Movie
    {
        public Avengers()
        {
            this.Name = "Avengers";
            this.PosterPath = new Uri("Images/Avengers.jpg", UriKind.Relative);
        }
    }
}
