using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAprovação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a nota do aluno?: ");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine("Quanto o aluno tem de frequência?: ");
            double f = double.Parse(Console.ReadLine());

            if (n > 4 && f > 75) 
            { 
                Console.WriteLine("O aluno foi aprovado! "); 
            }
            else if (n > 4 && f < 75)
             {
                Console.WriteLine("O aluno está de recuperação! ");
            }
            else
            { 
                Console.WriteLine("O aluno está retido! ");
            }

            Console.ReadKey();

        }
    }
}
