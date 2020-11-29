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
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void Add(Role entity)
        {
            _roleDal.Add(entity);
        }

        public void Delete(Role entity)
        {
            _roleDal.Delete(entity);
        }

        public Role Get(Expression<Func<Role, bool>> filter)
        {
            return _roleDal.Get(filter);
        }

        public List<Role> GetAll(Expression<Func<Role, bool>> filter = null)
        {
            return _roleDal.GetAll(filter);
        }

        public void Update(Role entity)
        {
            _roleDal.Update(entity);
        }
    }
}
