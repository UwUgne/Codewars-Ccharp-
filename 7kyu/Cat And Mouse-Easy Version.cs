//7kyu

using System;

public class Kata
{
    public static string CatMouse(string x)
    {
        string answer;

        if (x.Length <= 5)
        {
            answer = "Caught!";
        }
        else
        {
            answer = "Escaped!";
        }

        return answer;
    }
}