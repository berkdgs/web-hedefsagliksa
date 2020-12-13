using HedefSagliksa.Business.Abstract;
using HedefSagliksa.Business.Concrete;
using HedefSagliksa.DataAccess.Abstract;
using HedefSagliksa.DataAccess.Concrete.EntityFramework;
using HedefSagliksa.DataAccess.Concrete.GoogleCloudFireBase;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HedefSagliksa.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IArticleService>().To<ArticleManager>().InSingletonScope();
            Bind<IArticleDal>().To<EfArticleDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope();
            Bind<ICategoryDal>().To<FbCategoryDal>().InSingletonScope();

            Bind<ICommentService>().To<CommentManager>().InSingletonScope();
            Bind<ICommentDal>().To<EfCommentDal>().InSingletonScope();

            Bind<IIdentityService>().To<IdentityManager>().InSingletonScope();
            Bind<IIdentityDal>().To<EfIdentityDal>().InSingletonScope();

            Bind<IRoleService>().To<RoleManager>().InSingletonScope();
            Bind<IRoleDal>().To<EfRoleDal>().InSingletonScope();
        }
    }
}
