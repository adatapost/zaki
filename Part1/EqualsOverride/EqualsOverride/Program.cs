using System;

class Person
{
    public int Age { get; set; }
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        Person other = obj as Person;
        return this.Age == other.Age && this.Name.Equals(other.Name);
    }
    public override string ToString()
    {
        return "[Name: " + Name + ",Age:" + Age + "]";
    } 
}
class Test
{
    static void Main()
    {
        Person p1 = new Person() { Age = 10, Name = "Aa" };
        Person p2 = new Person() { Age = 10, Name = "Aa" };

        if (p1.Equals(p2))
            Console.WriteLine("EQ");
        else
            Console.WriteLine("Not Eq");

        Console.WriteLine(p1);
        Console.WriteLine(p2);
    }
}
