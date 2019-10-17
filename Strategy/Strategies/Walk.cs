﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    class Walk : IMovable
    {
        public void Move(Character character)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0} ходит", character.Type);
            MainWindow.EventBoard.Items.Add(stringBuilder.ToString());
        }

        public void MoveGroup(List<Character> group)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("ходит группа:");
            foreach (Character character in group)
            {
                stringBuilder.AppendFormat("\n\t" + character.Type.ToString());
            }
            MainWindow.EventBoard.Items.Add(stringBuilder.ToString());
        }
    }
}
