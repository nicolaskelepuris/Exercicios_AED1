using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioDia05_10_2020Classes
{
    public class Veiculo
    {
        string marca;
        int anoFabricacao;
        public double Valor { get; private set; }
        int km;

        public Veiculo(string marca, int anoFabricacao, double valor, int km)
        {
            this.marca = marca;
            this.anoFabricacao = anoFabricacao;
            Valor = valor;
            this.km = km;
        }

        public void Relatorio()
        {
            Console.WriteLine("Marca: {0}, Ano: {1}, Valor: {2}, Quilometragem: {3}\n", marca, anoFabricacao, Valor, km);
        }

        public void AtualizaValor(int ano)
        {
            Valor -= ((ano - anoFabricacao) * 2.05);
        }
    }
}