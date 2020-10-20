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
            Dictionary<Carro, float> carrosComQuantidadeDeCombustivelGasto = new Dictionary<Carro, float>();

            foreach (var carro in carros)
            {
                carrosComQuantidadeDeCombustivelGasto.Add(carro, quantidadeDeKM / carro.ConsumoEmKMPorLitro);
            }

            return carrosComQuantidadeDeCombustivelGasto;
        }

        public static Dictionary<Carro, float> GetValorDeCombustivelGasto(Dictionary<Carro, float> carrosComQuantidadeDeCombustivelGasto)
        {
            Dictionary<Carro, float> carrosComValorDeCombustivelGasto = new Dictionary<Carro, float>();

            foreach (var item in carrosComQuantidadeDeCombustivelGasto)
            {
                carrosComValorDeCombustivelGasto.Add(item.Key, 4.89f * item.Value);
            }

            return carrosComValorDeCombustivelGasto;
        }
    }
}