using System;

namespace ExercicioDia01_12_2020Classes
{
    public class Data
    {
        public Data()
        {
            var dataAtual = DateTime.Now;
            Dia = dataAtual.Day;
            Mes = dataAtual.Month;
            Ano = dataAtual.Year;
        }

        public Data(int dia, int mes, int ano)
        {
            try
            {
                Dia = dia > 0 && dia <= MaximoDeDiasNoMes(mes, EhAnoBissexto(ano))
                ? dia : throw new DataInvalidaException();

                Mes = mes > 0 && mes <= 12 ? mes : throw new DataInvalidaException();
                Ano = ano;
            }
            catch (DataInvalidaException)
            {
                Console.WriteLine("Invalida a data informada");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        private bool EhAnoBissexto(int ano)
        {
            if (ano % 400 == 0)
            {
                return true;
            }
            else
            {
                if (ano % 4 == 0 && ano % 100 != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private int MaximoDeDiasNoMes(int mes, bool anoBissexto)
        {
            if (MesTem31Dias(mes))
            {
                return 31;
            }
            else
            {
                if (MesTem30Dias(mes))
                {
                    return 30;
                }
                else
                {
                    if (anoBissexto)
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
            }
        }

        private bool MesTem30Dias(int mes)
        {
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool MesTem31Dias(int mes)
        {
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AvancarUmDia()
        {
            if (Dia == MaximoDeDiasNoMes(Mes, EhAnoBissexto(Ano)))
            {
                Dia = 1;
                AvancarUmMes();
            }
            else
            {
                Dia++;
            }
        }

        private void AvancarUmMes()
        {
            if (Mes == 12)
            {
                Mes = 1;
                Ano++;
            }
            else
            {
                Mes++;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Dia, Mes, Ano);
        }
    }
}