namespace AlgoExpertSolutions;

public class NonConstructibleChange
{
    public static int nonConstructibleChange(int[] coins)
    {
        if (coins.Length == 1) return coins[0] + 1;
        
        Array.Sort(coins);
        var sum = 0;
        foreach (var coin in coins)
        {
            if (coin > sum + 1)
            {
                return sum + 1;
            }

            if (coin <= sum + 1)
            {
                sum += coin;
            }
        }

        return sum + 1;
    }
}