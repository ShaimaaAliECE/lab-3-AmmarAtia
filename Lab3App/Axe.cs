using System;

namespace Lab3App
{
    internal class Axe : Tool
    {
        public Axe(string description) : base(description)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Axe " + base.Description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
    }
}