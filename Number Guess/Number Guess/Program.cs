using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to number guess");
            string player1Name = GetPlayerName(1);
            string player2Name = GetPlayerName(2);


            Console.ReadKey();


        }

        public static string GetPlayerName(int playerNumber)///creates method that takes in a player number weather it is 1 or 2 
        {
            string playerName="";
            Console.WriteLine("Player {0} what is your name", playerNumber);///asks users to enter their name 
            try///Reads the input by the player
            {
               playerName = Console.ReadLine();
              
            }
            catch( Exception e)
            {
                Console.WriteLine("Looks like something went wrong");
            }
            return playerName;//returns player name to method call
        }
    }
}
