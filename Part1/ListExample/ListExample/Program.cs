using System;
using System.Collections.Generic;

public class Emps : List<Emp>
{
    public void SortByID()
    {
        Sort((x, y) => x.ID - y.ID);
    }
    public void SortByName()
    {
        Sort((x, y) => x.Name.CompareTo(y.Name));
    }
}


class Test
{
    static void Main()
    {
        Emps emps = new Emps()
        {
            new Emp(){ID=30,Name="W", IsAdhoc=false},
            new Emp(){ID=10,Name="Z", IsAdhoc=false},
            new Emp(){ID=40,Name="A", IsAdhoc=false},
        };

        emps.SortByID();
        foreach (var e in emps)
            Console.WriteLine(e.ID + " " + e.Name + " " + e.IsAdhoc);

        emps.SortByName();
        foreach (var e in emps)
            Console.WriteLine(e.ID + " " + e.Name + " " + e.IsAdhoc);


    }
    static void Main5()
    {
        List<Emp> emps = new List<Emp>()
        {
            new Emp(){ID=30,Name="W", IsAdhoc=false},
            new Emp(){ID=10,Name="Z", IsAdhoc=false},
            new Emp(){ID=40,Name="A", IsAdhoc=false},
        };

        Comparison<Emp> sortById = (e1, e2) =>
        {
            if (e1.ID > e2.ID)
                return 1;
            else
                if (e1.ID < e2.ID)
                    return -1;
                else
                    return 0;
        };



        emps.Sort(sortById);
        foreach (var e in emps)
            Console.WriteLine(e.ID + " " + e.Name + " " + e.IsAdhoc);

        emps.Sort((e1, e2) =>
        {
            return e1.Name.CompareTo(e2.Name);
        });

        foreach (var e in emps)
            Console.WriteLine(e.ID + " " + e.Name + " " + e.IsAdhoc);


    }
    static void Main2()
    {
        List<string> cities = new List<string>()
        {
            "Meh","Pat","Raj","Sur"
        };
        foreach (var city in cities)
            Console.WriteLine(city);
    }
    static void Main1()
    {
        List<int> nos = new List<int>() { 44, 55, 66, 77, 88 };
        //append nos
        nos.Add(10);
        nos.Add(20);
        nos.Add(1);

        //insert elements
        nos.Insert(0, 4);
        nos.Insert(2, 90);

        //Exists
        Console.WriteLine(nos.Contains(10));

        //Get single element
        Console.WriteLine(nos[0]); //1st
        //Set an element
        nos[0] = 900;

        foreach (var n in nos)
            Console.WriteLine(n);

        nos.RemoveAt(1); //Remove 2nd item
        nos.Remove(90);

        Console.WriteLine("---------");
        foreach (var n in nos)
            Console.WriteLine(n);
    }
}