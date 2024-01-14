using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHomeWorks
{
    public class Calculator
    {
        public void CalculateMethod(ICalculateType calculateType)
        {
            calculateType.CalculateInterest();
        }
    }
}
