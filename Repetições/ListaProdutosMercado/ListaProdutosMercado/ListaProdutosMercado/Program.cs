using System;
using System.Collections.Generic;
using System.Linq;
using ListaProdutosMercado.Classes

namespace ListaProdutosMercado
{
    class Program
    {





        static void Main(string[] argumentos)
        {
            List<Produto> produtosDisponiveis = new List<Produto>();
            produtosDisponiveis.Add(new Produto() { Nome = "Pão", Preco = 0.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Shampoo", Preco = 19.9 });
            produtosDisponiveis.Add(new Produto() { Nome = "Azeite", Preco = 14.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Refrigerante", Preco = 6.25 });
            produtosDisponiveis.Add(new Produto() { Nome = "Queijo", Preco = 12.75 });
            produtosDisponiveis.Add(new Produto() { Nome = "Carne", Preco = 62.85 });

            if (argumentos.Lenght == 0)
            {
                Console.WriteLine("Você não passou os produtos que deseja comprar");
                return;
            }

            var produtosSelecionadosDisponiveis = produtosDisponiveis.Where(Produto =>
                    argumentos.Any(argumento => Produto.Nome.ToUpper() == argumento.ToUpper())))
            
            foreach (var produto in produtosSelecionadosDisponiveis)
            {
                Console.WriteLine($"Este produto nós temos: {produto.ExibirDadosProduto()}")
            }

            var produtosSelecionadosNaoDisponiveis = argumentos.Where(argumentos
        }
    }
}
