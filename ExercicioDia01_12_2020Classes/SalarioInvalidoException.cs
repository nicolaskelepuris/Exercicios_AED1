using System;

namespace ExercicioDia01_12_2020Classes
{
    public class SalarioInvalidoException : Exception
    {
        public SalarioInvalidoException() : base(message: "Salario invalido! O salario deve possuir um valor positivo.")
        {
        }
    }
}