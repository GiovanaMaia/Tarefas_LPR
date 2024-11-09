using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio2
{
    internal class Biblioteca
    {
        public string ID { get; }
        List<Livro> livros = new List<Livro>();

        public Biblioteca(string iD)
        {
            ID = iD;
        }

        public void AdicionarLivro(Livro l)
        {
            livros.Add(l);
        }

        public void ListarLivros()
        {

            Console.WriteLine("Livros da biblioteca " + ID);
            foreach (Livro livro in livros)
            {
                Console.WriteLine("Título: "+livro.titulo+"\n Autor: " +livro.autor+"\n Ano de publicação: "+ livro.anoPublic);
            }
        }

    }
}
