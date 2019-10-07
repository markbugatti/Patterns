﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Point
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public Point(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
