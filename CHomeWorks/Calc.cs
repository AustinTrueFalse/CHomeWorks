using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHomeWorks
{
    public class Calc : ICalc
    {
        ILogger Logger { get; }

        public Calc(ILogger logger)
        {
            Logger = logger;
        }

        public void Sum()
        {

            while (true)
            {

                try
                {

                    Logger.Event("Calculator начал работу");

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Введите первое число");

                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");

                    int b = int.Parse(Console.ReadLine());

                    int c = a + b;

                    Console.WriteLine("Результат {0}", c);
                }
                catch (Exception)
                {
                    Logger.Error("Необходимо ввести числовое значение!!! Перезапустите калькулятор, нажав Enter");
                }

                Logger.Event("Calculator окончил работу, чтобы перезапустить калькулятор, нажмите Enter");

                Console.ReadKey();


            }

        }
    }
}
