using System.Collections.Generic;
using System;

namespace Lab3App
{
    abstract class Tool : Collectable
    {
        protected Tool(string description) : base(description)
        {
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(base.Description + " Collected, Congrats!!!!");
            DoAction();
        }

        public abstract void DoAction();
    }
}