namespace C__Practice

{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain) 
            {
                startGame();
                Console.Write("Would you like to play again? 'Y' for yes. 'N 'for no: ");
                string option = Console.ReadLine();

                if (option == "N")
                {
                    playAgain = false;
                }  else
                {
                    Console.WriteLine("Invalid option");
                    Environment.Exit(1);
                }
            }

        }

        public static void startGame()
        {
            // Ask the user to enter rock, paper or scissors
            Console.Write("Enter a move. 'R' for Rock, 'P' for Paper, and 'S' for Scissors:  ");
            string playerMove = Console.ReadLine();

            if (playerMove == "R" || playerMove == "P" || playerMove == "S")
            {
                Console.WriteLine($"You chose: {playerMove}");
            }
            else
            {
                Console.WriteLine("Error: Invlaid input from player.");
                Environment.Exit(1);
            }

            // Computer generates a random choice
            Random rand = new Random();

            int randInt = rand.Next(3); // Random number from 0 to 2

            string computerMove = "";
            if (randInt == 0)
            {
                computerMove = "R";
            }
            else if (randInt == 1)
            {
                computerMove = "P";
            }
            else if (randInt == 2)
            {
                computerMove = "S";
            }
            else
            {
                Console.WriteLine("Error with computer's move");
                Environment.Exit(1);
            }

            Console.WriteLine($"Computer's move is: {computerMove}");

            // Compare player vs computer
            if (playerMove == "R")
            {
                switch (computerMove)
                {
                    case "R":
                        Console.WriteLine("Draw");
                        break;

                    case "P":
                        Console.WriteLine("Computer Wins");
                        break;

                    case "S":
                        Console.WriteLine("Player Wins");
                        break;
                }
            }
            else if (playerMove == "P")
            {
                switch (computerMove)
                {
                    case "R":
                        Console.WriteLine("Player Wins");
                        break;

                    case "P":
                        Console.WriteLine("Draw");
                        break;

                    case "S":
                        Console.WriteLine("Computer Wins");
                        break;
                }
            }
            else if (playerMove == "S")
            {
                switch (computerMove)
                {
                    case "R":
                        Console.WriteLine("Computer Wins");
                        break;

                    case "P":
                        Console.WriteLine("Player Wins");
                        break;

                    case "S":
                        Console.WriteLine("Draw");
                        break;
                }
            }
        }
    }
}
