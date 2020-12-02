using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HedefSagliksa.Business.Abstract;

namespace HedefSagliksa.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService _articleService;

        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        // GET: Article
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View(new Article());
        }
        [HttpPost]
        public ActionResult Add(Article model)
        {
            model.CategoryId = 2;
            model.IdentityId = 2;
            model.HomePage = true;
            model.LikesCount += 1;
            model.ReleaseDate = new DateTime(2020, 12, 2);
            model.Tag = "Test";
            model.ViewsCount += 1;
            _articleService.Add(model);
            return View(new Article());
        }
    }
}