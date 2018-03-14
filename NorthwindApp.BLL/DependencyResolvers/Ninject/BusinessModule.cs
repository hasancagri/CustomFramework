using Ninject.Modules;
using NorthwindApp.BLL.Abstract;
using NorthwindApp.Interfaces;

namespace NorthwindApp.BLL.DependencyResolvers.Ninject
{
    public class BusinessModule
         : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<NorthwindApp.BLL.Concrete.Managers.Product>().InSingletonScope();
            Bind<IProductDal>().To<NorthwindApp.Repository.DAPPER.Product>().InSingletonScope();
            Bind<IAccountService>().To<NorthwindApp.BLL.Concrete.Managers.Account>().InSingletonScope();
            Bind<IAccountDal>().To<NorthwindApp.Repository.DAPPER.Account>().InSingletonScope();
            Bind<ICategoryService>().To<NorthwindApp.BLL.Concrete.Managers.Category>().InSingletonScope();
            Bind<ICategoryDal>().To<NorthwindApp.Repository.DAPPER.Category>().InSingletonScope();
        }
    }
}
