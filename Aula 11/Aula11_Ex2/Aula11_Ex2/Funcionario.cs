using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Ex2
{
    internal class Funcionario
    {
        public string nome;
        public double salarioBrut;
        public double salarioLiq;

        public void aumentoSalario()
        {
            if (salarioBrut <= 2000)
            {
                salarioLiq = salarioBrut * 1.1;
            }
            else if (salarioBrut > 2000 && salarioBrut < 3000)
            {
                salarioLiq = salarioBrut * 1.15;
            }
            else
            {
                salarioLiq = salarioBrut * 1.20;
            }

        }
        public void dados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salário líquido: R$" + salarioLiq + ",00");

        }

    }
}
