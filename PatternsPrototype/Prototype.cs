using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatternsPrototype
{
    public abstract class Prototype
    {

        public string Title { get ; private set ; }
        public string Text { get ; private set ; }

        public Prototype(string Title, string Text)
        {
            this.Title = Title;
            this.Text = Text;
        }

        public abstract Prototype Clone();
    }
}
