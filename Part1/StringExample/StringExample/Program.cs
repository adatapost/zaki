using System;
using System.Text;
class Test
{
    static  void Main()
    {
        string str = "mehsana,patan,rajkot";
        string []cities = str.Split(',');
        foreach (var c in cities)
            Console.WriteLine(c);

        str = "meh,pat|,|rajkot*sur,,,";

        cities = str.Split(new string[] { ",","|","*" },
            StringSplitOptions.RemoveEmptyEntries);
        foreach (var c in cities)
            Console.WriteLine(c);
    }

    static void Main7()
    {
        int[] nos = { 11, 22, 33 };
        string str= string.Join(" and ", nos);
        Console.WriteLine(str);
    }
    static void Main6()
    {
        int no = 10;
        string name = "Mr. Abc";

        string str = string.Format("Hello, I'm {1} and I'm {0} years old",
                                          no, name);
        Console.WriteLine(str);

    }
    static void Main5()
    {
        var str = "The red sun and red rose.";
        str = str.Insert(4, "dark ");
        Console.WriteLine(str);

        str = str.Replace("red", "yellow");
        Console.WriteLine(str);

        str = str.Remove(4, 2);
        Console.WriteLine(str);

        StringBuilder sb = new StringBuilder();
        sb.Append("The red sun and red rose");
        int index = sb.ToString().IndexOf("red");
        sb.Replace("red", "yellow",index,3);
        Console.WriteLine(sb);

        Console.WriteLine(str.ToUpper());
        Console.WriteLine(str.ToLower());

    }
    static void Main4()
    {
        var str = "The red sun and red rose.";

        int index = str.IndexOf("red");
        Console.WriteLine(index);

        index = str.IndexOf("red",index+1);
        Console.WriteLine(index);

        index = str.LastIndexOf("red");
        Console.WriteLine(index);
        index = str.LastIndexOf("red",index-1);
        Console.WriteLine(index);
    }
    static void Main3()
    {
        var str = "The red sun and red rose.";
        if (str.Contains("sun"))
            Console.WriteLine("Exists");

        if (str.EndsWith("."))
            Console.WriteLine("Ends with .");

        if (str.StartsWith("The"))
            Console.WriteLine("Yes");



    }
    static void Main2()
    {
        string str = "     Hello World   ";

        Console.WriteLine(str);
        Console.WriteLine(str.Trim());

        
    }
    static void TestTheString()
    {
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        string str = "";
        watch.Start();
        for (int i = 1; i <= 100000; i++)
        {
            str = str + i;
        }
        watch.Stop();
        Console.WriteLine(watch.ElapsedMilliseconds);

    }
    static void TestTheStringBuilder()
    {
        System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        watch.Start();
        for (int i = 1; i <= 100000; i++)
        {
            sb.Append(i);
        }
        watch.Stop();
        Console.WriteLine(watch.ElapsedMilliseconds);

    }
    static void Main1()
    {
        //TestTheString();
        TestTheStringBuilder();
    }
}
