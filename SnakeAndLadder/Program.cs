using System;

namespace SnakeAndLadder
{
    class Program
    {
        const int START_POSITION = 0;
        const int END_POSITION = 100;

        /// Create Reference for Random class
        static Random random = new Random();

        /// variables
        public static int currentPosition = 0;
        public static int selectedOption = 0;

        static void Main(string[] args)
        {
            /// Computation
            Console.WriteLine("Player Position is : " + PlayerOption());
        }

        /// <summary>
        /// Players the option.
        /// </summary>
        /// <returns></returns>
        public static int PlayerOption()
        {
            /// If Selected Option is 3(In case Snake), 
            /// Player Current Postion Moves Behind by The Number of Position recieved in the Dice
            /// If Option is 2(In case Ladder), Player Current Position Moves Ahead
            /// If Option is 1(In case No Play),Player Stay in Same Position
            while (currentPosition < END_POSITION - 1)
            {
                /// Variables
                int thrownDice = ThrowDice();
                int selectedOption = CheckForOption();

                if (selectedOption == 2)
                {
                    /// If Current Position and Thrown Dice Value is more than END_POSITION,
                    /// Stay With Previous Position
                    /// If Not, Till the Player get To Exact Position 100
                    if(currentPosition+thrownDice > END_POSITION)
                    {
                        ; // Do Nothing
                    }
                    else
                    {
                       currentPosition +=thrownDice;
                    }

                }
                else if (selectedOption == 3)
                {
                    currentPosition -= thrownDice;

                    /// If Current Position is Lessthan Zero then,
                    /// Player Position Starts from STARTING_POSITION (ie, 0)
                    if (currentPosition < 0)
                    {
                        currentPosition = START_POSITION;
                    }
                }
            }
            /// It returns Current Position
            return currentPosition;
        }
        public static int ThrowDice()
        {
            /// It returns Random Number Between 1 to 6
            return random.Next(1, 7);
        }

        public static int CheckForOption()
        {
            /// It returns Random Number Between 1 to 3
            return random.Next(1, 4);
        }
    }
}