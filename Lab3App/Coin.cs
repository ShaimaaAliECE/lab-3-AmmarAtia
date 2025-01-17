﻿using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Coin : Treasure
    {
        public int Value { get; set; }

        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;
        }

        public override void Display()
        {
            Console.WriteLine("Coin " + base.Description + " is displayed");
        }

        public void UpdateTotalValue()
        {
            Board.TotalValue += Value;
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            UpdateTotalValue();
        }
    }
}