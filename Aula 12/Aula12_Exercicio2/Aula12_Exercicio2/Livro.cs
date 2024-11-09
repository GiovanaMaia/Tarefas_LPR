using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio2
{
    internal class Livro
    {
        public string titulo { get; set; }
        public string autor { get; set; }
        public int anoPublic { get; set; }

        public Livro(string titulo, string autor, int anoPublic)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anoPublic = anoPublic;
        }
    }
}
