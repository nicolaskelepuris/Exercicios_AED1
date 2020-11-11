using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace Exercicios_AED1.ExercicioDia10_11_2020Classes
{
    public static class ManipuladorDeArquivo
    {
        public const string CaminhoArquivoIdeias = "/ideias.txt";
        public const string CaminhoArquivoUsuarios = "/usuarios.txt";
        public static void SalvarIdeiasNoArquivo(RepositorioDeIdeias repositorioDeIdeias)
        {
            var ideias = new Dictionary<string, List<Ideia>>();
            ideias.Add("Lista", repositorioDeIdeias.PegarItensCadastrados());
            EscreverDadosEmArquivo<Ideia>(CaminhoArquivoIdeias, ideias);
        }

        public static void SalvarUsuariosNoArquivo(Repositorio<Usuario> repositorioDeUsuarios)
        {
            var usuarios = new Dictionary<string, List<Usuario>>();
            usuarios.Add("Lista", repositorioDeUsuarios.PegarItensCadastrados());
            EscreverDadosEmArquivo<Usuario>(CaminhoArquivoUsuarios, usuarios);
        }

        private static void EscreverDadosEmArquivo<T>(string caminhoDoArquivo, Dictionary<string, List<T>> informacao)
        {
            var caminho = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var informacaoSerializada = JsonSerializer.Serialize(informacao);
            File.WriteAllText(caminho + caminhoDoArquivo, informacaoSerializada);
        }

        public static List<T> LerArquivo<T>(string caminhoDoArquivo)
        {
            var caminho = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var conteudoDoArquivo = File.ReadAllText(caminho + caminhoDoArquivo);
            var itens = JsonSerializer.Deserialize<Dictionary<string, List<T>>>(conteudoDoArquivo);

            return itens["Lista"];
        }
    }
}