using System;

namespace ExercicioDia01_12_2020Classes
{
    public class DataInvalidaException : Exception
    {
        public DataInvalidaException() : base("Data invalida!")
        {
        }
    }
}