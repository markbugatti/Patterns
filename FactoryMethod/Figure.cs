using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace FactoryMethod
{
    public abstract class Figure
    {
        public Point coordinates { get; set; }
        public List<Point> points { get; set; }
        public List<Button> buttons { get; set; }
        public Brush Brush { get; set; }
    }

}
