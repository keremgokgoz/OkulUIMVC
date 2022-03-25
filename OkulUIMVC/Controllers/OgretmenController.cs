using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OkulUIMVC.Controllers
{
    public class OgretmenController : Controller
    {
        // GET: Ogretmen
        public ActionResult Index()
        {
            return View();
        }

        OgretmenManager om = new OgretmenManager();
        public ActionResult GetOgretmenList()
        {
            var ogretmenValues = om.GetAll();
            return View(ogretmenValues);
        }
    }
}