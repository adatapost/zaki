using System;
using System.Collections.Generic;

class MainApp
{
    static void Main()
    {
        Dictionary<string, List<string>> cnt = new Dictionary<string, List<string>>();
        cnt.Add("IN", new List<string>() { "Guj" });
        cnt.Add("USA", new List<string>());

        cnt["IN"].Add("Raj");
        cnt["USA"].Add("OC");
        cnt["USA"].Add("NY");

        foreach (var c in cnt)
        {
            Console.WriteLine(c.Key);
            foreach (var s in c.Value)
            {
                Console.WriteLine("\t" + s);
            }
        }
    }
    static void Main1()
    {
        Dictionary<int, string> std = new Dictionary<int, string>();

        //Add an entry Key-Value (Pair)

        std.Add(10, "R");
        std.Add(1, "B");
        std.Add(30, "P");
        if (std.ContainsKey(10))
            Console.WriteLine("10 is exists");
        else
           std.Add(10, "T");

        //Set or get using key

        std[10] = "Rajesh";
        Console.WriteLine(std[10]);

        //Remove an entry - returns true if removed
        Console.WriteLine(std.Remove(10));

        //Iterate all entries
        foreach (KeyValuePair<int, string> e in std)
            Console.WriteLine(e.Key + " " + e.Value);
        foreach (var t in std)
            Console.WriteLine(t.Key + " " + t.Value);
    }
}