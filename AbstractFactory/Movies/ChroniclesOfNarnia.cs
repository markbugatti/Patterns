using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ChroniclesOfNarnia : Movie
    {
        public ChroniclesOfNarnia()
        {
            this.Name = "Chronicles Of Narnia";
            this.PosterPath = new Uri("Images/TheChroniclesOfNarnia.jpg", UriKind.Relative);
        }
    }
}
