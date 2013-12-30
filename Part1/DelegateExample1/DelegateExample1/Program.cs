using System;

public delegate void MyDel(int n,int m);

class Test
{
    public static void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public static void Mul(int a, int b)
    {
        Console.WriteLine(a * b);
    }
}

class TestMain
{
    static void Main()
    {
        MyDel p;
        p = Test.Add;
        p += Test.Mul;
        p+= Test.Add;

        p(10,10);
        p -= Test.Add;
   
        p -= Test.Mul;
        p(3, 4);
    }

}
