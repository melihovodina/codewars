Console.WriteLine(Kata.Solution(10)); //On codewars this line isn't needed
public static class Kata
{
    public static int Solution(int value)
    {
        int a = 0, sum = 0;
        for (int i = 0; i < value; i++)
        {
            if (a % 3 == 0)
                sum += a;
            else if (a % 5 == 0)
                sum += a;
            a++;
        }
        return sum;
    }
}