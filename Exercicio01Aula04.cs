using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_AED1
{
    //     Criar um programa que leia dois números inteiros, e que solicite ao usuário qual a operação
    // deseja realizar entre esses números.Caso o usuário digitar o caractere “*” será realizada uma multiplicação,
    // caso seja digitado o caractere “/” será realizada uma divisão, caso seja digitado o caractere “+” 
    // será realizado uma adição, e caso seja digitado o caractere “–” será realizada uma subtração.
    class Exercicio01Aula04
    {
        int[] numbers = new int[2];
        public Exercicio01Aula04()
        {
        }

        int[] GetNumbers()
        {
            Console.WriteLine("Please inform first number");
            numbers[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Please inform second number");
            numbers[1] = int.Parse(Console.ReadLine());
            return numbers;
        }

        char GetMathOperation()
        {
            Console.WriteLine("Please inform math operation (* for multiplication, / for division, + for sum, - for subtract)");
            return char.Parse(Console.ReadLine());
        }

        int DoMathOperation(int[] numbers, char mathOperation)
        {
            switch (mathOperation)
            {
                case '*':
                    return Multiply(numbers[0], numbers[1]);
                case '/':
                    return Divide(numbers[0], numbers[1]);
                case '+':
                    return Sum(numbers[0], numbers[1]);
                case '-':
                    return Subtract(numbers[0], numbers[1]);
                default:  
                    throw new Exception("Invalid math operation");           
            }
        }

        void PrintResult(int result)
        {
            Console.WriteLine("Result: {0}", result);
        }

        public void PerformExercicio01Aula04()
        {
            var numbersToCalculate = GetNumbers();
            var mathOperation = GetMathOperation();
            var result = DoMathOperation(numbers, mathOperation);
            PrintResult(result);
        }

        int Multiply(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        int Divide(int firstNumber, int secondNumber)
        {
            return firstNumber / secondNumber;
        }
        int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        int Subtract(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

    }
}
