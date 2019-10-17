using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Characters
{
    class Pixy : Character
    {
        public IMovable Movable { private get; set; }
        public Pixy(IMovable movable)
        {
            this.Type = "Фея";
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
