using System;

public interface Printer
{
    void Print();
}
public interface Screen
{
    void Preview();
}

class Document : Printer, Screen
{
    void Printer.Print()
    {
        Console.WriteLine("Printing...");
    }
    void Screen.Preview()
    {
        Console.WriteLine("Preview");
    }
    
}
class MainApp
{
    static void Main()
    {
        Document d = new Document();
       
        Screen s = d;
        Printer p = d;

        s.Preview();
        p.Print();
    }
}