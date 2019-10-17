using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Characters
{
    class Orc : Character
    {
        public IMovable Movable { private get; set; }
        public Orc(IMovable movable)
        {
            this.Type = "Орк";
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
