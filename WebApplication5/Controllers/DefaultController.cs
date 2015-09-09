using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Blah()
        {


            return View((object)Sample.LabelName);
        }
    }
}