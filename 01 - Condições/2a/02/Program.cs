using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Faça um programa que receba duas notas, calcule e mostre a média aritmética e a mensagem que está na tabela a seguir 0-4 reprovado 4-7 recuperação 7-10 aprovado*/

            double notaOne, notaTwo, avarage;
            Console.WriteLine("Digite a primeira nota: ");
            notaOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            notaTwo = Convert.ToDouble(Console.ReadLine());

            avarage = (notaOne + notaTwo) /2;

            if (avarage >= 0 && avarage < 4)
            {
                Console.WriteLine("Reprovado");
            } if (avarage >= 4 && avarage < 7)
            {
                Console.WriteLine("Recuperação");
            } if(avarage >= 7 && avarage <= 10)
            {
                Console.WriteLine("Aprovado");
            }
            Console.ReadLine();

        }
    }
}
