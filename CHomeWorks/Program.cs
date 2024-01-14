using BenchmarkDotNet.Exporters;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Concurrent;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;


namespace CHomeWorks
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var calculator = new Calculator();

            //  посадка на землю
            calculator.CalculateMethod(new CalculateDefault());

            Console.WriteLine();

            //  посадка на воду
            calculator.CalculateMethod(new CalculateSalary());

        }


    }
}



