using System;

class Data<A>
{
    public A Value { get; set; }
    public void Something(A n) { }
}
class Pair<K, V>
{
    public K Key { get; set; }
    public V Value { get; set; }
}

public class Stack<T>
{
    public T[] Items { get; set; }
    private int index = -1;

    public void Push(T item)
    {
        
        Items[++index] = item;
    }
    public T Pop()
    {
        return Items[index--];
    }
}

class MainApp
{
    static void Main()
    {
        System.Collections.Generic.Stack<int> k = new System.Collections.Generic.Stack<int>();
        k.Push(100);
        k.Push(200);
        Console.WriteLine(k.Pop());
        Console.WriteLine(k.Pop());
    }
    static void Main4()
    {
        Stack<int> a = new Stack<int>();
        a.Items = new int[4];

        a.Push(10);
        a.Push(20);
        a.Pop();
        a.Push(30);

        Console.WriteLine(a.Pop());
        Console.WriteLine(a.Pop());
    }
    static void Main2()
    {
        Pair<int, string> r = new Pair<int, string>();
        r.Key = 10;
        r.Value = "Raj";


    }
    static void Main1()
    {
        Data<int> a = new Data<int>();
        Data<string> b = new Data<string>();
        b.Value = "Hello";
        a.Value = 10;
        Console.WriteLine(a.Value + " " + b.Value);
    }
}