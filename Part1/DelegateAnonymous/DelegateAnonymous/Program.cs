using System;

public delegate void MyDel(int a,int b);

class MainApp
{
    static void Main()
    {
        MyDel add = (x, y) => Console.WriteLine(x + y);
        MyDel series = (start, end) =>
        {
            for (int i = start; i <= end; i++)
                Console.WriteLine(i);
        };

        add(10, 20);
        series(10, 20);
    }
    static void Main1()
    {
        MyDel add = delegate(int m, int n)
        {
            Console.WriteLine(m + n);
        };
        MyDel series = delegate(int start, int end)
        {
            for (int i = start; i <= end; i++)
                Console.WriteLine(i);
        };

        add(10, 20);
        series(3, 9);
    }
}