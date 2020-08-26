using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios_AED1
{
    //     2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
    // Código Produto Preço Unitário (R$)
    // ---------------------------------
    // 100  Cachorro quente   R$ 1,70
    // 101   Bauru Simples    R$ 2,30
    // 102   Bauru com ovo    R$ 2,60
    // 103   Hamburguer       R$ 2,40
    // 104   Cheeseburguer    R$ 2,50
    // 105   Refrigerante     R$ 1,00
    // ----------------------------------
    // Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
    // quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto
    // e o valor, somente o valor final
    class Exercicio02Aula04
    {
        public Exercicio02Aula04()
        {
        }

        string GetProductCode()
        {
            Console.WriteLine("Please inform the product code");
            return Console.ReadLine();
        }

        double GetProductQuantity()
        {
            Console.WriteLine("Please inform the quantity of products");
            return double.Parse(Console.ReadLine());
        }

        double CalculateTotalPrice(string productCode, double quantity)
        {
            switch (productCode)
            {
                case "100":
                    return 1.7 * quantity;
                case "101":
                    return 2.3 * quantity;
                case "102":
                    return 2.6 * quantity;
                case "103":
                    return 2.4 * quantity;
                case "104":
                    return 2.5 * quantity;
                case "105":
                    return 1 * quantity;
                default:
                    throw new Exception("Invalid product code");
            }
        }

        void PrintTotalPrice(double totalPrice)
        {
            Console.WriteLine("Total price: {0}", totalPrice);
        }

        public void PerformExercicio02Aula04()
        {
            var productCode = GetProductCode();
            var quantityOfProducts = GetProductQuantity();
            var totalPrice = CalculateTotalPrice(productCode, quantityOfProducts);
            PrintTotalPrice(totalPrice);
        }
    }
}
