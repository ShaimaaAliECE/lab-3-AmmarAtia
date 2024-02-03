using Lab3App.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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