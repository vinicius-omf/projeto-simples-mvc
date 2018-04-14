using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class CadastroController : Controller
    {
        // GET: Cadastro
        [Authorize]
        public ActionResult Usuario()
        {
            return View();
        }

        [Authorize]
        public ActionResult Produto()
        {
            return View();
        }
    }
}