using System;
using System.Collections.Generic;

namespace MementoPattern
{
    public static class Caretaker<T>
    {
        //list of states saved
        private static List<Memento<T>> mementoList = new List<Memento<T>>();

        //save state of the originator
        public static void SaveState(Originator<T> orig)
        {
            mementoList.Add(orig.CreateMemento());
        }

        //restore state of the originator
        public static void RestoreState(Originator<T> orig, int stateNumber)
        {
            orig.SetMemento(mementoList[stateNumber]);
        }
    }
}