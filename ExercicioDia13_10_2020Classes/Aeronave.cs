namespace Exercicios_AED1.ExercicioDia13_10_2020Classes
{
    public class Aeronave
    {
        public string Nome { get; private set; }
        public int CapacidadeTanqueCombustivel { get; private set; }
        public int QuantidadeCombustivelAtual { get; private set; }
        public int QuantidadeMaximaPassageiros { get; private set; }
        public int AutonomiaKm { get; private set; }
        public int TotalKmsPercorridos { get; private set; } // representa a mesma variavel "HorasDeVoo" do escopo do projeto
        public string NomePiloto { get; private set; }
        public string AeroportoAtual { get; private set; }

        public Aeronave()
        {
        }

        public Aeronave(string nome, int capacidadeTanqueCombustivel, int quantidadeCombustivelAtual, int quantidadeMaximaPassageiros, int autonomiaKm, int totalKmsPercorridos, string nomePiloto, string aeroportoAtual)
        {
            Nome = nome;
            CapacidadeTanqueCombustivel = capacidadeTanqueCombustivel;
            QuantidadeCombustivelAtual = quantidadeCombustivelAtual;
            QuantidadeMaximaPassageiros = quantidadeMaximaPassageiros;
            AutonomiaKm = autonomiaKm;
            TotalKmsPercorridos = totalKmsPercorridos;
            NomePiloto = nomePiloto;
            AeroportoAtual = aeroportoAtual;
        }

        public int AbastecerAeronave()
        {            
            var quantidadeAbastecida = CapacidadeTanqueCombustivel - QuantidadeCombustivelAtual;

            QuantidadeCombustivelAtual = CapacidadeTanqueCombustivel;

            return quantidadeAbastecida;
        }

        public int Voar(int quantidadeKmDoVoo)
        {
            if (quantidadeKmDoVoo <= AutonomiaKm)
            {
                TotalKmsPercorridos += quantidadeKmDoVoo;
            }

            return TotalKmsPercorridos;
        }

        public string GetNomePiloto()
        {
            return NomePiloto;
        }

        public void SetNomePiloto(string novoNomePiloto)
        {
            NomePiloto = novoNomePiloto;
        }

        public string GetAeroportoAtual()
        {
            return AeroportoAtual;
        }

        public void SetAeroportoAtual(string novoAeroportoAtual)
        {
            AeroportoAtual = novoAeroportoAtual;
        }
    }
}