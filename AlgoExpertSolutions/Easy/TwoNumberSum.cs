using System.Collections;

namespace AlgoExpertSolutions;

public class TwoNumberSum
{
    public static int[] Sum(int[] array, int targetSum) {
        var map = new Dictionary<int, int>(); 
        var result = new int[2];
        
        foreach(var num in array)
        {
            if (map.ContainsKey(num))
            {
                map[num] += 1;
            }
            else
            {
                map.Add(num, 1);
            }

            if ((targetSum - num) != num && map.ContainsKey(targetSum - num))
            {
                result[0] = targetSum - num;
                result[1] = num;
                return result;
            }
        }

        return Array.Empty<int>();
    }
}