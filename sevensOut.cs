public class SevensOut
{
    private Dice dice = new Dice();

    public void PlayGame(Player player1, Player player2)
    {
        try
        {
            bool playerOneTurn = true;
            while (true)
            {
                Player currentPlayer = playerOneTurn ? player1 : player2;
                Console.WriteLine($"{currentPlayer.Name}'s turn!");
                int die1 = dice.Roll();
                int die2 = dice.Roll();
                int rollTotal = die1 + die2;
                Console.WriteLine($"Rolled: {die1} and {die2} = {rollTotal}");
                if (rollTotal == 7) break;

                int pointsToAdd = rollTotal;
                if (die1 == die2) pointsToAdd *= 2;
                currentPlayer.Score += pointsToAdd;
                Console.WriteLine($"Current score: {currentPlayer.Score}");

                playerOneTurn = !playerOneTurn; // Switch turns
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Game over.");
            Console.WriteLine($"{player1.Name}'s final score: {player1.Score}");
            Console.WriteLine($"{player2.Name}'s final score: {player2.Score}");
        }
    }
}
