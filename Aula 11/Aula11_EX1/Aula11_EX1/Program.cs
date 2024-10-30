using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo novoRetangulo = new Retangulo();

            Console.WriteLine("Digite a altura do retângulo");
            novoRetangulo.Altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a largura:");
            novoRetangulo.Largura = int.Parse(Console.ReadLine());
            Console.WriteLine("entrou nas functions");
            novoRetangulo.calcArea();
            novoRetangulo.calcPerimetro();
            Console.WriteLine("entrou das functions");
        }
    }
}
