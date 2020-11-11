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

        public int Id { get; set; }
        public AreaDeAplicacao AreaDeAplicacao { get; set; }
        public string Descricao { get; set; }
        public int IdUsuario { get; set; }
        public int Votos { get; set; }

        public void AdicionarVoto(){
            Votos++;
        }
    }
}