namespace ConsoleApp1;

public class RockPaperScissors
{
    public void PlayGame()
    {
        // Game logic goes here
        while (true)
        {
            // Implementation of Rock-Paper-Scissors game
            Console.WriteLine("Enter your choice (rock/paper/scissors):");
            string player1=Console.ReadLine().toLowerCase();
            Console.WriteLine("Enter your choice (rock/paper/scissors):");
            string player2=Console.ReadLine().toLowerCase();
            if(player1==player2)
            {
                Console.WriteLine("It's a tie!");
            }
            else if((player1=="rock" && player2=="scissors") || (player1=="scissors" && player2=="paper") || (player1=="paper" && player2=="rock"))
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if((player2=="rock" && player1=="scissors") || (player2=="scissors" && player1=="paper") || (player2=="paper" && player1=="rock"))
            {
                Console.WriteLine("Player 2 wins!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter rock, paper, or scissors.");
            }
        }

    }
}
