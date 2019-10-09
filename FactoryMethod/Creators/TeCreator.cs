using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    class TeCreator : Creator
    {
        public override Figure Create(int row, int column)
        {
            return new TeFigure(row, column);
        }
    }
}
