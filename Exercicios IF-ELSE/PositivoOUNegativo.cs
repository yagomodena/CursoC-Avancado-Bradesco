using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_IF_ELSE
{
    class PositivoOUNegativo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número qualquer:");
            int numero = int.Parse(Console.ReadLine());

            if(numero > 0 )
            {
                Console.WriteLine("O número é positivo!");
            }else if(numero < 0)
            {
                Console.WriteLine("O número é negativo!");
            }
            else
            {
                Console.WriteLine("O número é zero");
            }
        }
    }
}
