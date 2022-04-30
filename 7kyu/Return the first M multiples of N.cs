/* 7 kuy
Implement a function, multiples(m, n), which returns an array of the first m multiples of the real number n. Assume that m is a positive integer.

Ex.

multiples(3, 5.0)
should return

[5.0, 10.0, 15.0] */

using System;
using System.Collections.Generic;
public class Kata
{
    public static double[] Multiples(int m, double n)
    {
        List<double> list = new List<double>();

        for (int i = 1; i <= m; i++)
        {

            list.Add(n * i);

        }
        double[] arr = list.ToArray();
        return arr;
    }
}