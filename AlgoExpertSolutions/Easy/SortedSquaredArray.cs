namespace AlgoExpertSolutions;

public class SortedSquaredArray
{
    public static int[] sortedSquaredArray(int[] array)
    {
        var list = new int[array.Length];

        if (array.Length == 1)
        {
            list[0] = array[0] *= array[0];
            return list;
        }
        
        var lIndex = 0;
        var rIndex = array.Length - 1;
        var insertIndex = rIndex;

        while (insertIndex >= 0)
        {
            var lSqrd = array[lIndex] * array[lIndex];
            var rSqrd = array[rIndex] * array[rIndex];
            if (lSqrd > rSqrd)
            {
                list[insertIndex] = lSqrd;
                lIndex++;
            }
            else if (lSqrd < rSqrd)
            {
                list[insertIndex] = rSqrd;
                rIndex--;
            }
            else if(lSqrd == rSqrd && lIndex != rIndex)
            {
                list[insertIndex] = lSqrd;
                insertIndex--;
                list[insertIndex] = rSqrd;
                lIndex++;
                rIndex--;
            }
            else
            {
                list[insertIndex] = lSqrd;
            }

            insertIndex--;
        }

        return list;
    }
}