using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Methods

        // <summary>
        // Instantiates a Game object, then runs its methods multiple times to test its results, outputs to console when finished
        // </summary>
        public void Test()
        {
            Game game = new Game();
            game.Instantiate();
            for (int i = 0; i < 9999; i++)
            {
                // Run the Roll method, test if the Die values are out of range with an assertion
                game.Roll();
                foreach (Die die in game.DieList)
                {
                    Debug.Assert( die.Value >= 1 && die.Value <= 6, "Die value out of range");
                }

                // Run the Sum method, then sum up all the dice in our own loop and compare the two with an assertion
                game.Sum();
                int total = 0;
                foreach (Die die in game.DieList)
                {
                    total += die.Value;
                }
                Debug.Assert(game.Total == total, "Die sum incorrectly computed");
            }
            Console.WriteLine("Testing finished succesfully");
        }
    }
}
