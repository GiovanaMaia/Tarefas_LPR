using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alunos aluno = new Alunos();


            Console.WriteLine("Digite o nº de matrícula: ");
            aluno.matricula = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do aluno: ");
            aluno.nome = Console.ReadLine();
            Console.WriteLine("Nota da prova 1: ");
            aluno.prova1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota da prova 2: ");
            aluno.prova2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nota do trabalho: ");
            aluno.trabalho = int.Parse(Console.ReadLine());

            aluno.mediaFinal();
            aluno.provaFinal();
        }
    }
}
