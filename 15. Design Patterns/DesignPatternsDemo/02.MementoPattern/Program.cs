﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator<string> orig = new Originator<string>();

            orig.SetState("state0");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();

            orig.SetState("state1");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();

            orig.SetState("state2");
            Caretaker<string>.SaveState(orig); //save state of the originator
            orig.ShowState();

            //restore state of the originator
            Caretaker<string>.RestoreState(orig, 0);
            orig.ShowState();  //shows state0
        }
    } 
}