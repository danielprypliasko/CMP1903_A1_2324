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

        //Method
        public void Test()
        {
            Game game = new Game();
            game.Instantiate();
            for (int i = 0; i < 999999; i++)
            {
                game.Roll();
                Debug.Assert(game.DieOne.Value >= 1 && game.DieOne.Value <= 6);
                Debug.Assert(game.DieTwo.Value >= 1 && game.DieTwo.Value <= 6);
                Debug.Assert(game.DieThree.Value >= 1 && game.DieThree.Value <= 6);
                game.Sum();
                Debug.Assert(game.Total == (game.DieOne.Value + game.DieTwo.Value + game.DieThree.Value));

            }
            game.Report();
            Console.WriteLine("Testing finished succesfully");
        }
    }
}
