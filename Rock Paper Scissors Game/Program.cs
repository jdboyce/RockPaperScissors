using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Start_Game_Dialogue newGame = new Start_Game_Dialogue();

            newGame.Welcome();

        }
    }
}
