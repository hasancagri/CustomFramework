using Ninject;
using Ninject.Modules;
using NorthwindApp.Helpers.Utilities.ExtensionMethods;
using System.Configuration;

namespace NorthwindApp.BLL.DependencyResolvers.Ninject
{
    public class ResolveModule
          : NinjectModule
    {
        public override void Load()
        {
            var soaSetting = ConfigurationManager.AppSettings["SOA"];

            var soa = !string.IsNullOrEmpty(soaSetting) && soaSetting.ToBoolean();

            if (soa)
            {
                //Burası daha sonra yapılacak
                //Kernel.Load(new ServiceModule());
            }
            else
            {
                Kernel.Load(new BusinessModule());
            }
        }
    }
}
