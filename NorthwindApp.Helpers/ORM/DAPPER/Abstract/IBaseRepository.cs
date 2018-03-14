using NorthwindApp.Helpers.Utilities.Search;
using System.Collections.Generic;

namespace NorthwindApp.Helpers.ORM.DAPPER.Abtract
{
    public interface IBaseRepository<TEntity>
    {
        List<TEntity> GetList(string tanim, params QueryParam[] parametreler);
        TEntity Get(string tanim, params QueryParam[] parametreler);
        int Execute(string tanim, params QueryParam[] parametreler);
        T Scalar<T>(string tanim, params QueryParam[] parametreler);
    }
}
