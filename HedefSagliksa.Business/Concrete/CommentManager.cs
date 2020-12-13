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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public Comment Get(Expression<Func<Comment, bool>> filter)
        {
            return _commentDal.Get(filter);
        }

        public List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return _commentDal.GetAll(filter);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}
