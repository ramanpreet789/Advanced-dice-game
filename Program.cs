class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a game:\n1. Sevens Out\n2. Three or More");
        int choice = ReadIntegerInput("Please enter a valid choice (1 or 2): ", 1, 2);

        Console.WriteLine("Enter your name:");
        string playerName = Console.ReadLine();
        Player player1 = new Player(playerName);

        Player player2;
        Console.WriteLine("Play against:\n1. Another player\n2. Computer");
        int opponentType = ReadIntegerInput("Please enter a valid choice (1 or 2): ", 1, 2);
        if (opponentType == 1)
        {
            Console.WriteLine("Enter second player's name:");
            string opponentName = Console.ReadLine();
            player2 = new Player(opponentName);
        }
        else
        {
            player2 = new Player("Computer");
        }

        if (choice == 1)
        {
            SevensOut game = new SevensOut();
            game.PlayGame(player1, player2);
        }
        else
        {
            ThreeOrMore game = new ThreeOrMore();
            game.PlayGame(player1, player2);
        }
    }

    static int ReadIntegerInput(string prompt, int min, int max)
    {
        int input;
        do
        {
            Console.WriteLine(prompt);
            string line = Console.ReadLine();
            if (!int.TryParse(line, out input) || input < min || input > max)
            {
                Console.WriteLine($"Invalid input. Please enter a number between {min} and {max}.");
                continue;
            }
            break;
        } while (true);
        return input;
    }
}
