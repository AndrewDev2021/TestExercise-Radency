using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestExercise;

class Recalculation
{
    public string Order(string input)
    {
        var temp = input.Split(' ');

        var listOfValue = new List<string>();

        foreach (var item in temp)
        {
            if (item != "")
            {
                listOfValue.Add(item);
            }   
        }

        var listOfTurple = new List<Tuple<string, int>>();

        foreach (var item in listOfValue)
        {
            var temp2 = item.ToCharArray();

            int temp3 = 0;

            foreach (var item2 in temp2)
            {
                var flag = int.TryParse(item2.ToString(), out int res);

                if (flag && res >= 0)
                    temp3 += res;
                else
                    return "invalid data";
            }

            listOfTurple.Add(new Tuple<string, int>(item,temp3));
        }

        var sortArray = listOfTurple.OrderBy(p => p.Item2).Select(p => p.Item1).ToArray();

        var output = string.Join(' ', sortArray);

        return output;
    }
}
