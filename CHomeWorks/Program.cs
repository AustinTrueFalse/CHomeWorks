using BenchmarkDotNet.Exporters;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Concurrent;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using static Program;


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


    public class Account
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        
    }

    public class Calculator
    {
        public void CalculateMethod(ICalculateType calculateType)
        {
            calculateType.CalculateInterest();
        }

    }



    public class CalculateDefault : ICalculateType
    {
        public void CalculateInterest()
        {

            Console.WriteLine("Default");

            var account = new Account();

            if (account.Type == "Обычный")
            {
                // расчет процентной ставки обычного аккаунта по правилам банка
                account.Interest = account.Balance * 0.4;
                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;

                if (account.Balance < 50000)
                    account.Interest -= account.Balance * 0.4;
            }
        }
    }

    public class CalculateSalary : ICalculateType
    {
        public void CalculateInterest()
        {

            Console.WriteLine("Salary");

            var account = new Account();

            if (account.Type == "Зарплатный")
            {
                // расчет процентной ставки зарплатного аккаунта по правилам банка
                account.Interest = account.Balance * 0.5;
            }
        }
    }

    


}


