using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        //propriedade coleção
        public List<Pessoa> Alunos { get; set; }


        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAlunos(Pessoa aluno)
        {
           return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {   
            
            Console.WriteLine($"Alunos do curso de : {Nome}");

            for (int count = 1; count < Alunos.Count; count++)
            { 
                // string texto = "N " + count + " - " + Alunos[count].NomeCompleto;
                string texto = $"N {count} - {Alunos[count].NomeCompleto}";
                Console.WriteLine(texto);
            }
        }
    }
}