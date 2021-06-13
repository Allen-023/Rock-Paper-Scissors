using System;


namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueOrStop = "Enter a number between 1-3 or 'Stop': ";
            string[] rockPaperScissor = {"Rock", "Paper", "Scissor"};

           

            //Prompt User
            Console.WriteLine("Welcome to Rock Paper Scissor." + "\n" + "1 = Rock, 2 = Paper, 3 = Scissor.\n");
            Console.WriteLine(continueOrStop);

            //User input 
            var playerOne = Console.ReadLine();

            //Input validation 
            bool inputValidation = false;
            while (inputValidation != true)
            {
                if (playerOne != "1" && playerOne != "2" && playerOne != "3" & playerOne != "Stop")
                {
                    Console.WriteLine("\n*****Input must be a number between 1-3 or Stop. Try again.*****");
                    playerOne = Console.ReadLine();
                }
                else
                {
                    inputValidation = true;

                    // game
                    while (playerOne != "Stop" && inputValidation == true)
                    {

                        int playerOneInt = Convert.ToInt32(playerOne);
                        Random rand = new Random();
                        int playerTwo = rand.Next(1, 4);

                        // Display results of choices picked
                        Console.WriteLine("\n" + "You Picked: " + rockPaperScissor[playerOneInt - 1]);
                        Console.WriteLine("Computer Picked: " + rockPaperScissor[playerTwo - 1]);

                        // tie
                        if (playerOneInt == playerTwo)
                        {
                            Console.WriteLine("Its a tie!" + "\n\n" + continueOrStop);
                            inputValidation = false;
                            playerOne = Console.ReadLine();
                        }

                        // rock beats scissors 
                        else if (playerOneInt == 1 && playerTwo == 3)
                        {
                            Console.WriteLine("You Won!" + "\n\n" + continueOrStop);
                            inputValidation = false;
                            playerOne = Console.ReadLine();
                        }

                        // paper beats rock
                        else if (playerOneInt == 2 && playerTwo == 1)
                        {
                            Console.WriteLine("You Won!" + "\n\n" + continueOrStop);
                            inputValidation = false;
                            playerOne = Console.ReadLine();
                        }

                        // scissor beats paper
                        else if (playerOneInt == 3 && playerTwo == 2)
                        {
                            Console.WriteLine("You Won!" + "\n\n" + continueOrStop);
                            inputValidation = false;
                            playerOne = Console.ReadLine();
                        }

                        // otherwise lose
                        else
                        {
                            Console.WriteLine("Sorry, You lose." + "\n\n" + continueOrStop);
                            inputValidation = false;
                            playerOne = Console.ReadLine();
                        }
                    }
                }
            }

            Console.WriteLine("\nThanks for playing!");
        }
    }
}
