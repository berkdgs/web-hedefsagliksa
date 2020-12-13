﻿using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll(Expression<Func<Category, bool>> filter = null);
        Category Get(Expression<Func<Category, bool>> expression);
        Category GetById(string id);
        void Add(Category entity);
        void Update(Category entity);
        void Delete(Category entity);
    }
}
