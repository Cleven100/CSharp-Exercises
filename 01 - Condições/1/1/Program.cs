using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Faça um programa que receba quatro notas de um aluno, calcule e mostre a média aritmética das notas e a mensagem de aprovação ou reprovação, considerando para aprovação média 7*/
            double noteOne, noteTwo, noteThree, noteFour, average;
            Console.WriteLine("Digite a nota do primeiro aluno: ");
            noteOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do segunda aluno: ");
            noteTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do terceira aluno: ");
            noteThree = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota do quarta aluno: ");
            noteFour = Convert.ToDouble(Console.ReadLine());

            average = (noteOne + noteTwo + noteThree + noteFour) / 4;

            Console.WriteLine(average);

            if(average >= 7)
            {
                Console.WriteLine("Aprovado!");
            }if(average < 7)
            {
                Console.WriteLine("Reprovado!");
            }
            Console.ReadLine();
        }
    }
}
