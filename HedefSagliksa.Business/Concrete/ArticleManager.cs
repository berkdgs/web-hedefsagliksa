using HedefSagliksa.Business.Abstract;
using HedefSagliksa.DataAccess.Abstract;
using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.Business.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public void Add(Article entity)
        {
            _articleDal.Add(entity);
        }

        public void Delete(Article entity)
        {
            _articleDal.Delete(entity);
        }

        public Article Get(Expression<Func<Article, bool>> filter)
        {
            return _articleDal.Get(filter);
        }

        public List<Article> GetAll(Expression<Func<Article, bool>> filter = null)
        {
            return _articleDal.GetAll(filter);
        }

        public void Update(Article entity)
        {
            _articleDal.Update(entity);
        }
    }
}
