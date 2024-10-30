using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite o nome do funcionário: ");
            funcionario.nome = Console.ReadLine();
            Console.WriteLine("Digite o salário: ");
            funcionario.salarioBrut = int.Parse(Console.ReadLine());

            funcionario.aumentoSalario();
            funcionario.dados();

        }
    }
}
