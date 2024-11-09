using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio3
{
    internal class Matricula
    {
        public string data{get; set;}
        public Turma turma { get; set;}
        public Aluno aluno { get; set;}

        public Matricula(Turma turma, Aluno aluno, string data)
        {
            this.turma = turma;
            this.aluno = aluno;
            this.data = data;
        }
    }
}
