﻿using HedefSagliksa.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T: class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T GetById(string id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
