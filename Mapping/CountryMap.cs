using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using Desafio.Models;
using FluentNHibernate.Mapping;

namespace Desafio.Mapping
{
    public class CountryMap: ClassMap<Country>
    {
        public CountryMap()
        {

            /*Auto mapeamento
            using FluentNHibernate.Automapping;
            AutoMap.AssemblyOf<Country>();*/

            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Nome);
            Map(x => x.Presidente);
            Map(x => x.Bandeira);
        }
    }
}