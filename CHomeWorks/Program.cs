using System;
using System.IO;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


class Program
{


    static void Main(string[] args)
    {


        NumberReader numberReader = new NumberReader();
        numberReader.NumberEnteredEvent += ShowNumber;


        while (true)
        {
            try
            {
                numberReader.Read();

            }
            catch (MyException)
            {
                Console.WriteLine("Введено некорректное значение");
            }


        }

        static void ShowNumber(int number)
        {

            List<string> Users = new List<string>() { "Ivanov", "Petrov", "Erohin", "Sychov" };

            switch (number)
            {
                case 1:
                    Users.Sort();
                    foreach (string User in Users)
                    {
                        Console.WriteLine(User);
                    }; break;
                case 2:
                    Users.Sort();
                    Users.Reverse();
                    foreach (string User in Users)
                    {
                        Console.WriteLine(User);
                    }; break;
            }
        }
    }

    class NumberReader
    {

        public delegate void NumberEnteredDelegate(int value);
        public event NumberEnteredDelegate NumberEnteredEvent;

        public void Read()
        {

            Console.WriteLine("Отсортируйте список, нажмите 1 - отсортировать по возрастанию, 2 - отсортировать по убыванию");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2) throw new MyException("Некорректный формат");

            NumberEntered(number);

        }

        public virtual void NumberEntered(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }

    class MyException : Exception
    {
        public MyException(string message)
            : base(message) { }
    }
}






