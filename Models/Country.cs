using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Desafio.Models
{
    public class Country
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Presidente { get; set; }
        public virtual string Bandeira { get; set; }
    }

}