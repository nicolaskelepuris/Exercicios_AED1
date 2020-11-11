using System;
using System.Linq;

namespace Exercicios_AED1.ExercicioDia10_11_2020Classes
{
    public static class AtendimentoAoCliente
    {
        const string caminhoArquivoIdeias = "..\\ideias.txt";
        const string caminhoArquivoUsuarios = "..\\usuarios.txt";
        static Repositorio<Usuario> repositorioDeUsuario = new Repositorio<Usuario>(caminhoArquivoUsuarios);
        static RepositorioDeIdeias repositorioDeIdeias = new RepositorioDeIdeias(caminhoArquivoIdeias);
        public static Usuario CadastrarUsuario()
        {
            Console.WriteLine("Informe os dados para o cadastro de usuario:\n");
            var nome = PegarInfoDoUsuario("Nome");

            var email = PegarInfoDoUsuario("Email");

            var id = repositorioDeUsuario.PegarQuantidadeDeItensCadastrados();

            var usuario = new Usuario(id, nome, email);

            repositorioDeUsuario.CadastrarItem(usuario);

            //Console.Clear();

            return usuario;
        }

        private static string PegarInfoDoUsuario(string info)
        {
            Console.WriteLine("{0}: ", info);
            var resposta = Console.ReadLine();

            return !String.IsNullOrEmpty(resposta) ? resposta : PegarInfoDoUsuario(info);
        }

        private static AreaDeAplicacao PegarAreaDeAplicacaoDaIdeia(string info)
        {
            Console.WriteLine("{0}: ", info);
            var respostaRecebida = Console.ReadLine();

            int respostaInt;

            if (!int.TryParse(respostaRecebida, out respostaInt))
            {
                return PegarAreaDeAplicacaoDaIdeia(info);
            }

            AreaDeAplicacao areaDeAplicacao;

            if (!Enum.IsDefined(typeof(AreaDeAplicacao), respostaInt))
            {
                return PegarAreaDeAplicacaoDaIdeia(info);
            }

            areaDeAplicacao = (AreaDeAplicacao)respostaInt;
            return areaDeAplicacao;
        }

        public static void CadastrarIdeia(Usuario usuario)
        {
            Console.WriteLine("\nInforme os dados para o cadastro da ideia:\n");
            var descricao = PegarInfoDoUsuario("Descricao");

            var areaDeAplicacao = PegarAreaDeAplicacaoDaIdeia("\nArea de aplicacao(0 - Tecnologia, 1 - Arte, 2 - Filme, 3 - Comida, 4 -  Jogos, 5 - Musica)");

            var id = repositorioDeIdeias.PegarQuantidadeDeItensCadastrados();

            var idUsuario = usuario.Id;

            var ideia = new Ideia(id, areaDeAplicacao, descricao, idUsuario);

            repositorioDeIdeias.CadastrarItem(ideia);

            Console.Clear();
        }

        public static OpcaoDoCliente PegarOpcaoVisualizarIdeiasOuCriarIdeia()
        {
            Console.WriteLine("\nInforme a opcao que deseja (0 - Cadastrar ideia, 1 - Visualizar ideias existentes):\n");
            var resposta = ValidaOpcao(Console.ReadLine());
            return resposta;
        }

        private static OpcaoDoCliente ValidaOpcao(string opcao)
        {
            int respostaInt;
            if (!int.TryParse(opcao, out respostaInt))
            {
                return PegarOpcaoVisualizarIdeiasOuCriarIdeia();
            }

            if (!Enum.IsDefined(typeof(OpcaoDoCliente), respostaInt))
            {
                return PegarOpcaoVisualizarIdeiasOuCriarIdeia();
            }

            return (OpcaoDoCliente)respostaInt;
        }

        public static void RealizaOpcaoDoCliente(OpcaoDoCliente opcaoDoCliente, Usuario usuario)
        {
            OpcaoDoCliente opcao;
            switch (opcaoDoCliente)
            {
                case OpcaoDoCliente.CadastrarIdeia:
                    CadastrarIdeia(usuario);
                    opcao = PegarOpcaoVisualizarIdeiasOuCriarIdeia();
                    RealizaOpcaoDoCliente(opcao, usuario);
                    break;
                case OpcaoDoCliente.VisualizarIdeias:
                    MostrarIdeiasCadastradas();
                    PegarVotoDoUsuario();
                    opcao = PegarOpcaoVisualizarIdeiasOuCriarIdeia();
                    RealizaOpcaoDoCliente(opcao, usuario);
                    break;
            }
        }

        public static void MostrarIdeiasCadastradas()
        {
            var ideiasCadastradas = repositorioDeIdeias.PegarItensCadastrados();

            Console.WriteLine("\nTodas as ideias disponiveis:\n");

            foreach (var item in ideiasCadastradas)
            {
                Console.WriteLine("Area: {0}, Descricao: {1}, Votos: {2}, Autor: {3}, Id: {4}", Enum.GetName(typeof(AreaDeAplicacao),
                                item.AreaDeAplicacao), item.Descricao, item.Votos,
                                repositorioDeUsuario.PegarItensCadastrados().FirstOrDefault(x => x.Id == item.IdUsuario).Nome,
                                item.Id);
            }
        }

        public static void PegarVotoDoUsuario()
        {
            var desejaVotar = UsuarioDesejaVotar();

            if (desejaVotar)
            {
                var ideia = PegarIdeiaVotada();
                ideia.AdicionarVoto();
                MostrarIdeiasEmDestaque();
            }
            else
            {
                return;
            }
        }

        private static bool UsuarioDesejaVotar()
        {
            Console.WriteLine("\nDeseja votar em alguma ideia? digite(s/n)");
            var resposta = Console.ReadLine();

            switch (resposta)
            {
                case "s":
                    return true;
                case "n":
                    return false;
                default:
                    return UsuarioDesejaVotar();
            }
        }

        private static Ideia PegarIdeiaVotada()
        {
            Console.WriteLine("\nInforme o id da ideia: ");
            var resposta = Console.ReadLine();

            int respostaInt;

            if (!int.TryParse(resposta, out respostaInt))
            {
                return PegarIdeiaVotada();
            }
            var ideiaVotada = repositorioDeIdeias.PegarItensCadastrados().FirstOrDefault(x => x.Id == respostaInt);

            if (ideiaVotada == null)
            {
                return PegarIdeiaVotada();
            }

            return ideiaVotada;
        }

        private static void MostrarIdeiasEmDestaque()
        {
            var ideiasEmDestaque = repositorioDeIdeias.PegarIdeiasEmDestaque();

            Console.WriteLine("\nIdeias em destaque:\n");

            foreach (var item in ideiasEmDestaque)
            {
                Console.WriteLine("Area: {0}, Descricao: {1}, Votos: {2}, Autor: {3}, Id: {4}", Enum.GetName(typeof(AreaDeAplicacao),
                                item.AreaDeAplicacao), item.Descricao, item.Votos,
                                repositorioDeUsuario.PegarItensCadastrados().FirstOrDefault(x => x.Id == item.IdUsuario).Nome,
                                item.Id);
            }
        }
    }
}