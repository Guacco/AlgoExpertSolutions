namespace AlgoExpertSolutions;

public class FirstNonRepeatingCharacter
{
    public static int firstNonRepeatingCharacter(string str)
    {
        if (str.Length == 0) return -1;
        if (str.Length == 1) return 0;
        var map = new Dictionary<char, int[]>();
        for (var i = 0; i < str.Length; i++)
        {
            if (map.ContainsKey(str[i]))
            {
                map[str[i]][0] += 1;
            }
            else
            {
                map.Add(str[i], new int[2]{1,i});
            }
        }

        foreach (KeyValuePair<char, int[]> entry in map)
        {
            if (entry.Value[0] == 1) return entry.Value[1];
        }

        return -1;
    }
}