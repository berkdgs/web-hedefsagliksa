
using HedefSagliksa.Business.Abstract;
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
        private readonly IArticleService _articleService;

        public HomeController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET: Home
        public ActionResult Index()
        {
            
            List<Article> articles = _articleService.GetAll(x => x.Active);
            return View(articles);
        }
    }
}