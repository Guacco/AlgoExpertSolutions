namespace AlgoExpertSolutions;

public class ValidateSubsequence
{
    public static bool validateSubsequence(List<int> array, List<int> sequence)
    {
        if (array.Count == 0 || sequence.Count == 0) return false;
        var prevIndex = 0;
        var map = new Dictionary<int, List<int>>();

        for (var i = 0; i < array.Count; i++)
        {
            if (!map.ContainsKey(array[i])) map.Add(array[i], new List<int> {i});
            map[array[i]].Add(i);
        }

        if(!map.ContainsKey(sequence[0])) return false;
        for (var i = 1; i < sequence.Count; i++)
        {
            if (!map.ContainsKey(sequence[i])) return false;

            if (map[sequence[i]].Count == 1 && prevIndex < map[sequence[i]][0])
            {
                prevIndex = map[sequence[i]][0];
            }
            else
            {
                var hasValidKey = false;

                for (var j = 0; j < map[sequence[i]].Count; j++)
                {
                    if (map[sequence[i]][j] != -1 && map[sequence[i]][j] > prevIndex)
                    {
                        prevIndex = map[sequence[i]][j];
                        map[sequence[i]][j] = -1;
                        hasValidKey = true;
                        break;
                    }
                }

                if (!hasValidKey) return false;
            }
        }

        return true;
    }
}