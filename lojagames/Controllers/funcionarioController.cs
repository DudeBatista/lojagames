using lojagames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lojagames.Controllers
{
    public class funcionarioController : Controller
    {
        // GET: funcionario
        public ActionResult Index()
        {
            var funcionario = new Funcionario();
            return View(funcionario);
        }
        [HttpPost]
        public ActionResult Index(Funcionario funcionario)
        {
            if(ModelState.IsValid)
            {
                return View("Listar", funcionario);
            }
            return View(funcionario);
        }
        public ActionResult Listar(Funcionario funcionario)
        {
            return View(funcionario);
        }
    }
}