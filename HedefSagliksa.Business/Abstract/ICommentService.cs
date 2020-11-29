using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.Business.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null);
        Comment Get(Expression<Func<Comment, bool>> filter);
        void Add(Comment entity);
        void Update(Comment entity);
        void Delete(Comment entity);
    }
}
