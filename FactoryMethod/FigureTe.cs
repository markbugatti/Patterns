using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace FactoryMethod
{
    class FigureTe : Figure
    {
        public FigureTe()
        {
            create();
        }
        public override void create()
        {
            this.coordinates = new Point(0, 0);

            this.points = new List<Point>();

            this.points.Add(new Point(1, 0));
            this.points.Add(new Point(1, 1));
            this.points.Add(new Point(1, 2));
            this.points.Add(new Point(0, 1));

            this.buttons = new List<GameObject>();

            SolidColorBrush brush = new SolidColorBrush(Colors.Aqua);

            this.buttons.Add(new GameObject(brush));
            this.buttons.Add(new GameObject(brush));
            this.buttons.Add(new GameObject(brush));
            this.buttons.Add(new GameObject(brush));

            MainWindow.grid.Children.Add(buttons[0]);
            MainWindow.grid.Children.Add(buttons[1]);
            MainWindow.grid.Children.Add(buttons[2]);
            MainWindow.grid.Children.Add(buttons[3]);

            buttons[0].SetValue(Grid.RowProperty, points[0].Row);

            buttons[1].SetValue(Grid.RowProperty, points[1].Row);
            buttons[1].SetValue(Grid.ColumnProperty, points[1].Column);

            buttons[2].SetValue(Grid.RowProperty, points[2].Row);
            buttons[2].SetValue(Grid.ColumnProperty, points[2].Column);

            buttons[3].SetValue(Grid.RowProperty, points[3].Row);
            buttons[3].SetValue(Grid.ColumnProperty, points[3].Column);
        }        
        public override void moveDown()
        {
            
        }

        public override void moveLeft()
        {
            throw new NotImplementedException();
        }

        public override void moveRight()
        {
            throw new NotImplementedException();
        }
    }
}
