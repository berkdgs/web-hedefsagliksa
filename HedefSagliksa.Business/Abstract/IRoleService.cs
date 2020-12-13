using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.Business.Abstract
{
    public interface IRoleService
    {
        List<Role> GetAll(Expression<Func<Role, bool>> filter = null);
        Role Get(Expression<Func<Role, bool>> filter);
        void Add(Role entity);
        void Update(Role entity);
        void Delete(Role entity);
    }
}
