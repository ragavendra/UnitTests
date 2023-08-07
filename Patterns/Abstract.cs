using System;
namespace UnitTests.Patterns;

public class Adaptee
{
    protected void PrintWord(string word)
    {
        Console.WriteLine("Word is " + word);
    }

    protected void PrintNo(double no)
    {
        Console.WriteLine("No is " + no);
    }
}

public class Adapter : Adaptee
{
    public void PrintWordA(string word)
    {
        PrintWord("hi " + word);
    }

    public void PrintNoA(double no)
    {
        PrintNo(no++);
    }
}

public partial class Program
{
    public static void Main__()
    {
        Adapter adapter = new Adapter();
        adapter.PrintWordA("adlskjasl");

        adapter.PrintNoA(1.69);
    }
}