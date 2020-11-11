namespace Exercicios_AED1.ExercicioDia10_11_2020Classes
{
    public class Ideia
    {
        public Ideia()
        {
        }

        public Ideia(int id, AreaDeAplicacao areaDeAplicacao, string descricao, int idUsuario)
        {
            Id = id;
            AreaDeAplicacao = areaDeAplicacao;
            Descricao = descricao;
            IdUsuario = idUsuario;
            Votos = 0;
        }

        public int Id { get; private set; }
        public AreaDeAplicacao AreaDeAplicacao { get; private set; }
        public string Descricao { get; private set; }
        public int IdUsuario { get; private set; }
        public int Votos { get; private set; }

        public void AdicionarVoto(){
            Votos++;
        }
    }
}