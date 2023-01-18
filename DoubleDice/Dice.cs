using System;
using System.Collections.Generic;
using System.Text;

namespace DoubleDice
{
    //class for the dice
    public class Dice
    {
        public int roll = 0;
        public Dice() // constructor that rolls the dice
        {
            Random rd = new Random();
            roll = rd.Next(6) + 1;
        }

        public int getNum()
        {
            return roll;
        }
    }
}
