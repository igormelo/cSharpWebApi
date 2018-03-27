using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio.Models
{
    public class Cadastro
    {
        public virtual int Id { get; set; }
        public virtual string Login{ get; set; }
        public virtual string Senha { get; set; }
    }
}