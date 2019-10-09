using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Creators
{
    class ElCreator : Creator
    {
        public override Figure Create(int row, int column)
        {
            return new ElFigure(row, column);
        }
    }
}
