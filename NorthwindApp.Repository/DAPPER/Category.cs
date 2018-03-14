using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using NorthwindApp.Helpers.Utilities.Search;
using NorthwindApp.Interfaces;
using NorthwindApp.Repository.DAPPER.Concrete;

namespace NorthwindApp.Repository.DAPPER
{
    public class Category
        : DapperBase<NorthwindApp.Entities.CORE.Category>, ICategoryDal
    {
        public List<Entities.CORE.Category> GetCategoriesWithProduct(string tanim, params QueryParam[] parametreler)
        {
            //Burada daha farklı bir çözüm dene
            SqlConnection connection = new SqlConnection("Data source=ÇAĞRı-ÇAĞRı;initial catalog=NORTHWND;user Id=sa;password=hasan");
            var result =
                connection.Query<NorthwindApp.Entities.ComplexTypes.Category>(tanim, parametreler, commandType: CommandType.StoredProcedure).ToList();
            return null;
        }
    }
}
