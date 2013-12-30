using System;

class Person
{
    public virtual void Who()
    {
        Console.WriteLine("I'm person");
    }
}
class Teacher : Person
{
    public override void Who()
    {
        Console.WriteLine("I'm Teacher");
    }
}

class MainApp
{
    static void Main()
    {
        Teacher t = new Teacher();
        t.Who();
        Person p = t;
        p.Who();

    }
}