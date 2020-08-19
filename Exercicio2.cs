using System;
namespace Exercicios_AED1
{
    public class Exercicio2
    {
        public Exercicio2()
        {
        }

        float[] GetFourGrades()
        {
            var grades = new float[4];
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Please inform grade number {0} to get the average", i+1);
                grades[i] = float.Parse(Console.ReadLine());
            }
            return grades;
        }

        float CalculeAverage(float[] grades)
        {
            float sum = 0f;
            foreach (var grade in grades)
            {
                sum += grade;
            }

            return sum / grades.Length;
        }

        void PrintGradesAverage(float average)
        {
            Console.WriteLine("Grades average is: {0}", average);
        }

        public void GetFourGradesAndPrintAverage()
        {
            var grades = GetFourGrades();
            var average = CalculeAverage(grades);
            PrintGradesAverage(average);
        }
    }
}