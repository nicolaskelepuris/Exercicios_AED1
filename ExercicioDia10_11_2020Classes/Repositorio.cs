using System.Collections.Generic;

namespace Exercicios_AED1.ExercicioDia10_11_2020Classes
{
    public class Repositorio<T> where T : class
    {
        protected List<T> itensCadastrados;

        public Repositorio(string caminho)
        {
            itensCadastrados = new List<T>();
        }

        public void CadastrarItem(T entidade)
        {
            itensCadastrados.Add(entidade);
        }

        public List<T> PegarItensCadastrados()
        {
            return new List<T>(itensCadastrados);
        }

        public int PegarQuantidadeDeItensCadastrados()
        {
            return itensCadastrados.Count;
        }
    }
}