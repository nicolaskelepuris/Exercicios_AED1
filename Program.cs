﻿using System;
using System.Collections.Generic;
using ExercicioDia01_12_2020Classes;
using Exercicios_AED1.ExercicioDia03_11_2020Classes;
using Exercicios_AED1.ExercicioDia10_11_2020Classes;
using Exercicios_AED1.ExercicioDia13_10_2020Classes;
using Exercicios_AED1.ExercicioDia20_10_2020Classes;

namespace Exercicios_AED1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio dia 18/08/2020
            //var exercicio1 = new Exercicio1();
            //exercicio1.GetTwoNumbersAndPrintSum();

            //var exercicio2 = new Exercicio2();
            //exercicio2.GetFourGradesAndPrintAverage();
            #endregion

            #region Exercicio dia 25/08/2020
            //var exercicio01Aula04 = new Exercicio01Aula04();
            //exercicio01Aula04.PerformExercicio01Aula04();

            //var exercicio02Aula04 = new Exercicio02Aula04();
            //exercicio02Aula04.PerformExercicio02Aula04();

            //var exercicio03Aula04 = new Exercicio03Aula04();
            //exercicio03Aula04.PerformExercicio03Aula04();
            #endregion

            #region Exercicio dia 08/09/2020
            // var macaco1 = new Exercicio8MacacoAulaDia08_09_2020("macaco1");
            // var macaco2 = new Exercicio8MacacoAulaDia08_09_2020("macaco2");
            // Console.WriteLine("Macaco 1:");
            // macaco1.VerConteudoDoEstomago();
            // macaco1.Comer("banana");
            // macaco1.VerConteudoDoEstomago();
            // macaco1.Comer("pimenta");
            // macaco1.DigerirConteudoDoEstomago();
            // macaco1.VerConteudoDoEstomago();
            // Console.WriteLine("\nMacaco 2:");
            // macaco2.DigerirConteudoDoEstomago();
            // macaco2.DigerirConteudoDoEstomago();
            // macaco2.Comer("piolho");
            // macaco2.VerConteudoDoEstomago();
            // macaco2.DigerirConteudoDoEstomago();
            // macaco2.VerConteudoDoEstomago();
            #endregion

            #region Exercicio dia 13/10/2020

            // var aeronave = new Aeronave("Aeronave", 2000, 1500, 150, 4500, 250000, "Joao", "Vitoria");
            // Console.WriteLine(aeronave.Voar(3000));

            #endregion

            #region Exercicio dia 20/10/2020  

            // var carros = new List<Carro>();

            // carros.Add(new Carro("Gol", consumoEmKMPorLitro: 13));
            // carros.Add(new Carro("Etios", consumoEmKMPorLitro: 12));
            // carros.Add(new Carro("Onix", consumoEmKMPorLitro: 11));
            // carros.Add(new Carro("Palio", consumoEmKMPorLitro: 15));
            // carros.Add(new Carro("Civic", consumoEmKMPorLitro: 14));
            // carros.Add(new Carro("Corolla", consumoEmKMPorLitro: 14));

            // var carroMaisEconomico = GerenciadorDeConsumoDeCarro.GetCarroMaisEconomico(carros);

            // Console.WriteLine("Modelo de carro mais economico: {0}\n", carroMaisEconomico.Modelo);

            // var carrosComQuantidadeDeCombustivelGasto = GerenciadorDeConsumoDeCarro.GetQuantidadeDeCombustivelGasto(carros, quantidadeDeKM: 1000f);

            // var carrosComValorDeCombustivelGasto = GerenciadorDeConsumoDeCarro.GetValorDeCombustivelGasto(carrosComQuantidadeDeCombustivelGasto);

            // Console.WriteLine("Quantidade de combustivel gasto e valor gasto com combustivel para cada carro percorrer 1000Km (Considerando gasolina BRL4.89):\n");

            // foreach (var item in carrosComQuantidadeDeCombustivelGasto)
            // {
            //     Console.WriteLine("Modelo: {0}, Quantidade de combustivel: {1}, Valor gasto com combustivel: {2}", item.Key.Modelo, item.Value, carrosComValorDeCombustivelGasto[item.Key]);
            // }

            #endregion

            #region Exercicio dia 03/11/2020
            //CadastroDeCarro.Cadastrar();
            //ConsumoDoCarro.PrintaCarroMaisEconomico();
            //ConsumoDoCarro.PrintaTodosOsCarrosEConsumos();
            #endregion

            #region Exercicio dia 10/11/2020
            // var usuario = AtendimentoAoCliente.CadastrarUsuario();
            // var opcaoDoCliente = AtendimentoAoCliente.PegarOpcaoVisualizarIdeiasOuCriarIdeia();
            // AtendimentoAoCliente.RealizaOpcaoDoCliente(opcaoDoCliente, usuario);
            #endregion

            #region Exercicio dia 01/12/2020
            // exercicio 1
            var empregado = new Empregado(nome: "Empregado 1", sobrenome: "Sobrenome do empregado 1", salarioMensal: 2000.0);
            try
            {
                empregado.SalarioMensal = -1.0;
            }
            catch (SalarioInvalidoException)
            {
                Console.WriteLine("Aconteceu um erro ao mudar o salario mensal para um valor negativo, o valor nao foi alterado");
            }
            var empregado2 = new Empregado(nome: "Empregado 2", sobrenome: "Sobrenome do empregado 2", salarioMensal: 4000.0);

            Console.WriteLine(empregado.ToString());
            Console.WriteLine(empregado2.ToString());

            // exercicio 2
            var datas = new List<Data>();
            bool continuarInserindoDados = true;
            while (continuarInserindoDados)
            {
                Console.WriteLine("Informe o dia");
                var dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o mes");
                var mes = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o ano");
                var ano = int.Parse(Console.ReadLine());

                datas.Add(new Data(dia, mes, ano));

                Console.WriteLine("Informe se deseja continuar inserindo datas: sim/nao");
                continuarInserindoDados = Console.ReadLine() == "sim" ? true : false;
            }
            #endregion

        }
    }
}
