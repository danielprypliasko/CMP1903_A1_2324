using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Properties
        public Die DieOne;
        public Die DieTwo;
        public Die DieThree;
        public int Total;

        //Methods
        public void Instantiate()
        {
            DieOne = new Die();
            DieTwo = new Die();
            DieThree = new Die();
        }
        public void Roll()
        {
            DieOne.Roll();
            DieTwo.Roll();
            DieThree.Roll();
        }
        public void Sum()
        {
            int total = DieOne.Value + DieTwo.Value + DieThree.Value;
            Total = total;
        }
        public void Report()
        {
            Console.WriteLine($"The sum is {Total}");
        }
        public void Play() {
            Instantiate();
            Roll();
            Sum();
            Report();
        }

    }
}
