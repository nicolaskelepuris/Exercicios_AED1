using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_AED1.ExercicioDia05_10_2020Classes
{
    public class Vendedor
    {
        double salario;
        double comissao;

        public double RecebeSalario(double vendasDoMes)
        {
            return salario + (comissao * vendasDoMes);
        }
    }
}