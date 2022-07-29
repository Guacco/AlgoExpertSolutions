namespace AlgoExpertSolutions;

public class CaesarCypherEncryptor
{
    public static string caesarCypherEncryptor(string str, int key)
    {
        var results = string.Empty;
        foreach (var lett in str)
        {
            var asciiVal = (int) lett;
            var newAsciiVal = asciiVal + key;

            if (newAsciiVal > 122)
            {
                newAsciiVal = (newAsciiVal - 122);
                var remainder = newAsciiVal % 26;
                results += (char) (remainder + 96);
            }
            else
            {
                results += (char) newAsciiVal;
            }
        }
        return results;
    }
}