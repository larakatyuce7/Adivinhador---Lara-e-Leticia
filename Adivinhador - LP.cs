using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADIVINHADOR");
            Console.WriteLine("REGRAS:");
            Console.WriteLine("*TENTE DESCOBRIR A PALAVRA SECRETA COM O MENOR NÚMERO DE TENTATIVAS");

            double palavra1, palavra2, palavra3, palavra4, palavra5, palavras;

            Console.WriteLine("Digite a primeira palavra");
            palavra1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda palavra");
            palavra2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a terceira palavra");
            palavra3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quarta palavra");
            palavra4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a quinta palavra");
            palavra5 = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();

            {
                Random adivinhador = new Random();
                palavras = adivinhador.Next(2);
            }
           
            string palavrachave = "Gado", palavra = "";
            int tentativas = 0;


            do
            {
             
                Console.WriteLine("Digite 5 palavras");
                palavra = Console.ReadLine();
                tentativas = tentativas + 1;
                Console.Clear();
            } while (palavra != palavrachave);

            Console.WriteLine("Você adivinhou a paloavra chave em "
             + tentativas + "tentativas");

            Console.ReadKey();


        }
    }
}
