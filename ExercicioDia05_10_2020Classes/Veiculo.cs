using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_AED1.ExercicioDia05_10_2020Classes
{
    public class Veiculo
    {
        string marca;
        int anoFabricacao;
        double valor;
        int km;

        public void Relatorio()
        {
            Console.WriteLine("Marca: {0}, Ano: {1}, Valor: {2}, Quilometragem: {3}\n", marca, anoFabricacao, valor, km);
        }

        public void AtualizaValor(int ano)
        {
            valor -= ((ano - anoFabricacao) * 2.05);
        }
    }
}