using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class CalculationEngine
    {
        public int DoMath(string stuffToCalculate)
        {
            try
            {
                var splitNumbers = stuffToCalculate.Split('+')
                .Select(int.Parse).ToArray();

                return splitNumbers[0] + splitNumbers[1];
            }
            catch(FormatException /* ex this would be a var of FormatException*/)
            {
                throw new InvalidInputException();
            }

           
        }
    }
}
