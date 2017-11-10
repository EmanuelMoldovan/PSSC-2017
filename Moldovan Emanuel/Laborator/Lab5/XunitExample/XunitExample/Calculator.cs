using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XunitExample
{
    public class Calculator
    {
        public float ComputeAritmeticSum(List<int> numbers, IExternalItem externalItem)
        {
            var externalStuff = externalItem.GetSomeExternalStuff();

            int sum = 0;
            foreach (int i in numbers)
            {
                sum += i;
            }
            sum += externalStuff;

            return sum / numbers.Count();
        }

        public int MultiplyIntegers(int a, int b)
        {
            return a * b;
        }

        public int SumIntegers(int a, int b)
        {
            return a + b;
        }

        public int ComputeSpecialSum(NumbersContainer nrContainer)
        {
            var sum = 0;
            foreach (int x in nrContainer.Numbers)
            {
                sum += x;
            }

            return sum;
        }
    }
}
