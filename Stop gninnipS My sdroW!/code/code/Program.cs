using System.Collections.Generic;
using System.Linq;
using System;
Console.WriteLine(Kata.SpinWords("Hey fellow warriors"));
public class Kata
{
    public static string SpinWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        char[] a;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 5)
            {
                a = words[i].ToCharArray();
                Array.Reverse(a);
                words[i] = "";
                for(int j = 0; j < a.Length; j++)
                {
                    words[i] += a[j];
                }
            }   

        }
        string result = string.Join(" ", words);
        return result;
    }
}