using System;

class Student
{
    public int Roll { get; set; }
    public string Name { get; set; }
}

class Test
{
    static void Main()
    {
        
    }
    static void Main8()
    {
        Student[] students = new Student[3]; // It create three reference variable of Student
       
        //Now creating three objects of student class
        students[0] = new Student() { Roll = 1, Name = "B" };
        students[1] = new Student() { Roll = 32, Name = "E" };
        students[2] = new Student() { Roll = 6, Name = "R" };

        foreach (var s in students)
        {
            Console.WriteLine(s.Roll + " " + s.Name );
        }

    }
    static void Mai6n()
    {
        int[][] a;
        a = new int[3][];  //Create reference for three arrays

        a[0] = new int[5]; //first array stored at 0 index
        a[1] = new int[] { 11, 22, 33};
        a[2] = new int[10];

        foreach (int[] t in a)
        {
            foreach (var i in t)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
        }

    }
    static void Main5()
    {
        int[,] a = new int[3, 4];
        a[0, 0] = 1;
        a[1, 2] = 3;
        a[2, 3] = 6;
        for (int i = 0; i <= a.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= a.GetUpperBound(1); j++)
            {
                Console.Write(" " + a[i,j]);
            }
            Console.WriteLine();
        }
        
    }
    static void Main3()
    {
        int[] a = new int[20];
        int[,] b = new int[4, 5];
        int[, ,] c = new int[2, 3, 4];

        Console.WriteLine(a.Rank);
        Console.WriteLine(b.Rank);
        Console.WriteLine(c.Rank);

        Console.WriteLine(a.GetUpperBound(0));
        Console.WriteLine(b.GetUpperBound(0) + " " + b.GetUpperBound(1));

        Console.WriteLine(a.Length);
        Console.WriteLine(b.Length);
        Console.WriteLine(c.Length);
    }
    static void Main2()
    {
        string[] cities = new string[3];
        cities[0] = "Mehsana";
        cities[1] = "Ahm";
        cities[2] = "Patan";

        foreach (var city in cities)
            Console.WriteLine(city);

        Array.Sort(cities);

        foreach (var city in cities)
            Console.WriteLine(city);

    }
    static void Main1()
    {
        int[] no = { 11, 22, 33, 44 ,442};

        for (int i = 0; i < no.Length; i++)
        {
            Console.WriteLine(no[i]);
        }

        foreach (int i in no)
        {
            Console.WriteLine(i);
        }
        
    }
}
