using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Creator
    {
        public static Figure Create(string name, int row, int column)
        { 
            if(name == "zet")
            {
                return new ZetFigure(row, column);
            }
            else if(name == "worm")
            {
                return new WormFigure(row, column);
            }
            else if(name == "te")
            {
                return new TeFigure(row, column);
            }
            else if(name == "square")
            {
                return new SquareFigure(row, column);
            }
            else if(name == "el")
            {
                return new ElFigure(row, column);
            }
            throw new NotImplementedException();
        }
    }
}
