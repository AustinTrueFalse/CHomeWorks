using CHomeWorks;
using System;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


class Program
{

    static ILogger Logger { get; set; }

    static void Main(string[] args)
    {
        Logger = new Logger();

        var calc = new Calc(Logger);

        calc.Sum();

        Console.ReadKey();
    }

}

public interface ILogger
{
    void Event(string message);
    void Error(string message);
}

public class Logger : ILogger
{
    public void Error(string message)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(message);
    }
    public void Event(string message)
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine(message);
    }


}


public interface ICalc
{
    void Sum();
}






