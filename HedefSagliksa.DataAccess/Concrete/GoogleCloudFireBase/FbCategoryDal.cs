﻿using HedefSagliksa.DataAccess.Abstract;
using HedefSagliksa.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.DataAccess.Concrete.GoogleCloudFireBase
{
    public class FbCategoryDal : FbEntityRepositoryBase<Category>, ICategoryDal
    {
    }
}