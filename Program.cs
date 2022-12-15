using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooMaiorIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa P1;
            Pessoa P2;
            Pessoa P3;
            Console.WriteLine("Determina qual pessoa é a mais velha");
            Console.WriteLine("Nome da 1 pessoa: ");
            P1= new Pessoa();
            P1.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 1 pessoa: ");
            P1.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nome da 2 pessoa: ");
            P2 = new Pessoa();
            P2.Nome = Console.ReadLine();
            Console.WriteLine("Idade da 2 pessoa: ");
            P2.Idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nome da 3 pessoa: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Idade da 3 pessoa: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            P3 = new Pessoa(nome, idade);
            //Logica
            if ((P1.Idade > P2.Idade) && (P1.Idade > P3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                P1.ExibirDados();
            }
            else
            {
                if ((P2.Idade > P3.Idade) && (P2.Idade > P1.Idade))
                {
                    Console.WriteLine("A pessoa mais velha é: ");
                    P2.ExibirDados();
                }
                else
                {
                    if ((P3.Idade > P1.Idade) && (P3.Idade > P2.Idade))
                    {
                        Console.WriteLine("A pessoa mais velha é: ");
                        P3.ExibirDados();
                    }
                    else
                    {
                        Console.WriteLine("Todas as pessoas possuem a mesma idade.");
                    }
                }

                
            }
            Console.ReadKey();
        }
    }
}
