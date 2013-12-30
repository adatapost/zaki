using System;

class Language {
    public void Speak()
    {
    }
    public void Write()
    {
    }
}
class English : Language { }
class Gujarati : Language { }
class Mahesani : Gujarati { }
class Kutchhi : Gujarati { }

class Test
{
    static void Main()
    {
        Kutchhi k = new Kutchhi();

        //Boxing or Selecting appropriate object from "k"

        object o = k;
        Language l = k;
        Gujarati g = k;

       
        Kutchhi c = (Kutchhi) g;



    }
    static void Main1()
    {
        Language l;

        l = new Kutchhi();// Objects[Object,Language,Gujarati,Kutchhi]
         

        //English p = (English)l;
        Gujarati e = l as Gujarati;
        if (e != null)
            Console.WriteLine("Cast");
        else
            Console.WriteLine("Invalid");

        English f = l as English;
        if (f != null)
            Console.WriteLine("Cast");
        else
            Console.WriteLine("Invalid");

    }
}