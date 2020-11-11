using System.Collections.Generic;
using System.Linq;

namespace Exercicios_AED1.ExercicioDia10_11_2020Classes
{
    public class RepositorioDeIdeias : Repositorio<Ideia>
    {
        private List<Ideia> ideiasEmDestaque;

        public RepositorioDeIdeias(string caminho) : base(caminho)
        {
            ideiasEmDestaque = new List<Ideia>();
        }

        public List<Ideia> PegarIdeiasEmDestaque(){
            var ideiasOrdenadasPorVotos = itensCadastrados.OrderByDescending(x => x.Votos);
            ideiasEmDestaque = ideiasOrdenadasPorVotos.Take(3).ToList();
            return new List<Ideia>(ideiasEmDestaque);
        }
    }
}