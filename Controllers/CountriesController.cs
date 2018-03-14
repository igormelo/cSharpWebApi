using Desafio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Desafio.Controllers
{
    [EnableCors(origins: "http://localhost:4201", headers: "*", methods: "*")]
    public class CountriesController : ApiController
    {
        List<Country> countries = new List<Country>
        {
            new Country {
                Id = 1,
                Nome = "Brasil",
                Presidente = "Michel Teme",
                Bandeira = "http://www.bandeirasnacionais.com/data/flags/big/br.png"
            },
            new Country {
                Id = 2,
                Nome = "Estados Unidos",
                Presidente = "Donald Trump",
                Bandeira = "http://www.bandeirasnacionais.com/data/flags/big/us.png"
            },
            new Country
            {
                Id = 3,
                Nome = "Uruguai",
                Presidente = "Tabaré Vázquez",
                Bandeira = "http://www.bandeirasnacionais.com/data/flags/big/uy.png"
            },
            new Country
            {
                Id = 4,
                Nome = "Russia",
                Presidente = "Vladimir Putin",
                Bandeira = "http://www.bandeirasnacionais.com/data/flags/big/ru.png"
            },
            new Country
            {
                Id = 5,
                Nome = "China",
                Presidente = "Xi Jinping",
                Bandeira = "http://www.bandeirasnacionais.com/data/flags/big/cn.png"
            },
            new Country
            {
                Id = 6,
                Nome = "Suécia",
                Presidente = "Urban Ahlin",
                Bandeira = "http://www.bandeirasnacionais.com/data/flags/big/se.png"
            },
            new Country
            {
                Id = 7,
                Nome = "Iraque",
                Presidente = "Hassan Rohani",
                Bandeira = "http://www.bandeirasnacionais.com/data/flags/big/iq.png"
            },
            new Country
            {
                Id = 8,
                Nome = "Arábia Saudita",
                Presidente = "Abdullah",
                Bandeira = "http://www.bandeirasnacionais.com/data/flags/big/sa.png"
            }

        };

        //Action ObterLista()

        [HttpGet]
        public IEnumerable<Country> ObterLista()
        {

            return countries.ToList();
        }
        [HttpGet]
        public Country ObterLista(int id)
        {
            return countries.SingleOrDefault(c => c.Id == id);
        }
    }

}
