using System;
public delegate void FirstDel();
public delegate void SecondDel(int n);

class Test
{
    public void Print()
    {
        Console.WriteLine("Print it");
    }
    public void Disp(int n)
    {
        Console.WriteLine(n);
    }
}

class MainApp
{
    public delegate int MyDel(int a, int b);
    static int Add(int m, int n)
    {
        return m + n;
    }
    static int Mul(int a, int b)
    {
        return a * b;
    }
    static void Main()
    {
        MyDel p = Add;
        Console.WriteLine(p(10, 20));
        p = Mul;
        Console.WriteLine(p(10, 20));

            
    }
    static void Main1()
    {
        Test a = new Test();
        
        //Create delegate var
        FirstDel printHello = a.Print;
        SecondDel displayNo = a.Disp;

        //Invoke method using delegate ref

        printHello();
        displayNo(9);


    }
}