using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio.Models
{
    public class User

    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Idade { get; set; }
        public DateTime DataRegistro { get; set; }
   
        /*public User(int Id, string Nome, string Sobrenome, int Idade, DateTime dataRegistro)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Idade = Idade;
            this.DataRegistro = DataRegistro;
        }*/


        public string ObterNomeIdade()
        {
            string result = Nome + ", " + Idade;
            return result;
        }
        public string ObterData()
        {
            return DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
        }


        public string NomeCompleto
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Nome))
                return Sobrenome;
                return Nome+ " " +Sobrenome;
            }
        }
        public int ObterAnoDoNascimento()
        {
            var ano = DateTime.Now.Year - Idade;
            return ano;
        }
        public string NomeESobrenomeReverso(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string (array);
        }
        public int ObterLenghtNomeCompleto()
        {
            return (Nome + Sobrenome).Length;
        }
    }
}