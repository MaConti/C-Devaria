using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeProdutosDisponiveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lista de produtos que o Mercado tem

            List<string> produtosDisponiveis = new List<string>()
            {
                "pão", "leite", "manteiga", "requeijão", "refrigerante", "arroz", "alface", "tomate", "frango", "doce"
            };


            try
            {
                var produtosSelecionados = produtosDisponiveis.Where(produto => args.Contains(produto)).ToList();
                foreach (var produtoSelecionado in produtosSelecionados)
                {
                    Console.WriteLine($"Este produto nós temos: {produtoSelecionado}");
                }

                var produtosNaoDisponiveis = args.Where(args => !produtosDisponiveis.Contains(args)).ToList();
                foreach (var produtoNaoDisponivel in produtosNaoDisponiveis)
                {
                    Console.WriteLine($"Este produto nós não temos infelizmente =/: {produtoNaoDisponivel}");
                }


            }

            catch(Exception)
            {
                Console.WriteLine("Argumentos inválidos");
            }


        }
    }
}
