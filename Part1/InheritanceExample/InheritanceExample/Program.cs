using System;
class A
{
    public int No { get; set; }
}
class B : A
{
    public int No { get; set; }
}

class Test
{
    static void Main()
    {
        object o = new B();
        A a = o as A;
        o = "Hello";
        A a1 = o as A;
        
    }
    static void Main12()
    {
        object o = new B();
        A a = (A)o;
        o = "Hello";
        A a1 = (A)o;
    }
    static void Main1()
    {
       /* B b = new B();
        A a = b;
        b.No = 10;
        a.No = 20;

        Console.WriteLine(a.No + " " + b.No);*/

        B b = new B();

        b.No = 10;
        ((A)b).No = 20;

        Console.WriteLine(((A)b).No + " " + b.No);

    }
}