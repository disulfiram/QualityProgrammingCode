using System;

namespace MementoPattern
{
    public class Memento<T>
    {
        private T state;

        public T GetState()
        {
            return state;
        }

        public void SetState(T state)
        {
            this.state = state;
        }
    }
}