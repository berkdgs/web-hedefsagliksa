using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.Business.Abstract
{
    public interface IArticleService
    {
        List<Article> GetAll(Expression<Func<Article, bool>> filter = null);
        Article Get(Expression<Func<Article, bool>> expression);
        void Add(Article entity);
        void Update(Article entity);
        void Delete(Article entity);
    }
}
