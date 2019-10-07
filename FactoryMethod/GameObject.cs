using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace FactoryMethod
{
    public class GameObject : Button
    {
        public GameObject(Brush brush)
        {
            Background = brush;
        }
    }
}
