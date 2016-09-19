using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    public abstract class Player
    {


        public string name;
        public int points;
        public int inputAsInt;
        public string inputAsString;

        public virtual void PlayerInput()
        {
        }


        public int AddPoint()
        {
            return points += 1;
        }

        public class Human : Player
        {



            public override void PlayerInput()
            {
                Console.WriteLine("\n{0}'s turn. Enter rock, paper, or scissors:", name);

                string playerInput = Console.ReadLine().ToLower();

                if (playerInput == "rock")
                {
                    inputAsInt = 1;
                    inputAsString = "rock";
                }

                else if (playerInput == "paper")
                {
                    inputAsInt = 2;
                    inputAsString = "paper";

                }

                else if (playerInput == "scissors")
                {
                    inputAsInt = 3;
                    inputAsString = "scissors";
                }

                else
                {
                    this.PlayerInput();
                }

            }

        }


        public class Computer : Player
        {

            public override void PlayerInput()

            {
                Console.WriteLine("\n{0}'s turn. Choosing now...", name);

                Random randomNumber = new Random();

                inputAsInt = randomNumber.Next(1, 4);

                if (inputAsInt == 1)
                {
                    inputAsString = "rock";
                }

                else if (inputAsInt == 2)
                {
                    inputAsString = "paper";

                }

                else if (inputAsInt == 3)
                {
                    inputAsString = "scissors";
                }
            }

        }

    }
}
