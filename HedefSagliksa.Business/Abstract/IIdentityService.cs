using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.Business.Abstract
{
    public interface IIdentityService
    {
        List<Identity> GetAll(Expression<Func<Identity, bool>> filter = null);
        Identity Get(Expression<Func<Identity, bool>> filter);
        void Add(Identity entity);
        void Update(Identity entity);
        void Delete(Identity entity);
    }
}
