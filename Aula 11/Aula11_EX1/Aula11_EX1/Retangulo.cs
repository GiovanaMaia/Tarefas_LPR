using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_EX1
{
    internal class Retangulo
    {
        public double Altura;
        public double Largura;

        public void calcArea()
        {
            double area = 0;

            area = Altura * Largura;

            Console.WriteLine("A área é igual a " + area);

        }

        public void calcPerimetro()
        {
            double perimetro = 0;

            perimetro = 2 * Altura + 2 * Largura;

            Console.WriteLine("O perímetro é igual a " + perimetro);
        }
    }
}
