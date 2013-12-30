using System;
using System.Text.RegularExpressions;

class Test
{
    static void Main()
    {
        string input = "This 190 and 39 are number";
        string pattern = @"\d+";
        Match match = Regex.Match(input, pattern);
        if (match.Success)
        {
            Console.WriteLine(match.Value);
            Console.WriteLine(match.NextMatch());
            Console.WriteLine(match.Value);
        }
        else
        {
            Console.WriteLine("No result");
        }

    }
    static void Main6()
    {
        string input = "This   is    the     word        splitter";
        string pattern = @"\s+";
        string []ar= Regex.Split(input, pattern);
        foreach (var t in ar)
            Console.WriteLine(t);

        Console.WriteLine("Total words : " + ar.Length);
    
    }
    static void Main5()
    {
        string input = "Th1e re22222d s2222u33n and 43red r44ose";
        string pattern = @"(\d+|\s+)";
        Console.WriteLine(Regex.Replace(input, pattern, ""));
    }
    static void Main4()
    {
        string pattern = @"(red|blue|black)";
        string input = "I like blue color";
        Console.WriteLine(Regex.IsMatch(input, pattern));
    }
    static void Main3()
    {
         string str = "dasfdasfdsfdsfdsfdsf dsafDSDSF SDDS dsafdasfdasfdsafdsfdsaj";
        string pattern = "^[a-zA-Z ]{3,40}$";
        Console.WriteLine(Regex.IsMatch(str, pattern));
    }
    static void Main2()
    {
        string str = "932923";
        Console.WriteLine(Regex.IsMatch(str, @"^\d{6}$"));

         
    }
    static void Main1()
    {
        Regex pattern = new Regex(@"^\d\d\d$");

        string str = "9329";

        Console.WriteLine(pattern.IsMatch(str));
    }
}