using System;

public class Dice
{
    private Random random = new Random();

    public int Roll() => random.Next(1, 7);

    public int[] RollMultiple(int count)
    {
        int[] results = new int[count];
        for (int i = 0; i < count; i++)
        {
            results[i] = Roll();
        }
        return results;
    }
}




