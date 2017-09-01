using System.Collections.Generic;
using VendeBemVeiculos_Patterns.Interfaces;

namespace VendeBemVeiculos_Patterns.Observers
{
    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attatch(IObserver observer)
        {
            this.observers.Add(observer);
        }
        
        public void Notify()
        {
            foreach(IObserver observer in this.observers)
            {
                observer.Update();
            }
        }
    }
}
