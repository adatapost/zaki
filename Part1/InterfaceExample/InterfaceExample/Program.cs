using System;

public interface Test
{
    void Examine();
    void Write();
}

public class EnglishTest : Test
{

    public void Examine()
    {
        Console.WriteLine("Examine The English Test");
    }

    public void Write()
    {
        Console.WriteLine("Write English Test");
    }
}
public class MathsTest : Test
{

    public void Examine()
    {
        Console.WriteLine("Examine The Maths Test");
    }

    public void Write()
    {
        Console.WriteLine("Write Maths Test");
    }
}
abstract public class HindiTest : Test
{
    public void Examine() { }
    public abstract void Write();
}
class MainApp
{
    static void Main()
    {
        Test a;

        EnglishTest e = new EnglishTest();
        MathsTest m = new MathsTest();

        a = m;
        a.Write();
        a.Examine();

        a = e;
        a.Write();
        a.Examine();
        
    }
}