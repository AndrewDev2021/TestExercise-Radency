﻿using System;
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

        var list = temp.Select(p => p).Where(p => p != "").ToList();

        var listOfTuples = new List<Tuple<string, int>>();

        foreach (var item in list)
        {
            var temp3 = 0;

            foreach (var item2 in item.ToCharArray())
            {
                var flag = int.TryParse(item2.ToString(), out int res);

                if (flag && res >= 0)
                    temp3 += res;
                else
                    return "invalid data";
            }

            listOfTuples.Add(new Tuple<string, int>(item,temp3));
        }

        var sortArray = listOfTuples.OrderBy(p => p.Item2).Select(p => p.Item1).ToArray();

        return string.Join(' ', sortArray);
    }
}
