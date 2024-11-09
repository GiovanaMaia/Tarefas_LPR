using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Turma t1 = new Turma (34);
            Aluno aluno = new Aluno("gi");
            Aluno a2 = new Aluno("mari");
            

            Matricula m1 = new Matricula(t1,aluno, "09/11/2024");
            Matricula m2 = new Matricula(t1, aluno, "07/12/2024");
            Matricula m3 = new Matricula(t1, a2, "07/12/2024");

            aluno.setMatricula(m1); 
            t1.setMatricula(m1);
            t1.setMatricula(m2);
            t1.setMatricula(m3);

            t1.mostarAlunos();

        }
    }
}
