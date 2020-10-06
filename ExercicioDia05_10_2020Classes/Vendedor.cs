using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDia05_10_2020Classes
{
    public class Vendedor
    {
        double salario;
        double comissao;

        public Vendedor(double salario, double comissao)
        {
            this.salario = salario;
            this.comissao = comissao;
        }

        public double RecebeSalario(double vendasDoMes)
        {
            return salario + (comissao * vendasDoMes);
        }
    }
}