using System;
using System.Collections.Generic;

namespace Lab3App
{
    abstract class Collectable : Displayable
    {
        public string Description { get; set; }

        public CollectionBoard Board;

        protected Collectable(string description)
        {
            Description = description;
        }

        public abstract void AddMe(List<Collectable> list);

        public abstract void Display();
    }
}