using System;
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override int GetHashCode()
    {
       /* int prime = 8;
        int hash = 0;
        hash = hash + prime * Age.GetHashCode();
        hash = hash + prime * Name.GetHashCode();
        return hash; */

        return Age.GetHashCode() + Name.GetHashCode();
    }
    public override bool Equals(object obj)
    {
        return GetHashCode() == obj.GetHashCode();
    }
}
class Test
{
    static void Main()
    {
        Person p1 = new Person() { Age = 10, Name = "amar" };
        Person p2 = new Person() { Age = 10, Name = "amar" };

        Console.WriteLine(p1.GetHashCode() + " " + p2.GetHashCode());
        if (p1.GetHashCode() > p2.GetHashCode())
            Console.WriteLine("P1 > P2");
        else
            if (p1.GetHashCode() < p2.GetHashCode())
                Console.WriteLine("P1 < P2");
            else
                Console.WriteLine("EQ");

        if (p1.Equals(p2))
            Console.WriteLine("Equal");
        else
            Console.WriteLine("Not Equal");

        

    }
    static void Main1()
    {
        double m1 = 10.12, m2 = 10.12;
        Console.WriteLine(m1.GetHashCode() + " " + m2.GetHashCode());
        string s1 = "Admin", s2 = "Admin";
        Console.WriteLine(s1.GetHashCode() + " " + s2.GetHashCode());
    }
}