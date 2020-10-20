using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_AED1
{
    //     3- Crie um programa que funcione para uma votação eleitoral. Existem três candidatos:
    // 33 - José Couve
    // 25 - Joana Bravo
    // 10 - Roberto Nove
    // 0 - Voto branco
    // 4 - Voto nulo

    // Deseja-se saber:
    // - O candidato vencedor;
    // - O total de votos em branco;
    // - O total de votos nulos;
    class Exercicio03Aula04
    {
        int[] votes = new int[5];
        int mostVotesQuantity;
        int mostVotedCandidateIndex;
        string voteInput;
        public Exercicio03Aula04()
        {
        }

        void GetVotes()
        {
            do
            {
                Console.WriteLine("Please inform your vote (33 - Jose Couve, 25 - Joana Bravo, 10 - Roberto Nove, 0 - Blank Vote, 4 - Null Vote, -1 - Get Result)");
                voteInput = Console.ReadLine();
                ComputeVote(voteInput);
            }
            while (voteInput != "-1");            
        }

        void ComputeVote(string vote)
        {
            switch (vote)
            {
                case "33":
                    votes[0]++;
                    break;
                case "25":
                    votes[1]++;
                    break;
                case "10":
                    votes[2]++;
                    break;
                case "0":
                    votes[3]++;
                    break;
                case "4":
                    votes[4]++;
                    break;
                case "-1":
                    break;
                default:
                    Console.WriteLine("Invalid vote, try again");
                    GetVotes();
                    break;
            }
        }

        void GetResult()
        {
            for (int i = 0; i < 3; i++)
            {
              if (votes[i] > mostVotesQuantity )
                {
                    mostVotesQuantity = votes[i];
                    mostVotedCandidateIndex = i;
                }  
            }
        }

        string GetMostVotedCandidate(int mostVotedCandidateIndex)
        {
            switch (mostVotedCandidateIndex)
            {
                case 0:
                    return "Jose Couve";
                case 1:
                    return "Joana Bravo";
                case 2:
                    return "Roberto Nove";
                default:
                    throw new Exception("Error getting most voted candidate");
            }
        }

        public void PerformExercicio03Aula04()
        {
            GetVotes();
            GetResult();
            PrintResult();
        }

        void PrintResult()
        {
            Console.WriteLine("Most voted candidate: {0}", GetMostVotedCandidate(mostVotedCandidateIndex));
            Console.WriteLine("Quantity of blank votes: {0}", votes[3]);
            Console.WriteLine("Quantity of null votes: {0}", votes[4]);
        }
    }
}
