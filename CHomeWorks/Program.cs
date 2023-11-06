using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class MyException : Exception
{
    public MyException(string message) : base(message) { }
}

class Program
{
    static void Main(string[] args)
    {


        Exception[] ExceptionList = new Exception[5];

        ExceptionList[0] = new FormatException();
        ExceptionList[1] = new DivideByZeroException();
        ExceptionList[2] = new OverflowException();
        ExceptionList[3] = new DivideByZeroException();
        ExceptionList[4] = new MyException("Число больше 10");

        foreach (Exception i in ExceptionList)
        {
            try
            {
                int a = 10;
                int b = 0;

                Console.WriteLine(a / b);

                throw i;


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

    }

}






