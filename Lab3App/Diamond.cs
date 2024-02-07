using System;

namespace Lab3App
{
    internal class Diamond : Treasure
    {
        public Diamond(string description, int score) : base(description, score)
        {
        }

        public override void Display()
        {
            Console.WriteLine(base.Description + " is displayed");
        }

    }
}