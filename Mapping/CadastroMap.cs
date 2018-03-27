using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Desafio.Models;
using FluentNHibernate.Mapping;

namespace Desafio.Mapping
{
    public class CadastroMap: ClassMap<Cadastro>
    {
        public CadastroMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Login);
            Map(x => x.Senha);
        }
    }
}