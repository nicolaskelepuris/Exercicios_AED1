using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace Exercicios_AED1.ExercicioDia10_11_2020Classes
{
    public class Repositorio<T> where T : class
    {
        protected List<T> itensCadastrados;

        public Repositorio(string caminho)
        {
            List<T> itens = new List<T>();
            try
            {
                itens = new List<T>(ManipuladorDeArquivo.LerArquivo<T>(caminho));
            }
            catch (System.Exception)
            {
            }

            itensCadastrados = itens.Count > 0 ? new List<T>(itens) : new List<T>();
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