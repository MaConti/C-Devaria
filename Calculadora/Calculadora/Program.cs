using System;

namespace Calculadora
{
    class Program
    {   
        static float RealizarOperacao(floar primeiroNumero, float segundoNumero, string operador)
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um número");
            var primeiroNumeroString = Console.ReadLine
            float primeiroNumero;

            bool isPrimeiroNumeroValido = float.TryParse(primeiroNumeroString, out primeiroNumero);
            if (!isPrimeiroNumeroValido)
            {
                Console.WriteLine("Primeiro número inválido");
                return;
            }
        }
    }
}
