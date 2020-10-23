using System;

namespace SnakeAndLadder
{
    class Program
    {
        const int START_POSITION = 0;
        const int END_POSITION = 100;

        /// variables
        public static int currentPosition = 0;
      
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            /// Computation
            /// prints the Current Position
            currentPosition += ThrowDice();
            Console.WriteLine("Current position :"+currentPosition);
        }

        /// <summary>
        /// Throws the dice.
        /// </summary>
        /// <returns></returns>
        public static int ThrowDice()
        {
            /// Create Reference for Random class
            Random random = new Random();

            /// It Returns a Random value 
            return random.Next(1, 7);
        }
    }
}
