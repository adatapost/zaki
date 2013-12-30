using System;
using System.Collections.Generic;
class MyColl : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        yield return 11;
        yield return 12;
        yield return 13;
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public static class MyExtension
{
    public static IEnumerable<int> Odd(this int[] nos)
    {
        foreach (var t in nos)
        {
            if (t % 2 != 0)
                yield return t;
        }
    }
    public static int MySum(this IEnumerable<int> nos)
    {
        int sum = 0;
        foreach (var t in nos)
            sum = sum + t;
        return sum;
    }
}
class Test
{
    static void Main()
    {
        int[] nos = { 1, 22, 3, 44, 55, 6, 7, 89, 62 };
        var oddNos = nos.Odd();
        foreach (var t in oddNos)
            Console.WriteLine(t);

        Console.WriteLine(nos.MySum());
        Console.WriteLine(oddNos.MySum());
    }
    static IEnumerable<int> GetSomeNos()
    {
        yield return 10;
        yield return 20;
        yield return 30;
    }
    static void Main3()
    {
        var nos = GetSomeNos();
        foreach (var n in nos)
            Console.WriteLine(n);

        MyColl coll = new MyColl();
        foreach (var t in coll)
            Console.WriteLine(t);

    }
    static void Main1()
    {
        string name = "Hello";
        foreach (char ch in name)
            Console.WriteLine(ch);

        int[] nos = { 11, 22, 33 };
        foreach (var n in nos)
            Console.WriteLine(n);

        IEnumerator<char> i = name.GetEnumerator();
        while (i.MoveNext())
        {
            Console.WriteLine(i.Current);
        }

        System.Collections.IEnumerator  j = nos.GetEnumerator();
        while (j.MoveNext())
        {
            Console.WriteLine(j.Current);
        }
    }
}