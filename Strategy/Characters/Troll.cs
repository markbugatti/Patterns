using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Characters
{
    class Troll : Character
    {
        public IMovable Movable { private get; set; }
        public Troll(IMovable movable)
        {
            this.Type = "Троль";
            Movable = movable;
        }
        public void Move()
        {
            Movable.Move(this);
        }
        public void MoveGroup(List<Character> characters)
        {
            characters.Add(this);
            Movable.MoveGroup(characters);
        }

    }
}
