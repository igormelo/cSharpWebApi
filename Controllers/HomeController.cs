using Desafio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Desafio.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            var user = new User();
            user.Nome = "Igor";
            user.Idade = 24;
            ViewBag.Title = user.Nome;
            ViewBag.Teste = user.Idade;

            return View();
        }
       
    }
}
