using NorthwindApp.Interfaces;
using NorthwindApp.Repository.DAPPER.Concrete;

namespace NorthwindApp.Repository.DAPPER
{
    public class Account
         : DapperBase<NorthwindApp.Entities.CORE.Kullanici>, IAccountDal
    {
    }
}
