using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace FactoryMethod
{
    class SquareFigure : Figure
    {
        public SquareFigure(int row, int column)
        {
            this.coordinates = new Point(row - 1, column - 1);

            this.points = new List<Point>();

            this.points.Add(new Point(coordinates.Row, coordinates.Column));
            this.points.Add(new Point(coordinates.Row, coordinates.Column + 1));
            this.points.Add(new Point(coordinates.Row + 1, coordinates.Column));
            this.points.Add(new Point(coordinates.Row + 1, coordinates.Column + 1));

            this.buttons = new List<Button>();

            Brush = new SolidColorBrush(Colors.BurlyWood);

            for (int i = 0; i < 4; i++)
            {
                Button button = new Button();
                button.Background = Brush;
                button.SetValue(Grid.RowProperty, points[i].Row);
                button.SetValue(Grid.ColumnProperty, points[i].Column);
                buttons.Add(button);
                MainWindow.grid.Children.Add(button);
            }
        }
    }
}
