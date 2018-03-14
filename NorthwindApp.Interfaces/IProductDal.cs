using NorthwindApp.Helpers.ORM.DAPPER.Abtract;

namespace NorthwindApp.Interfaces
{
    public interface IProductDal
          : IBaseRepository<NorthwindApp.Entities.CORE.Product>
    {

    }
}
