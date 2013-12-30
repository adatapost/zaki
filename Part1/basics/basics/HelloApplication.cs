using System;
class Address
{
    public string City { get; set; }
    public int Pin { get; set; }
    public string Street { get; set; }
}
class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }
    public Address LocalAddress { get; set; }
    public Address PostalAddress { get; set; }

    //Initialization
    public Student()
    {
        Roll = 1;
        Name = string.Empty; //or "";
         LocalAddress = new Address();
        PostalAddress = new Address();
    }
}
class MainApp
{
    static void Main()
    {
        Student s = new Student
        {
            Roll = 1,
            Name = "A",
            LocalAddress = new Address { City="Meh",Pin=222,Street="1st" },
            PostalAddress = new Address { City = "Pat", Pin = 111, Street = "3rd" }
        };
        

       

        Console.WriteLine(s.Roll + " " + s.Name);
        Console.WriteLine(s.LocalAddress.City + " " + s.LocalAddress.Pin + " " + s.LocalAddress.Street);
        Console.WriteLine(s.PostalAddress.City + " " + s.PostalAddress.Pin);
    }
    static void Main1()
    {
        Student s = new Student();
        s.Roll = 10;
        s.Name = "A";
        s.LocalAddress.City = "Meh";
        s.LocalAddress.Street = "1st Lane";
        s.LocalAddress.Pin = 384001;

        s.PostalAddress.City = "Pat";
        s.PostalAddress.Pin = 340001;

        Console.WriteLine(s.Roll + " " + s.Name);
        Console.WriteLine(s.LocalAddress.City + " " + s.LocalAddress.Pin + " " + s.LocalAddress.Street);
        Console.WriteLine(s.PostalAddress.City + " " + s.PostalAddress.Pin);
    }
}