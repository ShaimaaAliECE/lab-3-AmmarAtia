using System;
using System.Collections.Generic;
using System.Net;

namespace Lab3App
{
    abstract class Treasure : Collectable
    {
        public int Score { get; set; }

        protected Treasure(string description, int score) : base(description)
        {
            Score = score;
        }


        public void UpdateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(base.Description + " Collected, Congrats!!!!");
            UpdateTotalScore();
        }
    }
}