using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDia05_10_2020Classes
{
    public class Mostruario
    {
        public Vendedor Representante { get; private set; }
        List<Veiculo> veiculos;

        public Mostruario(Vendedor representante, List<Veiculo> veiculos)
        {
            Representante = representante;
            this.veiculos = new List<Veiculo>(veiculos);
        }

        public double CalculaSomaDosValoresDosVeiculos()
        {
            double somaDosValoresDosVeiculos = default;

            foreach (var veiculo in veiculos)
            {
                somaDosValoresDosVeiculos += veiculo.Valor;
            }

            return somaDosValoresDosVeiculos;
        }
    }
}