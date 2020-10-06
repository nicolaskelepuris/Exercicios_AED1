using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDia05_10_2020Classes
{
    public class Vendedor
    {
        public string Nome { get; private set; }
        double salario;
        double comissao;

        public Vendedor(string nome, double salario, double comissao)
        {
            Nome = nome;
            this.salario = salario;
            this.comissao = comissao;
        }

        public double RecebeSalario(double vendasDoMes)
        {
            return salario + (comissao * vendasDoMes);
        }
    }
}