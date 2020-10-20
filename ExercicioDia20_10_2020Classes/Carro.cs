namespace Exercicios_AED1.ExercicioDia20_10_2020Classes
{
    public class Carro
    {
        public string Modelo { get; private set; }
        public float ConsumoEmKMPorLitro { get; private set; }
        public Carro(string modelo, float consumoEmKMPorLitro)
        {
            Modelo = modelo;
            ConsumoEmKMPorLitro = consumoEmKMPorLitro;
        }
    }
}