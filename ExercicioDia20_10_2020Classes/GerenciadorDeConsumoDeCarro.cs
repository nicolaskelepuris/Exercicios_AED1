using System.Collections.Generic;

namespace Exercicios_AED1.ExercicioDia20_10_2020Classes
{
    public static class GerenciadorDeConsumoDeCarro
    {
        public static Carro GetCarroMaisEconomico(List<Carro> carros)
        {
            Carro carroMaisEconomico = carros[0];

            foreach (var carro in carros)
            {
                if (carro.ConsumoEmKMPorLitro > carroMaisEconomico.ConsumoEmKMPorLitro)
                {
                    carroMaisEconomico = carro;
                }
            }
            
            return carroMaisEconomico;
        }

        public static Dictionary<Carro, float> GetQuantidadeDeCombustivelGasto(List<Carro> carros, float quantidadeDeKM)
        {
            Dictionary<Carro, float> quantidadeDeCombustivelGastoPorCadaCarro = new Dictionary<Carro, float>();

            foreach (var carro in carros)
            {
                quantidadeDeCombustivelGastoPorCadaCarro.Add(carro, quantidadeDeKM / carro.ConsumoEmKMPorLitro);
            }

            return quantidadeDeCombustivelGastoPorCadaCarro;
        }

        public static Dictionary<Carro, float> GetValorDeCombustivelGasto(Dictionary<Carro, float> quantidadeDeCombustivelGastoPorCadaCarro)
        {
            Dictionary<Carro, float> valorDeCombustivelGastoPorCadaCarro = new Dictionary<Carro, float>();

            foreach (var item in quantidadeDeCombustivelGastoPorCadaCarro)
            {
                valorDeCombustivelGastoPorCadaCarro.Add(item.Key, 4.89f * item.Value);
            }

            return valorDeCombustivelGastoPorCadaCarro;
        }
    }
}