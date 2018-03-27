using Desafio.Mapping;
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
   [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CountriesController : ApiController
    {

        [HttpGet]
        public IEnumerable<Country> ObterLista()
        {

            return Repository.ObterPaises();
            
        }
        [HttpGet]
        public Country ObterLista(int id)
        {
            return Repository.RetornarPaisesPorId(id);
        }
    }

}
