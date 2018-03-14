using NorthwindApp.Interfaces;
using NorthwindApp.Repository.DAPPER.Concrete;

namespace NorthwindApp.Repository.DAPPER
{
    public class Product
        : DapperBase<NorthwindApp.Entities.CORE.Product>, IProductDal
    {
    }
}
