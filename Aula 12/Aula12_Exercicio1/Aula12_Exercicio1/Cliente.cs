using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio1
{
    internal class Cliente
    {
        public string nome { get; set; }

        List<Reserva> reservas = new List<Reserva>();

        public Cliente(string Nome)
        {
            this.nome = Nome;
        }

        public void addReserva(Reserva r)
        {
            reservas.Add(r);
        }

        public void mostrarReservas()
        {
            Console.WriteLine("Cliente " + nome);
            foreach(Reserva reserva in reservas)
            {
                Console.WriteLine("Reserva "+reserva.ID+":\n"+reserva.Local);
            }
        }
    }
}
