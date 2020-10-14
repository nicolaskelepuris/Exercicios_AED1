using System;
using Exercicios_AED1.ExercicioDia13_10_2020Classes;

namespace Exercicios_AED1
{
    class Program
    {        
        static void Main(string[] args)
        {
            //var exercicio1 = new Exercicio1();
            //exercicio1.GetTwoNumbersAndPrintSum();

            //var exercicio2 = new Exercicio2();
            //exercicio2.GetFourGradesAndPrintAverage();

            //var exercicio01Aula04 = new Exercicio01Aula04();
            //exercicio01Aula04.PerformExercicio01Aula04();

            //var exercicio02Aula04 = new Exercicio02Aula04();
            //exercicio02Aula04.PerformExercicio02Aula04();

            //var exercicio03Aula04 = new Exercicio03Aula04();
            //exercicio03Aula04.PerformExercicio03Aula04();

            // var macaco1 = new Exercicio8MacacoAulaDia08_09_2020("macaco1");
            // var macaco2 = new Exercicio8MacacoAulaDia08_09_2020("macaco2");
            // Console.WriteLine("Macaco 1:");
            // macaco1.VerConteudoDoEstomago();
            // macaco1.Comer("banana");
            // macaco1.VerConteudoDoEstomago();
            // macaco1.Comer("pimenta");
            // macaco1.DigerirConteudoDoEstomago();
            // macaco1.VerConteudoDoEstomago();
            // Console.WriteLine("\nMacaco 2:");
            // macaco2.DigerirConteudoDoEstomago();
            // macaco2.DigerirConteudoDoEstomago();
            // macaco2.Comer("piolho");
            // macaco2.VerConteudoDoEstomago();
            // macaco2.DigerirConteudoDoEstomago();
            // macaco2.VerConteudoDoEstomago();

            var aeronave = new Aeronave("Aeronave", 2000, 1500, 150, 4500, 250000, "Joao", "Vitoria");
            Console.WriteLine(aeronave.Voar(3000));
        }
    }
}
