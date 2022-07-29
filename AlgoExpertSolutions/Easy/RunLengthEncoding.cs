namespace AlgoExpertSolutions;

public class RunLengthEncoding
{
    public static string runLengthEncoding(string str)
    {
        var count = 0;
        var prev = str[0];
        var encoded = string.Empty;
        for (var i = 0; i < str.Length; i++)
        {
            if (str[i] != prev || count == 9)
            {
                encoded += $"{count}{prev}";
                count = 0;
                prev = str[i];
            }

            count++;

            if (i == str.Length - 1)
            {
                encoded += $"{count}{str[i]}";
            }
        }
        return encoded;
    }
}