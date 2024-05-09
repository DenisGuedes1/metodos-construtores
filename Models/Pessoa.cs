using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ExemplosExplorando.Models
{
    public class Pessoa
    {
        //construtor precisa ter o mesmo nome da classe e nao possui tipo de retorno
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            
        }
        //desconstrutor nele estamos fazendo o modo inverso
        //
        public void Deconstruct (out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        public Pessoa()        
        {

        }
        //validações 
        private string _nome;
        private int _idade;
        private string _sobrenome;
        public string NomeCompleto => $" {_nome} { _sobrenome} ";
        public string Nome 
        {
             get
             {
                return _nome.ToUpper();
             } 
             
             set
             {
                if (value == ""){
                    throw new ArgumentException("o nome nao poser ser vazio.");
                }

                _nome = value;
             } 
        
        }

        public string Sobrenome
        {
            get
            {
                return _sobrenome;
            }
            
            set
            {
                if (value == ""){
                    throw new ArgumentException("o nome nao poser ser vazio.");
                }

                _sobrenome = value;

            }
        
        }

        public int Idade 
        { get => _idade;
        
         set
         {
            if (value < 0)
            {
                throw new ArgumentException("A idade nao pode ser menor que 0");
            }
            _idade = value;
         }
        
        }
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome},Idade: {Idade}");
        }
    }
}