using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Gio");
            Reserva r1 = new Reserva(c1, "Mesa 7");

            Cliente c2 = new Cliente("Scooby-dooby-doo");
            Reserva r2 = new Reserva(c2, "Mesa mais próxima da cozinha");
            
            c1.addReserva(r1);
            c1.mostrarReservas();

            c2.addReserva(r2);
            c2.mostrarReservas();
        }
    }
}
