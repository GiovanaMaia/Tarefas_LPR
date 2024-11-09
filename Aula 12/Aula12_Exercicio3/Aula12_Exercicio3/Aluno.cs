using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12_Exercicio3
{
    internal class Aluno
    {
        public string nome { get; set; }  
        
        List<Turma> turmas = new List<Turma>(); //ADICIONA TURMAS
        List<Matricula> matriculas = new List<Matricula>();

        public Aluno(string nome)
        {
            this.nome = nome;
        }

        public void setMatricula(Matricula m)
        {
            foreach (Matricula matricula in matriculas)

                if (matriculas.Contains(m) || matricula.turma==m.turma)
            {
                Console.WriteLine("ERRO: Essa matrícula já existe");
            } 

            else matriculas.Add(m);
    }


    }
}
