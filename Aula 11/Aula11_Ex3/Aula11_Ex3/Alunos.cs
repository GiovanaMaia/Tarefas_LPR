using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Ex3
{
    internal class Alunos
    {
        public int matricula;
        public string nome;
        public float prova1;
        public float prova2;
        public float trabalho;
        public double media;
        public double resto;


        public void mediaFinal()
        {

            media = (prova1 * 2.5 + prova2 * 2.5 + trabalho * 2) / 3;

        }
        public int provaFinal()
        {   //media final >= 60

            if (media <= 60)
            {
                resto = 60 - media;
                Console.WriteLine("Sua nota na prova final precisar ser <= " + resto % .2f);
                return 1;
            }
            else return 0;
        }
    }
}
