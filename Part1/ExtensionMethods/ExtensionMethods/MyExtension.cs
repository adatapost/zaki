using System;
public static class MyExtension
{
    public static void Hello(this string str)
    {
        Console.WriteLine("Hello " + str);
    }

    public static int Square(this int no)
    {
        return no * no;
    }
    public static bool IsPrime(this int no)
    {
        for (int i = 2; i <= no / 2; i++)
        {
            if (no % i == 0)
                return false;
        }
        return true;
    }
}