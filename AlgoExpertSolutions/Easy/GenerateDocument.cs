namespace AlgoExpertSolutions;

public class GenerateDocument
{
    public static bool generateDocument(string characters, string document)
    {
        if (characters.Length == 0) return true;

        var map = new Dictionary<char, int>();
        foreach (var lett in characters)
        {
            if (map.ContainsKey(lett))
            {
                map[lett] += 1;
            }
            else
            {
                map.Add(lett, 1);
            }
        }

        foreach (var lett in document)
        {
            if (map.ContainsKey(lett) && map[lett] > 0)
            {
                map[lett] -= 1;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}