using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAddition
{
    class Program
    {
        static void Main(string[] args)
        {
              int resultToDisplay = AdditionNumber(2, 2);
            Console.WriteLine(resultToDisplay);
            Console.ReadKey();
        }
        //Method to Add data and return it
        private static int AdditionNumber(int NumberOne, int NumberTwo) 
        {
            int calculationResult;
            calculationResult = NumberOne + NumberTwo;
            return calculationResult;
        }

    }
}
