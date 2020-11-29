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
    public class IdentityManager : IIdentityService
    {
        private readonly IIdentityDal _identityDal;

        public IdentityManager(IIdentityDal identityDal)
        {
            _identityDal = identityDal;
        }

        public void Add(Identity entity)
        {
            _identityDal.Add(entity);
        }

        public void Delete(Identity entity)
        {
            _identityDal.Delete(entity);
        }

        public Identity Get(Expression<Func<Identity, bool>> filter)
        {
            return _identityDal.Get(filter);
        }

        public List<Identity> GetAll(Expression<Func<Identity, bool>> filter = null)
        {
            return _identityDal.GetAll(filter);
        }

        public void Update(Identity entity)
        {
            _identityDal.Update(entity);
        }
    }
}
