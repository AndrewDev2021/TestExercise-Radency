﻿using System;

namespace TestExercise;

internal class Program
{
    static void Main(string[] args)
    {
        var instance = new Recalculation();

        Console.WriteLine($"{instance.Order(" 2022 70 123 3344 13 ")}" +
                          $"\n{instance.Order("45 34 24 108 76 58 64 130 80")}");
    }
}