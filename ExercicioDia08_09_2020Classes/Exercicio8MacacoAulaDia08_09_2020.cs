using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_AED1
{
    class Exercicio8MacacoAulaDia08_09_2020
    {
        public Exercicio8MacacoAulaDia08_09_2020(string nome)
        {
            Nome = nome;
            ConteudoDoEstomago = estomagoVazio;
        }

        public string Nome { get; private set; }

        private string estomagoVazio = "Estomago vazio";

        private bool comeuComSucesso;

        private bool digeriuComSucesso;

        private string conteudoDoEstomago;

        public string ConteudoDoEstomago
        {
            get { return conteudoDoEstomago; }
            set
            {
                if (conteudoDoEstomago == estomagoVazio)
                {
                    // caso o macaco esteja de estomago vazio e mande digerir havera falha ao digerir
                    if (value == estomagoVazio)
                    {
                        digeriuComSucesso = false;
                    }

                    // conteudo do estomago recebe o alimento caso o estomago esteja vazio
                    conteudoDoEstomago = value;
                    comeuComSucesso = true;
                }
                else
                {
                    if (value == estomagoVazio)
                    {
                        digeriuComSucesso = true;
                    }

                    comeuComSucesso = false;
                    conteudoDoEstomago = value;
                }
            }
        }

        public void Comer(string alimento)
        {
            ConteudoDoEstomago = alimento;

            if (comeuComSucesso)
            {
                Console.WriteLine("O macaco comeu com sucesso");
            }
            else
            {
                Console.WriteLine("O macaco não conseguiu comer ja que ainda nao digeriu o alimento presente no estomago e jogou o novo alimento fora");
            }
        }

        public void VerConteudoDoEstomago()
        {
            Console.WriteLine("Conteudo do Estomago: {0}", ConteudoDoEstomago);
        }

        public void DigerirConteudoDoEstomago()
        {
            ConteudoDoEstomago = estomagoVazio;

            if(digeriuComSucesso)
            {
                Console.WriteLine("O macaco digeriu com sucesso");
            }
            else
            {
                Console.WriteLine("O macaco não conseguiu digerir ja que seu estomago estava vazio");
            }
        }


    }
}
