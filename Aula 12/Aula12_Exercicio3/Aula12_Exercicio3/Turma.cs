using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio3
{
    internal class Turma
    {
        public int ID;

        List<Aluno> alunos = new List<Aluno>();//ADICIONA ALUNOS
        List<Matricula> matriculasTurma = new List<Matricula>();

        public Turma(int iD)
        {
            ID = iD;
        }

        public void setMatricula(Matricula m)
        {
            foreach (Matricula matricula in matriculasTurma)
            {

                if (matricula == m || matricula.aluno == m.aluno)
                {
                    Console.WriteLine("O aluno já está matriculado");
                    return;
                }
                
            }
            matriculasTurma.Add(m);
            alunos.Add(m.aluno);
            Console.WriteLine("Matrícula feita com sucesso");
            
        }


        public void mostarAlunos()
        {
            Console.WriteLine("Alunos:");

            foreach (Aluno aluno in alunos )
            {
                Console.WriteLine(aluno.nome);
            }
        }
    }
}
