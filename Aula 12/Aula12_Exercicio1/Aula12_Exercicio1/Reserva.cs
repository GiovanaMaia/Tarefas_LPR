using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio1
{
    internal class Reserva
    {
        public int ID { get; set; }
        public string Local { get; set; }

        int cont=1;

        Cliente cliente { get; set; } 
        
        public Reserva(Cliente c, string mesa)
        {
            this.cliente = c;
            this.Local= mesa;
            this.ID = cont;
            cont++;
        }



    }
}
