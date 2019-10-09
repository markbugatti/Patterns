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
        public BacteriaFactory()
        {
            for (Index = 0; Index < 100; Index++)
            {
                // create Bacterium with id extrinsicState - form, size; intrinsicState = id of real bacteriem in pool
                flyweights.Enqueue(new ConcreteBacterium(Index));
            }
        }
        public Bacterium GetBacteria(int size, string shape)
        {
            if(flyweights.Count != 0)
            {
                ConcreteBacterium bacterium = (ConcreteBacterium)flyweights.Dequeue();
                bacterium.Explore(size, shape);
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
