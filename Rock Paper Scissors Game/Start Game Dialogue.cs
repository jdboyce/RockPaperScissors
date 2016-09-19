using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    public class Start_Game_Dialogue
    {

        public void Welcome()
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors! \nThis is a two player game, but you may play agaist the computer as well. \nOr you can have the computer play itself, if that makes you happy. \nThen you will select the winning score: each round is worth one point. \nGood luck!");

            Two_Player_Game_Dialogue newGame = new Two_Player_Game_Dialogue();

            newGame.ChooseNumberOfPlayers();
        }


    }
}
