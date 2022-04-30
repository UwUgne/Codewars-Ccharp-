/*Gordon Ramsay shouts. He shouts and swears. There may be something wrong with him.

Anyway, you will be given a string of four words. Your job is to turn them in to Gordon language.

Rules:

Obviously the words should be Caps, Every word should end with '!!!!', Any letter 'a' or 'A' should become '@', Any other vowel should become '*'.*/

using System.Text.RegularExpressions;
public class Kata
{
    public static string Gordon(string a)
    {
        string h = a.ToUpper();

        var r = new Regex("[EIOU]");
        string b = r.Replace(h, "*");
        string c = b.Replace("A", "@");
        string d = c.Replace(" ", "!!!! ");



        return d + @"!!!!";
    }
}