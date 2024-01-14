using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHomeWorks
{
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
