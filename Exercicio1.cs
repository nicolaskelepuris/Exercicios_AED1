using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_AED1
{
    //get 2 numbers and print the sum of them
    class Exercicio1
    {
        public Exercicio1()
        {
        }

        float[] GetNumbers()
        {
            var numbersToSum = new float[2];
            Console.WriteLine("Please inform first number to get the sum");
            numbersToSum[0] = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Please inform second number to get the sum");
            numbersToSum[1] = float.Parse(Console.ReadLine());
            
            return numbersToSum;
        }

        float CalculeSum(float[] numbersToSum)
        {
            var sum = numbersToSum[0] + numbersToSum[1];
            return sum;
        }

        void PrintSumOfNumbers(float sum)
        {
            Console.WriteLine("The sum of these two numbers is: {0}", sum);
        }

        public void GetTwoNumbersAndPrintSum()
        {
            var numbersToSum = GetNumbers();
            var sum = CalculeSum(numbersToSum);            
            PrintSumOfNumbers(sum);
        }

    }
}
