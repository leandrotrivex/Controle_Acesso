using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controle_Acesso.Controllers
{

    [Authorize]

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult qAcessos()
        {
            return View();
        }
        public ActionResult qrela()
        {
            return View();
        }



    }
}

