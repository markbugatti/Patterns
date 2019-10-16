﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class LionTheKing : Movie
    {
        public LionTheKing()
        {
            this.Name = "Lion The King";
            this.PosterPath = new Uri("Images/TheLionKing.jpg", UriKind.Relative);
        }
    }
}
