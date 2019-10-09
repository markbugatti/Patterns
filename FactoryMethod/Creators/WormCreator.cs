using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    class WormCreator : Creator
    {
        public override Figure Create(int row, int column)
        {
            return new WormFigure(row, column);
        }
    }
}
