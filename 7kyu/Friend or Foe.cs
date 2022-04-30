//7kyu
using System;
using System.Collections.Generic;

public static class Kata
{
    public static IEnumerable<string> FriendOrFoe(string[] names)
    {
        List<string> friends = new List<string>();

        for (int i = 0; i < names.Length; i++)
        {
            string test = names[i];

            if (test.Length == 4)
            {
                friends.Add(test);
            }

            else { continue; }

        }
        return friends;
    }
}