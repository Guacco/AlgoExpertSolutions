namespace AlgoExpertSolutions;

public class IsPalindrome
{
    public static bool isPalindrome(string str)
    {
        if (str.Length == 0) return false;
        if (str.Length == 1) return true;

        var result = "";

        for (var i = str.Length - 1; i >= 0; i--)
        {
            result += str[i];
        }

        if (str.ToLower() != result.ToLower()) return false;

        return true;
    }
}