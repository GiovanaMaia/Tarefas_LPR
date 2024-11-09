using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Biblioteca biblioteca = new Biblioteca ("Biblertao");
            Livro livro1 = new Livro("Instrumentos mortais", "Cassandra Clare", 2008);
            Livro livro2 = new Livro("Divinos rivais", "Rebecca Ross", 2023);
            Livro livro3 = new Livro("Marley e eu", "John Grogan", 2005);

            Livro[] vetor = {livro1,livro2,livro3};

            for (int i=0; i<3; i++)
            {
                biblioteca.AdicionarLivro(vetor[i]);
            }
            
            biblioteca.ListarLivros();


        }
    }
}
