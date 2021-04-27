using System;

namespace TesteVarConst
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constante = "uma constante que não muda";

            if(args.Length == 0)
            {
                Console.WriteLine("Favor Informar um número inteiro");
                return;
            }

            int inteiro;
            bool test = int.TryParse(args[0].Trim(), out inteiro);

            if(test == false)
            {
                Console.WriteLine("O argumento informado não é um inteiro" + args[0]);
                       return;
            }
            Console.WriteLine(constante);
            Console.WriteLine("O número informado foi: " + inteiro);
        }


    }
}
