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

            

            
                PlayGame(player1Name, player2Name);

               
            
            
            Console.ReadKey();


        }

        public static string GetPlayerName(int playerNumber)///creates method that takes in a player number weather it is 1 or 2 
        {
            string playerName="";
            while (playerName == "")
            { 
                Console.WriteLine("Player {0} what is your name", playerNumber);///asks users to enter their name 
              
                playerName = Console.ReadLine(); ///Reads the input by the player
            }
            return playerName;//returns player name to method call
        }

        public static int GetNumber(string playerName, string message)
        {

            string numberString = "";
            int number = 0;
            while(numberString == ""|| number<1|| number >100)//this makes sure that a user does not enter blank and within range
            {
                Console.WriteLine("{0} {1}", playerName, message);
                numberString = Console.ReadLine();
                try
                {
                    number = int.Parse(numberString);
                }catch(FormatException ex)
                {
                    Console.WriteLine("that is not a number");
                    numberString = "";///this make the loop repeat by setting numberstring back to null 
                }
                
            }
          
            return number;
        }

        public static int PlayGame(string player1Name, string player2Name)
        {
            char playagain = 'y';
            while (playagain.Equals('y')){
                string message = "Please choose a number between 1 and 100";
                int numberToGuess = GetNumber(player1Name, message);
                int currentAttempt = 1;
                Console.WriteLine("{0} please try to guess {1}'s number", player2Name, player1Name);


                while (currentAttempt <= 10)
                {
                    int guessedNumber = 0;
                    int guessedNumbertest = 0;
                    try
                    {
                        guessedNumber = int.Parse(Console.ReadLine());
                    } catch (FormatException e)
                    {
                        Console.WriteLine("this is not a number");
                        guessedNumbertest = -1;
                    }

                    if (guessedNumber == numberToGuess)
                    {
                        Console.WriteLine("Congratulation, you guessed the correct Number");
                        break;
                    }
                    else if (guessedNumbertest == -1)
                    {
                        Console.WriteLine("Please try again");
                    }
                    else if (currentAttempt == 10)
                    {
                        Console.WriteLine("Sorry you did not guess the number");
                        Console.WriteLine("GAME OVER");
                        break;
                    }
                    else if (currentAttempt > 5 && guessedNumber < numberToGuess)
                    {
                        Console.WriteLine("Oh that number is less then the correct number");
                        Console.WriteLine("please try again your have used {0} out of 10 attempts", currentAttempt);
                        currentAttempt++;
                    }
                    else if (currentAttempt > 5 && guessedNumber > numberToGuess)
                    {
                        Console.WriteLine("Oh that number is greater than the correct number");

                        Console.WriteLine("please try again your have used {0} out of 10 attempts", currentAttempt);
                        currentAttempt++;
                    }
                    else
                    {
                        Console.WriteLine("please try again you have used {0} out of 10 attempts", currentAttempt);
                        currentAttempt++;
                    }
                }

                Console.WriteLine("Would you like to play again?, If yes please enter 'y' and if not please enter 'n'");
                string input = Console.ReadLine();

                switch(input)
                {
                    case "y":
                        playagain = 'y';
                        break;
                    case "n":
                        playagain = 'n';
                        break;
                                    
                }

            }
            return 0;
        }
        
    }
}

