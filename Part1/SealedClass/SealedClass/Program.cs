using System;
/*
public sealed class Person
{
}
public class Employee : Person { } */

/*
public static class MyApp
{
    public static int Age { get; set; }
    public void Print() { } // Invalid
}
 * */

public class Emp
{
    public int Age { get; set; }
}
partial class Emp
{
    public string Name { get; set; }
}
class MainApp
{
    static void Main()
    {
        Emp a = new Emp();
        a.
       
    }
}

