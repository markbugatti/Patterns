using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace FactoryMethod
{
    public abstract class Figure
    {
        public Point coordinates { get; set; }
        public List<Point> points { get; set; }
        public List<GameObject> buttons { get; set; }
        public Brush background { get; set; }
        
        public abstract void create();
        public abstract void moveDown();
        public abstract void moveRight();
        public abstract void moveLeft();
        public bool checkRight()
        {

            return true;
        }
        public bool checkLeft()
        {
            return true;
        }
        public bool checkBottom()
        {
            return true;
        }
    }

}
