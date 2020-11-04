namespace Exercicios_AED1.ExercicioDia03_11_2020Classes
{
    public class Carro
    {
        public string Marca { get; private set; }
        public double ConsumoLitro { get; private set; }

        public Carro(string marca, double consumoLitro)
        {
            Marca = marca;
            ConsumoLitro = consumoLitro;
        }
    }
}