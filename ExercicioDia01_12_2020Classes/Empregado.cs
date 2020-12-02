namespace ExercicioDia01_12_2020Classes
{
    public class Empregado
    {
        public Empregado(string nome, string sobrenome, double salarioMensal)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            SalarioMensal = salarioMensal;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        private double salarioMensal;
        public double SalarioMensal
        {
            get { return salarioMensal; }
            set
            {
                salarioMensal = value >= 0 ? value
                  : throw new SalarioInvalidoException();
            }
        }

        public double SalarioAnual { get { return SalarioMensal * 12; } }

        public static double GetSalarioComAdicional(double adicional, double salario)
        {
            return salario + (salario * adicional);
        }

        public override string ToString()
        {
            return string.Format("Dados do empregado:\nNome: {0}, Sobrenome {1}, Salario Mensal: {2}, Salario Anual: {3}", Nome, Sobrenome, SalarioMensal, SalarioAnual);
        }
    }
}