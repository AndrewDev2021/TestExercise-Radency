namespace TestExercise;

internal class Recalculation
{
    public static string Order(string input)
    {
        var tempList = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

        var listOfTuples = new List<Tuple<string, int>>();

        foreach (var item in tempList)
        {
            var temp = 0;

            foreach (var item2 in item.ToCharArray())
            {
                var flag = int.TryParse(item2.ToString(), out int res);

                if (flag && res >= 0)
                    temp += res;
                else
                    return "invalid data";
            }

            listOfTuples.Add(new Tuple<string, int>(item, temp));
        }

        var sortListOfTuples = listOfTuples.OrderBy(p => p.Item2).ToList();

        var arrWeights = sortListOfTuples.Select(p => p.Item2).ToArray();
        var arrValues = sortListOfTuples.Select(p => p.Item1).ToArray();

        return string.Join(' ', SortWithSameWeights(arrWeights,arrValues));
    }

    private static bool CompareOfString(string str1, string str2)
    {
        int cmpVal = string.Compare(str1, str2, StringComparison.Ordinal);

        if (cmpVal == 0)
            return false;
        if (cmpVal < 0)
            return false;

        return true;
    }

    private static string[] SortWithSameWeights(int[] array,string[] array2)
    {
        var len = array.Length;
        for (var i = 1; i < len; i++)
        {
            for (var j = 0; j < len - i; j++)
            {
                if (array[j] == array[j + 1] && CompareOfString(array2[j], array2[j + 1]))
                {
                    Swap(ref array2[j], ref array2[j + 1]);
                }
            }
        }
        return array2;
    }
    private static void Swap(ref string e1, ref string e2)
    {
        (e1, e2) = (e2, e1);
    }
}
    