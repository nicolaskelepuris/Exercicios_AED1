using System;
using System.Collections.Generic;

namespace Exercicios_AED1.ExercicioDia03_11_2020Classes
{
    public static class ConsumoDoCarro
    {
        public static void PrintaCarroMaisEconomico()
        {
            var listaCarros = new List<Carro>(CadastroDeCarro.ListaCarros);

            Carro menor_consumo = listaCarros[0];

            for (int i = 1; i < listaCarros.Count; i++)
            {
                if (listaCarros[i].ConsumoLitro > menor_consumo.ConsumoLitro)
                {
                    menor_consumo = listaCarros[i];
                }
            }

            Console.WriteLine("MARCA DE MENOR CONSUMO: {0} \n CONSUMO DE: {1} KM/L", menor_consumo.Marca, menor_consumo.ConsumoLitro);
        }

        public static void PrintaTodosOsCarrosEConsumos()
        {
            var listaCarros = new List<Carro>(CadastroDeCarro.ListaCarros);

            for (int i = 0; i < listaCarros.Count; i++)
            {
                Console.WriteLine("-------------{0}------------", listaCarros[i].Marca);
                Console.WriteLine("LITROS GASTOS EM 1000 KM: {0}", 1000 / listaCarros[i].ConsumoLitro);
                Console.WriteLine("VALOR GASTO AO PERCORRER 1000 KM {0}", (1000 / listaCarros[i].ConsumoLitro) * 4.89);
            }
        }
    }
}