using System.Collections.Generic;

namespace MVCLab6
{
    public class Observable
    {
        protected List<IMovieObserver> observers = new List<IMovieObserver>();

        public void AddObserver(IMovieObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IMovieObserver observer)
        {
            observers.Remove(observer);
        }

        protected void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(); 
            }
        }
    }
}
