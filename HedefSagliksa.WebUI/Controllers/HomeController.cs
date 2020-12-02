
using HedefSagliksa.DataAccess.Concrete.EntityFramework.Context;
using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HedefSagliksa.WebUI.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult Index()
        {
            List<Article> articles;
            using (var db = new HSContext())
            {
                articles = db.Articles.Include("Comments").ToList();
            }
            return View(articles);
        }
    }
}