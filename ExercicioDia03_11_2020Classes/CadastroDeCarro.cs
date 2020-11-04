using System;
using System.Collections.Generic;

namespace Exercicios_AED1.ExercicioDia03_11_2020Classes
{
    public static class CadastroDeCarro
    {
        public static List<Carro> ListaCarros = new List<Carro>();
        public static void Cadastrar()
        {
            bool continuar = true;
            string marca;
            Carro automovel = new Carro("TESTE", 0);

            while (continuar)
            {
                Console.WriteLine("MARCA DO CARRO >>");
                marca = Console.ReadLine();

                double consumo = 0;                
                while (consumo == 0)
                {
                    consumo = RecebeConsumoDoCarro();
                }

                automovel = new Carro(marca, consumo);
                ListaCarros.Add(automovel);

                Console.WriteLine("CONTINUAR CADASTRANDO CARROS? S/N");
                var respostaDoCliente = Console.ReadLine();

                if (respostaDoCliente == "S")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }
            }
        }

        private static double RecebeConsumoDoCarro()
        {
            try
            {
                Console.WriteLine("KM/L DO CARRO >>");
                return double.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro ocorreu ao receber o valor do consumo em KM/L do carro. Erro: {0}", ex.Message);
                return 0;
            }
        }
    }
}