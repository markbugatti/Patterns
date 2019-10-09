using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    class BacteriaFactory
    {
        Queue<Bacterium> flyweights = new Queue<Bacterium>();
        private int Index;

        public Bacterium GetBacteria(int size, string shape)
        {
            if (flyweights.Count >   0)
            {
                ConcreteBacterium bacterium = (ConcreteBacterium)flyweights.Dequeue();
                bacterium.Adjust(size, shape);
                return bacterium;
            }
            else
            {
                Index++;
                return new ConcreteBacterium(Index);
            }
        }

        public void ReturnBacteria(Bacterium bacterium)
        {
            flyweights.Enqueue(bacterium);
        }
    }
}
