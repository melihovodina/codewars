using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine(Kata.Narcissistic(153)); //On codewars this line isn't needed
public class Kata
{
    public static bool Narcissistic(int value)
    {
        int a = value;
        int[] digits = new int[value.ToString().Length];
        int index = digits.Length - 1;
        while (value > 0)
        {
            digits[index] = value % 10;
            value /= 10;
            index--;
        }
        double sum = 0;
        for(int i = 0; i < digits.Length; i++)
        {
            int num = 1;
            int pow = digits.Length;
            while (pow > 0)
            {
                num *= digits[i];
                pow--;
            }
            sum += num;
        }
        if(sum == a)
            return true;
        else 
            return false;
    }
}
