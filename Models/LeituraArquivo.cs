using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class LeituraArquivo
    {
        //estruturando um retorno em tupla
        public (bool Sucesso, string[] Linhas,int QuantidadeDeLinhas) LerArquivo(string caminho)
        {
            try 
            {

                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());

            }
            catch(Exception)
            {
                return (false,new string[] { } , 0);   
            }
            


        }
    }
}