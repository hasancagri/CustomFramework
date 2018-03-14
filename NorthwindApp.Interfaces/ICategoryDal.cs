using NorthwindApp.Helpers.ORM.DAPPER.Abtract;
using NorthwindApp.Helpers.Utilities.Search;
using System.Collections.Generic;

namespace NorthwindApp.Interfaces
{
    public interface ICategoryDal
        : IBaseRepository<NorthwindApp.Entities.CORE.Category>
    {
        List<NorthwindApp.Entities.CORE.Category> GetCategoriesWithProduct(string tanim, params QueryParam[] parametreler);
    }
}
