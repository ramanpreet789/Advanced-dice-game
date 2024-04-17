public class ThreeOrMore
{
    private Dice dice = new Dice();

    public void PlayGame(Player player1, Player player2)
    {
        while (player1.Score < 20 && player2.Score < 20)
        {
            Player currentPlayer = player1.Score <= player2.Score ? player1 : player2; // Alternate starting based on the score
            Console.WriteLine($"{currentPlayer.Name}'s turn!");
            int[] rolls = dice.RollMultiple(5);
            Console.WriteLine($"Rolled: {string.Join(", ", rolls)}");
            int[] counts = new int[7];
            foreach (var roll in rolls) counts[roll]++;

            for (int i = 1; i < counts.Length; i++)
            {
                if (counts[i] >= 3)
                {
                    int points = counts[i] == 3 ? 3 : counts[i] == 4 ? 6 : 12;
                    currentPlayer.Score += points;
                    Console.WriteLine($"Scored {points} points for {counts[i]} of a kind!");
                    break;
                }
            }

            Console.WriteLine($"Current score: {currentPlayer.Score}");
        }

        Console.WriteLine("Game over.");
        Console.WriteLine($"{player1.Name}'s final score: {player1.Score}");
        Console.WriteLine($"{player2.Name}'s final score: {player2.Score}");
    }
}

