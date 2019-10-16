using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternObserver
{
    class Post : IObserver, IObservable
    {
        private List<IObserver> observers;

        public Post()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void GetParcel()
        {
            MainWindow.mainWindow.ProcessList.Items.Add("Ура! Я получил свои журнальчики и газеты, которые мне нужно отдать теперь моим подписчикам");   
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in observers)
            {
                observer.GetParcel();
            }
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }
    }
}
